using System;
using System.Linq;
using System.Collections;

namespace Iterative
{
    public class BasicSorting_TB
    {
        public static void Print_SortedItems_And_Steps_Table(int from = 1, int to = 100000)
        {
            Console.WriteLine("############### Basic Sorting: Bubble, Selection, Insertion ################");
            Console.WriteLine("############################################################################");
            Console.WriteLine("1. Random Arrays\n");
            Console.WriteLine($"{"Array Size", 15}{"Bubble Steps", 20}{"Selection Steps", 20}{"Insertion Steps", 20}");            
            for (int i = from; i <= to; i = i * 10)
            {
                BasicSorting.StepsBubble = 0;
                BasicSorting.StepsSelection = 0;               
                var items = GenerateRandomArray(i);
                BasicSorting.RunBubbleSort(items);
                BasicSorting.RunSelectionSort(items);
                Console.Write($"{i, 15:N0}{BasicSorting.StepsBubble, 20:N0}{BasicSorting.StepsSelection, 20:N0}");
                Console.WriteLine();
            }

            Console.WriteLine("2. Sorted Arrays\n");
            Console.WriteLine($"{"Array Size", 15}{"Bubble Steps", 20}{"Selection Steps", 20}{"Insertion Steps", 20}");            
            for (int i = from; i <= to; i = i * 10)
            {
                BasicSorting.StepsBubble = 0;
                BasicSorting.StepsSelection = 0;
                var items = GenerateRandomArray(i, sorted: true);
                BasicSorting.RunBubbleSort(items);
                BasicSorting.RunSelectionSort(items);
                Console.Write($"{i, 15:N0}{BasicSorting.StepsBubble, 20:N0}{BasicSorting.StepsSelection, 20:N0}");
                Console.WriteLine();
            }

            Console.WriteLine("3. Reverse Sorted Arrays\n");
            Console.WriteLine($"{"Array Size", 15}{"Bubble Steps", 20}{"Selection Steps", 20}{"Insertion Steps", 20}");            
            for (int i = from; i <= to; i = i * 10)
            {
                BasicSorting.StepsBubble = 0;
                BasicSorting.StepsSelection = 0;
                var items = GenerateRandomArray(i, sorted: true, ascending: false);
                BasicSorting.RunBubbleSort(items);
                BasicSorting.RunSelectionSort(items);
                Console.Write($"{i, 15:N0}{BasicSorting.StepsBubble, 20:N0}{BasicSorting.StepsSelection, 20:N0}");
                Console.WriteLine();
            }
        }

        private static int[] GenerateRandomArray(int n, bool sorted = false, bool ascending = true)
        {
            Random r = new Random();
            int[] items = new int[n];

            for (int i = 0; i < n; i++)
            {
                items[i] = r.Next(1, n);
            }

            if(sorted)
            {
                // Using built-in sorting algorithms
                if(ascending)
                    Array.Sort(items);
                else
                    Array.Reverse(items);
            }           

            return items;
        }
    }
}