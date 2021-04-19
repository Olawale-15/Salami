using System;
using System.Diagnostics;
using System.Threading;
namespace AbdusSalam10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stopwatch stopwatch = new Stopwatch();
            // stopwatch.Start();

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
    Console.WriteLine("Second Number: " +number2);

    

    // int number1;
    // int number2;
    // float result;
    // Console.WriteLine("Enter First Number");
    // number1 = int.Parse(Console.ReadLine());
    // Console.WriteLine("Enter The Second Number");
    // number2 = int.Parse(Console.ReadLine());
    // result =  number1 / number2;
    // Console.WriteLine(result);
       
       


        }
    }
}
