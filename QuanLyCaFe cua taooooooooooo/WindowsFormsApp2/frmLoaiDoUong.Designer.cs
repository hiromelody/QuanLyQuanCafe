namespace WindowsFormsApp2
{
    partial class frmLoaiDoUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiDoUong));
            this.dgv_DanhMucLoaiDoUong = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txt_TenLoai = new System.Windows.Forms.TextBox();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TenLoai = new System.Windows.Forms.Label();
            this.lbl_MaLoai = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuXoaHet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucLoaiDoUong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhMucLoaiDoUong
            // 
            this.dgv_DanhMucLoaiDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMucLoaiDoUong.Location = new System.Drawing.Point(265, 39);
            this.dgv_DanhMucLoaiDoUong.Name = "dgv_DanhMucLoaiDoUong";
            this.dgv_DanhMucLoaiDoUong.ReadOnly = true;
            this.dgv_DanhMucLoaiDoUong.RowHeadersWidth = 51;
            this.dgv_DanhMucLoaiDoUong.Size = new System.Drawing.Size(249, 412);
            this.dgv_DanhMucLoaiDoUong.TabIndex = 27;
            this.dgv_DanhMucLoaiDoUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMucLoaiDoUong_CellClick);
            this.dgv_DanhMucLoaiDoUong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMucLoaiDoUong_CellContentClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(40, 244);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(168, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Location = new System.Drawing.Point(97, 95);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.Size = new System.Drawing.Size(122, 20);
            this.txt_TenLoai.TabIndex = 1;
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Location = new System.Drawing.Point(97, 51);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(122, 20);
            this.txt_MaLoai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nhập tên loại đồ uống: ";
            // 
            // lbl_TenLoai
            // 
            this.lbl_TenLoai.AutoSize = true;
            this.lbl_TenLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenLoai.Location = new System.Drawing.Point(29, 94);
            this.lbl_TenLoai.Name = "lbl_TenLoai";
            this.lbl_TenLoai.Size = new System.Drawing.Size(60, 19);
            this.lbl_TenLoai.TabIndex = 22;
            this.lbl_TenLoai.Text = "Tên loại:";
            // 
            // lbl_MaLoai
            // 
            this.lbl_MaLoai.AutoSize = true;
            this.lbl_MaLoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLoai.Location = new System.Drawing.Point(29, 54);
            this.lbl_MaLoai.Name = "lbl_MaLoai";
            this.lbl_MaLoai.Size = new System.Drawing.Size(58, 19);
            this.lbl_MaLoai.TabIndex = 23;
            this.lbl_MaLoai.Text = "Mã loại:";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(550, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "Tên nhân viên:";
            // 
            // MenuThem
            // 
            this.MenuThem.Image = ((System.Drawing.Image)(resources.GetObject("MenuThem.Image")));
            this.MenuThem.Name = "MenuThem";
            this.MenuThem.Size = new System.Drawing.Size(72, 24);
            this.MenuThem.Text = "Thêm ";
            this.MenuThem.Click += new System.EventHandler(this.MenuThem_Click);
            // 
            // MenuSua
            // 
            this.MenuSua.Image = ((System.Drawing.Image)(resources.GetObject("MenuSua.Image")));
            this.MenuSua.Name = "MenuSua";
            this.MenuSua.Size = new System.Drawing.Size(58, 24);
            this.MenuSua.Text = "Sửa";
            this.MenuSua.Click += new System.EventHandler(this.MenuSua_Click);
            // 
            // MenuXoa
            // 
            this.MenuXoa.Image = ((System.Drawing.Image)(resources.GetObject("MenuXoa.Image")));
            this.MenuXoa.Name = "MenuXoa";
            this.MenuXoa.Size = new System.Drawing.Size(59, 24);
            this.MenuXoa.Text = "Xóa";
            this.MenuXoa.Click += new System.EventHandler(this.MenuXoa_Click);
            // 
            // MenuXoaHet
            // 
            this.MenuXoaHet.Image = ((System.Drawing.Image)(resources.GetObject("MenuXoaHet.Image")));
            this.MenuXoaHet.Name = "MenuXoaHet";
            this.MenuXoaHet.Size = new System.Drawing.Size(79, 24);
            this.MenuXoaHet.Text = "Xóa hết";
            this.MenuXoaHet.Click += new System.EventHandler(this.MenuXoaHet_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Image = ((System.Drawing.Image)(resources.GetObject("menuThoat.Image")));
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(69, 24);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(65, 291);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(110, 36);
            this.btn_TimKiem.TabIndex = 28;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // frmLoaiDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(550, 462);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dgv_DanhMucLoaiDoUong);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txt_TenLoai);
            this.Controls.Add(this.txt_MaLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TenLoai);
            this.Controls.Add(this.lbl_MaLoai);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmLoaiDoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục loại đồ uống";
            this.Load += new System.EventHandler(this.frmLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucLoaiDoUong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem MenuXoa;
        private System.Windows.Forms.ToolStripMenuItem MenuSua;
        private System.Windows.Forms.ToolStripMenuItem MenuThem;
        private System.Windows.Forms.DataGridView dgv_DanhMucLoaiDoUong;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txt_TenLoai;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TenLoai;
        private System.Windows.Forms.Label lbl_MaLoai;
        private System.Windows.Forms.ToolStripMenuItem MenuXoaHet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}