using System;

class Program
{
    static void Main(string[] args)
    {


      while(true){

        int numRows = int.Parse(Console.ReadLine());

        if(numRows<0){
            Console.WriteLine("Invalid Pascal’s triangle row number.");
            continue;
        }

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

        
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < pascal[i].Length; j++)
            {
                Console.Write(pascal[i][j] + " ");
            }
            Console.WriteLine();
        }

       
    }
    }
}
