public class GCD
{
    public static int GCD_Recursive(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD_Recursive(b, a % b);
    }

    public static int GCD_Iterative(int a, int b)
    {
        if (b == 0)
            return a;
        if (a == 0)
            return b;

        int t;
        while (b != 0)
        {
            t = b;
            b = a % b;
            a = t;
        }

        return a;
    }

}