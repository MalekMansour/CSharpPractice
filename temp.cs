// Basic C# Program to test OR and AND functions.
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("What is the temperature outside? (C)");
        double temp = Convert.ToDouble(Console.ReadLine());
        if (temp >= 10 && temp <= 25)
        {
            Console.WriteLine("It's warm outside!");
        }
        else if (temp <= -50 || temp >= 50)
        Console.WriteLine("DO NOT GO OUTSIDE!");
    }
}
