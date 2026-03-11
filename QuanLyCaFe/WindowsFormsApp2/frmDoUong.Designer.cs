namespace WindowsFormsApp2
{
    partial class frmDoUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoUong));
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_DanhMucDoUong = new System.Windows.Forms.DataGridView();
            this.txtbTimkiem = new System.Windows.Forms.TextBox();
            this.txt_TenDoUong = new System.Windows.Forms.TextBox();
            this.txt_MaDoUong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TenDoUong = new System.Windows.Forms.Label();
            this.lbl_MaDoUong = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuXoaHet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_MaLoaiDoUong = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.txtbDongia = new System.Windows.Forms.TextBox();
            this.pictbhinhanh = new System.Windows.Forms.PictureBox();
            this.linklbThemhinh = new System.Windows.Forms.LinkLabel();
            this.cbb_MaLoaiDoUong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucDoUong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbhinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(801, 548);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(147, 44);
            this.btn_TimKiem.TabIndex = 19;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgv_DanhMucDoUong
            // 
            this.dgv_DanhMucDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMucDoUong.Location = new System.Drawing.Point(219, 156);
            this.dgv_DanhMucDoUong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_DanhMucDoUong.Name = "dgv_DanhMucDoUong";
            this.dgv_DanhMucDoUong.ReadOnly = true;
            this.dgv_DanhMucDoUong.RowHeadersWidth = 51;
            this.dgv_DanhMucDoUong.Size = new System.Drawing.Size(729, 372);
            this.dgv_DanhMucDoUong.TabIndex = 18;
            this.dgv_DanhMucDoUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMucDoUong_CellClick);
            this.dgv_DanhMucDoUong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMucDoUong_CellContentClick);
            this.dgv_DanhMucDoUong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DanhMucDoUong_CellFormatting);
            // 
            // txtbTimkiem
            // 
            this.txtbTimkiem.Location = new System.Drawing.Point(517, 558);
            this.txtbTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbTimkiem.Name = "txtbTimkiem";
            this.txtbTimkiem.Size = new System.Drawing.Size(255, 22);
            this.txtbTimkiem.TabIndex = 13;
            // 
            // txt_TenDoUong
            // 
            this.txt_TenDoUong.Location = new System.Drawing.Point(219, 107);
            this.txt_TenDoUong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenDoUong.Name = "txt_TenDoUong";
            this.txt_TenDoUong.Size = new System.Drawing.Size(255, 22);
            this.txt_TenDoUong.TabIndex = 14;
            // 
            // txt_MaDoUong
            // 
            this.txt_MaDoUong.Location = new System.Drawing.Point(219, 59);
            this.txt_MaDoUong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaDoUong.Name = "txt_MaDoUong";
            this.txt_MaDoUong.Size = new System.Drawing.Size(255, 22);
            this.txt_MaDoUong.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 558);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập tên đồ uống cần tìm: ";
            // 
            // lbl_TenDoUong
            // 
            this.lbl_TenDoUong.AutoSize = true;
            this.lbl_TenDoUong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDoUong.Location = new System.Drawing.Point(61, 107);
            this.lbl_TenDoUong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenDoUong.Name = "lbl_TenDoUong";
            this.lbl_TenDoUong.Size = new System.Drawing.Size(113, 22);
            this.lbl_TenDoUong.TabIndex = 8;
            this.lbl_TenDoUong.Text = "Tên đồ uống:";
            // 
            // lbl_MaDoUong
            // 
            this.lbl_MaDoUong.AutoSize = true;
            this.lbl_MaDoUong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDoUong.Location = new System.Drawing.Point(59, 62);
            this.lbl_MaDoUong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaDoUong.Name = "lbl_MaDoUong";
            this.lbl_MaDoUong.Size = new System.Drawing.Size(109, 22);
            this.lbl_MaDoUong.TabIndex = 11;
            this.lbl_MaDoUong.Text = "Mã đồ uống:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuThem,
            this.MenuSua,
            this.MenuXoa,
            this.MenuXoaHet,
            this.menuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(968, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "Tên nhân viên:";
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
            // lbl_MaLoaiDoUong
            // 
            this.lbl_MaLoaiDoUong.AutoSize = true;
            this.lbl_MaLoaiDoUong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLoaiDoUong.Location = new System.Drawing.Point(533, 59);
            this.lbl_MaLoaiDoUong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaLoaiDoUong.Name = "lbl_MaLoaiDoUong";
            this.lbl_MaLoaiDoUong.Size = new System.Drawing.Size(145, 22);
            this.lbl_MaLoaiDoUong.TabIndex = 11;
            this.lbl_MaLoaiDoUong.Text = "Mã loại đồ uống:";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(533, 107);
            this.lbl_DonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(79, 22);
            this.lbl_DonGia.TabIndex = 8;
            this.lbl_DonGia.Text = "Đơn giá:";
            // 
            // txtbDongia
            // 
            this.txtbDongia.Location = new System.Drawing.Point(693, 108);
            this.txtbDongia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbDongia.Name = "txtbDongia";
            this.txtbDongia.Size = new System.Drawing.Size(255, 22);
            this.txtbDongia.TabIndex = 14;
            // 
            // pictbhinhanh
            // 
            this.pictbhinhanh.BackColor = System.Drawing.Color.LightGray;
            this.pictbhinhanh.Location = new System.Drawing.Point(30, 156);
            this.pictbhinhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictbhinhanh.Name = "pictbhinhanh";
            this.pictbhinhanh.Size = new System.Drawing.Size(146, 217);
            this.pictbhinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictbhinhanh.TabIndex = 22;
            this.pictbhinhanh.TabStop = false;
            // 
            // linklbThemhinh
            // 
            this.linklbThemhinh.AutoSize = true;
            this.linklbThemhinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbThemhinh.Location = new System.Drawing.Point(26, 394);
            this.linklbThemhinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklbThemhinh.Name = "linklbThemhinh";
            this.linklbThemhinh.Size = new System.Drawing.Size(150, 22);
            this.linklbThemhinh.TabIndex = 23;
            this.linklbThemhinh.TabStop = true;
            this.linklbThemhinh.Text = "Thay đổi hình ảnh";
            this.linklbThemhinh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbThemhinh_LinkClicked);
            // 
            // cbb_MaLoaiDoUong
            // 
            this.cbb_MaLoaiDoUong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MaLoaiDoUong.FormattingEnabled = true;
            this.cbb_MaLoaiDoUong.Location = new System.Drawing.Point(693, 60);
            this.cbb_MaLoaiDoUong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_MaLoaiDoUong.Name = "cbb_MaLoaiDoUong";
            this.cbb_MaLoaiDoUong.Size = new System.Drawing.Size(255, 24);
            this.cbb_MaLoaiDoUong.TabIndex = 21;
            // 
            // frmDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.linklbThemhinh);
            this.Controls.Add(this.pictbhinhanh);
            this.Controls.Add(this.cbb_MaLoaiDoUong);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dgv_DanhMucDoUong);
            this.Controls.Add(this.txtbTimkiem);
            this.Controls.Add(this.txtbDongia);
            this.Controls.Add(this.txt_TenDoUong);
            this.Controls.Add(this.txt_MaDoUong);
            this.Controls.Add(this.lbl_DonGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_MaLoaiDoUong);
            this.Controls.Add(this.lbl_TenDoUong);
            this.Controls.Add(this.lbl_MaDoUong);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dang mục đồ uống";
            this.Load += new System.EventHandler(this.frmDoUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucDoUong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbhinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem MenuXoa;
        private System.Windows.Forms.ToolStripMenuItem MenuSua;
        private System.Windows.Forms.ToolStripMenuItem MenuThem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhMucDoUong;
        private System.Windows.Forms.TextBox txtbTimkiem;
        private System.Windows.Forms.TextBox txt_TenDoUong;
        private System.Windows.Forms.TextBox txt_MaDoUong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TenDoUong;
        private System.Windows.Forms.Label lbl_MaDoUong;
        private System.Windows.Forms.ToolStripMenuItem MenuXoaHet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_MaLoaiDoUong;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.TextBox txtbDongia;
        private System.Windows.Forms.PictureBox pictbhinhanh;
        private System.Windows.Forms.LinkLabel linklbThemhinh;
        private System.Windows.Forms.ComboBox cbb_MaLoaiDoUong;
    }
}