using System;

namespace Iterative
{
    public class Program
    {
        static long counter_recursive = 0;
        static long counter_iterative = 0;

        static void Main(string[] args)
        {
            int from = 3;
            int to = 20;

            Console.WriteLine("############### Fibonacci Iterative ################");            
            for (int i = from; i <= to; i++)
            {
                counter_iterative = 0;
                Console.WriteLine($"{i}th Fib: {Fib_Iterative(i)}, Steps: {counter_iterative}");
            }

            Console.WriteLine("############### Fibonacci Recursive ################");

            for (int i = from; i <= to; i++)
            {
                counter_recursive = 0;
                Console.WriteLine($"{i}th Fib: {Fib_Recursive(i)}, Steps: {counter_recursive}");
            }
        }

        public static int Fib_Recursive(int n)
        {
            counter_recursive++;
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;

            return Fib_Recursive(n - 1) + Fib_Recursive(n - 2);
        }
        public static long Fib_Iterative(int n)
        {
            long[] fibs = new long[n];

            fibs[0] = 0;
            fibs[1] = 1;

            for (int i = 2; i < n; i++)
            {
                counter_iterative++;
                fibs[i] = fibs[i - 1] + fibs[i - 2];
            }

            return fibs[n - 1];
        }

        public static int GCD_Recursive(int a, int b)
        {
            return 0;
        }

        public static int GCD_Iterative(int a, int b)
        {
            return 0;
        }
    }
}
