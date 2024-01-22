using System;

namespace String_Methods
{
    internal class String_Methods
    {
        static void Main1(string[] args)
        {
            string fullName = "First Last";
            string fullNmae_upper = fullName.ToUpper();
            string fullNmae_lower = fullName.ToLower();
            Console.WriteLine($"my full name is {fullName}, in Upper: {fullNmae_upper}, in lower: {fullNmae_lower}");
            string fullNameTitle = fullName.Insert(0, "Mr. ");
            Console.WriteLine($"My name with title: {fullNameTitle}");
            Console.WriteLine("the length of my name: {0} characters", fullName.Length);
            string firstName = fullName.Substring(0, 5);
            string lastName = fullName.Substring(6, 4);
            Console.WriteLine("First name is {0} and my last name is {1}", firstName, lastName);
            string phoneNumber = "123-456-7890";
            Console.WriteLine("ny phone number is: {0} or {1}", phoneNumber, phoneNumber.Replace("-", "/"));

            Console.ReadKey();
        }
    }
}
