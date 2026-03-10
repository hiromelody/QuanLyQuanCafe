namespace WindowsFormsApp2
{
    partial class frmDoiMatKhau
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
            this.txt_XacNhan = new System.Windows.Forms.TextBox();
            this.txt_NhapMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txt_NhapMatKhauCu = new System.Windows.Forms.TextBox();
            this.lbl_XacNhan = new System.Windows.Forms.Label();
            this.lbl_NhapMatKhauMoi = new System.Windows.Forms.Label();
            this.lbl_NhapMatKhauCu = new System.Windows.Forms.Label();
            this.btn_DoiMatKhau = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_XacNhan
            // 
            this.txt_XacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_XacNhan.Location = new System.Drawing.Point(223, 94);
            this.txt_XacNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_XacNhan.Name = "txt_XacNhan";
            this.txt_XacNhan.Size = new System.Drawing.Size(269, 22);
            this.txt_XacNhan.TabIndex = 6;
            // 
            // txt_NhapMatKhauMoi
            // 
            this.txt_NhapMatKhauMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_NhapMatKhauMoi.Location = new System.Drawing.Point(223, 55);
            this.txt_NhapMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NhapMatKhauMoi.Name = "txt_NhapMatKhauMoi";
            this.txt_NhapMatKhauMoi.Size = new System.Drawing.Size(269, 22);
            this.txt_NhapMatKhauMoi.TabIndex = 7;
            // 
            // txt_NhapMatKhauCu
            // 
            this.txt_NhapMatKhauCu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_NhapMatKhauCu.Location = new System.Drawing.Point(223, 15);
            this.txt_NhapMatKhauCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NhapMatKhauCu.Name = "txt_NhapMatKhauCu";
            this.txt_NhapMatKhauCu.Size = new System.Drawing.Size(269, 22);
            this.txt_NhapMatKhauCu.TabIndex = 8;
            // 
            // lbl_XacNhan
            // 
            this.lbl_XacNhan.AutoSize = true;
            this.lbl_XacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_XacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_XacNhan.Location = new System.Drawing.Point(16, 92);
            this.lbl_XacNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_XacNhan.Name = "lbl_XacNhan";
            this.lbl_XacNhan.Size = new System.Drawing.Size(194, 22);
            this.lbl_XacNhan.TabIndex = 3;
            this.lbl_XacNhan.Text = "Xác nhận lại mật khẩu: ";
            // 
            // lbl_NhapMatKhauMoi
            // 
            this.lbl_NhapMatKhauMoi.AutoSize = true;
            this.lbl_NhapMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhapMatKhauMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_NhapMatKhauMoi.Location = new System.Drawing.Point(16, 54);
            this.lbl_NhapMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NhapMatKhauMoi.Name = "lbl_NhapMatKhauMoi";
            this.lbl_NhapMatKhauMoi.Size = new System.Drawing.Size(168, 22);
            this.lbl_NhapMatKhauMoi.TabIndex = 4;
            this.lbl_NhapMatKhauMoi.Text = "Nhập mật khẩu mới:";
            // 
            // lbl_NhapMatKhauCu
            // 
            this.lbl_NhapMatKhauCu.AutoSize = true;
            this.lbl_NhapMatKhauCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhapMatKhauCu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_NhapMatKhauCu.Location = new System.Drawing.Point(16, 16);
            this.lbl_NhapMatKhauCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NhapMatKhauCu.Name = "lbl_NhapMatKhauCu";
            this.lbl_NhapMatKhauCu.Size = new System.Drawing.Size(160, 22);
            this.lbl_NhapMatKhauCu.TabIndex = 5;
            this.lbl_NhapMatKhauCu.Text = "Nhập mật khẩu cũ: ";
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.BackColor = System.Drawing.Color.Red;
            this.btn_DoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(20, 136);
            this.btn_DoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(185, 42);
            this.btn_DoiMatKhau.TabIndex = 9;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu";
            this.btn_DoiMatKhau.UseVisualStyleBackColor = false;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Blue;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(307, 136);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(185, 42);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(512, 195);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DoiMatKhau);
            this.Controls.Add(this.txt_XacNhan);
            this.Controls.Add(this.txt_NhapMatKhauMoi);
            this.Controls.Add(this.txt_NhapMatKhauCu);
            this.Controls.Add(this.lbl_XacNhan);
            this.Controls.Add(this.lbl_NhapMatKhauMoi);
            this.Controls.Add(this.lbl_NhapMatKhauCu);
            this.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_XacNhan;
        private System.Windows.Forms.TextBox txt_NhapMatKhauMoi;
        private System.Windows.Forms.TextBox txt_NhapMatKhauCu;
        private System.Windows.Forms.Label lbl_XacNhan;
        private System.Windows.Forms.Label lbl_NhapMatKhauMoi;
        private System.Windows.Forms.Label lbl_NhapMatKhauCu;
        private System.Windows.Forms.Button btn_DoiMatKhau;
        private System.Windows.Forms.Button btn_Thoat;
    }
}