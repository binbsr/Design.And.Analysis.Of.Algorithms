public class GCD
{
    public static long counter_recursive = 0;
    public static long counter_iterative = 0;

    public static int GCD_Recursive(int a, int b)
    {
        counter_recursive++;
        if (b == 0)
            return a;
        return GCD_Recursive(b, a % b);
    }

    public static int GCD_Iterative(int a, int b)
    {
        counter_iterative += 2;

        if (b == 0)
            return a;
        if (a == 0)
            return b;

        int t;
        while (b != 0)
        {
            counter_iterative ++;

            t = b;
            b = a % b;
            a = t;
        }

        return a;
    }

}