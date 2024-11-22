using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        // Main loop
        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine()?.ToLower();

            if (input == "quit")
            {
                break;
            }

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Memorization complete!");
                break;
            }

            scripture.HideWords();
        }
    }
}
