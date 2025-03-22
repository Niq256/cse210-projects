using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {       // Showing Creativity and Exceeding Requirements
            // I have updated the program to load scriptures from a file.

        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found in the file.");
            return;
        }

        foreach (var scripture in scriptures)
        {
            Console.Clear();
            while (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput?.ToLower() == "quit")
                    return;

                scripture.HideRandomWords(3); // Hides 3 words per iteration
                Console.Clear();
            }

            Console.WriteLine("All words are now hidden. Well done!");
            Console.WriteLine("Press Enter to move to the next scripture.");
            Console.ReadLine();
        }
    }

    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        var scriptures = new List<Scripture>();

        try
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    string referenceText = parts[0];
                    string scriptureText = parts[1];

                    // Parse reference (assumes format "Book Chapter:Verse-Verse" or "Book Chapter:Verse")
                    var referenceParts = referenceText.Split(' ');
                    string book = referenceParts[0];
                    string chapterAndVerses = referenceParts[1];
                    var chapterVerseParts = chapterAndVerses.Split(':');
                    int chapter = int.Parse(chapterVerseParts[0]);

                    var verseParts = chapterVerseParts[1].Split('-');
                    int startVerse = int.Parse(verseParts[0]);
                    int? endVerse = verseParts.Length > 1 ? int.Parse(verseParts[1]) : (int?)null;

                    var reference = endVerse.HasValue
                        ? new Reference(book, chapter, startVerse, endVerse.Value)
                        : new Reference(book, chapter, startVerse);

                    scriptures.Add(new Scripture(reference, scriptureText));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
        }

        return scriptures;
    }
}