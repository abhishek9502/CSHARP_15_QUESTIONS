using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> items = new List<string>();

        // Add four items
        items.Add("Milk");
        items.Add("Eggs");
        items.Add("Bread");
        items.Add("Butter");

        // Insert at the start
        items.Insert(0, "Rice");

        // Remove one by value
        items.Remove("Rice");

        // Remove one by index
        items.RemoveAt(3);

        // Print final list
        Console.WriteLine("Final list: " + string.Join(", ", items));
        Console.WriteLine("Items: " + items.Count);
    }
}