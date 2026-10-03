using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> listA = new List<int> { 3, 7, 1, 9 };
        List<int> listB = new List<int> { 7, 4, 9, 2 };

        List<int> merged = new List<int>();

        foreach (int num in listA)
        {
            if (!merged.Contains(num))
            {
                merged.Add(num);
            }
        }

        foreach (int num in listB)
        {
            if (!merged.Contains(num))
            {
                merged.Add(num);
            }
        }

        // Sort the merged list
        merged.Sort();

        Console.WriteLine("List A: " + string.Join(", ", listA));
        Console.WriteLine("List B: " + string.Join(", ", listB));
        Console.WriteLine("Merged: " + string.Join(", ", merged));
    }
}