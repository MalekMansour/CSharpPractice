// Basic C# Program to replace '-' char with '@' char in a phone number.
using System;
class Program
{
    static void Main()
    {
        string phoneNum = "123-456-6789";
        phoneNum = phoneNum.Replace('-', '@');
        Console.WriteLine(phoneNum);
        Console.WriteLine(phoneNum.Length);
    }
}
