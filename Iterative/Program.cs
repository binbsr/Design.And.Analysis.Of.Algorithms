using System;

namespace Iterative
{
    class Program
    {
        static void Main(string[] args)
        {
            int nth = 90;
            int fibNum = Fib_Recursive(nth);
            Console.WriteLine(nth + "th fibonacci number: " + fibNum);
        }

        static int Fib_Recursive(int n)
        {
            if (n == 1)
                return 0;

            if (n == 2)
                return 1;

            return Fib_Recursive(n - 1) + Fib_Recursive(n - 2);
        }
    }
}
