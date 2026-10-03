using System;

class Program
{
    static void Main()
    {
        int[] marks = { 78, 92, 65, 88, 71 };

        int total = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            total += marks[i];
        }

        double average = (double)total / marks.Length;

        int above = 0;
        int below = 0;
        int equal = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            if (marks[i] > average)
            {
                above++;
            }
            else if (marks[i] < average)
            {
                below++;
            }
            else
            {
                equal++;
            }
        }

        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Above: {above}");
        Console.WriteLine($"Below: {below}");
        Console.WriteLine($"Equal: {equal}");
    }
}