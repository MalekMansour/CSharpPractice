using System;

class Program
{
    static void Main(string[] args)
    {
        // Suits and ranks
        string[] suits = { "♡", "♤", "♢", "♧" };
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        // Random number generator
        Random random = new Random();

        // Choose a random card and display it
        string selectedSuit = suits[random.Next(suits.Length)];
        string selectedRank = ranks[random.Next(ranks.Length)];

        Console.WriteLine(selectedRank + " " + selectedSuit);
    }
}
