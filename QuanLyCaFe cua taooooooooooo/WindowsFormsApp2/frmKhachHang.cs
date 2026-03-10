using ketnoisql;
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

namespace WindowsFormsApp2
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
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
            dgvMain.Columns["TenKH"].FillWeight = 140;
            dgvMain.Columns["MaKH"].FillWeight = 100;
            dgvMain.Columns["SDT"].FillWeight = 140;
            dgvMain.Columns["DiaChi"].FillWeight = 210;

        }

        private void LoadData()
        {
            string sql = "SELECT * FROM KhachHang WHERE TenKH LIKE @ten";

            SqlParameter[] param =
            {
                new SqlParameter("@ten","%" + txtTimKiem.Text + "%")
            };

            dgv_KhachHang.DataSource = KetNoiSQL.ThucThiQuery(sql, param);


            SetupDataGridView(dgv_KhachHang);
            dgv_KhachHang.Columns[0].HeaderText = "Mã NV";
            dgv_KhachHang.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_KhachHang.Columns[2].HeaderText = "Số Điện Thoại";
            dgv_KhachHang.Columns[3].HeaderText = "Địa Chỉ";

            if (dgv_KhachHang.Rows.Count == 0)
            {
                txt_MaKhachHang.Text = "";
                txt_TenKhachHang.Text = "";
                txt_SDT.Text = "";
                txt_DiaChi.Text = "";
            }
            else
            {
                DataGridViewRow drow = dgv_KhachHang.Rows[0];

                txt_MaKhachHang.Text = drow.Cells[0].Value?.ToString() ?? "";
                txt_TenKhachHang.Text = drow.Cells[1].Value?.ToString() ?? "";
                txt_SDT.Text = drow.Cells[2].Value?.ToString() ?? "";
                txt_DiaChi.Text = drow.Cells[3].Value?.ToString() ?? "";
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void MenuThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKhachHang.Text))
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                txt_MaKhachHang.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenKhachHang.Text))
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                txt_MaKhachHang.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM KhachHang WHERE MaKH = '{txt_MaKhachHang.Text}'";
            if (KetNoiSQL.ExcuteReader_bool(strSQL))
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại, vui lòng tạo mã khác");
                txt_MaKhachHang.Focus();
                return;
            }
            strSQL = $@"INSERT INTO KhachHang(MaKH,TenKH,MatKhau,SDT,DiaChi) 
                        VALUES ('{txt_MaKhachHang.Text}',N'{txt_TenKhachHang.Text}',N'{txt_SDT.Text}',N'{txt_DiaChi.Text}') ";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Thêm thành công");
            LoadData();
        }

        private void MenuSua_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sửa");
                return;
            }
            if (string.IsNullOrEmpty(txt_MaKhachHang.Text))
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                txt_MaKhachHang.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenKhachHang.Text))
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                txt_MaKhachHang.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM KhachHang WHERE MaKH = '{txt_MaKhachHang.Text}'";
            string MaKHSua = dgv_KhachHang.CurrentRow.Cells[0].Value.ToString().Trim();
            if (KetNoiSQL.ExcuteReader_bool(strSQL) && txt_MaKhachHang.Text.Trim() != MaKHSua)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại, vui lòng tạo mã khác");
                txt_MaKhachHang.Focus();
                return;
            }
            strSQL = $@"UPDATE KhachHang SET MaKH = '{txt_MaKhachHang.Text}'
                                            ,TenKH = N'{txt_TenKhachHang.Text}'
                                            ,SDT = N'{txt_SDT.Text}'
                                            ,DiaChi =  N'{txt_DiaChi.Text}'
                        WHERE MaKH = '{MaKHSua}'";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void MenuXoaHet_Click(object sender, EventArgs e)
        {
            txt_MaKhachHang.Text = "";
            txt_TenKhachHang.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
        }


        private void MenuXoa_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string strSQL = $@"DELETE KhachHang WHERE MaKH = '{dgv_KhachHang.CurrentRow.Cells[0].Value.ToString().Trim()}'";
                KetNoiSQL.ThucThiQuery(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];

            if (row.IsNewRow) return;

            txt_MaKhachHang.Text = row.Cells["MaKH"].Value?.ToString() ?? "";
            txt_TenKhachHang.Text = row.Cells["TenKH"].Value?.ToString() ?? "";
            txt_SDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            txt_DiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
        }

        private void MenuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
