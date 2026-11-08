using QuanlyNhaHang.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.DAL
{
    public class KhachHangDAL
    {
        public static DataTable LayDanhSachKhachHang()
        {
            string query = "SELECT MaKhach, TenKhach, DiaChi, DienThoai FROM Khach";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static bool ThemKhachHang(string maKhach, string tenKhach, string diaChi, string dienThoai)
        {
            string query = "INSERT INTO Khach (MaKhach, TenKhach, DiaChi, DienThoai) VALUES (@MaKhach, @TenKhach, @DiaChi, @DienThoai)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhach", maKhach),
                new SqlParameter("@TenKhach", tenKhach),
                new SqlParameter("@DiaChi", string.IsNullOrEmpty(diaChi) ? (object)DBNull.Value : diaChi),
                new SqlParameter("@DienThoai", string.IsNullOrEmpty(dienThoai) ? (object)DBNull.Value : dienThoai)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool XoaKhachHang(string maKhach)
        {
            string query = "DELETE FROM Khach WHERE MaKhach = @MaKhach";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhach", maKhach)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}