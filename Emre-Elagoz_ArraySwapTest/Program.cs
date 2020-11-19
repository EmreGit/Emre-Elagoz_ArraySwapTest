using System;

namespace Emre_Elagoz_ArraySwapTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 1, 2, 3, 4, 5 };

            int[] newAges = { 7, 8, 9, 10, 11 };

            Console.WriteLine(string.Join(",", nums));

            Console.WriteLine(string.Join(",", newAges));
            Console.WriteLine(" ");

            for (int i = 0; i < 5; i++)
            {
                int a = nums[i];
                int b = newAges[i];

                nums[i] = b;
                newAges[i] = a;
            }

            Console.WriteLine(string.Join(",", nums));
            Console.WriteLine(string.Join(",", newAges));
        }
    }
}

