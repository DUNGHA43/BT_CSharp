using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_BT
{
    public class Hanghoa
    {
        public string maH;
        public string tenH;
        public double gia;
        
        public Hanghoa()
        {
            gia = 0;
        }
        public Hanghoa(string maH, string tenH, double gia)
        {
            this.maH = maH;
            this.tenH = tenH;
            this.gia = gia;
        }
    }
}
