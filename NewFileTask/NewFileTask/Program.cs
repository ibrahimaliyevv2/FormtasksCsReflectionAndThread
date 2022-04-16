using System;
using System.IO;

namespace NewFileTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            char choose = ' ';
            do
            {
                Console.WriteLine("Folder adi daxil edin:");
                string folderName = Console.ReadLine();
                string givenPath = @"C:\Users\ibrahimaliyevv2\Desktop\dir2\";
                DirectoryInfo dirInfo = new DirectoryInfo(givenPath+folderName);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                Console.WriteLine("Yeni folder yaratmaq isteyirsinizmi?");
                choose = Convert.ToChar(Console.ReadLine());
                switch (choose)
                {
                    case 'y':
                        if (!dirInfo.Exists)
                        {
                            dirInfo.Create();
                        }
                        break;
                    case 'n':
                        foreach (var item in dirInfo.GetFiles())
                        {
                                Console.WriteLine(item.Name + " " + item.CreationTime);
                        }
                        break;
                    default:
                        Console.WriteLine("wrong option");
                        check = false;
                        break;
                }

            } while (check);
        }
    }
}
