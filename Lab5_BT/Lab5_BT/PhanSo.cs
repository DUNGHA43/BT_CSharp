using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_BT
{
    public class PhanSo
    {
        //Khoitao
        private double tuso;
        private double mauso;
        //Phuongthuc
        //Hamkhoitao
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(double tuso, double mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }

        //Nhap
        public void nhapPS()
        {
            double a;
            double b;
            do {
                Console.WriteLine("Nhap vào tử số: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vào mẫu số: ");
                b = double.Parse(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("Hãy nhập mẫu số khác 0");
                }
                else
                {
                    tuso = a;
                    mauso = b;
                }
            } while (b == 0);
        }
        //in
        public void inPS()
        {
            if (tuso * mauso < 0)
            {
                Console.WriteLine("-" + Math.Abs(tuso) + "/" + Math.Abs(mauso));
            }
            else
            {
                Console.WriteLine(Math.Abs(tuso) + "/" + Math.Abs(mauso));

            }
        }
        //rutgon
        private double ucln(double a, double b)
        {
            double r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return b;
        }
        public void rutgonPS()
        {
            double x = ucln(tuso, mauso);
            tuso /= x;
            mauso /= x;
        }
        // tinh +
        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            double Tu = ps1.tuso * ps2.mauso + ps2.tuso * ps1.mauso;
            double mau = ps1.mauso * ps2.mauso;
            return new PhanSo(Tu, mau);
        }
        // tinh -
        public static PhanSo operator -( PhanSo ps1,PhanSo ps2)
        {
            double tu;
            double mau;
            if(ps1.mauso == ps2.mauso)
            {
                tu = ps1.tuso - ps2.tuso;
                mau = ps1.mauso;
            }
            else
            {
                tu = ps1.tuso * ps2.mauso - ps2.tuso * ps1.mauso;
                mau = ps1.mauso * ps2.mauso;
            }
            return new PhanSo(tu, mau);
        }
        // tinh *
        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            double tu = ps1.tuso * ps2.tuso;
            double mau = ps1.mauso * ps2.mauso;
            return new PhanSo(tu, mau);
        }
        // tinh /
        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            double tu = ps1.tuso * ps2.mauso;
            double mau = ps2.mauso * ps2.tuso;
            return new PhanSo(tu, mau);
        }
    }
}
