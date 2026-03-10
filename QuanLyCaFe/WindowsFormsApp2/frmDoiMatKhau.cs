using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formDangNhap;
using ketnoisql;


namespace WindowsFormsApp2
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_NhapMatKhauCu.Text != frmDangNhap.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không được trùng khớp");
                txt_NhapMatKhauCu.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_NhapMatKhauCu.Text))
            {
                MessageBox.Show("Mật khẩu mới không được trống");
                txt_NhapMatKhauMoi.Focus();
                return;
            }

            if (txt_NhapMatKhauMoi.Text != txt_XacNhan.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp");
                txt_XacNhan.Focus();
                return;
            }
            string strSQL = $@"UPDATE NhanVien SET MatKhau = '{txt_NhapMatKhauMoi.Text}' WHERE MaNV = '{frmDangNhap.MaNV}'";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Đổi mật khẩu thành công");
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
