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
            this.mns_DanhMuc = new System.Windows.Forms.MenuStrip();
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
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.dgv_DoUong = new System.Windows.Forms.DataGridView();
            this.lbl_TimDoUong = new System.Windows.Forms.Label();
            this.txt_TimDoUong = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_ThemDoUong = new System.Windows.Forms.Button();
            this.imgl_MHC = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.lsv_Ban = new System.Windows.Forms.ListView();
            this.imgl_Ban = new System.Windows.Forms.ImageList(this.components);
            this.grpb_Ban = new System.Windows.Forms.GroupBox();
            this.rdb_Conguoi = new System.Windows.Forms.RadioButton();
            this.rdb_Trong = new System.Windows.Forms.RadioButton();
            this.rdb_Tatca = new System.Windows.Forms.RadioButton();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.dgvHienDoUong = new System.Windows.Forms.DataGridView();
            this.btn_ChonBan = new System.Windows.Forms.Button();
            this.btn_GiamDoUong = new System.Windows.Forms.Button();
            this.btn_XoaMon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mns_DanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoUong)).BeginInit();
            this.grpb_Ban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienDoUong)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_DanhMuc
            // 
            this.mns_DanhMuc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_DanhMuc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.mns_DanhMuc.Location = new System.Drawing.Point(0, 0);
            this.mns_DanhMuc.Name = "mns_DanhMuc";
            this.mns_DanhMuc.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mns_DanhMuc.Size = new System.Drawing.Size(1305, 24);
            this.mns_DanhMuc.TabIndex = 0;
            this.mns_DanhMuc.Text = "menuStrip1";
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
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
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
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thốngKêDoanhThuTheoNgàyToolStripMenuItem
            // 
            this.thốngKêDoanhThuTheoNgàyToolStripMenuItem.Name = "thốngKêDoanhThuTheoNgàyToolStripMenuItem";
            this.thốngKêDoanhThuTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.thốngKêDoanhThuTheoNgàyToolStripMenuItem.Text = "Thống kê doanh thu theo ngày";
            // 
            // thốngKêDoanhThuTheoNhânViênToolStripMenuItem
            // 
            this.thốngKêDoanhThuTheoNhânViênToolStripMenuItem.Name = "thốngKêDoanhThuTheoNhânViênToolStripMenuItem";
            this.thốngKêDoanhThuTheoNhânViênToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.thốngKêDoanhThuTheoNhânViênToolStripMenuItem.Text = "Thống kê doanh thu theo nhân viên";
            // 
            // thốngKêBánHàngToolStripMenuItem
            // 
            this.thốngKêBánHàngToolStripMenuItem.Name = "thốngKêBánHàngToolStripMenuItem";
            this.thốngKêBánHàngToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.thốngKêBánHàngToolStripMenuItem.Text = "Thống kê bán hàng";
            // 
            // xemLịchSửHóaĐơnToolStripMenuItem
            // 
            this.xemLịchSửHóaĐơnToolStripMenuItem.Name = "xemLịchSửHóaĐơnToolStripMenuItem";
            this.xemLịchSửHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.xemLịchSửHóaĐơnToolStripMenuItem.Text = "Xem lịch sử hóa đơn";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
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
            this.lbl_SoLuong.Location = new System.Drawing.Point(296, 94);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(93, 22);
            this.lbl_SoLuong.TabIndex = 1;
            this.lbl_SoLuong.Text = "Số lượng: ";
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSoLuong.Location = new System.Drawing.Point(395, 92);
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(51, 26);
            this.nmSoLuong.TabIndex = 3;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.BackColor = System.Drawing.Color.Blue;
            this.btn_ThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemMoi.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ThemMoi.Location = new System.Drawing.Point(465, 90);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(90, 29);
            this.btn_ThemMoi.TabIndex = 2;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = false;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // dgv_DoUong
            // 
            this.dgv_DoUong.AllowUserToAddRows = false;
            this.dgv_DoUong.AllowUserToDeleteRows = false;
            this.dgv_DoUong.AllowUserToResizeColumns = false;
            this.dgv_DoUong.AllowUserToResizeRows = false;
            this.dgv_DoUong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_DoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoUong.Location = new System.Drawing.Point(272, 168);
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
            this.lbl_TimDoUong.Location = new System.Drawing.Point(296, 134);
            this.lbl_TimDoUong.Name = "lbl_TimDoUong";
            this.lbl_TimDoUong.Size = new System.Drawing.Size(153, 22);
            this.lbl_TimDoUong.TabIndex = 1;
            this.lbl_TimDoUong.Text = "Tìm theo đồ uống";
            // 
            // txt_TimDoUong
            // 
            this.txt_TimDoUong.Location = new System.Drawing.Point(455, 134);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(643, 130);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(90, 28);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_ThemDoUong
            // 
            this.btn_ThemDoUong.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_ThemDoUong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemDoUong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDoUong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ThemDoUong.ImageIndex = 0;
            this.btn_ThemDoUong.ImageList = this.imgl_MHC;
            this.btn_ThemDoUong.Location = new System.Drawing.Point(811, 104);
            this.btn_ThemDoUong.Name = "btn_ThemDoUong";
            this.btn_ThemDoUong.Size = new System.Drawing.Size(57, 55);
            this.btn_ThemDoUong.TabIndex = 8;
            this.btn_ThemDoUong.UseVisualStyleBackColor = false;
            this.btn_ThemDoUong.Click += new System.EventHandler(this.btn_ThemDoUong_Click);
            // 
            // imgl_MHC
            // 
            this.imgl_MHC.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgl_MHC.ImageStream")));
            this.imgl_MHC.TransparentColor = System.Drawing.Color.Transparent;
            this.imgl_MHC.Images.SetKeyName(0, "addd.png");
            this.imgl_MHC.Images.SetKeyName(1, "reset.png");
            this.imgl_MHC.Images.SetKeyName(2, "minus.png");
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
            this.btn_ThanhToan.Location = new System.Drawing.Point(1044, 482);
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
            this.btn_InHoaDon.Location = new System.Drawing.Point(1178, 482);
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
            // imgl_Ban
            // 
            this.imgl_Ban.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgl_Ban.ImageStream")));
            this.imgl_Ban.TransparentColor = System.Drawing.Color.Transparent;
            this.imgl_Ban.Images.SetKeyName(0, "no table");
            this.imgl_Ban.Images.SetKeyName(1, "tablet");
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
            this.lb_TongTien.BackColor = System.Drawing.Color.NavajoWhite;
            this.lb_TongTien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.Color.Red;
            this.lb_TongTien.Location = new System.Drawing.Point(844, 490);
            this.lb_TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(76, 25);
            this.lb_TongTien.TabIndex = 12;
            this.lb_TongTien.Text = "0 VNĐ";
            // 
            // dgvHienDoUong
            // 
            this.dgvHienDoUong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienDoUong.Location = new System.Drawing.Point(772, 168);
            this.dgvHienDoUong.Name = "dgvHienDoUong";
            this.dgvHienDoUong.RowHeadersWidth = 51;
            this.dgvHienDoUong.Size = new System.Drawing.Size(512, 308);
            this.dgvHienDoUong.TabIndex = 14;
            // 
            // btn_ChonBan
            // 
            this.btn_ChonBan.BackColor = System.Drawing.Color.Pink;
            this.btn_ChonBan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ChonBan.Location = new System.Drawing.Point(165, 41);
            this.btn_ChonBan.Name = "btn_ChonBan";
            this.btn_ChonBan.Size = new System.Drawing.Size(90, 51);
            this.btn_ChonBan.TabIndex = 15;
            this.btn_ChonBan.Text = "Chưa chọn bàn";
            this.btn_ChonBan.UseVisualStyleBackColor = false;
            // 
            // btn_GiamDoUong
            // 
            this.btn_GiamDoUong.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_GiamDoUong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GiamDoUong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiamDoUong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_GiamDoUong.ImageIndex = 2;
            this.btn_GiamDoUong.ImageList = this.imgl_MHC;
            this.btn_GiamDoUong.Location = new System.Drawing.Point(978, 103);
            this.btn_GiamDoUong.Name = "btn_GiamDoUong";
            this.btn_GiamDoUong.Size = new System.Drawing.Size(57, 55);
            this.btn_GiamDoUong.TabIndex = 8;
            this.btn_GiamDoUong.UseVisualStyleBackColor = false;
            this.btn_GiamDoUong.Click += new System.EventHandler(this.btn_GiamDoUong_Click);
            // 
            // btn_XoaMon
            // 
            this.btn_XoaMon.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_XoaMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XoaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaMon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_XoaMon.ImageIndex = 1;
            this.btn_XoaMon.ImageList = this.imgl_MHC;
            this.btn_XoaMon.Location = new System.Drawing.Point(1132, 102);
            this.btn_XoaMon.Name = "btn_XoaMon";
            this.btn_XoaMon.Size = new System.Drawing.Size(57, 57);
            this.btn_XoaMon.TabIndex = 8;
            this.btn_XoaMon.UseVisualStyleBackColor = false;
            this.btn_XoaMon.Click += new System.EventHandler(this.btn_XoaMon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(779, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thêm đồ uống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(944, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giảm đồ uống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1119, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Xóa món";
            // 
            // frm_ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1305, 543);
            this.Controls.Add(this.btn_ChonBan);
            this.Controls.Add(this.dgvHienDoUong);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.grpb_Ban);
            this.Controls.Add(this.lsv_Ban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaMon);
            this.Controls.Add(this.btn_GiamDoUong);
            this.Controls.Add(this.btn_ThemDoUong);
            this.Controls.Add(this.txt_TimDoUong);
            this.Controls.Add(this.dgv_DoUong);
            this.Controls.Add(this.nmSoLuong);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.lbl_TimDoUong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_BanDangChon);
            this.Controls.Add(this.mns_DanhMuc);
            this.MainMenuStrip = this.mns_DanhMuc;
            this.Name = "frm_ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý";
            this.Load += new System.EventHandler(this.frm_ManHinhChinh_Load);
            this.mns_DanhMuc.ResumeLayout(false);
            this.mns_DanhMuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoUong)).EndInit();
            this.grpb_Ban.ResumeLayout(false);
            this.grpb_Ban.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienDoUong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label lbl_BanDangChon;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.DataGridView dgv_DoUong;
        private System.Windows.Forms.Label lbl_TimDoUong;
        private System.Windows.Forms.TextBox txt_TimDoUong;
        private System.Windows.Forms.Button btn_TimKiem;
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
        private System.Windows.Forms.Button btn_ThemDoUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.ListView lsv_Ban;
        private System.Windows.Forms.ImageList imgl_Ban;
        private System.Windows.Forms.GroupBox grpb_Ban;
        private System.Windows.Forms.RadioButton rdb_Conguoi;
        private System.Windows.Forms.RadioButton rdb_Trong;
        private System.Windows.Forms.RadioButton rdb_Tatca;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.DataGridView dgvHienDoUong;
        private System.Windows.Forms.Button btn_ChonBan;
        private System.Windows.Forms.Button btn_GiamDoUong;
        private System.Windows.Forms.Button btn_XoaMon;
        private System.Windows.Forms.ImageList imgl_MHC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

