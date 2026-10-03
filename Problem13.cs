using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Amit", "Priya", "Kiran", "Raj", "Meera"
        };

        Console.WriteLine("Before: " + string.Join(", ", names));

        for (int i = names.Count - 1; i >= 0; i--)
        {
            if (names[i].Length < 5)
            {
                names.RemoveAt(i);
            }
        }

        Console.WriteLine("After: " + string.Join(", ", names));
    }
}