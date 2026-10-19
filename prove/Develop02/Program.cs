using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nJournal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();
                entry.date = DateTime.Now.ToShortDateString();
                entry.promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine(entry.promptText);
                Console.Write("> ");
                entry.entryText = Console.ReadLine();

                journal.AddEntry(entry);
                Console.WriteLine("Entry added.");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please choose a number from 1 to 5.");
            }
        }
    }
}

class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
        }

        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.Info());
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();

        foreach (Entry entry in entries)
        {
            lines.Add(entry.date);
            lines.Add(entry.promptText);
            lines.Add(entry.entryText);
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            // Every entry has three lines: date, prompt, and response.
            if (lines.Length % 3 == 0)
            {
                entries.Clear();

                for (int i = 0; i < lines.Length; i += 3)
                {
                    Entry entry = new Entry();
                    entry.date = lines[i];
                    entry.promptText = lines[i + 1];
                    entry.entryText = lines[i + 2];
                    AddEntry(entry);
                }

                Console.WriteLine("Journal loaded.");
            }
            else
            {
                Console.WriteLine("This file does not have three lines per entry.");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

class Entry
{
    public string date = "";
    public string promptText = "";
    public string entryText = "";

    public string Info()
    {
        return $"{date}\n{promptText}\n{entryText}";
    }
}

class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What small victory did I have today?",
        "Who helped me today, and how?",
        "What surprised me today?",
        "What did I learn about myself today?",
        "What ordinary moment am I grateful for today?",
        "What is one thing I want to try tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
