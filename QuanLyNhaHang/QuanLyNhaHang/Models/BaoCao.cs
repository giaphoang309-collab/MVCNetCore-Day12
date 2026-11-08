using System;

public class BaoCaoDoanhThu
{
    public DateTime Ngay { get; set; }
    public int SoLuongDon { get; set; }
    public decimal DoanhThu { get; set; }
}

public class MonAnBanChay
{
    public string MaMonAn { get; set; }
    public string TenMonAn { get; set; }
    public decimal TongSoLuongBan { get; set; }
    public decimal TongDoanhThu { get; set; }
}