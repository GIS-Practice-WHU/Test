using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.Collections;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace Test
{


    public partial class Formwait : Form
    {
        private Image m_imgImage = null;
        private EventHandler m_evthdlAnimator = null;
        int i;
        public Formwait()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            i = 0;

            m_evthdlAnimator = new EventHandler(OnImageAnimate);
            Debug.Assert(m_evthdlAnimator != null);
            // http://www.cnblogs.com/sosoft/
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (m_imgImage != null)
            {
                UpdateImage();
                e.Graphics.DrawImage(m_imgImage, new Rectangle(0,0, m_imgImage.Width, m_imgImage.Height));
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            m_imgImage = Properties.Resources.loading2; // 加载测试用的Gif图片
            BeginAnimate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_imgImage != null)
            {
                StopAnimate();
                m_imgImage = null;
            }
        }

        private void BeginAnimate()
        {
            if (m_imgImage == null)
                return;

            if (ImageAnimator.CanAnimate(m_imgImage))
            {
                ImageAnimator.Animate(m_imgImage, m_evthdlAnimator);
            }
        }

        private void StopAnimate()
        {
            if (m_imgImage == null)
                return;

            if (ImageAnimator.CanAnimate(m_imgImage))
            {
                ImageAnimator.StopAnimate(m_imgImage, m_evthdlAnimator);
            }
        }

        private void UpdateImage()
        {
            if (m_imgImage == null)
                return;

            if (ImageAnimator.CanAnimate(m_imgImage))
            {
                ImageAnimator.UpdateFrames(m_imgImage);
            }
        }

        private void OnImageAnimate(Object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Formwait_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
