using System;

class Program
{
    // Each round selects only visible words, hiding three new words or all remaining words.
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 1, 1, 2);
        string text = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; "
            + "and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; "
            + "yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days. "
            + "Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input == null || input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (input == "")
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}
