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
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string sql = "SELECT * FROM ThanhToanWHERE TenKH LIKE @ten";

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

        }


        private void frmThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void txt_MaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_SoDienThoai_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DiaChi_Click(object sender, EventArgs e)
        {

        }
    }
}
