public class Fibonacci
{
    public static long counter_recursive = 0;
    public static long counter_iterative = 0;

    public static int Get_Nth_Recursive(int n)
    {
        counter_recursive += 2; //Two checks for each Get_Nth_Recursive(int n) call
        if (n == 1)
            return 0;
        if (n == 2)
            return 1;

        return Get_Nth_Recursive(n - 1) + Get_Nth_Recursive(n - 2);
    }
    public static long Get_Nth_Iterative(int n)
    {
        long[] fibs = new long[n];
        fibs[0] = 0;
        fibs[1] = 1;
        counter_iterative += 3; //For three assignments above

        for (int i = 2; i < n; i++)
        {
            counter_iterative++;
            fibs[i] = fibs[i - 1] + fibs[i - 2];
        }

        return fibs[n - 1];
    }

}