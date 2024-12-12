using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_Mang
{
    internal class SapXep
    {
        static List<int> so_nguyen = new List<int>();
        public static void Nhap()
        {
            Console.Write("Nhập số lượng số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;

            while (dem < n)
            {
                Console.Write($"Nhập số thứ {dem + 1}: ");
                string inputString = Console.ReadLine();
                bool passSuccess = int.TryParse(inputString, out int number);

                if (passSuccess)
                {
                    so_nguyen.Add(number);
                    dem++;
                }
                else
                {
                    Console.WriteLine("Input không hợp lệ. Vui lòng nhập một số nguyên.");
                }
            }
        }
        public static void Xuat()
        {
            if (so_nguyen.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
            }
            else
            {
                Console.WriteLine("Danh sách các số đã nhập:");
                foreach (int num in so_nguyen)
                {
                    Console.WriteLine(num);
                }
            }
        }
        public static void sort()
        {
            if (so_nguyen.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng. Không thể sắp xếp.");
                return;
            }

            so_nguyen.Sort();
            Console.WriteLine("Danh sách đã được sắp xếp tăng dần:");
            Xuat();
        }

    }
}
