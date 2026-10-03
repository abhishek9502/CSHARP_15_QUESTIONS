using System;

class Program
{
    static void Main()
    {
        int[] marks = { 78, 92, 65, 88, 71 };

        int total = 0;
        int highest = marks[0];
        int lowest = marks[0];

        for (int i = 0; i < marks.Length; i++)
        {
            total += marks[i];

            if (marks[i] > highest)
            {
                highest = marks[i];
            }

            if (marks[i] < lowest)
            {
                lowest = marks[i];
            }
        }

        double average = (double)total / marks.Length;

        Console.WriteLine("Marks: " + string.Join(", ", marks));
        Console.WriteLine("Total: " + total);
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine("Highest: " + highest);
        Console.WriteLine("Lowest: " + lowest);
    }
}