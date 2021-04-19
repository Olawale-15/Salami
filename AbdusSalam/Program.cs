using System;

namespace AbdusSalam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            double number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            string value = Console.ReadLine();

            Console.WriteLine("Enter  second number");
            double number2 = Convert.ToInt32(Console.ReadLine());

            double total = number1 / number2;
            Console.WriteLine(total);
        }
    }
}
