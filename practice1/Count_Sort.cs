using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void CountAndSortLetters(string inputString)
    {
        inputString = inputString.ToLower();
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();

        foreach (char c in inputString)
        {
            if (char.IsLetter(c))
            {
                if (letterCounts.ContainsKey(c))
                    letterCounts[c]++;
                else
                    letterCounts[c] = 1;
            }
        }
        
        // Sort the dictionary by keys (letters)
        var sortedLetterCounts = letterCounts.OrderBy(x => x.Key);
        
        // Print the sorted letter counts
        foreach (var pair in sortedLetterCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            // Ask the user for input
            Console.Write("Enter a bunch of letters (type 'exit' to quit): ");
            string userInput = Console.ReadLine();

            // Check if the user wants to exit
            if (userInput.ToLower() == "exit")
                break;

            // Call the function to count and sort letters
            CountAndSortLetters(userInput);
        }
    }
}
