using System;

namespace Ex04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tu 1- 9 \n");
            int num = Int32.Parse(Console.ReadLine());
            int soNhan;
           
            soNhan = 1;
            do
            {
                Console.WriteLine("{0} x {1} = {2}",
                    num, soNhan, num * soNhan);
            } while (soNhan <= 10);
            Console.WriteLine();
            num++;
            
        }
    }
}