using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Before: " + string.Join(" ", numbers));

        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            int temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;

            left++;
            right--;
        }

        Console.WriteLine("After: " + string.Join(" ", numbers));
    }
}