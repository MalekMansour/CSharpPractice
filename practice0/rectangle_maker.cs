// Basic C# Program to will create a rectangle using a set of rows and colunms and symbol.
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("How many rows?");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many colunms?");
        int colunms = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What Sumbol do you want?");
        String symbol = Console.ReadLine();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colunms; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
