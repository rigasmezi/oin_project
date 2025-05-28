using ForemsWeb.Core.Api.Services.Foundations.Oin;
using OinGenerator.Models;
using OinGenerator.Models.Exceptions;
using System.Text.Json;

namespace OinGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = Path.Combine(Directory.GetCurrentDirectory(), "input.json");
            OinFelling oinFelling = null;

            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine($"File '{inputFilePath}' does not exist.");
                return;
            }

            FileInfo fileInfo = new FileInfo(inputFilePath);
            if (fileInfo.Length == 0)
            {
                Console.WriteLine($"File '{inputFilePath}' is empty.");
                return;
            }

            try
            {
                string json = File.ReadAllText(inputFilePath);
                oinFelling = JsonSerializer.Deserialize<OinFelling>(json);

                if (oinFelling == null)
                {
                    Console.WriteLine("Failed to deserialize input.json into OinFelling.");
                    return;
                }

                OinService oinService = new OinService();
                var filePath = oinService.CreateFellingOinFile(oinFelling);

                Console.WriteLine($"Process completed OIN file saved to {filePath}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (InvalidOinFellingException ex)
            {
                Console.WriteLine($"Invalid OinFelling: {ex.Message}");
                foreach (System.Collections.DictionaryEntry entry in ex.Data)
                {
                    Console.WriteLine($"- {entry.Key}:");
                    if (entry.Value is IEnumerable<string> messages)
                    {
                        foreach (var message in messages)
                        {
                            Console.WriteLine($"    {message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"    {entry.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
