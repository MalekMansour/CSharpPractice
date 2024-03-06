using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialization_and_random_access_files
{
    internal class Program
    {
        [Serializable]
        class Event
        {
            public int EventNumber { get; set; }
            public string Location { get; set; }

            // Constructor with parameters
            public Event(int eventNumber, string location)
            {
                EventNumber = eventNumber;
                Location = location;
            }

            // Default constructor
            public Event() { }
        }

        // Method to serialize Event object to a file
        static void SerializeEvent(string filepath, Event eve)
        {
            using (FileStream stream = new FileStream(filepath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, eve);
            }
        }

        // Method to deserialize Event object from a file
        static Event DeserializeEvent(string filepath)
        {
            using (FileStream stream = new FileStream(filepath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Event)formatter.Deserialize(stream);
            }
        }

        // Method to read from a file and display first, middle, and last characters
        static void ReadFromFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write("Hackathon");
            }
            Console.WriteLine("Tech Competition");
            Console.WriteLine("In Word: Hackathon");

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[3];
                fileStream.Seek(0, SeekOrigin.Begin);
                fileStream.Read(buffer, 0, 1);
                Console.WriteLine($"The First Character is: \"{(char)buffer[0]}\"");

                fileStream.Seek(fileStream.Length / 2, SeekOrigin.Begin);
                fileStream.Read(buffer, 0, 1);
                Console.WriteLine($"The Middle Character is: \"{(char)buffer[0]}\"");

                fileStream.Seek(-1, SeekOrigin.End);
                fileStream.Read(buffer, 0, 1);
                Console.WriteLine($"The Last Character is: \"{(char)buffer[0]}\"");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                // Create an Event object
                Event calgaryEvent = new Event();
                calgaryEvent.EventNumber = 1;
                calgaryEvent.Location = "Calgary";

                // Define file path
                string filePath = @"../../data/textfile1.txt";

                // Serialize Event object to file
                SerializeEvent(filePath, calgaryEvent);

                // Deserialize Event object from file
                Event deserializedEvent = DeserializeEvent(filePath);
                Console.WriteLine(deserializedEvent.EventNumber);
                Console.WriteLine(deserializedEvent.Location);

                // Read from file and display characters
                ReadFromFile(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
