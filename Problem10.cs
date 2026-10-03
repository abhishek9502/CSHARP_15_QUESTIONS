using System;

class Program
{
    static void Main()
    {
        int[,] marks =
        {
            { 80, 75, 78, 77 },
            { 85, 70, 75, 56 },
            { 87, 80, 82, 85 }
        };

        // Student totals
        for (int i = 0; i < 3; i++)
        {
            int total = 0;

            for (int j = 0; j < 4; j++)
            {
                total += marks[i, j];
            }

            Console.WriteLine($"Student {i + 1} total: {total}");
        }

        // Subject averages
        Console.Write("Subject averages: ");

        for (int j = 0; j < 4; j++)
        {
            int total = 0;

            for (int i = 0; i < 3; i++)
            {
                total += marks[i, j];
            }

            double average = (double)total / 3;

            Console.Write($"{average:F2} ");
        }
    }
}