using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_Mang
{
    internal class Add_Show
    {
        static List<int> so_nguyen = new List<int>();
        public static void Nhap()
        {
            Console.Write("Vui lòng nhập số lượng số nguyên cần nhập: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            while (dem < n)
            {
                Console.Write($"Số {dem + 1}: ");
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
        public static void MinMax()
        {
            int min = so_nguyen[0];
            int max = so_nguyen[0];

            foreach (int num in so_nguyen)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"Giá trị nhỏ nhất (Min): {min}");
            Console.WriteLine($"Giá trị lớn nhất (Max): {max}");
        }
        public static void SapXep()
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
        public static void Xoa()
        {
            Console.Write("Nhập số cần xóa: ");
            string inputString1 = Console.ReadLine();
            bool passSuccess1 = int.TryParse(inputString1, out int number1);

            if (passSuccess1 && so_nguyen.Contains(number1))
            {
                so_nguyen.Remove(number1);
                Console.WriteLine($"Đã xóa: {number1}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy số trong danh sách hoặc input không hợp lệ.");
            }
        }
    }
}

