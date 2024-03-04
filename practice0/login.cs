using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Create a password: ");
        string createPassword = Console.ReadLine();
        string password = createPassword;

        while (true)
        {
            Console.Write("Login with your password: ");
            string login = Console.ReadLine();
            if (login == password)
            {
                Console.WriteLine("Access Granted");
                break;
            }
            else
            {
                Console.WriteLine("Access Denied, try again.");
            }
        }
    }
}
