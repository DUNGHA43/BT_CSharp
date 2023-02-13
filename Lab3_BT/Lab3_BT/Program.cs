using System;
using System.Linq;
namespace Lab3_BT
{
    class program
    {
        
        // Bai 1
        public class So
        {  
            static float Cong (float x, float y)
            {
                return x + y;
            }
            static float Tru (float x, float y)
            {
                return x - y;
            }
            static float Nhan (float x, float y)
            {
                return x * y;
            }
            static float Chia (float x, float y)
            {
                return x / y;
            }
            static void Main1(string[] b1)
            {
                float x = float.Parse(Console.ReadLine());
                float y = float.Parse(Console.ReadLine());
                Console.WriteLine("x + y: "+Cong(x, y));
                Console.WriteLine("x - y: "+Tru(x, y));
                Console.WriteLine("x * y: " + Nhan(x, y));
                Console.WriteLine("x / y: " + Chia(x, y));
            }
        }

        //Bai2
        class Tamgiac
        {
            double a = 5;
            double b = 8;
            double c = 6;
            static double chuvi(double a, double b, double c)
            {
                return a + b + c;
            }
            static double dientich(double a, double b, double c)
            { 
                double p = (a + b + c)/2;                          // nửa chu vi
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Theo công thức Heron
            }
            static void loaitamgiac(double a, double b, double c)
            {
                Tamgiac ca = new Tamgiac();
                Tamgiac cb = new Tamgiac();
                Tamgiac cc = new Tamgiac();
                if (ca.a + cb.b < cc.c || ca.a + cc.c < cb.b || cb.b + cc.c < ca.a)
                {
                    Console.WriteLine("Ba cạnh không là chiều dài của tam giác");
                }
                else if (ca.a == cb.b && ca.a == cc.c && cb.b == cc.c)
                {
                    Console.WriteLine("Ba cạnh là tam giác đều");
                }
                else if (ca.a == cb.b || ca.a == cc.c || cb.b == cc.c)
                {
                    Console.WriteLine("Ba cạnh là tam giác cân");
                }    
                else if (Math.Pow(ca.a, 2) == Math.Pow(cb.b, 2) + Math.Pow(cc.c, 2) || Math.Pow(cb.b, 2) == Math.Pow(ca.a, 2) + Math.Pow(cc.c, 2) || Math.Pow(cc.c, 2) == Math.Pow(ca.a, 2) + Math.Pow(cb.b, 2))
                {
                    Console.WriteLine("Ba cạnh là tam giác vuông");
                }
                else { Console.WriteLine("Ba cạnh là tam giác thường"); }
            }
            static void Main2(string[] b2)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Tamgiac ca = new Tamgiac();
                Tamgiac cb = new Tamgiac();
                Tamgiac cc = new Tamgiac();
                Console.WriteLine("Chu vi: "+chuvi(ca.a, cb.b, cc.c));
                Console.WriteLine("Diện tích: "+dientich(ca.a,cb.b,cc.c));
                loaitamgiac(ca.a,cb.b,cc.c);
            }
        }

        // Bai3
        class SV
        {
            string hoten;
            string lop;
            string khoa;
            float diem;

            public SV()
            {
                hoten = "HÀ TIẾN DŨNG";
                lop = "DCCNTT12.10.12";
                khoa = "K12";
                diem = 9.5F;
            }
            static void outPutSV()
            {
                SV sv = new SV();
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("||       HỌTÊN       ||        LỚP        ||     KHÓA     ||   ĐIỂM   ||");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("||   " + sv.hoten + "    |" + "|  " + sv.lop + "   |" + "|      " + sv.khoa + "     |" + "|    " + sv.diem + "   ||");
                Console.WriteLine("------------------------------------------------------------------------");
            }
            static void Main3(string[] b3)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                outPutSV();
            }
        }

        //Bai4
        class Diem
        {
            double[] tdx = {1,2};
            double[] tdy = {-3,4};

            static void khoangcach()
            {
                Diem diem= new Diem();
                double kc = Math.Sqrt(Math.Pow((diem.tdy[0] - diem.tdx[0]), 2) + Math.Pow((diem.tdy[1] - diem.tdx[1]), 2));
                Console.Write("Khoảng cách từ điểm x[1,2] đến điểm y[-3,4] là: "+ kc);
            }
            static void Main(string[] b4)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                khoangcach();
            }
        }
    }
}
