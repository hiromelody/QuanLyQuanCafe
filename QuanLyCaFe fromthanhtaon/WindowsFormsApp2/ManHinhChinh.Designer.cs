namespace WindowsFormsApp2
{
    partial class frm_ManHinhChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiĐồUốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đồUốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cÔngThứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuTheoNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLịchSửHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_BanDangChon = new System.Windows.Forms.Label();
            this.btn_ChonBan = new System.Windows.Forms.Button();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.dgv_SoLuong = new System.Windows.Forms.DataGridView();
            this.col_HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TimDoUong = new System.Windows.Forms.Label();
            this.txt_TimDoUong = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.grp_ThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_NhanVienBanHang = new System.Windows.Forms.TextBox();
            this.lbl_NgayHoaDon = new System.Windows.Forms.Label();
            this.lbl_NhanVienBanHang = new System.Windows.Forms.Label();
            this.btn_XoaDoUong = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoLuong)).BeginInit();
            this.grp_ThongTinHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiĐồUốngToolStripMenuItem,
            this.đồUốngToolStripMenuItem,
            this.bànToolStripMenuItem,
            this.cÔngThứcToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // loạiĐồUốngToolStripMenuItem
            // 
            this.loạiĐồUốngToolStripMenuItem.Name = "loạiĐồUốngToolStripMenuItem";
            this.loạiĐồUốngToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.loạiĐồUốngToolStripMenuItem.Text = "Loại đồ uống";
            this.loạiĐồUốngToolStripMenuItem.Click += new System.EventHandler(this.loạiĐồUốngToolStripMenuItem_Click);
            // 
            // đồUốngToolStripMenuItem
            // 
            this.đồUốngToolStripMenuItem.Name = "đồUốngToolStripMenuItem";
            this.đồUốngToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.đồUốngToolStripMenuItem.Text = "Đồ uống";
            this.đồUốngToolStripMenuItem.Click += new System.EventHandler(this.đồUốngToolStripMenuItem_Click);
            // 
            // bànToolStripMenuItem
            // 
            this.bànToolStripMenuItem.Name = "bànToolStripMenuItem";
            this.bànToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bànToolStripMenuItem.Text = "Bàn";
            this.bànToolStripMenuItem.Click += new System.EventHandler(this.bànToolStripMenuItem_Click);
            // 
            // cÔngThứcToolStripMenuItem
            // 
            this.cÔngThứcToolStripMenuItem.Name = "cÔngThứcToolStripMenuItem";
            this.cÔngThứcToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cÔngThứcToolStripMenuItem.Text = "Công thức";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêDoanhThuTheoNgàyToolStripMenuItem,
            this.thốngKêDoanhThuTheoNhânViênToolStripMenuItem,
            this.thốngKêBánHàngToolStripMenuItem,
            this.xemLịchSửHóaĐơnToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thốngKêDoanhThuTheoNgàyToolStripMenuItem
            // 
            this.thốngKêDoanhThuTheoNgàyToolStripMenuItem.Name = "thốngKêDoanhThuTheoNgàyToolStripMenuItem";
            this.thốngKêDoanhThuTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.thốngKêDoanhThuTheoNgàyToolStripMenuItem.Text = "Thống kê doanh thu theo ngày";
            // 
            // thốngKêDoanhThuTheoNhânViênToolStripMenuItem
            // 
            this.thốngKêDoanhThuTheoNhânViênToolStripMenuItem.Name = "thốngKêDoanhThuTheoNhânViênToolStripMenuItem";
            this.thốngKêDoanhThuTheoNhânViênToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.thốngKêDoanhThuTheoNhânViênToolStripMenuItem.Text = "Thống kê doanh thu theo nhân viên";
            // 
            // thốngKêBánHàngToolStripMenuItem
            // 
            this.thốngKêBánHàngToolStripMenuItem.Name = "thốngKêBánHàngToolStripMenuItem";
            this.thốngKêBánHàngToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.thốngKêBánHàngToolStripMenuItem.Text = "Thống kê bán hàng";
            // 
            // xemLịchSửHóaĐơnToolStripMenuItem
            // 
            this.xemLịchSửHóaĐơnToolStripMenuItem.Name = "xemLịchSửHóaĐơnToolStripMenuItem";
            this.xemLịchSửHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.xemLịchSửHóaĐơnToolStripMenuItem.Text = "Xem lịch sử hóa đơn";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // lbl_BanDangChon
            // 
            this.lbl_BanDangChon.AutoSize = true;
            this.lbl_BanDangChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BanDangChon.Location = new System.Drawing.Point(21, 51);
            this.lbl_BanDangChon.Name = "lbl_BanDangChon";
            this.lbl_BanDangChon.Size = new System.Drawing.Size(150, 19);
            this.lbl_BanDangChon.TabIndex = 1;
            this.lbl_BanDangChon.Text = "BÀN ĐANG CHỌN:";
            // 
            // btn_ChonBan
            // 
            this.btn_ChonBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ChonBan.BackColor = System.Drawing.Color.Magenta;
            this.btn_ChonBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChonBan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonBan.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ChonBan.Location = new System.Drawing.Point(177, 51);
            this.btn_ChonBan.Name = "btn_ChonBan";
            this.btn_ChonBan.Size = new System.Drawing.Size(110, 23);
            this.btn_ChonBan.TabIndex = 2;
            this.btn_ChonBan.Text = "Chưa chọn bàn";
            this.btn_ChonBan.UseVisualStyleBackColor = false;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(310, 55);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(78, 19);
            this.lbl_SoLuong.TabIndex = 1;
            this.lbl_SoLuong.Text = "Số lượng: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(394, 57);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.BackColor = System.Drawing.Color.Blue;
            this.btn_ThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemMoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMoi.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ThemMoi.Location = new System.Drawing.Point(451, 55);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(84, 23);
            this.btn_ThemMoi.TabIndex = 2;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = false;
            // 
            // dgv_SoLuong
            // 
            this.dgv_SoLuong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_SoLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SoLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_HinhAnh,
            this.col_MaDoUong,
            this.col_TenDoUong,
            this.col_GiaTien});
            this.dgv_SoLuong.Location = new System.Drawing.Point(314, 110);
            this.dgv_SoLuong.Name = "dgv_SoLuong";
            this.dgv_SoLuong.ReadOnly = true;
            this.dgv_SoLuong.RowHeadersWidth = 51;
            this.dgv_SoLuong.Size = new System.Drawing.Size(394, 521);
            this.dgv_SoLuong.TabIndex = 4;
            // 
            // col_HinhAnh
            // 
            this.col_HinhAnh.HeaderText = "Hình ảnh";
            this.col_HinhAnh.MinimumWidth = 6;
            this.col_HinhAnh.Name = "col_HinhAnh";
            this.col_HinhAnh.ReadOnly = true;
            this.col_HinhAnh.Width = 125;
            // 
            // col_MaDoUong
            // 
            this.col_MaDoUong.HeaderText = "Mã đồ uống";
            this.col_MaDoUong.MinimumWidth = 6;
            this.col_MaDoUong.Name = "col_MaDoUong";
            this.col_MaDoUong.ReadOnly = true;
            this.col_MaDoUong.Width = 50;
            // 
            // col_TenDoUong
            // 
            this.col_TenDoUong.HeaderText = "Tên đồ uống";
            this.col_TenDoUong.MinimumWidth = 6;
            this.col_TenDoUong.Name = "col_TenDoUong";
            this.col_TenDoUong.ReadOnly = true;
            this.col_TenDoUong.Width = 125;
            // 
            // col_GiaTien
            // 
            this.col_GiaTien.HeaderText = "Giá tiền";
            this.col_GiaTien.MinimumWidth = 6;
            this.col_GiaTien.Name = "col_GiaTien";
            this.col_GiaTien.ReadOnly = true;
            this.col_GiaTien.Width = 125;
            // 
            // lbl_TimDoUong
            // 
            this.lbl_TimDoUong.AutoSize = true;
            this.lbl_TimDoUong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimDoUong.Location = new System.Drawing.Point(310, 88);
            this.lbl_TimDoUong.Name = "lbl_TimDoUong";
            this.lbl_TimDoUong.Size = new System.Drawing.Size(124, 19);
            this.lbl_TimDoUong.TabIndex = 1;
            this.lbl_TimDoUong.Text = "Tìm theo đồ uống";
            // 
            // txt_TimDoUong
            // 
            this.txt_TimDoUong.Location = new System.Drawing.Point(441, 86);
            this.txt_TimDoUong.Name = "txt_TimDoUong";
            this.txt_TimDoUong.Size = new System.Drawing.Size(100, 20);
            this.txt_TimDoUong.TabIndex = 5;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Blue;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_TimKiem.Location = new System.Drawing.Point(547, 86);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(71, 23);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 80);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(295, 551);
            this.treeView1.TabIndex = 6;
            // 
            // grp_ThongTinHoaDon
            // 
            this.grp_ThongTinHoaDon.Controls.Add(this.dateTimePicker1);
            this.grp_ThongTinHoaDon.Controls.Add(this.txt_NhanVienBanHang);
            this.grp_ThongTinHoaDon.Controls.Add(this.lbl_NgayHoaDon);
            this.grp_ThongTinHoaDon.Controls.Add(this.lbl_NhanVienBanHang);
            this.grp_ThongTinHoaDon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinHoaDon.Location = new System.Drawing.Point(722, 51);
            this.grp_ThongTinHoaDon.Name = "grp_ThongTinHoaDon";
            this.grp_ThongTinHoaDon.Size = new System.Drawing.Size(324, 100);
            this.grp_ThongTinHoaDon.TabIndex = 7;
            this.grp_ThongTinHoaDon.TabStop = false;
            this.grp_ThongTinHoaDon.Text = "Thông tin hóa đơn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txt_NhanVienBanHang
            // 
            this.txt_NhanVienBanHang.Location = new System.Drawing.Point(132, 27);
            this.txt_NhanVienBanHang.Name = "txt_NhanVienBanHang";
            this.txt_NhanVienBanHang.ReadOnly = true;
            this.txt_NhanVienBanHang.Size = new System.Drawing.Size(132, 22);
            this.txt_NhanVienBanHang.TabIndex = 1;
            // 
            // lbl_NgayHoaDon
            // 
            this.lbl_NgayHoaDon.AutoSize = true;
            this.lbl_NgayHoaDon.Location = new System.Drawing.Point(8, 59);
            this.lbl_NgayHoaDon.Name = "lbl_NgayHoaDon";
            this.lbl_NgayHoaDon.Size = new System.Drawing.Size(86, 15);
            this.lbl_NgayHoaDon.TabIndex = 0;
            this.lbl_NgayHoaDon.Text = "Ngày hóa đơn:";
            // 
            // lbl_NhanVienBanHang
            // 
            this.lbl_NhanVienBanHang.AutoSize = true;
            this.lbl_NhanVienBanHang.Location = new System.Drawing.Point(8, 30);
            this.lbl_NhanVienBanHang.Name = "lbl_NhanVienBanHang";
            this.lbl_NhanVienBanHang.Size = new System.Drawing.Size(118, 15);
            this.lbl_NhanVienBanHang.TabIndex = 0;
            this.lbl_NhanVienBanHang.Text = "Nhân viên bán hàng:";
            // 
            // btn_XoaDoUong
            // 
            this.btn_XoaDoUong.BackColor = System.Drawing.Color.Red;
            this.btn_XoaDoUong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XoaDoUong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDoUong.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_XoaDoUong.Location = new System.Drawing.Point(722, 161);
            this.btn_XoaDoUong.Name = "btn_XoaDoUong";
            this.btn_XoaDoUong.Size = new System.Drawing.Size(126, 23);
            this.btn_XoaDoUong.TabIndex = 8;
            this.btn_XoaDoUong.Text = "Xóa đồ uống";
            this.btn_XoaDoUong.UseVisualStyleBackColor = false;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(722, 190);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(454, 313);
            this.treeView2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "TỔNG: ";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Blue;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ThanhToan.Location = new System.Drawing.Point(956, 529);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(107, 23);
            this.btn_ThanhToan.TabIndex = 2;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_InHoaDon.Location = new System.Drawing.Point(1069, 529);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(107, 23);
            this.btn_InHoaDon.TabIndex = 2;
            this.btn_InHoaDon.Text = "In hóa đơn";
            this.btn_InHoaDon.UseVisualStyleBackColor = false;
            // 
            // frm_ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1191, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaDoUong);
            this.Controls.Add(this.grp_ThongTinHoaDon);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txt_TimDoUong);
            this.Controls.Add(this.dgv_SoLuong);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.btn_ChonBan);
            this.Controls.Add(this.lbl_TimDoUong);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_BanDangChon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoLuong)).EndInit();
            this.grp_ThongTinHoaDon.ResumeLayout(false);
            this.grp_ThongTinHoaDon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label lbl_BanDangChon;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.DataGridView dgv_SoLuong;
        private System.Windows.Forms.Label lbl_TimDoUong;
        private System.Windows.Forms.TextBox txt_TimDoUong;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GiaTien;
        private System.Windows.Forms.GroupBox grp_ThongTinHoaDon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_NhanVienBanHang;
        private System.Windows.Forms.Label lbl_NgayHoaDon;
        private System.Windows.Forms.Label lbl_NhanVienBanHang;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiĐồUốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đồUốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cÔngThứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuTheoNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemLịchSửHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.Button btn_ChonBan;
        private System.Windows.Forms.Button btn_XoaDoUong;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

