using QuanlyNhaHang.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.DAL
{
    public class NhanVienDAL
    {
        public static DataTable LayDanhSachNhanVien()
        {
            string query = @"
                SELECT nv.MaNhanVien, nv.TenNhanVien, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, q.TenQue, nv.DienThoai, nv.MaQue
                FROM NhanVien nv
                LEFT JOIN Que q ON nv.MaQue = q.MaQue";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static DataTable LayDanhSachQue()
        {
            return DatabaseHelper.ExecuteQuery("SELECT MaQue, TenQue FROM Que");
        }

        public static bool ThemNhanVien(string ma, string ten, string gt, DateTime ns, string dc, string maQue, string dt)
        {
            string query = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DiaChi, MaQue, DienThoai) VALUES (@Ma, @Ten, @GT, @NS, @DC, @MQ, @DT)";
            SqlParameter[] parameters = {
                new SqlParameter("@Ma", ma),
                new SqlParameter("@Ten", ten),
                new SqlParameter("@GT", gt),
                new SqlParameter("@NS", ns),
                new SqlParameter("@DC", dc),
                new SqlParameter("@MQ", maQue),
                new SqlParameter("@DT", dt)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool XoaNhanVien(string ma)
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @Ma";
            SqlParameter[] parameters = { new SqlParameter("@Ma", ma) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}