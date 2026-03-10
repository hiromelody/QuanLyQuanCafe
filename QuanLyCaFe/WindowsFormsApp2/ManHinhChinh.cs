using System;
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
    }
}
