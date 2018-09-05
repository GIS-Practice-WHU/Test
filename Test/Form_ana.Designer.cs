namespace Test
{
    partial class Form_ana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.checkedListBoxControl2 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.checkedListBoxControl3 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl2)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(584, 321);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.SelectedPageIndex = 0;
            this.tabPane1.Size = new System.Drawing.Size(584, 321);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "tabNavigationPage1";
            this.tabNavigationPage1.Controls.Add(this.button_search);
            this.tabNavigationPage1.Controls.Add(this.textBox1);
            this.tabNavigationPage1.Controls.Add(this.checkedListBoxControl1);
            this.tabNavigationPage1.Controls.Add(this.chartControl1);
            this.tabNavigationPage1.Image = global::Test.Properties.Resources.折线图1;
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(566, 257);
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.Location = new System.Drawing.Point(434, 25);
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.Size = new System.Drawing.Size(132, 232);
            this.checkedListBoxControl1.TabIndex = 1;
            this.checkedListBoxControl1.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl1_ItemCheck);
            this.checkedListBoxControl1.DataSourceChanged += new System.EventHandler(this.checkedListBoxControl1_DataSourceChanged);
            this.checkedListBoxControl1.DisplayMemberChanged += new System.EventHandler(this.checkedListBoxControl1_DisplayMemberChanged);
            this.checkedListBoxControl1.ValueMemberChanged += new System.EventHandler(this.checkedListBoxControl1_ValueMemberChanged);
            this.checkedListBoxControl1.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxControl1_SelectedIndexChanged);
            this.checkedListBoxControl1.SelectedValueChanged += new System.EventHandler(this.checkedListBoxControl1_SelectedValueChanged);
            this.checkedListBoxControl1.Click += new System.EventHandler(this.checkedListBoxControl1_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(428, 257);
            this.chartControl1.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Controls.Add(this.chartControl2);
            this.tabNavigationPage2.Controls.Add(this.checkedListBoxControl2);
            this.tabNavigationPage2.Image = global::Test.Properties.Resources.柱状图1;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(566, 257);
            // 
            // chartControl2
            // 
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(428, 257);
            this.chartControl2.TabIndex = 3;
            this.chartControl2.Click += new System.EventHandler(this.chartControl2_Click);
            // 
            // checkedListBoxControl2
            // 
            this.checkedListBoxControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkedListBoxControl2.Location = new System.Drawing.Point(434, 0);
            this.checkedListBoxControl2.Name = "checkedListBoxControl2";
            this.checkedListBoxControl2.Size = new System.Drawing.Size(132, 257);
            this.checkedListBoxControl2.TabIndex = 2;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "tabNavigationPage3";
            this.tabNavigationPage3.Controls.Add(this.checkedListBoxControl3);
            this.tabNavigationPage3.Image = global::Test.Properties.Resources.饼状图1;
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(566, 257);
            // 
            // checkedListBoxControl3
            // 
            this.checkedListBoxControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkedListBoxControl3.Location = new System.Drawing.Point(434, 0);
            this.checkedListBoxControl3.Name = "checkedListBoxControl3";
            this.checkedListBoxControl3.Size = new System.Drawing.Size(132, 257);
            this.checkedListBoxControl3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 21);
            this.textBox1.TabIndex = 2;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(545, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(21, 21);
            this.button_search.TabIndex = 3;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Form_ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.tabPane1);
            this.Name = "Form_ana";
            this.Text = "Form_ana";
            this.Load += new System.EventHandler(this.Form_ana_Load);
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl2)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl2;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl3;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox1;
    }
}