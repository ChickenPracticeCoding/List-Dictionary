using System;
using System.Collections.Generic;

namespace TH_Mang
{
    public class DictionaryStudent
    {
        static Dictionary<string, double> danhSachSinhVien = new Dictionary<string, double>()
        {
            { "Nguyễn Trung Kiên", 9.2},
            { "Nguyễn Tiến Hưng", 8.8 },
            { "Đoàn Trung Hậu", 9.9 },
            { "Trần Tiến Linh", 6.6 },
            { "Lý Đức Anh", 8.6 }
        };
        static List<KeyValuePair<string, double>> danhSach = new List<KeyValuePair<string, double>>(danhSachSinhVien);

        // Hàm sắp xếp danh sách sinh viên theo điểm từ cao đến thấp
        public static void Sap_Xep()
        {
            for (int i = 0; i < danhSach.Count - 1; i++) // Chạy từ 0 -> n-2
            {
                for (int j = 0; j < danhSach.Count - i - 1; j++) // Chạy từ 0 -> n-i-2
                {
                    if (danhSach[j].Value < danhSach[j + 1].Value)
                    {
                        // Hoán đổi vị trí
                        var tg = danhSach[j];
                        danhSach[j] = danhSach[j + 1];
                        danhSach[j + 1] = tg;
                    }
                }
            }
        }

        // Hàm xếp hạng
        public static void Rank()
        {
            Console.WriteLine("Danh sách xếp hạng sinh viên:");
            int rank = 1; // Thứ hạng ban đầu
            foreach (var sv in danhSach)
            {
                Console.WriteLine($"Hạng {rank}: {sv.Key} - Điểm: {sv.Value}");
            }
        }
    }
}
