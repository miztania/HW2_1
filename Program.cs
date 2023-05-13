using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int numRows = int.Parse(Console.ReadLine());

        int[][] pascal = new int[numRows][];

        for (int i = 0; i < numRows; i++)
        {
            pascal[i] = new int[i + 1];
            pascal[i][0] = 1;

            for (int j = 1; j < i; j++)
            {
                pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
            }

            pascal[i][i] = 1;
        }

        Console.WriteLine("\nHere is Pascal's Triangle:");
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < pascal[i].Length; j++)
            {
                Console.Write(pascal[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
