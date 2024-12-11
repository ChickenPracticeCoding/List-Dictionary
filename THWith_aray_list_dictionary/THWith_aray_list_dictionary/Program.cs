using System.Text;

namespace THWith_aray_list_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Lọc học sinh tên Hiếu sử dụng với mảng ARRAY");
            Arr();
            Console.WriteLine(new string('-', 35));
            Console.WriteLine("Lọc học sinh tên Hiếu sử dụng với mảng LIST");
            List();
            Console.WriteLine(new string('-', 35));
            Console.WriteLine("Lọc học sinh tên Hiếu sử dụng với mảng DICTIONARY");
            Dic();
            Console.WriteLine(new string('-', 35));
        }

        public static void Arr()
        {
            var name = new string[,]
           {
                { "Hiếu", "18", "2006-05-15" },
                { "Minh", "17", "2007-08-20" },
                { "Hiếu", "19", "2005-12-10" },
                { "Hiếu", "19", "2004-10-10" },
                { "Lan", "18", "2006-03-22" },
                { "Hương", "20", "2004-09-12" }
           };
            Console.WriteLine($"{"STT",-5} {"Tên",-10} {"Tuổi",-5} {"Ngày sinh",-12}");
 

            int stt = 1;
            for (int i = 0; i < name.GetLength(0); i++)
            {
                if (name[i, 0] == "Hiếu")
                {
                    Console.WriteLine($"{stt,-5} {name[i, 0],-10} {name[i, 1],-5} {name[i, 2],-12}");
                    stt++;
                }
            }
        }
        static void List()
        {
            // Tạo danh sách
            List<(string Name, int Age, string Dob)> students = new List<(string, int, string)>
        {
            ("Hiếu", 18, "2006-05-15"),
            ("Minh", 17, "2007-08-20"),
            ("Hiếu", 19, "2005-12-10"),
            ("Lan", 18, "2006-03-22"),
            ("Hương", 20, "2004-09-12")
        };

            // Tìm kiếm và in kết quả
            Console.WriteLine($"{"STT",-5} {"Tên",-10} {"Tuổi",-5} {"Ngày sinh",-12}");
            int stt = 1;
            foreach (var student in students)
            {
                if (student.Name == "Hiếu")
                {
                    Console.WriteLine($"{stt,-5} {student.Name,-10} {student.Age,-5} {student.Dob,-12}");
                    stt++;
                }
            }
        }
        static void Dic()
        {
            // Khởi tạo từ điển
            var students = new Dictionary<int, Dictionary<string, object>>
        {
            {
                1, new Dictionary<string, object>
                {
                    { "Name", "Hiếu" },
                    { "Age", 18 },
                    { "Dob", "2006-05-15" }
                }
            },
            {
                2, new Dictionary<string, object>
                {
                    { "Name", "Minh" },
                    { "Age", 17 },
                    { "Dob", "2007-08-20" }
                }
            },
            {
                3, new Dictionary<string, object>
                {
                    { "Name", "Hiếu" },
                    { "Age", 19 },
                    { "Dob", "2005-12-10" }
                }
            },
            {
                4, new Dictionary<string, object>
                {
                    { "Name", "Lan" },
                    { "Age", 18 },
                    { "Dob", "2006-03-22" }
                }
            },
            {
                5, new Dictionary<string, object>
                {
                    { "Name", "Hương" },
                    { "Age", 20 },
                    { "Dob", "2004-09-12" }
                }
            }
        };

            // Tìm và in danh sách các bạn tên "Hiếu"
            Console.WriteLine($"{"STT",-5} {"Tên",-10} {"Tuổi",-5} {"Ngày sinh",-12}");

            foreach (var student in students)
            {
                if (student.Value["Name"].ToString() == "Hiếu")
                {
                    Console.WriteLine($"{student.Key,-5} {student.Value["Name"],-10} {student.Value["Age"],-5} {student.Value["Dob"],-12}");
                }
            }
        }
    }
}
