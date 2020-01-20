using System.Collections.Generic;
public class BinarySearch
{
    public static short[] Items { get; set; }
    public static int Search(int lower, int upper, short key)
    {
        if(lower > upper)
            return -1;

        int mid = (lower + upper) / 2;
        if (Items[mid] == key)
            return mid;

        if (Items[mid] < key)
            return Search(mid + 1, upper, key);
        else
           return Search(lower, mid - 1, key);
        
    }
}