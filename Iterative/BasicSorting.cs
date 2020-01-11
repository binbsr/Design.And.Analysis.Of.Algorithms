public class BasicSorting
{
    public static long StepsBubble { get; set; } = 0;
    public static long StepsSelection { get; set; } = 0;
    public static long StepsInsertion { get; set; } = 0;

    public static int[] RunBubbleSort(int[] items)
    {
        var itemsCount = items.Length;
        for (int i = itemsCount - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                StepsBubble++; //Adding a step for a comparision below
                if (items[j] > items[j + 1])
                {
                    StepsBubble += 3; // Adding 3 steps for following 3 assignments for SWAP
                    var t = items[j];
                    items[j] = items[j + 1];
                    items[j + 1] = t;
                }
            }
        }

        return items;
    }

    public static int[] RunSelectionSort(int[] items)
    {
        int itemsCount = items.Length;
        int minIndex;
        for (int i = 0; i < itemsCount; i++)
        {
            minIndex = i;
            StepsSelection++;   // For a assignment above, increase counter by 1
            for (int j = i + 1; j < itemsCount; j++)
            {
                // For a comparision below, increase counter by 1
                StepsSelection++;
                if (items[j] < items[minIndex])
                {
                    minIndex = j;
                    StepsSelection++;   // For a assignment above, increase counter by 1
                }
            }
            var t = items[i];
            items[i] = items[minIndex];
            items[minIndex] = t;
            StepsSelection += 3;    // For 3 assignments above, increase counter by 3
        }

        return items;
    }

    public static int[] RunInsertionSort(int[] items)
    {
        for (int i = 1; i < items.Length; i++)
        {
            int key = items[i];
            int j = i - 1;
            while (j >= 0 && items[j] > key)
            {
                items[j + 1] = items[j];
                j--;
            }
            items[j + 1] = key;
        }

        return items;
    }
}