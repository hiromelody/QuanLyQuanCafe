namespace WindowsFormsApp2
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.menuStrip_DuLieu = new System.Windows.Forms.MenuStrip();
            this.MenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuXoaHet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_MaNhanVien = new System.Windows.Forms.Label();
            this.lbl_TenNhanVien = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.menuStrip_DuLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_DuLieu
            // 
            this.menuStrip_DuLieu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_DuLieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuThem,
            this.MenuSua,
            this.MenuXoa,
            this.MenuXoaHet,
            this.menuThoat});
            this.menuStrip_DuLieu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_DuLieu.Name = "menuStrip_DuLieu";
            this.menuStrip_DuLieu.Size = new System.Drawing.Size(1011, 28);
            this.menuStrip_DuLieu.TabIndex = 0;
            this.menuStrip_DuLieu.Text = "Tên nhân viên:";
            // 
            // MenuThem
            // 
            this.MenuThem.Image = ((System.Drawing.Image)(resources.GetObject("MenuThem.Image")));
            this.MenuThem.Name = "MenuThem";
            this.MenuThem.Size = new System.Drawing.Size(84, 24);
            this.MenuThem.Text = "Thêm ";
            this.MenuThem.Click += new System.EventHandler(this.MenuThem_Click);
            // 
            // MenuSua
            // 
            this.MenuSua.Image = ((System.Drawing.Image)(resources.GetObject("MenuSua.Image")));
            this.MenuSua.Name = "MenuSua";
            this.MenuSua.Size = new System.Drawing.Size(68, 24);
            this.MenuSua.Text = "Sửa";
            this.MenuSua.Click += new System.EventHandler(this.MenuSua_Click);
            // 
            // MenuXoa
            // 
            this.MenuXoa.Image = ((System.Drawing.Image)(resources.GetObject("MenuXoa.Image")));
            this.MenuXoa.Name = "MenuXoa";
            this.MenuXoa.Size = new System.Drawing.Size(69, 24);
            this.MenuXoa.Text = "Xóa";
            this.MenuXoa.Click += new System.EventHandler(this.MenuXoa_Click);
            // 
            // MenuXoaHet
            // 
            this.MenuXoaHet.Image = ((System.Drawing.Image)(resources.GetObject("MenuXoaHet.Image")));
            this.MenuXoaHet.Name = "MenuXoaHet";
            this.MenuXoaHet.Size = new System.Drawing.Size(94, 24);
            this.MenuXoaHet.Text = "Xóa hết";
            this.MenuXoaHet.Click += new System.EventHandler(this.MenuXoaHet_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Image = ((System.Drawing.Image)(resources.GetObject("menuThoat.Image")));
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(81, 24);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // lbl_MaNhanVien
            // 
            this.lbl_MaNhanVien.AutoSize = true;
            this.lbl_MaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhanVien.Location = new System.Drawing.Point(38, 53);
            this.lbl_MaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNhanVien.Name = "lbl_MaNhanVien";
            this.lbl_MaNhanVien.Size = new System.Drawing.Size(127, 22);
            this.lbl_MaNhanVien.TabIndex = 1;
            this.lbl_MaNhanVien.Text = "Mã nhân viên: ";
            // 
            // lbl_TenNhanVien
            // 
            this.lbl_TenNhanVien.AutoSize = true;
            this.lbl_TenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNhanVien.Location = new System.Drawing.Point(405, 53);
            this.lbl_TenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenNhanVien.Name = "lbl_TenNhanVien";
            this.lbl_TenNhanVien.Size = new System.Drawing.Size(131, 22);
            this.lbl_TenNhanVien.TabIndex = 1;
            this.lbl_TenNhanVien.Text = "Tên nhân viên: ";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(405, 95);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(74, 22);
            this.lbl_DiaChi.TabIndex = 1;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Location = new System.Drawing.Point(177, 53);
            this.txt_MaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(149, 22);
            this.txt_MaNhanVien.TabIndex = 0;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(554, 54);
            this.txt_TenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(203, 22);
            this.txt_TenNhanVien.TabIndex = 1;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(487, 96);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(324, 61);
            this.txt_DiaChi.TabIndex = 4;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(40, 135);
            this.lbl_MatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(88, 22);
            this.lbl_MatKhau.TabIndex = 1;
            this.lbl_MatKhau.Text = "Mật khẩu:";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(40, 94);
            this.lbl_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(129, 23);
            this.lbl_SoDienThoai.TabIndex = 1;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(177, 135);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(149, 22);
            this.txt_MatKhau.TabIndex = 2;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(177, 94);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(149, 22);
            this.txt_SDT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 566);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên: ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(635, 568);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(181, 22);
            this.txtTimKiem.TabIndex = 5;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(826, 556);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(147, 44);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(42, 173);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(931, 376);
            this.dgv_NhanVien.TabIndex = 100;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick_1);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1011, 606);
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txt_TenNhanVien);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_MaNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_TenNhanVien);
            this.Controls.Add(this.lbl_SoDienThoai);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_MaNhanVien);
            this.Controls.Add(this.menuStrip_DuLieu);
            this.MainMenuStrip = this.menuStrip_DuLieu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.menuStrip_DuLieu.ResumeLayout(false);
            this.menuStrip_DuLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_DuLieu;
        private System.Windows.Forms.ToolStripMenuItem MenuThem;
        private System.Windows.Forms.ToolStripMenuItem MenuSua;
        private System.Windows.Forms.ToolStripMenuItem MenuXoa;
        private System.Windows.Forms.ToolStripMenuItem MenuXoaHet;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.Label lbl_MaNhanVien;
        private System.Windows.Forms.Label lbl_TenNhanVien;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
    }
}