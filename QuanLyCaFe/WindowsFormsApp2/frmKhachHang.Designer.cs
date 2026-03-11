namespace WindowsFormsApp2
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.MenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuXoaHet = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.MenuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txt_TenKhachHang = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_MaKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TenNhanVien = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_MaNhanVien = new System.Windows.Forms.Label();
            this.menuStrip_DuLieu = new System.Windows.Forms.MenuStrip();
            this.MenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.menuStrip_DuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(619, 434);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(110, 36);
            this.btn_TimKiem.TabIndex = 116;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(32, 122);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(698, 306);
            this.dgv_KhachHang.TabIndex = 115;
            this.dgv_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellClick);
            // 
            // MenuThoat
            // 
            this.MenuThoat.Image = ((System.Drawing.Image)(resources.GetObject("MenuThoat.Image")));
            this.MenuThoat.Name = "MenuThoat";
            this.MenuThoat.Size = new System.Drawing.Size(70, 24);
            this.MenuThoat.Text = "Thoát";
            this.MenuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
            // 
            // MenuXoaHet
            // 
            this.MenuXoaHet.Image = ((System.Drawing.Image)(resources.GetObject("MenuXoaHet.Image")));
            this.MenuXoaHet.Name = "MenuXoaHet";
            this.MenuXoaHet.Size = new System.Drawing.Size(79, 24);
            this.MenuXoaHet.Text = "Xóa hết";
            this.MenuXoaHet.Click += new System.EventHandler(this.MenuXoaHet_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(373, 66);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(244, 50);
            this.txt_DiaChi.TabIndex = 113;
            // 
            // MenuSua
            // 
            this.MenuSua.Image = ((System.Drawing.Image)(resources.GetObject("MenuSua.Image")));
            this.MenuSua.Name = "MenuSua";
            this.MenuSua.Size = new System.Drawing.Size(58, 24);
            this.MenuSua.Text = "Sửa";
            this.MenuSua.Click += new System.EventHandler(this.MenuSua_Click);
            // 
            // MenuThem
            // 
            this.MenuThem.Image = ((System.Drawing.Image)(resources.GetObject("MenuThem.Image")));
            this.MenuThem.Name = "MenuThem";
            this.MenuThem.Size = new System.Drawing.Size(73, 24);
            this.MenuThem.Text = "Thêm ";
            this.MenuThem.Click += new System.EventHandler(this.MenuThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(476, 443);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(137, 20);
            this.txtTimKiem.TabIndex = 114;
            // 
            // txt_TenKhachHang
            // 
            this.txt_TenKhachHang.Location = new System.Drawing.Point(424, 32);
            this.txt_TenKhachHang.Name = "txt_TenKhachHang";
            this.txt_TenKhachHang.Size = new System.Drawing.Size(153, 20);
            this.txt_TenKhachHang.TabIndex = 104;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(141, 64);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(113, 20);
            this.txt_SDT.TabIndex = 112;
            // 
            // txt_MaKhachHang
            // 
            this.txt_MaKhachHang.Location = new System.Drawing.Point(141, 31);
            this.txt_MaKhachHang.Name = "txt_MaKhachHang";
            this.txt_MaKhachHang.Size = new System.Drawing.Size(113, 20);
            this.txt_MaKhachHang.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "Tên nhân viên: ";
            // 
            // lbl_TenNhanVien
            // 
            this.lbl_TenNhanVien.AutoSize = true;
            this.lbl_TenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNhanVien.Location = new System.Drawing.Point(312, 31);
            this.lbl_TenNhanVien.Name = "lbl_TenNhanVien";
            this.lbl_TenNhanVien.Size = new System.Drawing.Size(99, 19);
            this.lbl_TenNhanVien.TabIndex = 106;
            this.lbl_TenNhanVien.Text = "Tên nhân viên: ";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(38, 64);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(97, 19);
            this.lbl_SoDienThoai.TabIndex = 107;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // lbl_MaNhanVien
            // 
            this.lbl_MaNhanVien.AutoSize = true;
            this.lbl_MaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNhanVien.Location = new System.Drawing.Point(36, 31);
            this.lbl_MaNhanVien.Name = "lbl_MaNhanVien";
            this.lbl_MaNhanVien.Size = new System.Drawing.Size(97, 19);
            this.lbl_MaNhanVien.TabIndex = 109;
            this.lbl_MaNhanVien.Text = "Mã nhân viên: ";
            // 
            // menuStrip_DuLieu
            // 
            this.menuStrip_DuLieu.BackColor = System.Drawing.Color.White;
            this.menuStrip_DuLieu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_DuLieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuThem,
            this.MenuSua,
            this.MenuXoa,
            this.MenuXoaHet,
            this.MenuThoat});
            this.menuStrip_DuLieu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_DuLieu.Name = "menuStrip_DuLieu";
            this.menuStrip_DuLieu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip_DuLieu.Size = new System.Drawing.Size(776, 28);
            this.menuStrip_DuLieu.TabIndex = 103;
            this.menuStrip_DuLieu.Text = "Tên nhân viên:";
            // 
            // MenuXoa
            // 
            this.MenuXoa.Image = ((System.Drawing.Image)(resources.GetObject("MenuXoa.Image")));
            this.MenuXoa.Name = "MenuXoa";
            this.MenuXoa.Size = new System.Drawing.Size(59, 24);
            this.MenuXoa.Text = "Xóa";
            this.MenuXoa.Click += new System.EventHandler(this.MenuXoa_Click);
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(312, 65);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(54, 19);
            this.lbl_DiaChi.TabIndex = 110;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(776, 475);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txt_TenKhachHang);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_MaKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TenNhanVien);
            this.Controls.Add(this.lbl_SoDienThoai);
            this.Controls.Add(this.lbl_MaNhanVien);
            this.Controls.Add(this.menuStrip_DuLieu);
            this.Controls.Add(this.lbl_DiaChi);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.menuStrip_DuLieu.ResumeLayout(false);
            this.menuStrip_DuLieu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem MenuThoat;
        private System.Windows.Forms.ToolStripMenuItem MenuXoaHet;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.ToolStripMenuItem MenuSua;
        private System.Windows.Forms.ToolStripMenuItem MenuThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txt_TenKhachHang;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_MaKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TenNhanVien;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_MaNhanVien;
        private System.Windows.Forms.MenuStrip menuStrip_DuLieu;
        private System.Windows.Forms.ToolStripMenuItem MenuXoa;
        private System.Windows.Forms.Label lbl_DiaChi;
    }
}