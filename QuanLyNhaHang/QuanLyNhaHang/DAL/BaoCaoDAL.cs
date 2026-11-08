using QuanlyNhaHang.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

public class BaoCaoDAL
{
    public static int LayTongSoNhanVien()
    {
        string query = "SELECT COUNT(*) FROM NhanVien";
        DataTable dt = DatabaseHelper.ExecuteQuery(query);
        return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
    }

    public static int LayTongSoKhachHang()
    {
        string query = "SELECT COUNT(*) FROM Khach";
        DataTable dt = DatabaseHelper.ExecuteQuery(query);
        return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
    }

    public static decimal LayDoanhThuThangHienTai()
    {
        string query = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDonNhap WHERE MONTH(NgayNhap) = MONTH(GETDATE()) AND YEAR(NgayNhap) = YEAR(GETDATE())";
        DataTable dt = DatabaseHelper.ExecuteQuery(query);
        return dt.Rows.Count > 0 ? Convert.ToDecimal(dt.Rows[0][0]) : 0;
    }

    public static DataTable LayDoanhThu6ThangGanNhat()
    {
        string query = "SELECT TOP 6 MONTH(NgayNhap) AS Thang, SUM(TongTien) AS DoanhThu FROM HoaDonNhap GROUP BY MONTH(NgayNhap), YEAR(NgayNhap) ORDER BY YEAR(NgayNhap) DESC, MONTH(NgayNhap) DESC";
        return DatabaseHelper.ExecuteQuery(query);
    }

    public static DataTable LayTyLeGioiTinhKhach()
    {
        string query = "SELECT GioiTinh, COUNT(*) AS SoLuong FROM Khach GROUP BY GioiTinh";
        return DatabaseHelper.ExecuteQuery(query);
    }

    public static DataTable LayDanhSachHoaDonChiTiet(DateTime? tuNgay = null, DateTime? denNgay = null, string maNV = "")
    {
        string query = "SELECT * FROM HoaDonNhap";
        return DatabaseHelper.ExecuteQuery(query);
    }

    public static DataTable LayDanhSachNhanVien()
    {
        string query = "SELECT MaNhanVien, TenNhanVien FROM NhanVien";
        return DatabaseHelper.ExecuteQuery(query);
    }
    public static decimal LayDoanhThuTheoThang(int thang, int nam)
    {
        decimal doanhThu = 0;

        string query = $"SELECT ISNULL(SUM(TongTien), 0) FROM HoaDonNhap WHERE MONTH(NgayNhap) = {thang} AND YEAR(NgayNhap) = {nam}";

        try
        {
            System.Data.DataTable dt = DatabaseHelper.ExecuteQuery(query); 

            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                doanhThu = Convert.ToDecimal(dt.Rows[0][0]);
            }
        }
        catch
        {
            doanhThu = 0;
        }

        return doanhThu;
    }
}