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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManHinhChinh));
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
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.dgv_DoUong = new System.Windows.Forms.DataGridView();
            this.lbl_TimDoUong = new System.Windows.Forms.Label();
            this.txt_TimDoUong = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grp_ThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_NhanVienBanHang = new System.Windows.Forms.TextBox();
            this.lbl_NgayHoaDon = new System.Windows.Forms.Label();
            this.lbl_NhanVienBanHang = new System.Windows.Forms.Label();
            this.btn_XoaDoUong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.lsv_Ban = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpb_Ban = new System.Windows.Forms.GroupBox();
            this.rdb_Conguoi = new System.Windows.Forms.RadioButton();
            this.rdb_Trong = new System.Windows.Forms.RadioButton();
            this.rdb_Tatca = new System.Windows.Forms.RadioButton();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.lb_ChonBan = new System.Windows.Forms.Label();
            this.dgvHienDoUong = new System.Windows.Forms.DataGridView();
            this.btn_ChonBan = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoUong)).BeginInit();
            this.grp_ThongTinHoaDon.SuspendLayout();
            this.grpb_Ban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienDoUong)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
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
            this.lbl_BanDangChon.Location = new System.Drawing.Point(10, 57);
            this.lbl_BanDangChon.Name = "lbl_BanDangChon";
            this.lbl_BanDangChon.Size = new System.Drawing.Size(150, 19);
            this.lbl_BanDangChon.TabIndex = 1;
            this.lbl_BanDangChon.Text = "BÀN ĐANG CHỌN:";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(290, 90);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(93, 22);
            this.lbl_SoLuong.TabIndex = 1;
            this.lbl_SoLuong.Text = "Số lượng: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(403, 86);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.BackColor = System.Drawing.Color.Blue;
            this.btn_ThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMoi.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ThemMoi.Location = new System.Drawing.Point(475, 83);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(90, 29);
            this.btn_ThemMoi.TabIndex = 2;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = false;
            // 
            // dgv_DoUong
            // 
            this.dgv_DoUong.AllowUserToAddRows = false;
            this.dgv_DoUong.AllowUserToDeleteRows = false;
            this.dgv_DoUong.AllowUserToResizeColumns = false;
            this.dgv_DoUong.AllowUserToResizeRows = false;
            this.dgv_DoUong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_DoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoUong.Location = new System.Drawing.Point(270, 168);
            this.dgv_DoUong.Name = "dgv_DoUong";
            this.dgv_DoUong.ReadOnly = true;
            this.dgv_DoUong.RowHeadersWidth = 51;
            this.dgv_DoUong.Size = new System.Drawing.Size(483, 308);
            this.dgv_DoUong.TabIndex = 4;
            // 
            // lbl_TimDoUong
            // 
            this.lbl_TimDoUong.AutoSize = true;
            this.lbl_TimDoUong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimDoUong.Location = new System.Drawing.Point(290, 137);
            this.lbl_TimDoUong.Name = "lbl_TimDoUong";
            this.lbl_TimDoUong.Size = new System.Drawing.Size(153, 22);
            this.lbl_TimDoUong.TabIndex = 1;
            this.lbl_TimDoUong.Text = "Tìm theo đồ uống";
            // 
            // txt_TimDoUong
            // 
            this.txt_TimDoUong.Location = new System.Drawing.Point(449, 139);
            this.txt_TimDoUong.Name = "txt_TimDoUong";
            this.txt_TimDoUong.Size = new System.Drawing.Size(168, 20);
            this.txt_TimDoUong.TabIndex = 5;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Blue;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_TimKiem.Location = new System.Drawing.Point(647, 133);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(90, 28);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // grp_ThongTinHoaDon
            // 
            this.grp_ThongTinHoaDon.Controls.Add(this.dateTimePicker1);
            this.grp_ThongTinHoaDon.Controls.Add(this.txt_NhanVienBanHang);
            this.grp_ThongTinHoaDon.Controls.Add(this.lbl_NgayHoaDon);
            this.grp_ThongTinHoaDon.Controls.Add(this.lbl_NhanVienBanHang);
            this.grp_ThongTinHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThongTinHoaDon.Location = new System.Drawing.Point(772, 39);
            this.grp_ThongTinHoaDon.Name = "grp_ThongTinHoaDon";
            this.grp_ThongTinHoaDon.Size = new System.Drawing.Size(324, 89);
            this.grp_ThongTinHoaDon.TabIndex = 7;
            this.grp_ThongTinHoaDon.TabStop = false;
            this.grp_ThongTinHoaDon.Text = "Thông tin hóa đơn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txt_NhanVienBanHang
            // 
            this.txt_NhanVienBanHang.Location = new System.Drawing.Point(160, 18);
            this.txt_NhanVienBanHang.Name = "txt_NhanVienBanHang";
            this.txt_NhanVienBanHang.ReadOnly = true;
            this.txt_NhanVienBanHang.Size = new System.Drawing.Size(132, 26);
            this.txt_NhanVienBanHang.TabIndex = 1;
            // 
            // lbl_NgayHoaDon
            // 
            this.lbl_NgayHoaDon.AutoSize = true;
            this.lbl_NgayHoaDon.Location = new System.Drawing.Point(8, 58);
            this.lbl_NgayHoaDon.Name = "lbl_NgayHoaDon";
            this.lbl_NgayHoaDon.Size = new System.Drawing.Size(107, 19);
            this.lbl_NgayHoaDon.TabIndex = 0;
            this.lbl_NgayHoaDon.Text = "Ngày hóa đơn:";
            // 
            // lbl_NhanVienBanHang
            // 
            this.lbl_NhanVienBanHang.AutoSize = true;
            this.lbl_NhanVienBanHang.Location = new System.Drawing.Point(8, 27);
            this.lbl_NhanVienBanHang.Name = "lbl_NhanVienBanHang";
            this.lbl_NhanVienBanHang.Size = new System.Drawing.Size(146, 19);
            this.lbl_NhanVienBanHang.TabIndex = 0;
            this.lbl_NhanVienBanHang.Text = "Nhân viên bán hàng:";
            // 
            // btn_XoaDoUong
            // 
            this.btn_XoaDoUong.BackColor = System.Drawing.Color.Red;
            this.btn_XoaDoUong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XoaDoUong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDoUong.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_XoaDoUong.Location = new System.Drawing.Point(772, 134);
            this.btn_XoaDoUong.Name = "btn_XoaDoUong";
            this.btn_XoaDoUong.Size = new System.Drawing.Size(126, 28);
            this.btn_XoaDoUong.TabIndex = 8;
            this.btn_XoaDoUong.Text = "Xóa đồ uống";
            this.btn_XoaDoUong.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(767, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "TỔNG: ";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Blue;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ThanhToan.Location = new System.Drawing.Point(996, 482);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(106, 46);
            this.btn_ThanhToan.TabIndex = 2;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InHoaDon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_InHoaDon.Location = new System.Drawing.Point(1130, 482);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(106, 46);
            this.btn_InHoaDon.TabIndex = 2;
            this.btn_InHoaDon.Text = "In hóa đơn";
            this.btn_InHoaDon.UseVisualStyleBackColor = false;
            // 
            // lsv_Ban
            // 
            this.lsv_Ban.HideSelection = false;
            this.lsv_Ban.Location = new System.Drawing.Point(8, 168);
            this.lsv_Ban.Name = "lsv_Ban";
            this.lsv_Ban.Size = new System.Drawing.Size(244, 309);
            this.lsv_Ban.TabIndex = 10;
            this.lsv_Ban.UseCompatibleStateImageBehavior = false;
            this.lsv_Ban.Click += new System.EventHandler(this.lsv_Ban_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ban co nguoi");
            this.imageList1.Images.SetKeyName(1, "Ban Trong");
            // 
            // grpb_Ban
            // 
            this.grpb_Ban.Controls.Add(this.rdb_Conguoi);
            this.grpb_Ban.Controls.Add(this.rdb_Trong);
            this.grpb_Ban.Controls.Add(this.rdb_Tatca);
            this.grpb_Ban.Location = new System.Drawing.Point(0, 96);
            this.grpb_Ban.Name = "grpb_Ban";
            this.grpb_Ban.Size = new System.Drawing.Size(252, 66);
            this.grpb_Ban.TabIndex = 11;
            this.grpb_Ban.TabStop = false;
            // 
            // rdb_Conguoi
            // 
            this.rdb_Conguoi.AutoSize = true;
            this.rdb_Conguoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Conguoi.Location = new System.Drawing.Point(127, 41);
            this.rdb_Conguoi.Name = "rdb_Conguoi";
            this.rdb_Conguoi.Size = new System.Drawing.Size(128, 25);
            this.rdb_Conguoi.TabIndex = 2;
            this.rdb_Conguoi.Text = "Bàn có người";
            this.rdb_Conguoi.UseVisualStyleBackColor = true;
            this.rdb_Conguoi.CheckedChanged += new System.EventHandler(this.rdb_Conguoi_CheckedChanged);
            // 
            // rdb_Trong
            // 
            this.rdb_Trong.AutoSize = true;
            this.rdb_Trong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Trong.Location = new System.Drawing.Point(10, 43);
            this.rdb_Trong.Name = "rdb_Trong";
            this.rdb_Trong.Size = new System.Drawing.Size(101, 25);
            this.rdb_Trong.TabIndex = 1;
            this.rdb_Trong.Text = "Bàn trống";
            this.rdb_Trong.UseVisualStyleBackColor = true;
            this.rdb_Trong.CheckedChanged += new System.EventHandler(this.rdb_Trong_CheckedChanged);
            // 
            // rdb_Tatca
            // 
            this.rdb_Tatca.AutoSize = true;
            this.rdb_Tatca.Checked = true;
            this.rdb_Tatca.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Tatca.Location = new System.Drawing.Point(10, 12);
            this.rdb_Tatca.Name = "rdb_Tatca";
            this.rdb_Tatca.Size = new System.Drawing.Size(107, 25);
            this.rdb_Tatca.TabIndex = 0;
            this.rdb_Tatca.TabStop = true;
            this.rdb_Tatca.Text = "Tất cả bàn";
            this.rdb_Tatca.UseVisualStyleBackColor = true;
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.BackColor = System.Drawing.Color.SeaShell;
            this.lb_TongTien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.Color.Red;
            this.lb_TongTien.Location = new System.Drawing.Point(864, 490);
            this.lb_TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(78, 25);
            this.lb_TongTien.TabIndex = 12;
            this.lb_TongTien.Text = "100000";
            // 
            // lb_ChonBan
            // 
            this.lb_ChonBan.AutoSize = true;
            this.lb_ChonBan.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lb_ChonBan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChonBan.ForeColor = System.Drawing.Color.Brown;
            this.lb_ChonBan.Location = new System.Drawing.Point(311, 51);
            this.lb_ChonBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ChonBan.Name = "lb_ChonBan";
            this.lb_ChonBan.Size = new System.Drawing.Size(56, 25);
            this.lb_ChonBan.TabIndex = 13;
            this.lb_ChonBan.Text = "Bàn ";
            // 
            // dgvHienDoUong
            // 
            this.dgvHienDoUong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienDoUong.Location = new System.Drawing.Point(772, 168);
            this.dgvHienDoUong.Name = "dgvHienDoUong";
            this.dgvHienDoUong.Size = new System.Drawing.Size(472, 308);
            this.dgvHienDoUong.TabIndex = 14;
            this.dgvHienDoUong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienDoUong_CellContentClick);
            // 
            // btn_ChonBan
            // 
            this.btn_ChonBan.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_ChonBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonBan.ForeColor = System.Drawing.Color.Blue;
            this.btn_ChonBan.Location = new System.Drawing.Point(166, 49);
            this.btn_ChonBan.Name = "btn_ChonBan";
            this.btn_ChonBan.Size = new System.Drawing.Size(86, 34);
            this.btn_ChonBan.TabIndex = 15;
            this.btn_ChonBan.Text = "Ban da chon";
            this.btn_ChonBan.UseVisualStyleBackColor = false;
            // 
            // frm_ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1260, 539);
            this.Controls.Add(this.btn_ChonBan);
            this.Controls.Add(this.dgvHienDoUong);
            this.Controls.Add(this.lb_ChonBan);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.grpb_Ban);
            this.Controls.Add(this.lsv_Ban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaDoUong);
            this.Controls.Add(this.grp_ThongTinHoaDon);
            this.Controls.Add(this.txt_TimDoUong);
            this.Controls.Add(this.dgv_DoUong);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.lbl_TimDoUong);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_BanDangChon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý";
            this.Load += new System.EventHandler(this.frm_ManHinhChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoUong)).EndInit();
            this.grp_ThongTinHoaDon.ResumeLayout(false);
            this.grp_ThongTinHoaDon.PerformLayout();
            this.grpb_Ban.ResumeLayout(false);
            this.grpb_Ban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienDoUong)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_DoUong;
        private System.Windows.Forms.Label lbl_TimDoUong;
        private System.Windows.Forms.TextBox txt_TimDoUong;
        private System.Windows.Forms.Button btn_TimKiem;
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
        private System.Windows.Forms.Button btn_XoaDoUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.ListView lsv_Ban;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpb_Ban;
        private System.Windows.Forms.RadioButton rdb_Conguoi;
        private System.Windows.Forms.RadioButton rdb_Trong;
        private System.Windows.Forms.RadioButton rdb_Tatca;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label lb_ChonBan;
        private System.Windows.Forms.DataGridView dgvHienDoUong;
        private System.Windows.Forms.Button btn_ChonBan;
    }
}

