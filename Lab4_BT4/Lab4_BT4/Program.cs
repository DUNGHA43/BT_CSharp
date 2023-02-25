using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_BT
{
    //Bai1
   public class Nguoi
    {
      
        public string hoten = "HA TIEN DUNG";
        public string cmnd = "014203002373";
        public string quequan = "SONLA";
        public string ghichu = "NULL";
        public Nguoi(string hoten, string cmnd, string quequan, string ghichu)
        {
            this.hoten = hoten;
            this.cmnd = cmnd;
            this.quequan = quequan;
            this.ghichu = ghichu;

        }
        public Nguoi()
        {

        }
        public virtual string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}", hoten, cmnd, quequan, ghichu);
        }
    }
    //Bai2
     public class SV1 : Nguoi
    {
        public string msv = "20213409";
       
        public void inTT()
        {
            Console.WriteLine(msv + " " + hoten + " " + cmnd + " " + quequan + " " + ghichu);
        }
    }
    public class SV2
    {
        public SV1 sinhVien { get; set; }
        public int soDienThoat { get; set; }
        public string in_TT()
        {
            string s = $"Ma Sinh Vien: {sinhVien.msv.ToString()}\nHo Ten: {sinhVien.hoten}\nCmnd: {sinhVien.cmnd}\nQue Quan: {sinhVien.quequan}\nSo Dien Thoai: {this.soDienThoat}";
            return s;
        }

    }

    class program
    {
        static void Main(string[] args)
        {
            // Bai1
            Console.WriteLine("Bai1");
            Nguoi ng = new Nguoi();
            Console.WriteLine(ng.ToString());

            //Bai2
            Console.WriteLine("Bai2");
            SV1 sv1 = new SV1();
            sv1.inTT();
           SV2 sinhVien = new SV2()
           {
               sinhVien  = new SV1()
               {
                   msv = "20213409",
                   hoten = "Hà Tiến Dũng",
                   cmnd = "014203002373",
                   quequan = "SonLa"
               } ,
               soDienThoat = 0383366423
           };
            Console.WriteLine(sinhVien.in_TT());
        }
    }
}


