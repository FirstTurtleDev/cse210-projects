using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    }
}

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
}

public class Entry
{
    public string date;
    public string[] prompt;
    public string response;

    public void Display()
    {
        Console.WriteLine();
    }
}