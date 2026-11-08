using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhaHang.DAL; 

namespace QuanLyNhaHang
{
    public partial class frmKhach : Form
    {
        public frmKhach()
        {
            InitializeComponent();

            LoadDanhSachKhach();
        }

        private void LoadDanhSachKhach()
        {
            dgvKhach.DataSource = KhachHangDAL.LayDanhSachKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhach = txtMaKhach.Text.Trim();
            string tenKhach = txtTenKhach.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(maKhach) || string.IsNullOrEmpty(tenKhach))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã khách và Tên khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool kq = KhachHangDAL.ThemKhachHang(maKhach, tenKhach, diaChi, dienThoai);
            if (kq)
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachKhach(); 
                btnLamMoi_Click(sender, e); 
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Kiểm tra lại mã khách có bị trùng không.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhach.Clear();
            txtTenKhach.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtMaKhach.Focus();
        }

        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhach.Rows[e.RowIndex];
                txtMaKhach.Text = row.Cells["MaKhach"].Value.ToString();
                txtTenKhach.Text = row.Cells["TenKhach"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString() == "" ? "" : row.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString() == "" ? "" : row.Cells["DienThoai"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhach = txtMaKhach.Text.Trim();

            if (string.IsNullOrEmpty(maKhach))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa trên bảng hoặc nhập Mã khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng có mã '{maKhach}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                bool kq = KhachHangDAL.XoaKhachHang(maKhach);
                if (kq)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachKhach();        
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Không tìm thấy mã khách này trong CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}