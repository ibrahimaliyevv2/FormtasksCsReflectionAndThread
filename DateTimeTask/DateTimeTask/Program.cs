using System;

namespace DateTimeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(date.DayOfWeek);
                }
        }
    }
}
