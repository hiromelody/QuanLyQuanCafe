using ketnoisql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmDoUong : Form
    {
        public frmDoUong()
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
            dgvMain.Columns[0].FillWeight = 50;
            dgvMain.Columns[1].FillWeight = 100;
            dgvMain.Columns[2].FillWeight = 55;
            dgvMain.Columns[3].FillWeight = 70;
            dgvMain.Columns[3].DefaultCellStyle.Format = "N0"; // format tiền

        }

        private void LoadData()
        {
            string strSQL = $@"SELECT * FROM DoUong WHERE TenDU LIKE N'%{txtbTimkiem.Text}%'";
            dgv_DanhMucDoUong.DataSource = KetNoiSQL.ThucThiQuery(strSQL);


            SetupDataGridView(dgv_DanhMucDoUong);
            dgv_DanhMucDoUong.Columns[0].HeaderText = "Mã Đồ Uống";
            dgv_DanhMucDoUong.Columns[1].HeaderText = "Tên Đồ Uống";
            dgv_DanhMucDoUong.Columns[2].HeaderText = "Mã Loại Đồ Uống";
            dgv_DanhMucDoUong.Columns[3].HeaderText = "Đơn Giá";
            dgv_DanhMucDoUong.Columns["HinhAnh"].Visible = false;

            if (dgv_DanhMucDoUong.Rows.Count == 0)
            {
                txt_MaDoUong.Text = "";
                txt_TenDoUong.Text = "";
                txtbDongia.Text = "";
                pictbhinhanh.Image = null;
            }
            else
            {
                DataGridViewRow drow = dgv_DanhMucDoUong.Rows[0];
                txt_MaDoUong.Text = drow.Cells[0].Value.ToString();
                txt_TenDoUong.Text = drow.Cells[1].Value.ToString();
                cbb_MaLoaiDoUong.Text = drow.Cells[2].Value.ToString();
                txtbDongia.Text = drow.Cells[3].Value.ToString();
                string strSQLA = $@"SELECT HinhAnh FROM DoUong WHERE MaDU = '{txt_MaDoUong.Text}'";
                string result = KetNoiSQL.ExcuteScalar_string(strSQLA);
                if (!string.IsNullOrEmpty(result))
                {
                    pictbhinhanh.Image = Base64ToImage(result);
                }
                else
                {
                    pictbhinhanh.Image = null;
                }
                dgv_DanhMucDoUong.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgv_DanhMucDoUong.Columns["DonGia"].DefaultCellStyle.NullValue = "0 VNĐ";
            }
        }
        private void dgv_DanhMucDoUong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DanhMucDoUong.Columns[e.ColumnIndex].Name == "DonGia" && e.Value != null)
            {
                e.Value = string.Format("{0:N0} VNĐ", e.Value);
                e.FormattingApplied = true;
            }
        }
        private void MenuThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaDoUong.Text))
            {
                MessageBox.Show("Chưa nhập mã đồ uống");
                txt_MaDoUong.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenDoUong.Text))
            {
                MessageBox.Show("Chưa nhập tên đồ uống");
                txt_TenDoUong.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtbDongia.Text))
            {
                MessageBox.Show("Chưa nhập đơn giá");
                txtbDongia.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM DoUong WHERE MaDU = '{txt_MaDoUong.Text}'";
            if (KetNoiSQL.ExcuteReader_bool(strSQL))
            {
                MessageBox.Show("Mã đồ uống này đã tồn tại, vui lòng tạo mã khác");
                txt_MaDoUong.Focus();
                return;
            }
            strSQL = $@"INSERT INTO DoUong(MaDU,TenDU,MaLoai,DonGia) 
                        VALUES ('{txt_MaDoUong.Text}',N'{txt_TenDoUong.Text}','{cbb_MaLoaiDoUong.SelectedValue}',{txtbDongia.Text})";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Thêm thành công");
            LoadData();
        }

        private void MenuSua_Click(object sender, EventArgs e)
        {
            if (dgv_DanhMucDoUong.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sửa");
                return;
            }
            if (string.IsNullOrEmpty(txt_MaDoUong.Text))
            {
                MessageBox.Show("Chưa nhập mã đồ uống");
                txt_MaDoUong.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_TenDoUong.Text))
            {
                MessageBox.Show("Chưa nhập tên đồ uống");
                txt_MaDoUong.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtbDongia.Text))
            {
                MessageBox.Show("Chưa nhập đơn giá");
                txtbDongia.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM DoUong WHERE MaDU = '{txt_MaDoUong.Text}'";
            string MaDUSua = dgv_DanhMucDoUong.CurrentRow.Cells[0].Value.ToString().Trim();
            if (KetNoiSQL.ExcuteReader_bool(strSQL) && txt_MaDoUong.Text.Trim() != MaDUSua)
            {
                MessageBox.Show("Mã đồ uống này đã tồn tại, vui lòng tạo mã khác");
                txt_MaDoUong.Focus();
                return;
            }
            strSQL = $@"UPDATE DoUong SET MaDU = '{txt_MaDoUong.Text}'
                                            ,TenDU = N'{txt_TenDoUong.Text}'
                                            ,MaLoai = N'{cbb_MaLoaiDoUong.Text}'
                                            ,DonGia =N'{txtbDongia.Text}'
                        WHERE MaDU = '{MaDUSua}'";
            KetNoiSQL.ThucThiQuery(strSQL);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void MenuXoa_Click(object sender, EventArgs e)
        {
            if (dgv_DanhMucDoUong.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string strSQL = $@"DELETE DoUong WHERE MaDU = '{dgv_DanhMucDoUong.CurrentRow.Cells[0].Value.ToString().Trim()}'";
                KetNoiSQL.ThucThiQuery(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void MenuXoaHet_Click(object sender, EventArgs e)
        {
            txt_MaDoUong.Text = "";
            txt_TenDoUong.Text = "";
            txtbDongia.Text = "";
            cbb_MaLoaiDoUong.Text = "";
            pictbhinhanh.Image = null;
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadComboboxLoaiDoUong()
        {
            string strSQL = "SELECT * FROM LoaiDoUong";
            DataTable dt = new DataTable();
            dt = KetNoiSQL.ThucThiQuery(strSQL);
            cbb_MaLoaiDoUong.DataSource = dt;
            cbb_MaLoaiDoUong.DisplayMember = "TenLoai";
            cbb_MaLoaiDoUong.ValueMember = "MaLoai";
        }

        private void frmDoUong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboboxLoaiDoUong();
        }

        private void dgv_DanhMucDoUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = this.dgv_DanhMucDoUong.Rows[e.RowIndex];

            txt_MaDoUong.Text = row.Cells["MaDU"].Value?.ToString() ?? "";
            txt_TenDoUong.Text = row.Cells["TenDU"].Value?.ToString() ?? "";
            cbb_MaLoaiDoUong.Text = row.Cells["MaLoai"].Value?.ToString() ?? "";
            txtbDongia.Text = row.Cells["DonGia"].Value?.ToString() ?? "";

            string base64 = row.Cells["HinhAnh"].Value?.ToString();

            Image img = Base64ToImage(base64);

            if (img != null)
            {
                pictbhinhanh.Image = img;
            }
            else
            {
                pictbhinhanh.Image = null;
            }
        }


        private Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemhinh_Click(object sender, EventArgs e)
        {

        }

        private string ConvertImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            } 
                
        }
        private void linklbThemhinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgv_DanhMucDoUong.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có đồ uống để thêm hình");
                return;
            }

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn ảnh";
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictbhinhanh.Image = Image.FromFile(open.FileName);

                string base64String = ConvertImageToBase64(pictbhinhanh.Image);

                string maDU = dgv_DanhMucDoUong.CurrentRow.Cells[0].Value.ToString().Trim();

                string strSQL = $@"
                    UPDATE DoUong 
                    SET HinhAnh = '{base64String}'
                    WHERE MaDU = '{maDU}'";

                KetNoiSQL.ThucThiQuery(strSQL);

                MessageBox.Show("Thêm hình thành công");

                LoadData();
            }
        }

        private void dgv_DanhMucDoUong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
