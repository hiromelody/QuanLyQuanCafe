namespace WindowsFormsApp2
{
    partial class v
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v));
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_ThanhToan = new System.Windows.Forms.DataGridView();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_MaNhanVien = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(350, 81);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(110, 36);
            this.btn_TimKiem.TabIndex = 129;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // dgv_ThanhToan
            // 
            this.dgv_ThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThanhToan.Location = new System.Drawing.Point(32, 122);
            this.dgv_ThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ThanhToan.Name = "dgv_ThanhToan";
            this.dgv_ThanhToan.RowHeadersWidth = 51;
            this.dgv_ThanhToan.RowTemplate.Height = 24;
            this.dgv_ThanhToan.Size = new System.Drawing.Size(697, 306);
            this.dgv_ThanhToan.TabIndex = 128;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(99, 43);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(514, 19);
            this.txt_DiaChi.TabIndex = 126;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(406, 9);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(196, 20);
            this.txt_SDT.TabIndex = 125;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(160, 10);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(113, 20);
            this.txt_TenKhachHang.TabIndex = 117;
            this.txt_TenKhachHang.TextChanged += new System.EventHandler(this.txt_MaKhachHang_TextChanged);
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(303, 8);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(97, 19);
            this.lbl_SoDienThoai.TabIndex = 122;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            this.lbl_SoDienThoai.Click += new System.EventHandler(this.lbl_SoDienThoai_Click);
            // 
            // lbl_MaNhanVien
            // 
            this.lbl_MaNhanVien.AutoSize = true;
            this.lbl_MaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhanVien.Location = new System.Drawing.Point(39, 9);
            this.lbl_MaNhanVien.Name = "lbl_MaNhanVien";
            this.lbl_MaNhanVien.Size = new System.Drawing.Size(115, 19);
            this.lbl_MaNhanVien.TabIndex = 123;
            this.lbl_MaNhanVien.Text = "Tên Khách Hàng:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(39, 43);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(54, 19);
            this.lbl_DiaChi.TabIndex = 124;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            this.lbl_DiaChi.Click += new System.EventHandler(this.lbl_DiaChi_Click);
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_ThemMoi.BackColor = System.Drawing.Color.White;
            this.btn_ThemMoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemMoi.Location = new System.Drawing.Point(211, 81);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(110, 36);
            this.btn_ThemMoi.TabIndex = 130;
            this.btn_ThemMoi.Text = "Thêm Mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = false;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThanhToan.Location = new System.Drawing.Point(576, 433);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(156, 48);
            this.btn_ThanhToan.TabIndex = 131;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(744, 494);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dgv_ThanhToan);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenKhachHang);
            this.Controls.Add(this.lbl_SoDienThoai);
            this.Controls.Add(this.lbl_MaNhanVien);
            this.Controls.Add(this.lbl_DiaChi);
            this.Name = "v";
            this.Text = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_ThanhToan;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_MaNhanVien;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.Button btn_ThanhToan;
    }
}