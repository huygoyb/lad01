using System;

namespace Lad1_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int inVal;
            double dblVal;
            string strVal;
            inVal = 10;
            dblVal = 3.142;
            strVal = "Fpt Aptech";
            Console.WriteLine("{0} is an integer value", inVal);
            Console.WriteLine("{0} is an double value", dblVal);
            Console.WriteLine("{0} is an string value", strVal);
            Console.ReadLine();
        }
    }
}