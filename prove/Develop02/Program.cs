using System;
using System.Net;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    }
}

class Journal
{
    public string name;
    string filename => $"JournalOf{name}.txt";
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.Info());
        }
    }
    public void SaveToFile(string filename)
    {
        File.WriteAllText($"JournalOf{name}.txt", "");
        foreach (var entry in entries)
        {
            File.AppendAllLines($"JournalOf{name}.txt", new[] {entry.Info()});
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        //Create a list of [] strings, each [] contains 4 strings.
        //Later Loop through the [] to create multiple Entries and assign them to this Journal
        if (File.Exists(filename))
        {
            string [] entry = new string[4];
            for (int i = 0, j = 0; j < lines.Length; i++, j++)
            {
                entry.Append(lines[i]);
                //if conditinal, if i is 3 then erase the variable holding the list reset i and create an entry with all the necesary values.
            }
        }
        //still in progress
    }
}

class Entry
{
    public string date;
    public string promptText;
    public string entryText;

    public string Info()
    {
        return $"{date}\n{promptText}\n{entryText}";
    }
}

class PromptGenerator
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        //not done yet, please introduce the behaviour of random on the list.
        return "hi";
    }
}