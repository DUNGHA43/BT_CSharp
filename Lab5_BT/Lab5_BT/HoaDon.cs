using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_BT
{
    public class HoaDon
    {
        // aggregation
        private List<HangHoa> hangHoaList;
        private KhachHang khachhang;

        public HoaDon(List<HangHoa> hangHoaList, KhachHang khachhang)
        {
            this.hangHoaList = hangHoaList;
            this.khachhang = khachhang;
        }
        // them xoa
        public void them(HangHoa hh)
        {
            hangHoaList.Add(hh);
        }
        public void xoa(HangHoa hh)
        {
            hangHoaList.Remove(hh);
        }
        // Tính tổng
        public double tong()
        {
            double tong = 0;
            foreach (HangHoa hanghoa in hangHoaList)
            {
                tong += hanghoa.dongia;
            }
            return tong;
        }
        // hàng giá trị cao nhất
        public void hhGiamax()
        {
            HangHoa hhgiamax = new HangHoa()
            {
                maH = null,
                tenH = null,
                dongia= 0D
            };
            foreach (HangHoa hanghoa in hangHoaList)
            {
                if(hanghoa.dongia > hhgiamax.dongia)
                {
                    hhgiamax = hanghoa;
                }
            }
            Console.WriteLine("Tên hàng: {0} || Giá tiền: {1}", hhgiamax.tenH, hhgiamax.dongia);
        }
        // in hoadon
        public void inHD()
        {
            Console.WriteLine("--------------------HÓA ĐƠN--------------------");
            Console.WriteLine("Mã khách hàng: {0}", khachhang.maK);
            Console.WriteLine("Tên khách hàng: {0}", khachhang.tenK);
            Console.WriteLine("Địa chỉ: {0}", khachhang.diachi);
            foreach(HangHoa hanghoa in hangHoaList)
            {
                Console.WriteLine("Tên hàng: {0} || Giá tiền: {1}",hanghoa.tenH, hanghoa.dongia);
            }
            Console.WriteLine("Tổng tiền: {0}", tong());
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
