namespace Iterative
{
    // Also known as Sequential Search
    public class LinearSearch
    {
        public static long Steps { get; set; } = 0;
        public static int Search(int[] items, int itemToFind)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Steps++;
                if (items[i] == itemToFind)
                    return i;
            }

            // Not found
            return -1;
        }
    }
}