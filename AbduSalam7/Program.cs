﻿using System;

namespace MrYusufAssignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number:  ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:  ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int total = num1 + num2;
            Console.WriteLine(total);


        }
    }
}
