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
        
        var sortedLetterCounts = letterCounts.OrderBy(x => x.Key);
        
        foreach (var pair in sortedLetterCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a bunch of letters (type 'exit' to quit): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
                break;

            CountAndSortLetters(userInput);
        }
    }
}
