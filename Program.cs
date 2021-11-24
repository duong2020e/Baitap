using System;

namespace BaiKT
{
        class NhanVien
        {
            public string maNV;
            public string tenNhanVien;
            public string gioiTinh;
            public string bangCap;
            public string ngaySinh;
            public void Info() 
            {
                Console.WriteLine("MaNV: " + maNV + "\n" + "TenNV: " + tenNhanVien +"\n"  + "GioiTinh: " + gioiTinh + "\n" + "BangCap: " + bangCap + "\n" + "NgaySinh: " + ngaySinh);
            }
        }
        class Nv : NhanVien
        {
            public Nv()
            {
                maNV = "NV1";
                tenNhanVien = "huỳnh bình dương";
                gioiTinh = "Nam";
                bangCap = "Cao Dang";
                ngaySinh = "12/10/2001";
            }
        }
        class KhachHang
        {
            public string maKH;
            public string tenKH;
            public string gioiTinh;
            public string loaiKH;
            public string ngaySinh;
            public void Info()
            {
                Console.WriteLine("MaKH: " + maKH + "\n" + "TenKH: " + tenKH + "\n" + "GioiTinh: " + gioiTinh + "\n" + "Loai Khach Hang: " + loaiKH + "\n" + "NgaySinh: " + ngaySinh);
            }
        }
        class Kh : KhachHang
        {
            public Kh()
            {
                maKH = "KH1";
                tenKH = "huỳnh bình dương";
                gioiTinh = "Nam";
                loaiKH = "Vip";
                ngaySinh = "12/10/2001";
            }
        }
    class Program
        {
            static void Main(string[] args)
            {
                Nv NV1 = new Nv();
                NV1.Info();
                Console.WriteLine();
                Kh KH1 = new Kh();
                KH1.Info();
                Console.ReadKey();
            }
        }
           
}
