using System;

namespace MrYusufssignment15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter three number:  ");
            if (n1 >= n2) 
            {
              if (n1 >= n3)
            Console.WriteLine("%.2lf is the largest number.", n1);
               else
            Console.WriteLine("%.2lf is the largest number.", n3);
            } 
            else {
                if (n2 >= n3)
                Console.WriteLine("%.2lf is the largest number.", n2);
                else
                Console.WriteLine("%.2lf is the largest number.", n3);
                }

            return 0;
        }
    }    
}