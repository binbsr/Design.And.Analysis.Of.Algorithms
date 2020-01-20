using System;
using System.Collections.Generic;

namespace Divide.And.Conquer
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] ages = { 12, 14, 17, 23, 34, 35, 38, 40, 45, 47, 50, 55, 66, 72 };
            BinarySearch.Items = ages;
            var index = BinarySearch.Search(0, ages.Length, 40);
            Console.WriteLine("Key index: " + index);
        }
    }
}
