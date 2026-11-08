using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhaHang.DAL;

namespace QuanLyNhaHang
{
    public partial class ucNhanSu : UserControl
    {
        public ucNhanSu()
        {
            InitializeComponent();

            LoadDanhSachNhanVien();
            LoadComboboxQue();
        }

        private void ucNhanSu_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            LoadComboboxQue();
            cboGioiTinh.SelectedIndex = 0;
        }

        private void LoadDanhSachNhanVien()
        {
            dgvNhanVien.DataSource = NhanVienDAL.LayDanhSachNhanVien();
            if (dgvNhanVien.Columns.Count > 0)
            {
                dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["TenNhanVien"].HeaderText = "Họ và Tên";
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvNhanVien.Columns["TenQue"].HeaderText = "Quê quán";
                dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện thoại";
                dgvNhanVien.Columns["MaQue"].Visible = false;
            }
        }

        private void LoadComboboxQue()
        {
            DataTable dt = NhanVienDAL.LayDanhSachQue();


            cboQueQuan.DataSource = dt;
            cboQueQuan.DisplayMember = "TenQue";
            cboQueQuan.ValueMember = "MaQue";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaNV.Text.Trim();
                string ten = txtTenNV.Text.Trim();
                string gt = cboGioiTinh.Text;
                DateTime ns = dtpNgaySinh.Value;
                string dc = txtDiaChi.Text.Trim();
                if (cboQueQuan.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn quê quán cho nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maQue = cboQueQuan.SelectedValue.ToString();
                string dt = txtDienThoai.Text.Trim();

                if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Vui lòng nhập Mã và Tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool kq = NhanVienDAL.ThemNhanVien(ma, ten, gt, ns, dc, maQue, dt);
                if (kq)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại (Có thể trùng mã nhân viên).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " +
                    ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                string ma = dgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên [{ma}] không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (NhanVienDAL.XoaNhanVien(ma))
                    {
                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại (Nhân viên này có thể đang liên kết với Hóa đơn nhập/Phiếu đặt bàn).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNhanVien"].Value.ToString();
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                cboQueQuan.SelectedValue = row.Cells["MaQue"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtMaNV.Focus();
        }
    }
}