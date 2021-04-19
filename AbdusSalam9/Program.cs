using System;

namespace MrYusufssingment9
{
    class Program
    {
        static void Main(string[] args)
        {
             int number1;
    int number2;
    int qayyum;
    Console.WriteLine("Input First Number");
    number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input Second Number");
    number2 = int.Parse(Console.ReadLine());
    qayyum = number1;
    number1 = number2;
    number2 = qayyum;
    Console.WriteLine("Swapping : ");
    Console.WriteLine("First Number: " +number1);
    Console.WriteLine("Second Number: " +number2)
        }
    }
}
