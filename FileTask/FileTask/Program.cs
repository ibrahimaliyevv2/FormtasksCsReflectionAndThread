using System;
using System.IO;

namespace FileTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFiles = @"C:\Users\ibrahimaliyevv2\Desktop\dir1";
            DirectoryInfo dirInfo = new DirectoryInfo(pathFiles);

            Console.WriteLine("Enter first date:");
            DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter second date:");
            DateTime secondDate = Convert.ToDateTime(Console.ReadLine());

            foreach (var item in dirInfo.GetFiles())
            {
                if (item.CreationTime>firstDate && item.CreationTime<secondDate)
                {
                    Console.WriteLine(item.Name);
                }
            }

        }
    }
}
