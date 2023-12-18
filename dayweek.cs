// Basic C# program that asks the user for the day of the week. This is an example on how to use switch cases in C#.
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("What day of the week is it?: ");
        string day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                Console.WriteLine("It's Monday!");
                break;
            case "Tuesday":
                Console.WriteLine("It's Tuesday!");
                break;
            case "Wednesday":
                Console.WriteLine("It's Wednesday!");
                break;
            case "Thursday":
                Console.WriteLine("It's Thursday!");
                break;
            case "Friday":
                Console.WriteLine("It's Friday!");
                break;
            case "Saturday":
                Console.WriteLine("It's Saturday!");
                break;
            case "Sunday":
                Console.WriteLine("It's Sunday!");
                break;
            default: Console.WriteLine(day + " Is not a valid day");
                break;
        }
    }
}
