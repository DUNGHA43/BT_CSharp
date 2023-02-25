using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_BT
{
    public class So
    {
        private int num;

        public So()
        {
            num = 0;
        }
        public So(int num)
        {
            this.num = num;
        }

        public void nhap()
        {
            num = int.Parse(Console.ReadLine());
        }
        public void inn()
        {
            Console.WriteLine(num);
        }
        // Cong
        public static So operator +(So num1, So num2)
        {
            int s = num1.num + num2.num;
            return new So(s);
        }
        public static So operator -(So num1, So num2)
        {
            int s = num1.num - num2.num;
            return new So(s);
        }
        public static So operator *(So num1, So num2)
        {
            int s = num1.num * num2.num;
            return new So(s);
        }
        public static So operator /(So num1, So num2)
        {
            int s = num1.num / num2.num;
            return new So(s);
        }
        // kiểm tra số Nguyen to
        public void soNT()
        {
            int cnt = 0;
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0) cnt++;
            }
            if (cnt == 0)
            {
                Console.WriteLine("Số này là số nguyên tố: " + num);
            }    
            else
            {
                Console.WriteLine("Số này không phải số nguyên tố: " + num);
            }
        }
        // Kiem tra so chan le
        public void soChanLe()
        {
            if(num % 2 == 0)
            {
                Console.WriteLine("Số này là số chẵn: " + num);
            }
            else
            {
                Console.WriteLine("Số này là số lẻ: " + num);
            }    
        }
    }
}
