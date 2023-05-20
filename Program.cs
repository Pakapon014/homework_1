using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for Pascal's triangle: ");
        int numRows;
        while (!int.TryParse(Console.ReadLine(), out numRows) || numRows < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            Console.Write("Enter the number of rows for Pascal's triangle: ");
        }

        for (int i = 0; i <= numRows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
        }
    }
}
