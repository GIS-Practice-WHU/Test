using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;
using DevExpress.Utils.Drawing.Helpers;
using System.Threading;

using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using stdole;

namespace Test
{
    public partial class Form_main : Form
    {
        
        GMapControl gMapControl1 = new GMapControl();
        //AxMapControl Map_open = new AxMapControl();
        bool state = true;
        bool shift = false;
        Formwait waitform = new Formwait();
        int i = 0;
        System.Drawing.Point pt = new System.Drawing.Point();
        public Form_main()
        {
            
            InitializeComponent();
            this.tabPane1.SendToBack();
            //Gmapcontrol();
            Gmapcontrol_test();
            timer_waitform.Start();
            Thread thread2 = new Thread(threadPro);//创建新线程  
            thread2.Start();
            if (mapcontrol_test() == 0)
            {
                
            }
            thread2.Abort();
            
            //waitform.Close();
            //this.pictureBox_watermark.Image = Image.FromFile("sign.png");
            //ControlTrans(pictureBox_watermark, this.pictureBox_watermark.Image);
            this.panel2.Visible = false;
            //Formwait form = new Formwait();
            //System.ComponentModel.ISupportInitialize
            //form.ShowDialog();
        }
        public void threadPro()
        {
            waitform.ShowDialog();
        }
        private int mapcontrol_test()
        {
            //((System.ComponentModel.ISupportInitialize)(this.Map_open)).BeginInit();
            
            this.tabNavigationPage1.Controls.Add(Map_open);
            Map_open.Dock = DockStyle.Fill;
            Map_open.OnMouseDown += new IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl_OnMouseDown);
            Map_open.OnMouseMove += new IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl_OnMouseMove);
            Map_open.OnMouseUp += new IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl_OnMouseUp);
            //((System.ComponentModel.ISupportInitialize)(this.Map_open)).EndInit();
            if (Map_open.CheckMxFile("D:/whu/洪水展示系统/demo/demo.mxd"))
            {
                Map_open.LoadMxFile("D:/whu/洪水展示系统/demo/demo.mxd");
            }
            else
            {
                MessageBox.Show("Cannot open mxd file");
                return 0;
            }
            
            this.tabNavigationPage2.Controls.Add(Map_population);
            Map_population.Dock = DockStyle.Fill;

            Map_population.OnMouseDown += new IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl_OnMouseDown);
            Map_population.OnMouseMove += new IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl_OnMouseMove);
            Map_population.OnMouseUp += new IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl_OnMouseUp);
            //((System.ComponentModel.ISupportInitialize)(this.Map_open)).EndInit();
            if (Map_population.CheckMxFile("D:/whu/洪水展示系统/demo_1/demo.mxd"))
            {
                Map_population.LoadMxFile("D:/whu/洪水展示系统/demo_1/demo.mxd");
            }
            else
            {
                MessageBox.Show("Cannot open mxd file");
                return 0;
            }
            
            this.tabNavigationPage3.Controls.Add(Map_land);
            Map_land.Dock = DockStyle.Fill;

            Map_land.OnMouseDown += new IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl_OnMouseDown);
            Map_land.OnMouseMove += new IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl_OnMouseMove);
            Map_land.OnMouseUp += new IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl_OnMouseUp);
            //((System.ComponentModel.ISupportInitialize)(this.Map_open)).EndInit();
            if (Map_land.CheckMxFile("D:/whu/洪水展示系统/demo_2/demo.mxd"))
            {
                Map_land.LoadMxFile("D:/whu/洪水展示系统/demo_2/demo.mxd");
            }
            else
            {
                MessageBox.Show("Cannot open mxd file");
                return 0;
            }
            
            this.tabNavigationPage4.Controls.Add(Map_economy);
            Map_economy.Dock = DockStyle.Fill;

            Map_economy.OnMouseDown += new IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl_OnMouseDown);
            Map_economy.OnMouseMove += new IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl_OnMouseMove);
            Map_economy.OnMouseUp += new IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl_OnMouseUp);
            //((System.ComponentModel.ISupportInitialize)(this.Map_open)).EndInit();
            if (Map_economy.CheckMxFile("D:/whu/洪水展示系统/demo_3/demo.mxd"))
            {
                Map_economy.LoadMxFile("D:/whu/洪水展示系统/demo_3/demo.mxd");
            }
            else
            {
                MessageBox.Show("Cannot open mxd file");
                return 0;
            }

            this.tabNavigationPage5.Controls.Add(Map_rainfall);
            Map_rainfall.Dock = DockStyle.Fill;

            Map_rainfall.OnMouseDown += new IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl_OnMouseDown);
            Map_rainfall.OnMouseMove += new IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl_OnMouseMove);
            Map_rainfall.OnMouseUp += new IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl_OnMouseUp);
            //((System.ComponentModel.ISupportInitialize)(this.Map_open)).EndInit();
            if (Map_rainfall.CheckMxFile("D:/whu/洪水展示系统/demo_4/demo.mxd"))
            {
                Map_rainfall.LoadMxFile("D:/whu/洪水展示系统/demo_4/demo.mxd");
            }
            else
            {
                MessageBox.Show("Cannot open mxd file");
                return 0;
            }

            //this.tabNavigationPage1.Controls.Add(Scene_3d);
            //Scene_3d.Dock = DockStyle.Fill;
            
            //Map_rainfall.OnMouseMove += new IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl_OnMouseMove);
            //Map_rainfall.OnMouseUp += new IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl_OnMouseUp);
            //((System.ComponentModel.ISupportInitialize)(this.Map_open)).EndInit();
            /*
            if (Scene_3d.CheckSxFile("D:/whu/洪水展示系统/srtm/demo.sxd"))
            {
                Scene_3d.LoadSxFile("D:/whu/洪水展示系统/srtm/demo.sxd");
            }
            else
            {
                MessageBox.Show("Cannot open sxd file");
                return 0;
            }*/
            return 1;
        }


        //private void Gmapcontrol()
        //{
        //    this.gMapControl1.CacheLocation = System.Windows.Forms.Application.StartupPath;//指定地图缓存存放路径
        //    this.gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
        //    this.gMapControl1.Manager.Mode = AccessMode.ServerAndCache;//地图加载模式
        //    this.gMapControl1.MinZoom = 1;   //最小比例
        //    this.gMapControl1.MaxZoom = 23; //最大比例
        //    this.gMapControl1.Zoom = 15; //当前比例
        //    this.gMapControl1.ShowCenter = false; //不显示中心十字点
        //    this.gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
        //    this.gMapControl1.Position = new PointLatLng(23, 113);
        //    this.gMapControl1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        //    //this.gMapControl1.Dock = DockStyle.Fill;
        //    this.Controls.Add(this.gMapControl1);
        //}
        private void Gmapcontrol_test()
        {
            //gMapControl_origin           
            //this.gMapControl_origin.CacheLocation = System.Windows.Forms.Application.StartupPath;//指定地图缓存存放路径
            //this.gMapControl_origin.MapProvider = GMapProviders.OpenStreetMap;
            //this.gMapControl_origin.Manager.Mode = AccessMode.ServerAndCache;//地图加载模式
            //this.gMapControl_origin.MinZoom = 1;   //最小比例
            //this.gMapControl_origin.MaxZoom = 23; //最大比例
            //this.gMapControl_origin.Zoom = 15; //当前比例
            //this.gMapControl_origin.ShowCenter = false; //不显示中心十字点
            //this.gMapControl_origin.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
            //this.gMapControl_origin.Position = new PointLatLng(23, 113);
            ////gMapControl_population
            //this.gMapControl_population.CacheLocation = System.Windows.Forms.Application.StartupPath;//指定地图缓存存放路径
            //this.gMapControl_population.MapProvider = GMapProviders.OpenStreetMap;
            //this.gMapControl_population.Manager.Mode = AccessMode.ServerAndCache;//地图加载模式
            //this.gMapControl_population.MinZoom = 1;   //最小比例
            //this.gMapControl_population.MaxZoom = 23; //最大比例
            //this.gMapControl_population.Zoom = 15; //当前比例
            //this.gMapControl_population.ShowCenter = false; //不显示中心十字点
            //this.gMapControl_population.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
            //this.gMapControl_population.Position = new PointLatLng(23, 113);
            ////gMapControl_land
            //this.gMapControl_land.CacheLocation = System.Windows.Forms.Application.StartupPath;//指定地图缓存存放路径
            //this.gMapControl_land.MapProvider = GMapProviders.OpenStreetMap;
            //this.gMapControl_land.Manager.Mode = AccessMode.ServerAndCache;//地图加载模式
            //this.gMapControl_land.MinZoom = 1;   //最小比例
            //this.gMapControl_land.MaxZoom = 23; //最大比例
            //this.gMapControl_land.Zoom = 15; //当前比例
            //this.gMapControl_land.ShowCenter = false; //不显示中心十字点
            //this.gMapControl_land.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
            //this.gMapControl_land.Position = new PointLatLng(23, 113);

            //gMapControl_economy
            //this.gMapControl_economy.CacheLocation = System.Windows.Forms.Application.StartupPath;//指定地图缓存存放路径
            //this.gMapControl_economy.MapProvider = GMapProviders.OpenStreetMap;
            //this.gMapControl_economy.Manager.Mode = AccessMode.ServerAndCache;//地图加载模式
            //this.gMapControl_economy.MinZoom = 1;   //最小比例
            //this.gMapControl_economy.MaxZoom = 23; //最大比例
            //this.gMapControl_economy.Zoom = 15; //当前比例
            //this.gMapControl_economy.ShowCenter = false; //不显示中心十字点
            //this.gMapControl_economy.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
            //this.gMapControl_economy.Position = new PointLatLng(23, 113);

            //gMapControl_rainfall
            //this.gMapControl_rainfall.CacheLocation = System.Windows.Forms.Application.StartupPath;//指定地图缓存存放路径
            //this.gMapControl_rainfall.MapProvider = GMapProviders.OpenStreetMap;
            //this.gMapControl_rainfall.Manager.Mode = AccessMode.ServerAndCache;//地图加载模式
            //this.gMapControl_rainfall.MinZoom = 1;   //最小比例
            //this.gMapControl_rainfall.MaxZoom = 23; //最大比例
            //this.gMapControl_rainfall.Zoom = 15; //当前比例
            //this.gMapControl_rainfall.ShowCenter = false; //不显示中心十字点
            //this.gMapControl_rainfall.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
            //this.gMapControl_rainfall.Position = new PointLatLng(23, 113);

            ////gMapControl_3d
            //this.gMapControl_3d.CacheLocation = System.Windows.Forms.Application.StartupPath;//指定地图缓存存放路径
            //this.gMapControl_3d.MapProvider = GMapProviders.OpenStreetMap;
            //this.gMapControl_3d.Manager.Mode = AccessMode.ServerAndCache;//地图加载模式
            //this.gMapControl_3d.MinZoom = 1;   //最小比例
            //this.gMapControl_3d.MaxZoom = 23; //最大比例
            //this.gMapControl_3d.Zoom = 15; //当前比例
            //this.gMapControl_3d.ShowCenter = false; //不显示中心十字点
            //this.gMapControl_3d.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
            //this.gMapControl_3d.Position = new PointLatLng(23, 113);

        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        //[DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        /// <summary>
        /// 为了是主界面能够移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_datain_Click(object sender, EventArgs e)
        {
            OpenFileDialog form = new OpenFileDialog();
            form.ShowDialog();
        }
        /// <summary>  
        /// 根据图片计算GraphicsPath路径  
        /// </summary>  
        /// <param name="img">gif或者png图片</param>  
        /// <returns>图片不透明区域路径</returns>  
        /// 用这个代码的时候需要选择项目属性->生成->勾选"允许不安全代码"  
        /// 因为这里用到了指针，C#用指针式不安全的，具体可查看msdn  
        private unsafe static GraphicsPath subGraphicsPath(Image img)
        {
            if (img == null) return null;

            // 建立GraphicsPath, 给我们的位图路径计算使用   
            GraphicsPath g = new GraphicsPath(FillMode.Alternate);

            Bitmap bitmap = new Bitmap(img);

            int width = bitmap.Width;
            int height = bitmap.Height;
            BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte* p = (byte*)bmData.Scan0;
            int offset = bmData.Stride - width * 3;
            int p0, p1, p2;         // 记录左上角0，0座标的颜色值  
            p0 = p[0];
            p1 = p[1];
            p2 = p[2];

            int start = -1;
            // 行座标 ( Y col )   
            for (int Y = 0; Y < height; Y++)
            {
                // 列座标 ( X row )   
                for (int X = 0; X < width; X++)
                {
                    if (start == -1 && (p[0] != p0 || p[1] != p1 || p[2] != p2))     //如果 之前的点没有不透明 且 不透明   
                    {
                        start = X;                            //记录这个点  
                    }
                    else if (start > -1 && (p[0] == p0 && p[1] == p1 && p[2] == p2))      //如果 之前的点是不透明 且 透明  
                    {
                        g.AddRectangle(new Rectangle(start, Y, X - start, 1));    //添加之前的矩形到  
                        start = -1;
                    }

                    if (X == width - 1 && start > -1)        //如果 之前的点是不透明 且 是最后一个点  
                    {
                        g.AddRectangle(new Rectangle(start, Y, X - start + 1, 1));      //添加之前的矩形到  
                        start = -1;
                    }
                    //if (p[0] != p0 || p[1] != p1 || p[2] != p2)  
                    //    g.AddRectangle(new Rectangle(X, Y, 1, 1));  
                    p += 3;                                   //下一个内存地址  
                }
                p += offset;
            }
            bitmap.UnlockBits(bmData);
            bitmap.Dispose();
            // 返回计算出来的不透明图片路径   
            return g;
        }

        /// <summary>  
        /// 调用此函数后使图片透明  
        /// </summary>  
        /// <param name="control">需要处理的控件</param>  
        /// <param name="img">控件的背景或图片，如PictureBox.Image  
        ///   或PictureBox.BackgroundImage</param>  
        public static void ControlTrans(Control control, Image img)
        {
            GraphicsPath g;
            g = subGraphicsPath(img);
            if (g == null)
                return;
            control.Region = new Region(g);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                /*this.WindowState = FormWindowState.Maximized;*/
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
                this.textBox_search.Size = new Size((int)(400.0), (int)(32.0));
                this.button_search.Location = new System.Drawing.Point((int)(425.0), (int)(150.0));
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.textBox_search.Size = new Size((int)(200.0), (int)(32.0));
                this.button_search.Location = new System.Drawing.Point((int)(225.0), (int)(150.0));
            }
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            //gMapControl_origin
            //this.gMapControl_origin.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            //gMapControl_population
            //this.gMapControl_population.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            //gMapControl_land
            //this.gMapControl_land.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            //gMapControl_economy
            //this.gMapControl_economy.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            //gMapControl_rainfall
            //this.gMapControl_rainfall.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            //gMapControl_3d
            //this.gMapControl_3d.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            //tabPane1
            tabPane1.Width = this.ClientSize.Width;
            tabPane1.Height = this.ClientSize.Height;
            //panel2
            this.panel2.Location = new System.Drawing.Point((int)((670.0 / 1000) * this.ClientSize.Width), (int)(int)((600.0 / 600) * this.ClientSize.Height));
            this.panel2.Size = new Size((int)((330.0 / 1000) * this.ClientSize.Width), (int)((200.0 / 600) * this.ClientSize.Height));
            //textBox_data
            System.Drawing.Point temp_ = new System.Drawing.Point((int)((-200.0/ 1000) * this.ClientSize.Width), (int)((300.0 / 600) * this.ClientSize.Height));
            this.textBox_data.Size = new Size((int)((200.0/1000)*this.ClientSize.Width),(int)((400.0/600)*this.ClientSize.Height));
            this.textBox_data.Location = temp_;
            //button_close
            System.Drawing.Point temp1 = new System.Drawing.Point((int)(this.ClientSize.Width-35), (int)((0.0 / 600) * this.ClientSize.Height));
            this.button_close.Location = temp1;
            //button_max
            System.Drawing.Point temp2 = new System.Drawing.Point((int)(this.ClientSize.Width - 70), (int)((0.0 / 600) * this.ClientSize.Height));
            this.button_max.Location = temp2;
            //button_min
            this.button_min.Location = new System.Drawing.Point((int)(this.ClientSize.Width - 105), (int)((0.0 / 600) * this.ClientSize.Height));
            //button_population
            this.button_population.Location = new System.Drawing.Point((int)((0.0 / 330) * this.panel2.Width), (int)((0.0 / 200) * this.panel2.Height));
            this.button_population.Size = new Size((int)((75.0 / 330) * this.panel2.Width), (int)((40.0 / 200) * this.panel2.Height));
            //button_land
            this.button_land.Location = new System.Drawing.Point((int)((80.0 / 330) * this.panel2.Width), (int)((0.0 / 200) * this.panel2.Height));
            this.button_land.Size = new Size((int)((75.0 / 330) * this.panel2.Width), (int)((40.0 / 200) * this.panel2.Height));
            //button_economy
            this.button_economy.Location = new System.Drawing.Point((int)((160.0 / 1000) * this.ClientSize.Width), (int)((0.0 / 600) * this.ClientSize.Height));
            this.button_economy.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)((40.0 / 600) * this.ClientSize.Height));
            //button_rainfall
            this.button_rainfall.Location = new System.Drawing.Point((int)((240.0 / 1000) * this.ClientSize.Width), (int)((0.0 / 600) * this.ClientSize.Height));
            this.button_rainfall.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)((40.0 / 600) * this.ClientSize.Height));
            //button_datain
            this.button_datain.Location = new System.Drawing.Point((int)((0.0 / 1000) * this.ClientSize.Width), (int)((100.0 / 600) * this.ClientSize.Height));
            this.button_datain.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)((40.0 / 600) * this.ClientSize.Height));
            //button_dataout
            this.button_dataout.Location = new System.Drawing.Point((int)((0.0 / 1000) * this.ClientSize.Width), (int)((150.0 / 600) * this.ClientSize.Height));
            this.button_dataout.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)((40.0 / 600) * this.ClientSize.Height));
            //button_3d
            //this.button_3d.Location = new System.Drawing.Point((int)((0.0 / 1000) * this.ClientSize.Width), (int)((50.0 / 600) * this.ClientSize.Height));
            //this.button_3d.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)((40.0 / 600) * this.ClientSize.Height));
            //button_origindata
            this.button_origindata.Location = new System.Drawing.Point((int)((80.0 / 1000) * this.ClientSize.Width), (int)((50.0 / 600) * this.ClientSize.Height));
            this.button_origindata.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)((40.0 / 600) * this.ClientSize.Height));
            //button_back
            this.button_back.Location = new System.Drawing.Point((int)((600.0 / 1000) * this.ClientSize.Width), (int)(25));
            this.button_back.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)(56.0));
            //button_stop
            this.button_stop.Location = new System.Drawing.Point((int)((675.0 / 1000) * this.ClientSize.Width), (int)(25));
            this.button_stop.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)(56.0));
            //button_forward
            this.button_forward.Location = new System.Drawing.Point((int)((750.0 / 1000) * this.ClientSize.Width), (int)(25));
            this.button_forward.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)(56.0));
            //button_hide
            this.button_hide.Location = new System.Drawing.Point((int)((925.0 / 1000) * this.ClientSize.Width), (int)((560.0 / 600) * this.ClientSize.Height));
            this.button_hide.Size = new Size((int)((75.0 / 1000) * this.ClientSize.Width), (int)((40.0 / 600) * this.ClientSize.Height));
            //trackBarControl_timecontrol
            this.trackBarControl_timecontrol.Location =new System.Drawing.Point((int)((200.0 / 1000) * this.ClientSize.Width), (int)(25.0));
            this.trackBarControl_timecontrol.Size = new Size((int)((400.0 / 1000) * this.ClientSize.Width), (int)((56.0 / 600) * this.ClientSize.Height));
            //panel1
            this.panel1.Location = new System.Drawing.Point((int)((0.0 / 1000) * this.ClientSize.Width), (int)(25.0));
            this.panel1.Size = new Size((int)((1000.0 / 1000) * this.ClientSize.Width), (int)(56.0));
            //linklable_login
            //this.linkLabel_login.Location = new System.Drawing.Point((int)(this.ClientSize.Width-125), (int)(45.0));
            //this.linkLabel_login.Size = new Size((int)(49.0), (int)(20.0));
            //PictureBoxIcon
            //this.pictureBoxIcon.Location = new System.Drawing.Point((int)(this.ClientSize.Width-50.0), (int)(30.0));
            //pictureBox_watermark
            //this.pictureBox_watermark.Location = new System.Drawing.Point((int)(this.Width - 122.0), (int)(125.0));    
        }

        private void Form1_DoubleClick_1(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.textBox_search.Size = new Size((int)(400.0), (int)(32.0));
                this.button_search.Location = new System.Drawing.Point((int)(425.0), (int)(150.0));
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.textBox_search.Size = new Size((int)(200.0), (int)(32.0));
                this.button_search.Location = new System.Drawing.Point((int)(225.0), (int)(150.0));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(trackBarControl_timecontrol.Value == 0)
            {
                return;
            }
            else
            {
                trackBarControl_timecontrol.Value--;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_stop.Enabled = false;
            button_back.Enabled = true;
            if(timer_go.Enabled)
            {
                timer_go.Stop();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer_go.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (this.panel2.Visible == true)
            {
                timer_panel2_out.Start();
            }
            else
            {
                this.panel2.Visible = true;
                timer_panel2_in.Start();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formlogin form = new Formlogin();
            form.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_watermark_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_login_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void linkLabel_login_Click(object sender, EventArgs e)
        {


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button_dataout_Click(object sender, EventArgs e)
        {
            SaveFileDialog form = new SaveFileDialog();
            form.ShowDialog();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void button_max_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form_main_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form_main_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.F11)
                button9_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.F10)
                button2_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.F1)
                button_population_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.F2)
                button_land_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.F3)
                button_economy_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.F4)
                button_rainfall_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.F9)
                关于系统ToolStripMenuItem_Click(sender, new EventArgs());
            if (e.Control && e.KeyCode == Keys.I)
                button_datain_Click(sender, new EventArgs());
            if (e.Control && e.KeyCode == Keys.O)
                button_dataout_Click(sender, new EventArgs());
            if (e.Control && e.KeyCode == Keys.S)
                button_3d_Click(sender, new EventArgs());
            if (e.KeyCode == Keys.Shift)
                this.shift = true;

        }

        private void 关于系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_about form = new Form_about();
            form.ShowDialog();
        }

        private void button_origindata_Click(object sender, EventArgs e)
        {
            this.tabPane1.SelectedPageIndex = 0;

        }

        private void button_population_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPageIndex = 1;


        }

        private void button_land_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPageIndex = 2;
            button_back.Enabled = false;
            button_forward.Enabled = false;
            button_stop.Enabled = false;
        }

        private void button_economy_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPageIndex = 3;
            button_back.Enabled = false;
            button_forward.Enabled = false;
            button_stop.Enabled = false;
        }

        private void button_rainfall_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPageIndex = 4;
            button_back.Enabled = false;
            button_forward.Enabled = false;
            button_stop.Enabled = false;
        }

        private void button_3d_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPageIndex = 5;
            button_back.Enabled = false;
            button_forward.Enabled = false;
            button_stop.Enabled = false;
        }

        private void 数据导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog form = new OpenFileDialog();
            form.ShowDialog();
        }

        private void 数据导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog form = new SaveFileDialog();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_panel2_out.Interval = 1;//时间间隔0.005s
            this.panel2.Location = new System.Drawing.Point((int)(this.panel2.Location.X), (int)(this.panel2.Location.Y + 25));
            if (this.panel2.Location.Y >= this.ClientSize.Height)
            {
                this.panel2.Visible = false;
                timer_panel2_out.Stop();

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer_panel2_in.Interval = 1;//时间间隔0.005s
            this.panel2.Location = new System.Drawing.Point((int)(this.panel2.Location.X), (int)(this.panel2.Location.Y - 25));
            if (this.panel2.Location.Y <= (int)((400.0 / 600) * this.ClientSize.Height))
            {
                this.panel2.Location = new System.Drawing.Point((int)((670.0 / 1000) * this.ClientSize.Width), (int)(int)((400.0 / 600) * this.ClientSize.Height));
                timer_panel2_in.Stop();
            }
        }

        private void timer_databox_in_Tick(object sender, EventArgs e)
        {
            timer_databox_in.Interval = 1;
            this.textBox_data.Location = new System.Drawing.Point((int)(this.textBox_data.Location.X + 20), (int)(this.textBox_data.Location.Y));
            if(this.textBox_data.Location.X>=0)
            {
                this.textBox_data.Location = new System.Drawing.Point(0, this.textBox_data.Location.Y);
                timer_databox_in.Stop();
            }
        }

        private void timer_databox_out_Tick(object sender, EventArgs e)
        {
            timer_databox_out.Interval = 1;
            this.textBox_data.Location = new System.Drawing.Point((int)(this.textBox_data.Location.X - 20), (int)(this.textBox_data.Location.Y));
            if (this.textBox_data.Location.X<=-200)
            {
                this.textBox_data.Location = new System.Drawing.Point(-200, this.textBox_data.Location.Y);
                timer_databox_out.Stop();
                this.textBox_data.Visible = false;
            }
        }
        private void timer_go_Tick(object sender, EventArgs e)
        {
            timer_databox_out.Interval = 2000;
            button_stop.Enabled = true;
            button_back.Enabled = false;
            trackBarControl_timecontrol.Value++;
            if(trackBarControl_timecontrol.Value == 10)
            {
                timer_go.Stop();
                button_stop.Enabled = false;
                button_back.Enabled = true;
            }
        }
        private void ClearSelect(AxMapControl t)
        {
            IMap pMap = t.Map;
            IActiveView pActiveView = pMap as IActiveView;
            pActiveView.FocusMap.ClearSelection();
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, pActiveView.Extent);
            t.CurrentTool = null;
        }
        public void axMapControl_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            shift = false;
            AxMapControl t = tabPane1.SelectedPage.Controls[0] as AxMapControl;
            IMap pMap = t.Map;
            IActiveView pActiveView = pMap as IActiveView;
            if(e.shift == 0)
            {
                ClearSelect(t);
            }
            IFeatureLayer pFeatureLayer = GetLayerByName(t, "CHN_adm2") as IFeatureLayer;
            IFeatureClass pFeatureClass = pFeatureLayer.FeatureClass;
            IPoint point = pActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y);
            IFeature feature = GetFeatureOnMouseDown(point, "CHN_adm2", t);
            ShowListBox(feature);
            //feature.
            pMap.SelectFeature(GetLayerByName(t, "CHN_adm2"), feature);
            //axMapControl1.Map.SelectByShape(point, null, true);//第三个参数为是否只选中一个
            t.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null); //选中要素高亮显示
        }

        private void ShowListBox(IFeature f)
        {
            if(f == null)
            {
                timer_databox_out.Start();
                return;
            }
            else
            {
                this.textBox_data.Visible = true;
                timer_databox_in.Start();
            }
            IFeatureClass iFeatureClass = f.Class as IFeatureClass;

            //int index = iFeatureClass.Fields.FindField(“字段名”);

            //string 字段值 = f.get_Value(index).ToString();
            textBox_data.RowCount = f.Fields.FieldCount;
            for (int i = 0; i < f.Fields.FieldCount; i++)
            {
                if(f.Fields.get_Field(i).Name == "Shape")
                {
                    continue;
                }
                string name = Translate(f.Fields.get_Field(i).Name);
                if(name == null)
                {
                    textBox_data[0, i].Value = f.Fields.get_Field(i).Name;
                }
                else
                {
                    textBox_data[0, i].Value = name;

                }
                textBox_data[1, i].Value = f.get_Value(i).ToString();
                
            }
            //textBox_data.DataSource = data.Rows[f.OID].Table;
        }
        public DataTable ToDataTable(ITable mTable)
        {
            try
            {
                DataTable pTable = new DataTable();
                for (int i = 0; i < mTable.Fields.FieldCount; i++)
                {
                    string name = Translate(mTable.Fields.get_Field(i).Name);
                    if(name == null)
                    {
                        pTable.Columns.Add(mTable.Fields.get_Field(i).Name);
                    }
                    else
                    {
                        pTable.Columns.Add(name);
                    }
                }
                ICursor pCursor = mTable.Search(null, false);
                IRow pRrow = pCursor.NextRow();
                while (pRrow != null)
                {
                    DataRow pRow = pTable.NewRow();
                    string[] StrRow = new string[pRrow.Fields.FieldCount];
                    for (int i = 0; i < pRrow.Fields.FieldCount; i++)
                    {
                        StrRow[i] = pRrow.get_Value(i).ToString();
                    }
                    pRow.ItemArray = StrRow;
                    pTable.Rows.Add(pRow);
                    pRrow = pCursor.NextRow();
                }
                return pTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void axMapControl_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            if(shift)
            {
                AxMapControl t = tabPane1.SelectedPage.Controls[0] as AxMapControl;
                //IEnvelope envelope = t.Extent;
                //double h = envelope.Width;
                //double w = envelope.Height;
                IActiveView pActiveView = t.Map as IActiveView;
                IPoint point = pActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y);
                t.CenterAt((point));//设置当前查询到的要素为地图的中心           
                Map_open.Refresh(esriViewDrawPhase.esriViewBackground, null, null);
                //t.Extent = envelope;
                pt.X = e.x;
                pt.Y = e.y;
                
            }
            //statusBarXY.Text = string.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl1.MapUnits.ToString().Substring(4));
        }
        public void axMapControl_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (e.button != 2)
                return;
            pt.X = e.x;
            pt.Y = e.y;
            shift = true;
            //statusBarXY.Text = string.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl1.MapUnits.ToString().Substring(4));
        }
        private ILayer GetLayerByName(AxMapControl axMapControl, string name)
        {

            try
            {
                ILayer layer;
                for (int i = 0; i < 1000; i++)
                {
                    layer = axMapControl.get_Layer(i);
                    if (layer.Name == name)
                    {
                        return layer;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }



        }
        public IFeature GetFeatureOnMouseDown(IPoint point, string name, AxMapControl axMapControl1)
        {
            try
            {
                ILayer layer = GetLayerByName(axMapControl1, name);
                if (layer == null)
                {
                    MessageBox.Show("请加载图层！", "提示");
                    return null;
                }
                //IFeatureLayer fLayer = layer as IFeatureLayer;
                //IFeatureSelection featureSelection = fLayer as IFeatureSelection;
                //featureSelection.Clear();
                //if (featureSelection == null)
                //{
                //    return null;
                //}

                IFeatureLayer featureLayer = layer as IFeatureLayer;
                if (featureLayer == null)
                    return null;
                IFeatureClass featureClass = featureLayer.FeatureClass;
                if (featureClass == null)
                    return null;

                //IPoint point = axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(x, y);
                IGeometry geometry = point as IGeometry;

                double length = ConvertPixelsToMapUnits(axMapControl1.ActiveView, 4);
                ITopologicalOperator pTopo = geometry as ITopologicalOperator;
                IGeometry buffer = pTopo.Buffer(length);
                geometry = buffer.Envelope as IGeometry;

                ISpatialFilter spatialFilter = new SpatialFilterClass();
                spatialFilter.Geometry = geometry;
                switch (featureClass.ShapeType)
                {
                    case esriGeometryType.esriGeometryPoint:
                        spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelContains;
                        break;
                    case esriGeometryType.esriGeometryPolygon:
                        spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
                        break;
                    case esriGeometryType.esriGeometryPolyline:
                        spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelCrosses;
                        break;
                }
                spatialFilter.GeometryField = featureClass.ShapeFieldName;
                IQueryFilter filter = spatialFilter as IQueryFilter;

                IFeatureCursor cursor = featureClass.Search(filter, false);
                IFeature pfeature = cursor.NextFeature();
                if (pfeature != null)
                {
                    return pfeature;
                    //featureSelection.Add(pfeature);
                    //pfeature = cursor.NextFeature();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {

                return null;
            }
        }
        private double ConvertPixelsToMapUnits(IActiveView pActiveView, double pixelUnits)
        {
            // Uses the ratio of the size of the map in pixels to map units to do the conversion
            IPoint p1 = pActiveView.ScreenDisplay.DisplayTransformation.VisibleBounds.UpperLeft;
            IPoint p2 = pActiveView.ScreenDisplay.DisplayTransformation.VisibleBounds.UpperRight;
            int x1, x2, y1, y2;
            pActiveView.ScreenDisplay.DisplayTransformation.FromMapPoint(p1, out x1, out y1);
            pActiveView.ScreenDisplay.DisplayTransformation.FromMapPoint(p2, out x2, out y2);
            double pixelExtent = x2 - x1;
            double realWorldDisplayExtent = pActiveView.ScreenDisplay.DisplayTransformation.VisibleBounds.Width;
            double sizeOfOnePixel = realWorldDisplayExtent / pixelExtent;
            return pixelUnits * sizeOfOnePixel;
        }

        private void Form_main_KeyUp(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Shift)
                this.shift = false;
        }

        private void Map_open_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                ShowListBox(null);
                ClearSelect(tabPane1.SelectedPage.Controls[0] as AxMapControl);
            }
                
        }

        private void button_search_Click(object sender, EventArgs e)
        {

            //IQueryFilter pQueryFilter = new QueryFilterClass();
            //IFeatureLayer pFeatlyr;
            //IFeatureCursor pFeatCursor;
            AxMapControl mapcontrol = tabPane1.SelectedPage.Controls[0] as AxMapControl;


            if (textBox_search.Text.Length == 0)
            {
                MessageBox.Show("查询信息不能为空!");
                return;
            }
            ILayer layer = GetLayerByName(mapcontrol, "CHN_adm2");
            string sql = /*"Select * From " + "CHN_adm2" + " Where:" + */"\"NL_NAME_2\" LIKE '" + textBox_search.Text + "'";
            //pFeatlyr = (IFeatureLayer)layer;
            //pQueryFilter.WhereClause = sql;
            IFeature f;
            if((f = QueryAndHight(sql, layer, mapcontrol))==null)
            {
                return;
            }
            mapcontrol.Map.SelectFeature(layer, f);//将查询到的地物作为选择对象高亮显示在地图上           
            mapcontrol.CenterAt((f.Shape as ESRI.ArcGIS.Geometry.IPolygon).ToPoint);//设置当前查询到的要素为地图的中心           
            mapcontrol.MapScale = layer.MinimumScale;//将当前地图的比例尺设置为ILayer的最小显示比例尺           
            mapcontrol.ActiveView.Refresh();//刷新地图，这样才能显示出地物  
            ShowListBox(f);
        }
        public IFeature QueryAndHight(string sql, ILayer pLayer, AxMapControl t)
        {//查询                   
            t.Map.ClearSelection();//清除地图的选择  
            IFeatureLayer pFeatureLayer = pLayer as IFeatureLayer;//定义矢量图层            
            IQueryFilter pQueryFilter = new QueryFilter();//实例化一个查询条件对象            
            pQueryFilter.WhereClause = sql;//将查询条件赋值            
            IFeatureCursor pFeatureCursor = pFeatureLayer.Search(pQueryFilter, false);//进行查询            
            IFeature pFeature;
            pFeature = pFeatureCursor.NextFeature();//此步是将游标中的第一个交给pFeature            
            if (pFeature == null)//判断是否查到结果            
            {//如果没有查到报错并结束                
                MessageBox.Show("没有查询到地物！", "查询提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return pFeature;
        }
        private void ZoomToSelectedFeature(IFeatureLayer pFeatlyr, IQueryFilter pQueryFilter)
        {
            throw new NotImplementedException();
        }
        public void createClassBreakRender(string layerName, int classCount, string ClassField, esriSimpleFillStyle FillStyle)
        {
            AxMapControl mapcontrol = tabPane1.SelectedPage.Controls[0] as AxMapControl;
            //int classCount = 6;
            //classCount++;
            ITableHistogram tableHistogram;//表格直方图
            IBasicHistogram basicHistogram;//Provides access to members that control histogram objects created from different data sources. 

            ITable table;
            IGeoFeatureLayer geoFeatureLayer;
            geoFeatureLayer = GetLayerByName(mapcontrol, layerName) as IGeoFeatureLayer;
            ILayer layer = GetLayerByName(mapcontrol, layerName);
            table = layer as ITable;
            tableHistogram = new BasicTableHistogramClass();
            //按照 数值字段分级
            tableHistogram.Table = table;
            tableHistogram.Field = ClassField;
            basicHistogram = tableHistogram as IBasicHistogram;
            object values;
            object frequencys;
            //先统计每个值和各个值出现的次数
            basicHistogram.GetHistogram(out values, out frequencys);
            //创建平均分级对象
            IClassifyGEN classifyGEN = new QuantileClass();
            //用统计结果进行分级 ，级别数目为classCount
            classifyGEN.Classify(values, frequencys, ref classCount);
            //获得分级结果,是个 双精度类型数组 
            double[] classes;
            classes = classifyGEN.ClassBreaks as double[];
            //classes[classes.Length - 1]++;
            //定义不同等级渲染的色带用色
            IEnumColors enumColors = CreateAlgorithmicColorRamp(classes.Length).Colors;
            IColor color;
            IClassBreaksRenderer classBreaksRenderer = new ClassBreaksRendererClass();
            classBreaksRenderer.Field = ClassField;
            classBreaksRenderer.BreakCount = classCount;//分级数目
            classBreaksRenderer.SortClassesAscending = true;//定义分类是否在TOC中显示Legend

            ISimpleFillSymbol simpleFillSymbol;
            for (int i = 0; i < classes.Length - 1; i++)
            {
                color = enumColors.Next();

                simpleFillSymbol = new SimpleFillSymbolClass();
                simpleFillSymbol.Color = color;
                simpleFillSymbol.Style = FillStyle;

                classBreaksRenderer.set_Symbol(i, simpleFillSymbol as ISymbol);
                classBreaksRenderer.set_Break(i, classes[i]);
            }

            if (geoFeatureLayer != null)
            {
                geoFeatureLayer.Renderer = classBreaksRenderer as IFeatureRenderer;
            }

        }
        private IColorRamp CreateAlgorithmicColorRamp(int count)
        { //创建一个新 AlgorithmicColorRampClass 对象 
            IAlgorithmicColorRamp algColorRamp = new AlgorithmicColorRampClass();
            IRgbColor fromColor = new RgbColorClass();
            IRgbColor toColor = new RgbColorClass();//创建起始颜色对象
            fromColor.Red = 255;
            fromColor.Green = 0;
            fromColor.Blue = 0; //创建终止颜色对象
            toColor.Red = 0;
            toColor.Green = 0;
            toColor.Blue = 255;//设置 AlgorithmicColorRampClass 的起止颜色属性
            algColorRamp.ToColor = fromColor;
            algColorRamp.FromColor = toColor; //设置梯度类型
            algColorRamp.Algorithm = esriColorRampAlgorithm.esriCIELabAlgorithm; //设置颜色带颜色数量
            algColorRamp.Size = count; //创建颜色带
            bool bture = true;
            algColorRamp.CreateRamp(out bture);
            return algColorRamp;
        }

        private void textBox_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trackBarControl_timecontrol_EditValueChanged(object sender, EventArgs e)
        {
            int i = trackBarControl_timecontrol.Value;
            if(i < 3)
            {
                IGeoFeatureLayer geoFeatureLayer = GetLayerByName(Map_open, "CHN_adm2") as IGeoFeatureLayer;
                IClassBreaksRenderer classBreaksRenderer = geoFeatureLayer.Renderer as IClassBreaksRenderer;
                classBreaksRenderer.Field = "level_6to7";
                Map_open.Refresh(esriViewDrawPhase.esriViewGeography, null, null);
            }
            else if(i < 6)
            {
                IGeoFeatureLayer geoFeatureLayer = GetLayerByName(Map_open, "CHN_adm2") as IGeoFeatureLayer;
                IClassBreaksRenderer classBreaksRenderer = geoFeatureLayer.Renderer as IClassBreaksRenderer;
                classBreaksRenderer.Field = "level_7to8";
                Map_open.Refresh(esriViewDrawPhase.esriViewGeography, null, null);

            }
            else if (i < 9)
            {
                IGeoFeatureLayer geoFeatureLayer = GetLayerByName(Map_open, "CHN_adm2") as IGeoFeatureLayer;
                IClassBreaksRenderer classBreaksRenderer = geoFeatureLayer.Renderer as IClassBreaksRenderer;
                classBreaksRenderer.Field = "level_8to9";
                Map_open.Refresh(esriViewDrawPhase.esriViewGeography, null, null);


            }
            else
            {
                IGeoFeatureLayer geoFeatureLayer = GetLayerByName(Map_open, "CHN_adm2") as IGeoFeatureLayer;
                IClassBreaksRenderer classBreaksRenderer = geoFeatureLayer.Renderer as IClassBreaksRenderer;
                classBreaksRenderer.Field = "level_Sep";
                Map_open.Refresh(esriViewDrawPhase.esriViewGeography, null, null);

            }
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if(tabPane1.SelectedPage.Equals(tabNavigationPage1))
            {
                button_back.Enabled = true;
                button_forward.Enabled = true;
                button_stop.Enabled = true;
            }
            else
            {
                button_back.Enabled = false;
                button_forward.Enabled = false;
                button_stop.Enabled = false;
            }
        }

        private void timer_waitform_Tick(object sender, EventArgs e)
        {
            i++;
            if(i == 30)
            {
                timer_waitform.Stop();
                
            }
        }

        private void 整体分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string layerName = "CHN_adm2";
            DataTable open = ToDataTable(GetLayerByName(Map_open, layerName) as ITable);
            DataTable popluation = ToDataTable(GetLayerByName(Map_population, layerName) as ITable);
            DataTable land = ToDataTable(GetLayerByName(Map_land, layerName) as ITable);
            DataTable economy = ToDataTable(GetLayerByName(Map_economy, layerName) as ITable);
            DataTable rainfail = ToDataTable(GetLayerByName(Map_rainfall, layerName) as ITable);
            Form_ana f = new Form_ana(open, popluation, land, economy, rainfail);
            f.ShowDialog();
        }
        private string Translate(string c)
        {
            //string e;
            if (c == "NL_NAME_2")
                return "城市名";
            if (c == "sunshi1")
                return "受灾人口";
            if (c == "Join_Count")
                return "全市工业用地占比";
            if (c == "Join_Cou_1")
                return "全市农业用地占比";
            if (c == "Join_Cou_2")
                return "全市居民用地占比";
            if (c == "Join_Cou_3")
                return "全市其他用地占比";
            if (c == "show_0")
                return "全市工业用地受灾";
            if (c == "show_1")
                return "全市农业用地受灾";
            if (c == "show_2")
                return "全市居民用地受灾";
            if (c == "show_3")
                return "全市其他用地受灾";
            if (c == "land_sum")
                return "全市土地总受灾";
            if (c == "sunshi_1")
                return "经济损失";
            if (c == "Rainfall")
                return "七至八月份降雨量";
            if (c == "Rain_Sep")
                return "九月份降雨量";
            else
                return null;
        }

        private void Map_rainfall_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {

        }

        private void Map_open_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {

        }
    }
}
