namespace QuanLyLopHoc
{
    partial class frmThaoTacTaiKhoan
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
            this.lblMaGiaoVien = new System.Windows.Forms.Label();
            this.txtMaGiaoVien = new System.Windows.Forms.TextBox();
            this.btnThaoTac = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblMaGiaoVien
            // 
            this.lblMaGiaoVien.AutoSize = true;
            this.lblMaGiaoVien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaGiaoVien.Location = new System.Drawing.Point(87, 62);
            this.lblMaGiaoVien.Name = "lblMaGiaoVien";
            this.lblMaGiaoVien.Size = new System.Drawing.Size(98, 17);
            this.lblMaGiaoVien.TabIndex = 0;
            this.lblMaGiaoVien.Text = "Mã giáo viên:";
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Location = new System.Drawing.Point(205, 59);
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.Size = new System.Drawing.Size(292, 23);
            this.txtMaGiaoVien.TabIndex = 1;
            // 
            // btnThaoTac
            // 
            this.btnThaoTac.Location = new System.Drawing.Point(262, 121);
            this.btnThaoTac.Name = "btnThaoTac";
            this.btnThaoTac.Size = new System.Drawing.Size(94, 29);
            this.btnThaoTac.TabIndex = 2;
            this.btnThaoTac.Text = "Thao tác";
            // 
            // frmThaoTacTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 173);
            this.Controls.Add(this.btnThaoTac);
            this.Controls.Add(this.txtMaGiaoVien);
            this.Controls.Add(this.lblMaGiaoVien);
            this.Name = "frmThaoTacTaiKhoan";
            this.Text = "EditTaiKhoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaGiaoVien;
        private System.Windows.Forms.TextBox txtMaGiaoVien;
        private DevExpress.XtraEditors.SimpleButton btnThaoTac;
    }
}