// C# Game where the user can travel to different planets to collect scraps for money and buy things from the store. User can also look inside of his inventory.
using System;
using System.Collections.Generic;
class Game
{
    static int money = 100;
    static List<string> inventory = new List<string>();
    static void Main()
    {
        Console.WriteLine("Welcome to the Space Adventure Game!");
        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Go to the Shop");
            Console.WriteLine("2. Travel to a Planet");
            Console.WriteLine("3. Check Inventory");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GoToShop();
                    break;
                case "2":
                    TravelToPlanet();
                    break;
                case "3":
                    CheckInventory();
                    break;
                case "4":
                    Console.WriteLine("Thanks for playing. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
    static void GoToShop()
    {
        Console.WriteLine("\nWelcome to the Shop!");
        Console.WriteLine("You have: $" + money);
        Console.WriteLine("\nItems for Sale:");
        Console.WriteLine("1. Spacesuit - $50");
        Console.WriteLine("2. Laser Gun - $30");
        Console.WriteLine("3. Energy Drink - $10");
        Console.WriteLine("4. Back to Main Menu");
        Console.Write("Enter your choice (1-4): ");
        string shopChoice = Console.ReadLine();

        switch (shopChoice)
        {
            case "1":
                BuyItem("Spacesuit", 50);
                break;
            case "2":
                BuyItem("Laser Gun", 30);
                break;
            case "3":
                BuyItem("Energy Drink", 10);
                break;
            case "4":
                break; // Back to the main menu
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                break;
        }
    }
    static void BuyItem(string itemName, int itemCost)
    {
        if (money >= itemCost)
        {
            money -= itemCost;
            inventory.Add(itemName);
            Console.WriteLine($"You bought {itemName} for ${itemCost}. Remaining money: ${money}");
        }
        else
        {
            Console.WriteLine("Not enough money to buy this item.");
        }
    }
    static void TravelToPlanet()
    {
        Console.WriteLine("\nYou are traveling to a distant planet...");
        int scrapsFound = new Random().Next(1, 11);
        money += scrapsFound * 5;
        Console.WriteLine($"You found {scrapsFound} scraps and earned ${scrapsFound * 5}!");
    }

    static void CheckInventory()
    {
        Console.WriteLine("\nInventory:");
        if (inventory.Count > 0)
        {
            foreach (string item in inventory)
            {
                Console.WriteLine("- " + item);
            }
        }
        else
        {
            Console.WriteLine("Your inventory is empty.");
        }
    }
}
