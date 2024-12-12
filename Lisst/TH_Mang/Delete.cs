using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_Mang
{
    internal class Delete
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
