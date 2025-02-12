using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of levels: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        int levels;
        if (int.TryParse(input, out levels))
        {
            PrintPyramid(levels);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    static void PrintPyramid(int levels)
    {
        for (int i = 1; i <= levels; i++)
        {
            for (int j = 1; j <= levels - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
