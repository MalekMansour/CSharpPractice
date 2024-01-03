using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors!");
        while (true)
        {
            Console.WriteLine("\nChoose your move:\n1. Rock\n2. Paper\n3. Scissors\n4. Quit");
            string userChoice = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userChoice)) { Console.WriteLine("Please enter a valid choice."); continue; }
            if (userChoice == "4") { Console.WriteLine("Thanks for playing. Goodbye!"); break; }

            string computerMove = GetComputerMove();
            string result = DetermineWinner(userChoice, computerMove);

            Console.WriteLine($"\nYour move: {GetMoveName(userChoice)}");
            Console.WriteLine($"Computer's move: {GetMoveName(computerMove)}");
            Console.WriteLine($"Result: {result}");
        }
    }
    static string GetComputerMove() { Random random = new Random(); int randomMove = random.Next(1, 4); return randomMove switch { 1 => "1", 2 => "2", 3 => "3", _ => throw new InvalidOperationException("Invalid move generated by the computer.") }; }

    static string DetermineWinner(string userMove, string computerMove)
    {
        if (userMove == computerMove) { return "It's a tie!"; }
        else if ((userMove == "1" && computerMove == "3") || (userMove == "2" && computerMove == "1") || (userMove == "3" && computerMove == "2")) { return "You win!"; }
        else { return "Computer wins!"; }
    }
    static string GetMoveName(string move) { return move switch { "1" => "Rock", "2" => "Paper", "3" => "Scissors", _ => throw new InvalidOperationException("Invalid move.") }; }
}