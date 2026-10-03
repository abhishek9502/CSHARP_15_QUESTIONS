using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 12, 7, 8, 19, 44, 3, 25 };

        List<int> evens = new List<int>();
        List<int> odds = new List<int>();

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                evens.Add(num);
            }
            else
            {
                odds.Add(num);
            }
        }

        Console.WriteLine($"Evens ({evens.Count}): " + string.Join(", ", evens));
        Console.WriteLine($"Odds ({odds.Count}): " + string.Join(", ", odds));
    }
}