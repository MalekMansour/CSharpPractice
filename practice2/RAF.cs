using System;
using System.IO;
using System.Runtime.Serialization;
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
        // Create Event object
        Event calgaryEvent = new Event
        {
            EventNumber = 1,
            Location = "Calgary"
        };

        // Serialization
        string jsonString = JsonSerializer.Serialize(calgaryEvent);
        File.WriteAllText("event.txt", jsonString);

        // Deserialization
        string jsonFromFile = File.ReadAllText("event.txt");
        Event deserializedEvent = JsonSerializer.Deserialize<Event>(jsonFromFile);

        // Display deserialized values
        Console.WriteLine(deserializedEvent.EventNumber);
        Console.WriteLine(deserializedEvent.Location);

        // Read from file and display first, middle, and last characters
        ReadFromFile();
    }

    static void ReadFromFile()
    {
        // Write "Hackathon" to file
        using (StreamWriter writer = new StreamWriter("event.txt"))
        {
            writer.Write("Hackathon");
        }

        // Read first, middle, and last characters
        using (FileStream fileStream = new FileStream("event.txt", FileMode.Open, FileAccess.Read))
        {
            using (StreamReader reader = new StreamReader(fileStream))
            {
                // Seek to the middle character
                reader.BaseStream.Seek(reader.BaseStream.Length / 2, SeekOrigin.Begin);

                // Read characters
                char firstChar = (char)reader.Read();
                reader.BaseStream.Seek(0, SeekOrigin.End);
                char lastChar = (char)reader.Read();
                reader.BaseStream.Seek(reader.BaseStream.Length / 2, SeekOrigin.Begin);
                char middleChar = (char)reader.Read();

                // Display characters
                Console.WriteLine("In Word: Hackathon");
                Console.WriteLine($"The First Character is: \"{firstChar}\"");
                Console.WriteLine($"The Middle Character is: \"{middleChar}\"");
                Console.WriteLine($"The Last Character is: \"{lastChar}\"");
            }
        }
    }
}
