// Basic C# Program that prompts user to enter name. If nothing is entered, the program will be stuck in a while loop until user enters something.
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        String name = Console.ReadLine();   
        while (name == "")
        {
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
        }
        Console.WriteLine("Hello " + name);
    }
}
