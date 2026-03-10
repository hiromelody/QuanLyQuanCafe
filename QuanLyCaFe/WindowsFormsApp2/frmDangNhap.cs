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
using WindowsFormsApp2;

namespace formDangNhap
{
    public partial class frmDangNhap : Form
    {
        KetNoiSQL db = new KetNoiSQL();
        public frmDangNhap()
        { 
            InitializeComponent();
        }

        public static string MatKhau;
        public static string MaNV;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDangNhap.Text))
            {
                MessageBox.Show("Chưa nhập thông tin mã đăng nhập!");
                txtMaDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM NhanVien WHERE MaNV = '{txtMaDangNhap.Text}' AND MatKhau = '{txtMatKhau.Text}' ";
            bool check = KetNoiSQL.ExcuteReader_bool(strSQL);
            if (check )
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_ManHinhChinh frm = new frm_ManHinhChinh();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin mã đăng nhập hoặc mật khẩu!");
                txtMaDangNhap.Focus();
                return;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
