using System;
using System.IO;
using System.Text.Json;

class Event
{
    public int EventNumber { get; set; }
    public string Location { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Event calgaryEvent = new Event
        {
            EventNumber = 1,
            Location = "Calgary"
        };

        // serialization
        string jsonString = JsonSerializer.Serialize(calgaryEvent);
        File.WriteAllText("event.txt", jsonString);

        // deserialization
        string jsonFromFile = File.ReadAllText("event.txt");
        Event deserializedEvent = JsonSerializer.Deserialize<Event>(jsonFromFile);
        Console.WriteLine(deserializedEvent.EventNumber);
        Console.WriteLine(deserializedEvent.Location);
        Console.WriteLine("Tech Competition");
        ReadFromFile();
    }

    static void ReadFromFile()
    {
        using (StreamWriter writer = new StreamWriter("event.txt"))
        {
            writer.Write("Hackathon");
        }

        // read first, middle, and last characters
        using (StreamReader reader = new StreamReader("event.txt"))
        {
            string word = reader.ReadToEnd();
            Console.WriteLine($"In Word: {word}");
            int length = word.Length;

            char firstChar = word[0];
            char middleChar = word[length / 2];
            char lastChar = word[length - 1];

            Console.WriteLine($"The First Character is: \"{firstChar}\"");
            Console.WriteLine($"The Middle Character is: \"{middleChar}\"");
            Console.WriteLine($"The Last Character is: \"{lastChar}\"");
            Console.ReadKey();
        }
    }
}
