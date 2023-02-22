using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_BT
{
    public class Phanso
    {
        public double tuso;
        public double mauso;

        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public Phanso(double tuso, double mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }

        public Phanso congPS(Phanso ps2)
        {
            double tu = tuso * ps2.mauso + ps2.tuso * mauso;
            double mau = mauso * ps2.mauso;

            return new Phanso(tu, mau);
        }
        public Phanso truPS(Phanso ps2)
        {
            double tu;
            double mau;
            if(mauso == ps2.mauso)
            {
                tu = tuso - ps2.tuso;
                mau = mauso;
            }
            else
            {     
                tu = tuso * ps2.mauso - ps2.tuso * mauso;
                mau = mauso * ps2.mauso;
            }
            return new Phanso(tu, mau);
        }
        public Phanso nhanPS(Phanso ps2)
        {
            double tu = tuso * ps2.tuso;
            double mau = mauso * ps2.mauso;

            return new Phanso(tu, mau);
        }
        public Phanso chiaPS(Phanso ps2)
        {
            double tu = tuso * ps2.mauso;
            double mau = mauso * ps2.tuso;

            return new Phanso(tu, mau);
        }

        // rutgon
        private double ucln(double a, double b)
        {
            double x = a % b;
            while(x != 0)
            {
                a = b;
                b = x;
                x = a % b;
            }
            return b;
        }
        public void rutgon()
        {
            double x = ucln(tuso, mauso);
            {
                tuso /= x;
                mauso /= x;
            }

        }
    }
}
