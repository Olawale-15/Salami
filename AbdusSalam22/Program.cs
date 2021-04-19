using System;

namespace AbdusSalam
{
    class Program
    {
        static void Main(string[] args)
        {
            
        int test(int nums , int arr_size)
         {
            for (int i = 0; i < arr_size - 1; i++)
             {
                if (nums[i] == 5 && nums[i] == nums[i + 1]) return 1;
              }
            return 0;
         }


        }
    }
}
