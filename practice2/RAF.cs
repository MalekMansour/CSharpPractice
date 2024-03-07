using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab6
{
    internal class Program
    {
        [Serializable]
        public class Event
        {
            public int EventNumber { get; set; }
            public string Location { get; set; }

            public Event(int eventNumber, string location)
            {
                EventNumber = eventNumber;
                Location = location;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Event calgaryEvent = new Event(1, "Calgary");

                string filePath = "event.txt";

                // serializing
                SerializeEvent(filePath, calgaryEvent);

                // deserializing 
                Event deserializedEvent = DeserializeEvent(filePath);
                Console.WriteLine(deserializedEvent.EventNumber);
                Console.WriteLine(deserializedEvent.Location);

                ReadFromFile(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
        }
        static void SerializeEvent(string filepath, Event eve)
        {
            using (FileStream stream = new FileStream(filepath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, eve);
            }
        }

        static Event DeserializeEvent(string filepath)
        {
            using (FileStream stream = new FileStream(filepath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Event)formatter.Deserialize(stream);
            }
        }

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

                // First character
                fileStream.Seek(0, SeekOrigin.Begin);
                fileStream.Read(buffer, 0, 1);
                Console.WriteLine($"The First Character is: \"{(char)buffer[0]}\"");

                // Middle character
                fileStream.Seek(fileStream.Length / 2, SeekOrigin.Begin);
                fileStream.Read(buffer, 0, 1);
                Console.WriteLine($"The Middle Character is: \"{(char)buffer[0]}\"");

                // Last character
                fileStream.Seek(-1, SeekOrigin.End);
                fileStream.Read(buffer, 0, 1);
                Console.WriteLine($"The Last Character is: \"{(char)buffer[0]}\"");
            }
            Console.ReadKey();
        }
    }
}
