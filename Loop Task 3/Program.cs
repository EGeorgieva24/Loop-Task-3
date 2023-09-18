using System;

class DiamondPattern
{
    static void Main()
    {
        Console.Write("Enter the number of rows (odd number): ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Please enter an odd number for a diamond pattern.");
            return;
        }

        DoDiamond(number, 1);
    }

    static void DoDiamond(int a, int row)
    {
        if (row <= a)
        {
            PrintSpaces((a - row) / 2);
            PrintAsterisks(row);
            Console.WriteLine();

            DoDiamond(a, row + 2);

            PrintSpaces((a - row) / 2);
            PrintAsterisks(row);
            Console.WriteLine();
        }
    }

    static void PrintSpaces(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(" ");
        }
    }

    static void PrintAsterisks(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("*");
        }
    }
}
