using System;

namespace Mryusuifssignment21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 0, 9, 6, 4, 3, 2};
            Array.Sort(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
