using QuanLyNhaHang.DAL; 
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyNhaHang 
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                lblTongSoNV.Text = BaoCaoDAL.LayTongSoNhanVien().ToString();
                lblTongSoKH.Text = BaoCaoDAL.LayTongSoKhachHang().ToString();

                decimal doanhThu = BaoCaoDAL.LayDoanhThuThangHienTai();
                lblDoanhThuThang.Text = doanhThu.ToString("N0") + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Dashboard: " + ex.Message);
            }

            try
            {
                LoadChartDoanhThu6Thang();
                LoadChartTyLeGioiTinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Biểu đồ: " + ex.Message);
            }

            try
            {
                cboLoaiBaoCao.Items.Clear();
                cboLoaiBaoCao.Items.Add("Báo cáo doanh thu");
                cboLoaiBaoCao.Items.Add("Báo cáo nhân sự");
                cboLoaiBaoCao.SelectedIndex = 0;

                cboNhanVien.DisplayMember = "TenNhanVien"; 
                cboNhanVien.ValueMember = "MaNhanVien";   
                cboNhanVien.DataSource = BaoCaoDAL.LayDanhSachNhanVien();
                cboNhanVien.SelectedIndex = -1;
            }
            catch (Exception )
            {
            }

            try
            {
                dgvBaoCao.DataSource = BaoCaoDAL.LayDanhSachHoaDonChiTiet();
            }
            catch (Exception )
            {
            }
        }

        private void LoadDashboardOverview()
        {
            try
            {
                lblTongSoNV.Text = BaoCaoDAL.LayTongSoNhanVien().ToString();
                lblTongSoKH.Text = BaoCaoDAL.LayTongSoKhachHang().ToString();

                decimal doanhThuThang = BaoCaoDAL.LayDoanhThuThangHienTai();
                lblDoanhThuThang.Text = doanhThuThang.ToString("N0") + " VNĐ"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải số liệu Dashboard: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChartDoanhThu6Thang()
        {
            chartDoanhThu6Thang.Series.Clear();
            var series = chartDoanhThu6Thang.Series.Add("Doanh thu");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            DateTime currentDate = DateTime.Now;

            for (int i = 5; i >= 0; i--)
            {
                DateTime targetDate = currentDate.AddMonths(-i);
                int thang = targetDate.Month;
                int nam = targetDate.Year;

                decimal doanhThu = BaoCaoDAL.LayDoanhThuTheoThang(thang, nam);

                int pointIndex = series.Points.AddXY($"Tháng {thang}", doanhThu);

            }
        }

        private void LoadChartTyLeGioiTinh()
        {
            chartTyLeGioiTinh.Series.Clear();
            var seriesTron = chartTyLeGioiTinh.Series.Add("TyLe");
            seriesTron.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            int pNam = seriesTron.Points.AddXY("Nam (60%)", 60);
            seriesTron.Points[pNam].Color = Color.Blue;

            int pNu = seriesTron.Points.AddXY("Nữ (40%)", 40);
            seriesTron.Points[pNu].Color = Color.Orange;

            seriesTron["PieRadiusPercentage"] = "78";

            if (chartTyLeGioiTinh.Legends.Count > 0)
            {
                chartTyLeGioiTinh.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom; 
                chartTyLeGioiTinh.Legends[0].Alignment = StringAlignment.Center;
            }

            seriesTron["PieLabelStyle"] = "Outside";
        }

        private void LoadDanhSachChiTiet()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value;
                DateTime denNgay = dtpDenNgay.Value;
                string maNV = cboNhanVien.SelectedValue?.ToString();

                DataTable dt = BaoCaoDAL.LayDanhSachHoaDonChiTiet(tuNgay, denNgay, maNV);
                dgvBaoCao.DataSource = dt;

                if (dgvBaoCao.Columns["MaHoaDonNhap"] != null)
                    dgvBaoCao.Columns["MaHoaDonNhap"].HeaderText = "Mã HĐ Nhập";

                if (dgvBaoCao.Columns["NgayNhap"] != null)
                {
                    dgvBaoCao.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
                    dgvBaoCao.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dgvBaoCao.Columns["MaNhanVien"] != null)
                    dgvBaoCao.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";

                if (dgvBaoCao.Columns["MaNhaCungCap"] != null)
                    dgvBaoCao.Columns["MaNhaCungCap"].HeaderText = "Mã NCC";

                if (dgvBaoCao.Columns["TongTien"] != null)
                {
                    dgvBaoCao.Columns["TongTien"].HeaderText = "Tổng Tiền (VNĐ)";
                    dgvBaoCao.Columns["TongTien"].DefaultCellStyle.Format = "N0"; 
                }

                dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            LoadDanhSachChiTiet(); 
            MessageBox.Show("Đã tạo báo cáo mới dựa trên điều kiện lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
            cboNhanVien.SelectedIndex = -1; 

            LoadDashboardOverview();
            LoadChartDoanhThu6Thang();
            LoadChartTyLeGioiTinh();
            LoadDanhSachChiTiet();

            MessageBox.Show("Đã làm mới dữ liệu báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lblTongSoNV_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}