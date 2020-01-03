public class Fibnaccci
{
    static long counter_recursive = 0;
    static long counter_iterative = 0;

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

}