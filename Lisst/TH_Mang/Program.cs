using System.Text;

namespace TH_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\nChọn chức năng:");
                Console.WriteLine("1. Nhập số");
                Console.WriteLine("2. Xuất danh sách");
                Console.WriteLine("3. Tìm Min và Max");
                Console.WriteLine("4. Xóa phần tử");
                Console.WriteLine("5. Sắp xếp mảng và in mảng");
                Console.WriteLine("6. Thoát");
                Console.WriteLine("--------------------------");
                Console.Write("Lựa chọn của bạn: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Add_Show.Nhap();
                        break;
                    case "2":
                        Add_Show.Xuat();
                        break;
                    case "3":
                        Add_Show.MinMax();
                        break;
                    case "4":
                        Add_Show.Xoa();
                        break;
                    case "5":
                        Add_Show.SapXep();
                        break;
                    case "6":
                        Console.WriteLine("Thoát chương trình. Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}
