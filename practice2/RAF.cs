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
        ReadFromFile();
    }

    static void ReadFromFile()
    {
        using (StreamWriter writer = new StreamWriter("event.txt"))
        {
            writer.Write("Hackathon");
        }

        // Read first middle and last character
        using (FileStream fileStream = new FileStream("event.txt", FileMode.Open, FileAccess.Read))
        {
            using (StreamReader reader = new StreamReader(fileStream))
            {
                reader.BaseStream.Seek(reader.BaseStream.Length / 2, SeekOrigin.Begin);
                char firstChar = (char)reader.Read();
                reader.BaseStream.Seek(0, SeekOrigin.End);
                char lastChar = (char)reader.Read();
                reader.BaseStream.Seek(reader.BaseStream.Length / 2, SeekOrigin.Begin);
                char middleChar = (char)reader.Read();
                Console.WriteLine("In Word: Hackathon");
                Console.WriteLine($"The First Character is: \"{firstChar}\"");
                Console.WriteLine($"The Middle Character is: \"{middleChar}\"");
                Console.WriteLine($"The Last Character is: \"{lastChar}\"");
                Console.ReadKey();
            }
        }
    }
}
