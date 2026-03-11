namespace WindowsFormsApp2
{
    partial class frmBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBan));
            this.dgv_DanhMucBan = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txt_SucChua = new System.Windows.Forms.TextBox();
            this.txt_MaBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SucChua = new System.Windows.Forms.Label();
            this.lbl_MaBan = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuXoaHet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucBan)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhMucBan
            // 
            this.dgv_DanhMucBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhMucBan.Location = new System.Drawing.Point(14, 121);
            this.dgv_DanhMucBan.Name = "dgv_DanhMucBan";
            this.dgv_DanhMucBan.ReadOnly = true;
            this.dgv_DanhMucBan.RowHeadersWidth = 51;
            this.dgv_DanhMucBan.Size = new System.Drawing.Size(776, 250);
            this.dgv_DanhMucBan.TabIndex = 18;
            this.dgv_DanhMucBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhMucBan_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(485, 50);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(177, 20);
            this.txtTimKiem.TabIndex = 13;
            // 
            // txt_SucChua
            // 
            this.txt_SucChua.Location = new System.Drawing.Point(109, 84);
            this.txt_SucChua.Name = "txt_SucChua";
            this.txt_SucChua.Size = new System.Drawing.Size(188, 20);
            this.txt_SucChua.TabIndex = 14;
            // 
            // txt_MaBan
            // 
            this.txt_MaBan.Location = new System.Drawing.Point(109, 51);
            this.txt_MaBan.Name = "txt_MaBan";
            this.txt_MaBan.Size = new System.Drawing.Size(188, 20);
            this.txt_MaBan.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập mã bàn: ";
            // 
            // lbl_SucChua
            // 
            this.lbl_SucChua.AutoSize = true;
            this.lbl_SucChua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SucChua.Location = new System.Drawing.Point(29, 81);
            this.lbl_SucChua.Name = "lbl_SucChua";
            this.lbl_SucChua.Size = new System.Drawing.Size(71, 19);
            this.lbl_SucChua.TabIndex = 8;
            this.lbl_SucChua.Text = "Sức chứa:";
            // 
            // lbl_MaBan
            // 
            this.lbl_MaBan.AutoSize = true;
            this.lbl_MaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaBan.Location = new System.Drawing.Point(29, 51);
            this.lbl_MaBan.Name = "lbl_MaBan";
            this.lbl_MaBan.Size = new System.Drawing.Size(59, 19);
            this.lbl_MaBan.TabIndex = 11;
            this.lbl_MaBan.Text = "Mã bàn:";
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
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
            this.btn_TimKiem.Location = new System.Drawing.Point(668, 43);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(110, 36);
            this.btn_TimKiem.TabIndex = 20;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dgv_DanhMucBan);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txt_SucChua);
            this.Controls.Add(this.txt_MaBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SucChua);
            this.Controls.Add(this.lbl_MaBan);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmBan";
            this.Text = "Danh mục bàn";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhMucBan)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_DanhMucBan;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txt_SucChua;
        private System.Windows.Forms.TextBox txt_MaBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SucChua;
        private System.Windows.Forms.Label lbl_MaBan;
        private System.Windows.Forms.ToolStripMenuItem MenuXoaHet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}