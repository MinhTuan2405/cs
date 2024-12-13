namespace QuanLyLopHoc
{
    partial class frmThongKeBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeBaoCao));
            this.xtraTabTKBC = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabKQHT = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabSLHSGV = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabML = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabTKBC)).BeginInit();
            this.xtraTabTKBC.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabTKBC
            // 
            this.xtraTabTKBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabTKBC.Location = new System.Drawing.Point(0, 0);
            this.xtraTabTKBC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabTKBC.Name = "xtraTabTKBC";
            this.xtraTabTKBC.SelectedTabPage = this.xtraTabKQHT;
            this.xtraTabTKBC.Size = new System.Drawing.Size(900, 562);
            this.xtraTabTKBC.TabIndex = 1;
            this.xtraTabTKBC.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabKQHT,
            this.xtraTabSLHSGV,
            this.xtraTabML});
            // 
            // xtraTabKQHT
            // 
            this.xtraTabKQHT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabKQHT.Name = "xtraTabKQHT";
            this.xtraTabKQHT.Size = new System.Drawing.Size(898, 527);
            this.xtraTabKQHT.Text = "Kết quả học tập";
            // 
            // xtraTabSLHSGV
            // 
            this.xtraTabSLHSGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabSLHSGV.Name = "xtraTabSLHSGV";
            this.xtraTabSLHSGV.Size = new System.Drawing.Size(898, 527);
            this.xtraTabSLHSGV.Text = "Số lượng Học sinh - Giáo viên";
            // 
            // xtraTabML
            // 
            this.xtraTabML.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabML.Name = "xtraTabML";
            this.xtraTabML.Size = new System.Drawing.Size(898, 527);
            this.xtraTabML.Text = "Môn - Lớp";
            // 
            // frmThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.xtraTabTKBC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThongKeBaoCao";
            this.Text = "Thống kê - báo cáo";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabTKBC)).EndInit();
            this.xtraTabTKBC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabTKBC;
        private DevExpress.XtraTab.XtraTabPage xtraTabKQHT;
        private DevExpress.XtraTab.XtraTabPage xtraTabSLHSGV;
        private DevExpress.XtraTab.XtraTabPage xtraTabML;
    }
}