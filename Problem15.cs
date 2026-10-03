using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine().ToLower();

        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char ch in word)
        {
            if (count.ContainsKey(ch))
            {
                count[ch]++;
            }
            else
            {
                count[ch] = 1;
            }
        }

        foreach (KeyValuePair<char, int> item in count)
        {
            Console.Write($"{item.Key}:{item.Value} ");
        }
    }
}