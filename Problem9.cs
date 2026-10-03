using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 23, 91, 45, 91, 12 };

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                secondLargest = largest;
                largest = numbers[i];
            }
            else if (numbers[i] > secondLargest && numbers[i] != largest)
            {
                secondLargest = numbers[i];
            }
        }

        Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Largest: " + largest);
        Console.WriteLine("Second largest: " + secondLargest);
    }
}