using System;

namespace Ex05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Cac so nguyen to tu 1 - 20 la: \n");
            for (i = 0; i < 20; i++)
            {
                if (isPrimeNumber(i))
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        static Boolean isPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai so nguyen to
            if (n < 2)
            {
                return false;
            }
            // kiem tra so nguyen to khi n>2
            int squareRoot = (int) Math.Sqrt(n);
            int i;
            for ( i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }   
            }

            return true;
        }
    }
}