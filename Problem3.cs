
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 7, 3, 9, 7, 1, 3 };

        Dictionary<int, int> count = new Dictionary<int, int>();

        Console.WriteLine("Numbers: " + string.Join(", ", numbers));

        foreach (int num in numbers)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        Console.WriteLine("Duplicates:");

        foreach (KeyValuePair<int, int> item in count)
        {
            if (item.Value > 1)
            {
                Console.WriteLine($"{item.Key} appears {item.Value} times");
            }
        }
    }
}