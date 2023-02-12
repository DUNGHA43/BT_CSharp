using System;

namespace BTlab1
{
    class lab1
    {
        // Bai1_Lab1
        static void Main1(string[] b1)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Rằm Tháng Riêng");
            Console.WriteLine("Rằm Xuân lồng lộng trăng soi,");
            Console.WriteLine("Sông xuân nước lẫn màu trời thêm xuân.");
            Console.WriteLine("Giữa dòng bàn bạc việc quân");
            Console.WriteLine("Khuya về bát ngát trăng ngân đầy thuyền.");
            Console.WriteLine("Hồ Chí Minh");
        }
        // Bai2_Lab1
        static void Main2(string[] b2)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập chiều cao hình trụ: ");
            float h = float.Parse(Console.ReadLine());
            Console.Write("Nhập bán kính hình trụ: ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Sxq = " + 2 * Math.PI * r * h);
            Console.WriteLine("V = " + Math.PI * Math.Pow(r, 2) * h);
        }
        // Bai3_lab1
        static void Main3(string[] b3)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = int.Parse(Console.ReadLine());
            string mstr = n.ToString();
            string str = "";
            for (int i = 0; i < mstr.Length; i++)
            {
                switch (mstr[i])
                {
                    case '1':
                        str += "Mot ";
                        break;
                    case '2':
                        str += "Hai ";
                        break;
                    case '3':
                        str += "Ba ";
                        break;
                    case '4':
                        str += "Bốn ";
                        break;
                    case '5':
                        str += "Năm ";
                        break;
                    case '6':
                        str += "Sáu ";
                        break;
                    case '7':
                        str += "Bảy ";
                        break;
                    case '8':
                        str += "Tám ";
                        break;
                    case '9':
                        str += "Chin ";
                        break;
                }
            }
            Console.WriteLine(str);
        }
    

    // Bai4_Lab1
    static void Main(string[] b4)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int n;
        do
        {
            Console.WriteLine("||-------------------------------||");
            Console.WriteLine("||1.Hiển thị tam giác vuông đặc  ||");
            Console.WriteLine("||2.Hiển thị tam giác vuông rỗng ||");
            Console.WriteLine("||3.Hiển thị hình vuông rỗng     ||");
            Console.WriteLine("||-------------------------------||");
            Console.Write("Chọn: ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        int x = 9;
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        //Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        int y = 9;
                        for (int i = 0; i < y; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                if (i == 0 || i == 1 || i == y - 1)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    if (j == 0 || j == i)
                                    {
                                        Console.Write("*");
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }

                                }

                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case 3:
                    {
                        int z = 9;
                        for (int i = 0; i < z; i++)
                        {
                            for (int j = 0; j < z; j++)
                            {
                                if (i == 0 || i == z - 1 || j == 0 || j == z - 1)
                                {
                                    Console.Write("* ");
                                }
                                else
                                {
                                    Console.Write("  ");
                                }
                            }
                            Console.WriteLine("");
                        }
                        //Console.ReadKey();
                        break;
                    }
            }
        } while (n != 0);
    }
}
}