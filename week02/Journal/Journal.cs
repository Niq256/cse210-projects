using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string date, string prompt, string response)
    {
        entries.Add(new Entry(date, prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine("-------------------------------");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            foreach (var line in File.ReadAllLines(filename))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    AddEntry(parts[0], parts[1], parts[2]);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}