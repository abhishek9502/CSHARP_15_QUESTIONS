using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Console.Write("Before: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        int n = arr.Length;
        k = k % n;

        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[(i + k) % n] = arr[i];
        }

        Console.WriteLine();
        Console.Write("After: ");

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}