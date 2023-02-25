using System;

namespace lab4_BT
{
    //Bai1
    class Nguoi 
    {
        public string hoten = "HA TIEN DUNG";
        public string cmnd = "014203002373";
        public string quequan = "SONLA";
        public string ghichu = "NULL";

        public override string ToString()
        {
            return hoten + "\n" + cmnd + "\n" + quequan + "\n" + ghichu;
        }
    }
    //Bai2
    class SV1 : Nguoi
    {
        public string msv = "20213409";
    }
    class SV2 : Nguoi
    {
        public override string ToString()
        {
            SV1 s = new SV1();
            return s.msv +"\n" + hoten + "\n" + cmnd + "\n" + quequan + "\n" + ghichu;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B1");
            Nguoi nguoi = new Nguoi();
            Console.WriteLine(nguoi.ToString());
            Console.WriteLine("B1");
            SV2 s = new SV2();
            Console.WriteLine(s.ToString());
        }
    }
}
