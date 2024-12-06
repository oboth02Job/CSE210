// ListingActivity.cs
using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private readonly string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are some achievements you’re proud of?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many items as you can in a certain area.") {}

    public override void Perform()
    {
        StartMessage();

        Random random = new Random();
        Console.WriteLine("\n" + _prompts[random.Next(_prompts.Length)]);
        ShowSpinner(3);

        List<string> items = new List<string>();
        Console.WriteLine("Start listing items:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        EndMessage();
    }
}
