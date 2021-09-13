using System;

namespace Ex02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Nhap vao so thu 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu 2");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu 3");
            c = int.Parse(Console.ReadLine());
            
            int max = a;
            
            if (max < b)
            {
                max = b;
            }

            if (max < c) {
                max = c;
            }

            switch (max > b)
            {
                case  true :
                    switch (max > c)
                    {
                       case false:
                           max = c;
                           break;
                    }
                    break;
                case false:
                    max = b;
                    break;
            }

            Console.WriteLine("Max tu ba so nguyen{0},{1},{2}, la {3}", a,b,c, max);
            Console.ReadKey();
        }
    }
}