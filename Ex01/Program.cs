using System;

namespace Ex01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // khai bao bien
            string ten, diaChi;
            int soDienThoai;
            // nhap thong tin
            Console.WriteLine("Nhap ten ");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi ");
            diaChi = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai");
            soDienThoai = Convert.ToInt32(Console.ReadLine());
            // dung man hinh
            Console.Read();
        }
    }
}