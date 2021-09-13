using System;

namespace Lad1_03
{
    internal class Program
    {
        public static void Main(string[] args) {
            int valueVal = 5;
            Test(valueVal);
            Console.WriteLine("The value of the variable is {0}", valueVal);
            Console.ReadLine();
        }

        static void Test(int value) {
            int temp = 5;
            value = temp * 2;
        }
    }
}