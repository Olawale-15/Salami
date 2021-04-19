using System;

namespace MrYusufAssignment8
{
    class Program
    {
        static void Main(string[] args)
        {
                Question4 question4 = new Question4();

           question4.CalculatorInput();
        double fahrenheit;

         double celsius = 36;
         Console.WriteLine("Celsius: " + celsius);

         fahrenheit = (celsius * 9) / 5 + 32;
         Console.WriteLine("Fahrenheit: " + fahrenheit);

         Console.ReadLine();
        }
    }
}
