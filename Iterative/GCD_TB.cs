using System;

namespace Iterative
{
    public class GCD_TB
    {
        public static void Print_GCD_And_Steps_Table(int first = 50, int second = 30)
        {
            Console.WriteLine("############### GCD Iterative ################");

            for (int i = first, j = second; i >= second; i--)
            {
                GCD.counter_iterative = 0;
                Console.WriteLine($"GCD of {i} and {j}: {GCD.GCD_Iterative(i, j)}, Steps: {GCD.counter_iterative}");
            }

            Console.WriteLine("############### GCD Recursive ################");

            for (int i = first, j = second; i >= second; i--)
            {
                GCD.counter_recursive = 0;
                Console.WriteLine($"GCD of {i} and {j}: {GCD.GCD_Recursive(i, j)}, Steps: {GCD.counter_recursive}");
            }
        }
    }
}