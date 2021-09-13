using System;

namespace Ex03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap 1 so tu 1-7");
            int thu = Int32.Parse(Console.ReadLine());

            DateTime date = new DateTime(thu);
            
            Console.WriteLine(date.DayOfWeek);
            Console.ReadKey();
        }
    }
}