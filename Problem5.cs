using System;

class Program
{
    static void Main()
    {
        for (int attempt = 1; attempt <= 3; attempt++)
        {
            try
            {
                Console.Write($"Attempt {attempt}: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine($"You entered {number}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number");

                if (attempt == 3)
                {
                    Console.WriteLine("Failed after 3 attempts");
                }
            }
        }
    }
}