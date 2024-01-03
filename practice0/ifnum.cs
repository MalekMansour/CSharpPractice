// Basic C# Program using if statements to tell if a number is bigger than, smaller than, or equal to 10.
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            if (number > 10) 
            {
                Console.WriteLine(number + " is bigger than 10.");
            }
            else if (number == 10)
            {
                Console.WriteLine(number + " is equal to 10.");
            }
            else 
            {
                Console.WriteLine(number + " is smaller than 10.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
