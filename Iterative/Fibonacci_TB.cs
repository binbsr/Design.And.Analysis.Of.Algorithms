using System;

namespace Iterative
{
    public class Fibonacci_TB
    {
        public static void Print_NthFib_And_Steps_Table(int from = 3, int to = 20)
        {
            Console.WriteLine("############### Fibonacci Iterative ################");
            for (int i = from; i <= to; i++)
            {
                Fibonacci.counter_iterative = 0;
                Console.WriteLine($"{i}th Fib: {Fibonacci.Get_Nth_Iterative(i)}, Steps: {Fibonacci.counter_iterative}");
            }

            Console.WriteLine("############### Fibonacci Recursive ################");

            for (int i = from; i <= to; i++)
            {
                Fibonacci.counter_recursive = 0;
                Console.WriteLine($"{i}th Fib: {Fibonacci.Get_Nth_Recursive(i)}, Steps: {Fibonacci.counter_recursive}");
            }
        }
    }
}