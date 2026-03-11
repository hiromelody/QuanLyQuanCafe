using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using formDangNhap;
using ketnoisql;

namespace WindowsFormsApp2
{
    public partial class frm_ManHinhChinh : Form
    {
        public frm_ManHinhChinh()
        {
            InitializeComponent();
        }
            
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void loạiĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiDoUong frm = new frmLoaiDoUong();
            frm.ShowDialog();
        }

        private void đồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoUong frm = new frmDoUong();
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Close();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan frm = new frmBan();
            frm.ShowDialog();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void LoadTable()
        {
            lsv_Ban.Clear();
            lsv_Ban.View = View.LargeIcon;
            lsv_Ban.LargeImageList = imageList1;

            string strSQL = "SELECT * FROM Ban";
            if(rdb_Trong.Checked == true)
            {
                strSQL += " WHERE TrangThai = 0";
            }
            else if (rdb_Conguoi.Checked == true)
            {
                strSQL += " WHERE TrangThai = 1";
            }

            DataTable dt = new DataTable();
            dt = KetNoiSQL.ThucThiQuery(strSQL);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item1 = new ListViewItem(dt.Rows[i]["MaBan"].ToString());
                if (dt.Rows[i]["TrangThai"].ToString() == "0")
                {
                    item1.ImageIndex = 0;
                }
                else
                {
                    item1.ImageIndex = 1;
                }
                lsv_Ban.Items.Add(item1);
            }
        }

        public static void SetupDataGridView(DataGridView dgvMain)
        {
            dgvMain.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvMain.DefaultCellStyle.Font = new Font("Tahoma", 10);

            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.RowTemplate.Height = 32;

            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.MultiSelect = false;
            dgvMain.AllowUserToAddRows = false;

            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvMain.Columns[0].FillWeight = 50;
            dgvMain.Columns[1].FillWeight = 100;
            dgvMain.Columns[2].FillWeight = 55;
            dgvMain.Columns[3].FillWeight = 70;
            dgvMain.Columns[3].DefaultCellStyle.Format = "N0"; // format tiền
        }

        private void LoadMenuDoUong()
        {
            string strSQL = $@"SELECT MaDU,TenDU,MaLoai,DonGia FROM DoUong WHERE TenDU LIKE N'%{txt_TimDoUong.Text}%'";
            DataTable dt = new DataTable();
            dt = KetNoiSQL.ThucThiQuery(strSQL);
            dgv_DoUong.DataSource = dt;
            SetupDataGridView(dgv_DoUong);  
            dgv_DoUong.Columns[0].HeaderText = "Mã Đồ Uống";
            dgv_DoUong.Columns[1].HeaderText = "Tên Đồ Uống";
            dgv_DoUong.Columns[2].HeaderText = "Loại Đồ Uống";
            dgv_DoUong.Columns[3].HeaderText = "Đơn Giá";        
        }


        private void frm_ManHinhChinh_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadMenuDoUong();
        }

        private void rdb_Trong_CheckedChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void rdb_Conguoi_CheckedChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadMenuDoUong();
        }

        private void lsv_Ban_Click(object sender, EventArgs e)
        {
            btn_ChonBan.Text = lsv_Ban.SelectedItems[0].SubItems[0].Text;
            LoadDoUongDaGoi();
        }

        private void LoadDoUongDaGoi()
        {
            string strSQL = $@"SELECT a.MaDU, c.TenDU, a.SoLuong, a.DonGia, a.ThanhTien
                               FROM ChiTietHoaDon a
                               INNER JOIN HoaDon b ON a.MaHD = b.MaHD
                               INNER JOIN DoUong c ON a.MaDU = c.MaDU
                               INNER JOIN Ban d ON b.MaBan = d.MaBan
                               WHERE d.MaBan = '{btn_ChonBan.Text}'
                               AND d.TrangThai = 0";
            DataTable dt = new DataTable();
            dt = KetNoiSQL.ThucThiQuery(strSQL);
            dgvHienDoUong.DataSource = dt;
            frmDoUong.SetupDataGridView(dgvHienDoUong);
            dgv_DoUong.Columns[0].HeaderText = "Mã Đồ Uống";
            dgv_DoUong.Columns[1].HeaderText = "Tên Đồ Uống";
            dgv_DoUong.Columns[2].HeaderText = "Loại Đồ Uống";
            dgv_DoUong.Columns[3].HeaderText = "Đơn Giá";

            //madu tendu soluong dongia thanhtien
            dgvHienDoUong.Columns[0].HeaderText = "Mã Đồ Uống";
            dgvHienDoUong.Columns[1].HeaderText = "Tên Đồ Uống";
            dgvHienDoUong.Columns[2].HeaderText = "Số Lượng";
            dgvHienDoUong.Columns[3].HeaderText = "Đơn Giá";
            dgvHienDoUong.Columns[4].HeaderText = "Thành Tiền";

        }

        private void dgvHienDoUong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan frmThanhToan = new frmThanhToan();
            frmThanhToan.ShowDialog();
        }
    }
}
