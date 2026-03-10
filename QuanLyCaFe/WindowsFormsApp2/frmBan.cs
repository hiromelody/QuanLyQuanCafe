using ketnoisql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmBan : Form
    {
        public frmBan()
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
            dgvMain.Columns["MaBan"].FillWeight = 150;
            dgvMain.Columns["SucChua"].FillWeight = 150;
            dgvMain.Columns["TrangThai"].FillWeight = 150;
        }

        private void LoadData()
        {
            string strSQL = $@"SELECT * FROM Ban WHERE MaBan LIKE N'%{txtTimKiem.Text}%'";
            dgv_DanhMucBan.DataSource = KetNoiSQL.ThucThiQuery(strSQL);


            SetupDataGridView(dgv_DanhMucBan);
            dgv_DanhMucBan.Columns[0].HeaderText = "Mã Bàn";
            dgv_DanhMucBan.Columns[1].HeaderText = "Sức Chứa";
            dgv_DanhMucBan.Columns[2].HeaderText = "Trạng Thái";

            if (dgv_DanhMucBan.Rows.Count == 0)
            {
                txt_MaBan.Text = "";
                txt_SucChua.Text = "";
            }
            else
            {
                DataGridViewRow drow = dgv_DanhMucBan.Rows[0];
                txt_MaBan.Text = drow.Cells[0].Value.ToString();
                txt_SucChua.Text = drow.Cells[1].Value.ToString();
            }
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MenuThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaBan.Text))
            {
                MessageBox.Show("Chưa nhập mã bàn");
                txt_MaBan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SucChua.Text))
            {
                MessageBox.Show("Chưa nhập sức chứa");
                txt_SucChua.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM Ban WHERE MaBan = '{txt_MaBan.Text}'";
            if (KetNoiSQL.ExcuteReader_bool(strSQL))
            {
                MessageBox.Show("Mã bàn này đã tồn tại, vui lòng tạo mã khác");
                txt_MaBan.Focus();
                return;
            }
            strSQL = $@"INSERT INTO Ban(MaBan,SucChua) 
                        VALUES ('{txt_MaBan.Text}',N'{txt_SucChua.Text}') ";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Thêm thành công");
            LoadData();
        }

        private void MenuSua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhMucBan.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sửa");
                return;
            }
            if (string.IsNullOrEmpty(txt_MaBan.Text))
            {
                MessageBox.Show("Chưa nhập mã bàn");
                txt_MaBan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_SucChua.Text))
            {
                MessageBox.Show("Chưa nhập sức chứa");
                txt_SucChua.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM Ban WHERE MaBan = '{txt_MaBan.Text}'";
            string MaBanSua = dgv_DanhMucBan.CurrentRow.Cells[0].Value.ToString().Trim();
            if (KetNoiSQL.ExcuteReader_bool(strSQL) && txt_MaBan.Text.Trim() != MaBanSua)
            {
                MessageBox.Show("Mã bàn này đã tồn tại, vui lòng tạo mã khác");
                txt_MaBan.Focus();
                return;
            }
            strSQL = $@"UPDATE Ban SET MaBan = '{txt_MaBan.Text}',SucChua = N'{txt_SucChua.Text}' WHERE MaBan = '{MaBanSua}'";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void MenuXoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhMucBan.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string strSQL = $@"DELETE Ban WHERE MaBan = '{dgv_DanhMucBan.CurrentRow.Cells[0].Value.ToString().Trim()}'";
                KetNoiSQL.ThucThiQuery(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuXoaHet_Click(object sender, EventArgs e)
        {
            txt_MaBan.Text = "";
            txt_SucChua.Text = "";
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DanhMucBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {     
                DataGridViewRow row = this.dgv_DanhMucBan.Rows[e.RowIndex];
                txt_MaBan.Text = row.Cells["MaBan"].Value.ToString();
                txt_SucChua.Text = row.Cells["SucChua"].Value.ToString();
            }
        }
    }
}
