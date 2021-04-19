using System;

namespace Mryusufssignment22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 4, 5, 6, 0, 8, 9 };

           int test(int number[], int arrSize)
         {
           for (int i = 0; i < arrSize - 1; i++)
            {
                if (number[i] == 5 && number[i] == number[i + 1]) return 1;
            }
            return 0;
         }

        }
    }
}
