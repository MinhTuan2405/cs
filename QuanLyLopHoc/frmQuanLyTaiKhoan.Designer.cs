namespace QuanLyLopHoc
{
    partial class frmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.gridControlDanhSachTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControlQLTK = new DevExpress.XtraEditors.PanelControl();
            this.btnThaoTacTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlQLTKtable = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlQLTK)).BeginInit();
            this.panelControlQLTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlQLTKtable)).BeginInit();
            this.panelControlQLTKtable.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlDanhSachTaiKhoan
            // 
            this.gridControlDanhSachTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDanhSachTaiKhoan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlDanhSachTaiKhoan.Location = new System.Drawing.Point(2, 2);
            this.gridControlDanhSachTaiKhoan.MainView = this.gridView1;
            this.gridControlDanhSachTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlDanhSachTaiKhoan.Name = "gridControlDanhSachTaiKhoan";
            this.gridControlDanhSachTaiKhoan.Size = new System.Drawing.Size(1858, 879);
            this.gridControlDanhSachTaiKhoan.TabIndex = 2;
            this.gridControlDanhSachTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDUser,
            this.colUsername,
            this.colPassword,
            this.colDateCreated,
            this.colLevel,
            this.colMaGV});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControlDanhSachTaiKhoan;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 900;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colIDUser
            // 
            this.colIDUser.Caption = "ID";
            this.colIDUser.MinWidth = 28;
            this.colIDUser.Name = "colIDUser";
            this.colIDUser.Visible = true;
            this.colIDUser.VisibleIndex = 0;
            this.colIDUser.Width = 56;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Tên tài khoản";
            this.colUsername.MinWidth = 28;
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 1;
            this.colUsername.Width = 351;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Mật khẩu";
            this.colPassword.MinWidth = 28;
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            this.colPassword.Width = 351;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo tài khoản";
            this.colDateCreated.MinWidth = 28;
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 3;
            this.colDateCreated.Width = 351;
            // 
            // colLevel
            // 
            this.colLevel.Caption = "Quyền hạn";
            this.colLevel.MinWidth = 28;
            this.colLevel.Name = "colLevel";
            this.colLevel.Visible = true;
            this.colLevel.VisibleIndex = 4;
            this.colLevel.Width = 351;
            // 
            // colMaGV
            // 
            this.colMaGV.Caption = "Mã giáo viên";
            this.colMaGV.MinWidth = 28;
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.Visible = true;
            this.colMaGV.VisibleIndex = 5;
            this.colMaGV.Width = 357;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControlQLTKtable);
            this.panelControl1.Controls.Add(this.panelControlQLTK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1866, 961);
            this.panelControl1.TabIndex = 8;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panelControlQLTK
            // 
            this.panelControlQLTK.Controls.Add(this.btnThaoTacTaiKhoan);
            this.panelControlQLTK.Controls.Add(this.btnThemTaiKhoan);
            this.panelControlQLTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlQLTK.Location = new System.Drawing.Point(2, 2);
            this.panelControlQLTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControlQLTK.Name = "panelControlQLTK";
            this.panelControlQLTK.Size = new System.Drawing.Size(1862, 74);
            this.panelControlQLTK.TabIndex = 3;
            // 
            // btnThaoTacTaiKhoan
            // 
            this.btnThaoTacTaiKhoan.Location = new System.Drawing.Point(170, 26);
            this.btnThaoTacTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThaoTacTaiKhoan.Name = "btnThaoTacTaiKhoan";
            this.btnThaoTacTaiKhoan.Size = new System.Drawing.Size(168, 36);
            this.btnThaoTacTaiKhoan.TabIndex = 0;
            this.btnThaoTacTaiKhoan.Text = "Thao tác";
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(6, 26);
            this.btnThemTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(106, 36);
            this.btnThemTaiKhoan.TabIndex = 0;
            this.btnThemTaiKhoan.Text = "Thêm";
            // 
            // panelControlQLTKtable
            // 
            this.panelControlQLTKtable.Controls.Add(this.gridControlDanhSachTaiKhoan);
            this.panelControlQLTKtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlQLTKtable.Location = new System.Drawing.Point(2, 76);
            this.panelControlQLTKtable.Name = "panelControlQLTKtable";
            this.panelControlQLTKtable.Size = new System.Drawing.Size(1862, 883);
            this.panelControlQLTKtable.TabIndex = 4;
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 961);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlQLTK)).EndInit();
            this.panelControlQLTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlQLTKtable)).EndInit();
            this.panelControlQLTKtable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlDanhSachTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUser;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGV;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControlQLTK;
        private DevExpress.XtraEditors.SimpleButton btnThaoTacTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnThemTaiKhoan;
        private DevExpress.XtraEditors.PanelControl panelControlQLTKtable;
    }
}