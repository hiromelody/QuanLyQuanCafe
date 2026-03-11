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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
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
        }

        private void LoadData()
        {
            //string sql = "SELECT * FROM ThanhToan";

            //dgv_ThanhToan.DataSource = KetNoiSQL.ThucThiQuery(sql);

            SetupDataGridView(dgv_ThanhToan);
            dgv_ThanhToan.Columns[0].HeaderText = "Mã NV";
            dgv_ThanhToan.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_ThanhToan.Columns[2].HeaderText = "Số Điện Thoại";
            dgv_ThanhToan.Columns[3].HeaderText = "Địa Chỉ";

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_SoDienThoai_Click(object sender, EventArgs e)
        {

        }

        private void lbl_MaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DiaChi_Click(object sender, EventArgs e)
        {

        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            //LoadData();
        }
    }
}
