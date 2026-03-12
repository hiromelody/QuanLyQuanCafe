using formDangNhap;
using ketnoisql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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
            lsv_Ban.LargeImageList = imgl_Ban;

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
                if (dt.Rows[i]["TrangThai"].ToString() == "1")
                {
                    item1.ImageIndex = 1;
                }
                else
                {
                    item1.ImageIndex = 0;
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
            dgvMain.Columns[2].FillWeight = 60;
            dgvMain.Columns[3].FillWeight = 65;
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
            //chi lay hoa don chua thanh toan
            string strSQL = $@"SELECT a.MaDU, c.TenDU, a.SoLuong, a.DonGia, a.ThanhTien
                FROM ChiTietHoaDon a
                INNER JOIN HoaDon b ON a.MaHD = b.MaHD
                INNER JOIN DoUong c ON a.MaDU = c.MaDU
                WHERE b.MaBan = '{btn_ChonBan.Text}'
                AND b.TrangThai = 0";
            DataTable dt = new DataTable();
            dt = KetNoiSQL.ThucThiQuery(strSQL);
            dgvHienDoUong.DataSource = dt;
            frmDoUong.SetupDataGridView(dgvHienDoUong);

            //cthd
            dgvHienDoUong.Columns[0].HeaderText = "Mã Đồ Uống";
            dgvHienDoUong.Columns[1].HeaderText = "Tên Đồ Uống";
            dgvHienDoUong.Columns[2].HeaderText = "Số Lượng";
            dgvHienDoUong.Columns[3].HeaderText = "Đơn Giá";
            dgvHienDoUong.Columns[4].HeaderText = "Thành Tiền";
            dgvHienDoUong.Columns[4].DefaultCellStyle.Format = "N0";

            decimal total = 0;
            //for (int i = 0; i < dt.Rows.Count; i++)
            //total += Convert.ToDecimal(dt.Rows[i]["ThanhTien"]);
            foreach (DataRow row in dt.Rows)
            {
                total += Convert.ToDecimal(row["ThanhTien"]);
            }
            lb_TongTien.Text = total.ToString("N0") + " VNĐ";
        }
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (btn_ChonBan.Text == "Chưa chọn bàn")
            {
                MessageBox.Show("Bạn hãy chọn bàn trước khi gọi món");
                return;
            }

            if (dgv_DoUong.CurrentRow == null)
            {
                MessageBox.Show("Bạn hãy chọn đồ uống");
                return;
            }

            string strSQL = $@"SELECT TOP 1 MaHD 
                       FROM HoaDon 
                       WHERE MaBan = '{btn_ChonBan.Text}' 
                       AND TrangThai = 0";

            DataTable dt = KetNoiSQL.ThucThiQuery(strSQL);

            string MAHD = "";

            // nếu đã có hóa đơn
            if (dt.Rows.Count > 0)
            {
                MAHD = dt.Rows[0]["MaHD"].ToString();
            }
            else
            {
                // nếu chưa có hóa đơn thì tạo mới
                MAHD = DateTime.Now.ToString("ssmmhhddMMyyyy");

                strSQL = $@"INSERT INTO HoaDon(NgayLap,MaNV,MaKH,MaBan,TrangThai)
                        VALUES(GETDATE(),
                               '{frmDangNhap.MaNV}',
                               NULL,
                               '{btn_ChonBan.Text}',
                               0);
                        SELECT SCOPE_IDENTITY();";

                DataTable dtNew = KetNoiSQL.ThucThiQuery(strSQL);
                MAHD = dtNew.Rows[0][0].ToString();

                KetNoiSQL.ThucThiNonQuery(strSQL);

                strSQL = $@"UPDATE Ban 
                    SET TrangThai = 1
                    WHERE MaBan = '{btn_ChonBan.Text}'";

                KetNoiSQL.ThucThiNonQuery(strSQL);
            }

            // thêm chi tiết hóa đơn
            string MADU = dgv_DoUong.CurrentRow.Cells[0].Value.ToString();
            string DonGia = dgv_DoUong.CurrentRow.Cells[3].Value.ToString();

            string checkSQL = $@"SELECT * 
                     FROM ChiTietHoaDon 
                     WHERE MaHD = {MAHD} 
                     AND MaDU = '{MADU}'";

            DataTable dtCheck = KetNoiSQL.ThucThiQuery(checkSQL);

            if (dtCheck.Rows.Count > 0)
            {
                // đã có món -> tăng số lượng
                string updateSQL = $@"UPDATE ChiTietHoaDon
                          SET SoLuong = SoLuong + {nmSoLuong.Value}
                          WHERE MaHD = {MAHD}
                          AND MaDU = '{MADU}'";

                KetNoiSQL.ThucThiNonQuery(updateSQL);
            }
            else
            {
                // chưa có -> insert
                strSQL = $@"INSERT INTO ChiTietHoaDon(MaHD,MaDU,SoLuong,DonGia)
                VALUES('{MAHD}',
                       '{MADU}',
                       {nmSoLuong.Value},
                       {DonGia})";

                KetNoiSQL.ThucThiNonQuery(strSQL);

                LoadDoUongDaGoi();
                LoadTable();
            }
        }
        //strSQL = $@"UPDATE HoaDon
        //            SET TrangThai = N'Đã thanh toán'
        //            WHERE MaHD = '{MAHD}'";

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            string sql = $@"SELECT TOP 1 MaHD
                    FROM HoaDon
                    WHERE MaBan = '{btn_ChonBan.Text}'
                    AND TrangThai = 0";

            DataTable dt = KetNoiSQL.ThucThiQuery(sql);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Bàn chưa có hóa đơn");
                return;
            }

            int maHD = Convert.ToInt32(dt.Rows[0]["MaHD"]);

            frmThanhToan frm = new frmThanhToan(maHD);
            frm.ShowDialog();

            LoadTable();
            LoadDoUongDaGoi();
        }

        private void btn_ThemDoUong_Click(object sender, EventArgs e)
        {
            if (dgvHienDoUong.CurrentRow == null) return;

            string maDU = dgvHienDoUong.CurrentRow.Cells[0].Value.ToString();

            string sql = $@"UPDATE ChiTietHoaDon
                    SET SoLuong = SoLuong + 1
                    WHERE MaDU = '{maDU}'
                    AND MaHD = (
                    SELECT TOP 1 MaHD
                    FROM HoaDon
                    WHERE MaBan = '{btn_ChonBan.Text}'
                    AND TrangThai = 0)";
            KetNoiSQL.ThucThiNonQuery(sql);

            LoadDoUongDaGoi();
        }

        private void btn_GiamDoUong_Click(object sender, EventArgs e)
        {
            if (dgvHienDoUong.CurrentRow == null) return;

            string maDU = dgvHienDoUong.CurrentRow.Cells[0].Value.ToString();

            string sql = $@"UPDATE ChiTietHoaDon
                    SET SoLuong = SoLuong - 1
                    WHERE MaDU = '{maDU}'
                    AND MaHD = (
                    SELECT TOP 1 MaHD 
                    FROM HoaDon 
                    WHERE MaBan = '{btn_ChonBan.Text}' 
                    AND TrangThai = 0)";

            KetNoiSQL.ThucThiNonQuery(sql);

            sql = $@"DELETE FROM ChiTietHoaDon
                    WHERE SoLuong <= 0";

            KetNoiSQL.ThucThiNonQuery(sql);

            LoadDoUongDaGoi();
        }

        private void btn_XoaMon_Click(object sender, EventArgs e)
        {
            if (dgvHienDoUong.CurrentRow == null) return;

            string maDU = dgvHienDoUong.CurrentRow.Cells[0].Value.ToString();

            string sql = $@"DELETE FROM ChiTietHoaDon
                    WHERE MaDU = '{maDU}'
                    AND MaHD = (
                    SELECT TOP 1 MaHD 
                    FROM HoaDon 
                    WHERE MaBan = '{btn_ChonBan.Text}' 
                    AND TrangThai = 0)";

            KetNoiSQL.ThucThiNonQuery(sql);

            LoadDoUongDaGoi();

        }
    }
}
