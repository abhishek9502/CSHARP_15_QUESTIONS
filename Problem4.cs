
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            Console.WriteLine("Result: " + (a / b));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter integers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too large or too small.");
        }
    }
}