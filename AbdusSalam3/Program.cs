using System;

namespace MrYusufssingment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any value");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("{0}*{1} = {2}", num, i, num*i);
            }
            
        }
    }
}
