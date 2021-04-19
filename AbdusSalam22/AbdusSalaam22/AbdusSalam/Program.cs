using System;

namespace MrYusufassingment20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your year:  ");
            int year = Convert.ToInt32(Console.ReadLine());

            int total = year / 100 + 2;
            
            Console.WriteLine(total);
        }
    }
}
