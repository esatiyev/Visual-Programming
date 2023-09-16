using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            /*string name, surname;
            name = Console.ReadLine();
            surname = Console.ReadLine();
            
            Console.WriteLine("Your fullname is {0} {1}!", name, surname);*/
            DateTime dateTime = DateTime.Now;
            DateTime dateTime1 = new DateTime(2023, 09, 18);
            Console.WriteLine(dateTime.AddDays(1));
            Console.WriteLine(dateTime1);

            //Console.WriteLine(DateOnly.FromDateTime(dateTime))
            DateTime dateFromString = DateTime.Parse("14/09/2026"); // or "2026/09/14"  => "yy/mm/dd" or "dd/mm/yy"
            Console.WriteLine(dateFromString);
        }
    }
}
