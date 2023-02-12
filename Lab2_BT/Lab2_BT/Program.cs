using System;

namespace Lab2_BT
{
    class Program
    {
        //Bai1
        static void Main1(string[] b1)
        {
            int n = int.Parse(Console.ReadLine());
            int i;
            int s = 0;
            for ( i = 0; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    s += i;
                }
            }
            Console.WriteLine(s);
        }
        // Bai2
        static void Main2(string[] b2)
        {
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            int i;
            for(i = 1; i <= n; i++)
            {
                s = s + 1.0/i;
            }
            Console.WriteLine(s);
        }
        // Bai3
        static void Main3(string[] b3)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = int.Parse(Console.ReadLine());
            int i;
            int cnt = 0;
            for (i = 2; i < n; i++) // 7
            {
                  if(n % i == 0)
                {
                    cnt++;
                }
            }    
            if(cnt == 0 )
            {
                Console.WriteLine(n + " là số nguyên tố");
            }
            else
            {
                Console.WriteLine(n + " không là số nguyên tố");
            }    
        }
        //Bai4
        static void Main4(string[] b4)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("ba cạnh không là chiều dài của một tam giác!");
            }
            else if (a == b & a == c & b == c)
            {
                Console.WriteLine("ba cạnh là tam giác đều!");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("ba cạnh là tam giác cân");
            }    
            else if (Math.Pow(c,2) == Math.Pow(a,2) + Math.Pow(b,2) || Math.Pow(a, 2) == Math.Pow(c, 2) + Math.Pow(b, 2) || Math.Pow(b, 2) == Math.Pow(c, 2) + Math.Pow(a, 2))
            {
                Console.WriteLine("ba cạnh là tam giác vuông");
            }
            else
            {
                Console.WriteLine("ba cạnh là tam giác thường");
            }
        }
        //Bai5
        static void Main(string[] b5)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                Console.Write("{0} ",Fb(i));
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static int Fb(int n)
        {
            int ft = 0;
            int fs = 1;
            int fn = 1;
            int i;
            if (n < 0)
            {
                return -1;
            }
            else if(n == 0 || n == 1)
            {
                return n;
            }
            else    
            {
                for(i = 2; i < n; i++)
                {
                    ft = fs;
                    fs = fn;
                    fn = ft + fs;
                }
            }
            return fn;
        }
    }
}


