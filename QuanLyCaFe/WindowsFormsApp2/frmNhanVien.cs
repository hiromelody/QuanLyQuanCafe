using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ketnoisql;

namespace WindowsFormsApp2
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public static void SetupDataGridView(DataGridView dgvMain)
        {
            dgvMain.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.RowTemplate.Height = 30;

            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.MultiSelect = false;

            dgvMain.AllowUserToAddRows = false;

            dgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMain.Columns["TenNV"].FillWeight = 140;
            dgvMain.Columns["MaNV"].FillWeight = 100;
            dgvMain.Columns["MatKhau"].FillWeight = 110;
            dgvMain.Columns["SDT"].FillWeight = 140;
            dgvMain.Columns["DiaChi"].FillWeight = 210;
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM NhanVien WHERE TenNV LIKE @ten";

            SqlParameter[] param =
            {
                new SqlParameter("@ten","%" + txtTimKiem.Text + "%")
            };

            dgv_NhanVien.DataSource = KetNoiSQL.ThucThiQuery(sql, param);


            SetupDataGridView(dgv_NhanVien);
            dgv_NhanVien.Columns[0].HeaderText = "Mã NV";
            dgv_NhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_NhanVien.Columns[2].HeaderText = "Mật Khẩu";
            dgv_NhanVien.Columns[3].HeaderText = "Số Điện Thoại";
            dgv_NhanVien.Columns[4].HeaderText = "Địa Chỉ";

            if (dgv_NhanVien.Rows.Count == 0)
            {
                txt_MaNhanVien.Text = "";
                txt_TenNhanVien.Text = "";
                txt_MatKhau.Text = "";
                txt_SDT.Text = "";
                txt_DiaChi.Text = "";
            }
            else
            {
                DataGridViewRow drow = dgv_NhanVien.Rows[0];

                txt_MaNhanVien.Text = drow.Cells[0].Value?.ToString() ?? "";
                txt_TenNhanVien.Text = drow.Cells[1].Value?.ToString() ?? "";
                txt_MatKhau.Text = drow.Cells[2].Value?.ToString() ?? "";
                txt_SDT.Text = drow.Cells[3].Value?.ToString() ?? "";
                txt_DiaChi.Text = drow.Cells[4].Value?.ToString() ?? "";
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void MenuThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNhanVien.Text))
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                txt_MaNhanVien.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenNhanVien.Text))
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                txt_MaNhanVien.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                txt_MatKhau.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM NhanVien WHERE MaNV = '{txt_MaNhanVien.Text}'";
            if (KetNoiSQL.ExcuteReader_bool(strSQL))
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại, vui lòng tạo mã khác");
                txt_MaNhanVien.Focus();
                return;
            }
            strSQL = $@"INSERT INTO NhanVien(MaNV,TenNV,MatKhau,SDT,DiaChi) 
                        VALUES ('{txt_MaNhanVien.Text}',N'{txt_TenNhanVien.Text}',N'{txt_MatKhau.Text}',N'{txt_SDT.Text}',N'{txt_DiaChi.Text}') ";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Thêm thành công");
            LoadData();
        }

        private void MenuSua_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sửa");
                return;
            }
            if (string.IsNullOrEmpty(txt_MaNhanVien.Text))
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                txt_MaNhanVien.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenNhanVien.Text))
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                txt_MaNhanVien.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                txt_MatKhau.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM NhanVien WHERE MaNV = '{txt_MaNhanVien.Text}'";
            string MaNVSua = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString().Trim();
            if (KetNoiSQL.ExcuteReader_bool(strSQL) && txt_MaNhanVien.Text.Trim() != MaNVSua)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại, vui lòng tạo mã khác");
                txt_MaNhanVien.Focus();
                return;
            }
            strSQL = $@"UPDATE NhanVien SET MaNV = '{txt_MaNhanVien.Text}'
                                            ,TenNV = N'{txt_TenNhanVien.Text}'
                                            ,MatKhau =N'{txt_MatKhau.Text}'
                                            ,SDT = N'{txt_SDT.Text}'
                                            ,DiaChi =  N'{txt_DiaChi.Text}'
                        WHERE MaNV = '{MaNVSua}'";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void MenuXoaHet_Click(object sender, EventArgs e)
        {
            txt_MaNhanVien.Text = "";
            txt_TenNhanVien.Text = "";
            txt_MatKhau.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
        }


        private void MenuXoa_Click(object sender, EventArgs e)
        {
            if (dgv_NhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string strSQL = $@"DELETE NhanVien WHERE MaNV = '{dgv_NhanVien.CurrentRow.Cells[0].Value.ToString().Trim()}'";
                KetNoiSQL.ThucThiQuery(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_NhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];

            if (row.IsNewRow) return;

            txt_MaNhanVien.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
            txt_TenNhanVien.Text = row.Cells["TenNV"].Value?.ToString() ?? "";
            txt_MatKhau.Text = row.Cells["MatKhau"].Value?.ToString() ?? "";
            txt_SDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            txt_DiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
        }
    }
}
