using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // List of hands possible
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };

        // Set the username
        Console.WriteLine("Welcome to BlackJack");
        Console.Write("Set your Username: ");
        string setusername = Console.ReadLine();
        Thread.Sleep(500);

        // Variables
        int balance = 1000;
        string username = setusername;
        Random random = new Random();
        string random_hand1 = cards[random.Next(cards.Length)];
        string random_hand2 = cards[random.Next(cards.Length)];
        string[] user_hand = { random_hand1 };
        string[] dealer_hand = { random_hand2 };
        var card_values = new Dictionary<string, int>
        {
            {"2", 2}, {"3", 3}, {"4", 4}, {"5", 5}, {"6", 6},
            {"7", 7}, {"8", 8}, {"9", 9}, {"10", 10}, {"11", 11}
        };

        // User choose to start the game or quit
        Console.WriteLine($"Username: {username}");
        Console.WriteLine("1: Start Game");
        Console.WriteLine("2: Quit");

        while (true)
        {
            string choice = Console.ReadLine();
            if (choice == "2")
            {
                Console.WriteLine("Quitting... ");
                return;
            }
            if (choice == "1")
                break;
            else
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
        }

        // If user starts the game
        Console.WriteLine("Entering Blackjack...");
        Thread.Sleep(1500);

        // Betting the money
        while (true)
        {
            try
            {
                Console.Write($"You have {balance} coins. Place your bet: ");
                int bet = int.Parse(Console.ReadLine());
                if (bet > balance)
                    Console.WriteLine("You don't have enough coins. ");
                else
                {
                    // Shuffling deck
                    Console.WriteLine("Shuffling Deck... ");
                    Thread.Sleep(1500);
                    Console.WriteLine($"Your hand: {string.Join(", ", user_hand)}");
                    Console.WriteLine($"Dealer's hand: {dealer_hand[0]} + ? ");
                    PlayGame(user_hand, dealer_hand, card_values, balance, bet);
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid. Enter a valid number of coins. ");
            }
        }
    }

    static void PlayGame(string[] user_hand, string[] dealer_hand, Dictionary<string, int> card_values, int balance, int bet)
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };
        int user_hand_value = card_values[user_hand[0]];

        while (true)
        {
            Console.Write("Hit or Stand?: ");
            string usermove = Console.ReadLine().ToLower();
            if (usermove == "hit")
            {
                string new_card = cards[new Random().Next(cards.Length)];
                Array.Resize(ref user_hand, user_hand.Length + 1);
                user_hand[user_hand.Length - 1] = new_card;
                user_hand_value += card_values[new_card];
                Console.WriteLine($"Your hand: {string.Join(", ", user_hand)} ({user_hand_value})");
                if (user_hand_value > 21)
                {
                    Console.WriteLine("Bust! You lose.");
                    balance -= bet;
                    Console.WriteLine($"You now have {balance} coins ");
                    return;
                }
            }
            else if (usermove == "stand")
            {
                Console.WriteLine("Dealer's hand: " + string.Join(", ", dealer_hand));
                int dealer_hand_value = card_values[dealer_hand[0]];
                while (dealer_hand_value < 17)
                {
                    string dealer_new_card = cards[new Random().Next(cards.Length)];
                    Array.Resize(ref dealer_hand, dealer_hand.Length + 1);
                    dealer_hand[dealer_hand.Length - 1] = dealer_new_card;
                    dealer_hand_value += card_values[dealer_new_card];
                    Console.WriteLine("Dealer hits: " + dealer_new_card);
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Dealer's hand: " + string.Join(", ", dealer_hand) + $" ({dealer_hand_value})");
                if (dealer_hand_value > 21)
                {
                    Console.WriteLine("Dealer busts! You win.");
                    balance += bet;
                    Console.WriteLine($"You now have {balance} coins ");
                }
                else if (dealer_hand_value < user_hand_value)
                {
                    Console.WriteLine("You win!");
                    balance += bet;
                    Console.WriteLine($"You now have {balance} coins ");
                }
                else if (dealer_hand_value > user_hand_value)
                {
                    Console.WriteLine("Dealer wins. You lose.");
                    balance -= bet;
                    Console.WriteLine($"You now have {balance} coins ");
                }
                else
                {
                    Console.WriteLine("It's a tie.");
                    Console.WriteLine($"You now have {balance} coins ");
                }
                return;
            }
            else
                Console.WriteLine("Invalid. Enter Hit or Stand. ");
        }
    }
}

