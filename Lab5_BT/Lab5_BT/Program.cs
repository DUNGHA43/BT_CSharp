using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_BT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Bài 1-----------------------------------");
            //PhanSo ps1 = new PhanSo();
            //PhanSo ps2 = new PhanSo();
            //PhanSo pss = new PhanSo();
            //Console.WriteLine("Nhập phân số thứ nhất");
            //ps1.nhapPS();
            //Console.WriteLine("Nhập phân số thứ hai");
            //ps2.nhapPS();
            //Console.WriteLine("Phân số thứ nhất ");
            //ps1.inPS();
            //Console.WriteLine("Phân số thứ hai ");
            //ps2.inPS();
            //Console.WriteLine("Cộng: ");
            //pss = ps1 + ps2;
            //pss.rutgonPS();
            //pss.inPS();
            //Console.WriteLine("Trừ: ");
            //pss = ps1 - ps2;
            //pss.rutgonPS();
            //pss.inPS();
            //Console.WriteLine("Nhân: ");
            //pss = ps1 * ps2;
            //pss.rutgonPS();
            //pss.inPS();
            //Console.WriteLine("Chia: ");
            //pss = ps1 / ps2;
            //pss.rutgonPS();
            //pss.inPS();
            ////Bai2
            //Console.WriteLine("Bài 2-----------------------------------");
            //So num1 = new So();
            //So num2 = new So();
            //So nums = new So();
            //Console.WriteLine("Nhập vào số thứ nhất: ");
            //num1.nhap();
            //Console.WriteLine("Nhập vào số thứ hai: ");
            //num2.nhap();
            //Console.WriteLine("Tổng hai số");
            //nums = num1 + num2;
            //nums.inn();
            //Console.WriteLine("Trừ hai số");
            //nums = num1 - num2;
            //nums.inn();
            //Console.WriteLine("Nhân hai số");
            //nums = num1 * num2;
            //nums.inn();
            //Console.WriteLine("Chia hai số");
            //nums = num1 / num2;
            //nums.inn();
            //Console.WriteLine("Số thứ nhất");
            //num1.soNT();
            //Console.WriteLine("Số thứ hai");
            //num2.soNT();
            //Console.WriteLine("Số thứ nhất");
            //num1.soChanLe();
            //Console.WriteLine("Số thứ hai");
            //num2.soChanLe();
            //Console.WriteLine("Bài 3-----------------------------------");
            HangHoa hh1 = new HangHoa()
            {
                maH = "BMN",
                tenH = "BÁNH MÌ",
                dongia = 25000D
            };
            List <HangHoa> h_h = new List<HangHoa>();
            h_h.Add(hh1);
            HangHoa hh2 = new HangHoa()
            {
                maH = "KOS",
                tenH = "KẸO GỪNG",
                dongia = 15000D
            };
            h_h.Add(hh2);
            HangHoa hh3 = new HangHoa()
            {
                maH = "SCVNM",
                tenH = "SỮA CHUA VINAMILK",
                dongia = 20000D
            };
            h_h.Add(hh3);
            KhachHang kh = new KhachHang()
            {
                maK = "kh01",
                tenK = "HÀ TIẾN DŨNG",
                diachi = "SONLA"
            };
            HoaDon h_d = new HoaDon(h_h, kh);
            h_d.inHD();
            Console.WriteLine("Hàng có giá cao nhất: ");
            h_d.hhGiamax();
            Console.ReadKey();
        }
    }
}
