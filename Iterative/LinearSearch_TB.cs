
using System;
using System.Linq;
using Iterative;

public class LinearSearch_TB
{
    public static void Print_LinearSearch_Results_And_Steps(int from = 1, int to =  10000)
    {
        Console.WriteLine("############################ Sequential Search #############################");
        Console.WriteLine("############################################################################");
        Console.WriteLine($"{"Array Size", 15}{"Item To Find", 20}{"Found Index", 20}{"Steps Taken", 20}");
            
        for (int i = from; i <= to; i = i * 10)  // Increase input size 10 times
        {
            LinearSearch.Steps = 0;
            var items = GenerateSequence(i);
            var itemToFind = GetRandomNumberBetween(0, i);  // We could have chosen fixed number
            Console.WriteLine($"{i, 15}{itemToFind, 20}{LinearSearch.Search(items, itemToFind), 20}{LinearSearch.Steps, 20}");
        }
    }

    private static int GetRandomNumberBetween(int from, int to)
    {
        Random r = new Random();
        return r.Next(from, to);
    }

    private static int[] GenerateSequence(int n, int seed = 0)
        => Enumerable.Range(seed, n).ToArray();
}