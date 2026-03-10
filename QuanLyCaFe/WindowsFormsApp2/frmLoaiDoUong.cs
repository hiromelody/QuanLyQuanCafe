using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ketnoisql;

namespace WindowsFormsApp2
{
    public partial class frmLoaiDoUong : Form
    {
        public frmLoaiDoUong()
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
            dgvMain.Columns["MaLoai"].FillWeight = 150;
            dgvMain.Columns["TenLoai"].FillWeight = 150;
        }

        private void LoadData()
        {
            string strSQL = $@"SELECT * FROM LoaiDoUong WHERE TenLoai LIKE N'%{txtTimKiem.Text}%'";
            dgv_DanhMucLoaiDoUong.DataSource = KetNoiSQL.ThucThiQuery(strSQL);


            SetupDataGridView(dgv_DanhMucLoaiDoUong);
            dgv_DanhMucLoaiDoUong.Columns[0].HeaderText = "Tên Loại Đồ Uống";
            dgv_DanhMucLoaiDoUong.Columns[1].HeaderText = "Mã Loại Đồ Uống";

            if (dgv_DanhMucLoaiDoUong.Rows.Count == 0)
            {
                txt_MaLoai.Text = "";
                txt_TenLoai.Text = "";
            }
            else
            {
                DataGridViewRow drow = dgv_DanhMucLoaiDoUong.Rows[0];
                txt_MaLoai.Text = drow.Cells[0].Value.ToString();
                txt_TenLoai.Text = drow.Cells[1].Value.ToString();
            }
        }

        private void frmLoai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MenuThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaLoai.Text))
            {
                MessageBox.Show("Chưa nhập mã đồ uống");
                txt_MaLoai.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenLoai.Text))
            {
                MessageBox.Show("Chưa nhập tên đồ uống");
                txt_TenLoai.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM LoaiDoUong WHERE MaLoai = '{txt_MaLoai.Text}'";
            if (KetNoiSQL.ExcuteReader_bool(strSQL))
            {
                MessageBox.Show("Mã loại đồ uống này đã tồn tại, vui lòng tạo mã khác");
                txt_MaLoai.Focus();
                return;
            }
            strSQL = $@"INSERT INTO LoaiDoUong(MaLoai,TenLoai) 
                        VALUES ('{txt_MaLoai.Text}',N'{txt_TenLoai.Text}') ";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Thêm thành công");
            LoadData();
        }

        private void MenuSua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhMucLoaiDoUong.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sửa");
                return;
            }
            if (string.IsNullOrEmpty(txt_MaLoai.Text))
            {
                MessageBox.Show("Chưa nhập mã đồ uống");
                txt_MaLoai.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenLoai.Text))
            {
                MessageBox.Show("Chưa nhập tên đồ uống");
                txt_TenLoai.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM LoaiDoUong WHERE MaLoai = '{txt_MaLoai.Text}'";
            string MaLDUSua = dgv_DanhMucLoaiDoUong.CurrentRow.Cells[0].Value.ToString().Trim();
            if (KetNoiSQL.ExcuteReader_bool(strSQL) && txt_MaLoai.Text.Trim() != MaLDUSua)
            {
                MessageBox.Show("Mã đồ uống này đã tồn tại, vui lòng tạo mã khác");
                txt_MaLoai.Focus();
                return;
            }
            strSQL = $@"UPDATE LoaiDoUong SET MaLoai = '{txt_MaLoai.Text}',TenLoai = N'{txt_TenLoai.Text}' WHERE MaLoai = '{MaLDUSua}'";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void MenuXoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhMucLoaiDoUong.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string strSQL = $@"DELETE LoaiDoUong WHERE MaLoai = '{dgv_DanhMucLoaiDoUong.CurrentRow.Cells[0].Value.ToString().Trim()}'";
                KetNoiSQL.ThucThiQuery(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DanhMucLoaiDoUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0) 
            { 
                DataGridViewRow row = this.dgv_DanhMucLoaiDoUong.Rows[e.RowIndex];
                txt_MaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                txt_TenLoai.Text = row.Cells["TenLoai"].Value.ToString();
            }
        }

        private void MenuXoaHet_Click(object sender, EventArgs e)
        {
            txt_MaLoai.Text = "";
            txt_TenLoai.Text = "";
        }

        private void dgv_DanhMucLoaiDoUong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
