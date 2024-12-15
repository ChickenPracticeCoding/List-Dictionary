using System.Text;

namespace TH_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.OutputEncoding = Encoding.UTF8;
                Add_Show.Nhap();
                MenuAgain:
                Console.WriteLine("\nChọn chức năng:");
                Console.WriteLine("1. Xuất danh sách");
                Console.WriteLine("2. Tìm Min và Max");
                Console.WriteLine("3. Xóa phần tử");
                Console.WriteLine("4. Sắp xếp mảng và in mảng");
                Console.WriteLine("5. Thoát");
                Console.WriteLine("--------------------------");
                Console.Write("Lựa chọn của bạn: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Add_Show.Xuat();
                        goto MenuAgain;
                    case "2":
                        Add_Show.MinMax();
                        goto MenuAgain;
                    case "3":
                        Add_Show.Xoa();
                        goto MenuAgain;
                    case "4":
                        Add_Show.SapXep();
                        goto MenuAgain;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        goto MenuAgain;
                    case "5":
                        Console.WriteLine("Thoát chương trình. Tạm biệt!");
                        break;
                }
            }*/
            DictionaryStudent.Sap_Xep();
            DictionaryStudent.Rank();
        }
    }
}