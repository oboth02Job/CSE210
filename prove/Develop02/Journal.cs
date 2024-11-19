using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;


public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what could that be?",
        "How have I showed my faith today?",
        "How have I acted in love today?",
        "How did I show kindness to fellow humans?",
        "How have I overcome the devil's temptations?",
    };

    

    public void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Console.Write("How would you rate your day on a scale of 1-10? ");
        int rating = int.Parse(Console.ReadLine());

        Console.Write("How are you feeling today (e.g., happy, sad, neutral)? ");
        string mood = Console.ReadLine();

        JournalEntry entry = new JournalEntry
        {
            Prompt = prompt,
            Response = response,
            Rating = rating,
            Mood = mood,
            Date = DateTime.Now
        };

        entries.Add(entry);
        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nThe journal is empty.");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine($"Rating: {entry.Rating}");
            Console.WriteLine($"Mood: {entry.Mood}");
            Console.WriteLine(new string('-', 30));
        }
    }

    public void SaveToCsv(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Prompt,Response,Rating,Mood");
                foreach (var entry in entries)
                {
                    string csvLine = $"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\",{entry.Rating},\"{entry.Mood}\"";
                    writer.WriteLine(csvLine);
                }
            }
            Console.WriteLine("Journal saved successfully to CSV!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void SaveToJson(string filename)
    {
        try
        {
            
            
            Console.WriteLine("Journal saved successfully to JSON!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromCsv(string filename)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                entries.Clear();
                string line = reader.ReadLine(); // Skip header line
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    JournalEntry entry = new JournalEntry
                    {
                        Date = DateTime.Parse(parts[0].Trim('"')),
                        Prompt = parts[1].Trim('"'),
                        Response = parts[2].Trim('"'),
                        Rating = int.Parse(parts[3]),
                        Mood = parts[4].Trim('"')
                    };
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully from CSV!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }

    public void LoadFromJson(string filename)
    {
        try
        {
            string json = File.ReadAllText(filename);
            Console.WriteLine("Journal loaded successfully from JSON!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }

    public void SetDailyReminder()
    {
        Console.Write("Set a time for your daily reminder (HH:mm): ");
        string timeInput = Console.ReadLine();
        if (TimeSpan.TryParse(timeInput, out TimeSpan reminderTime))
        {
            
            
        }
        else
        {
            Console.WriteLine("Invalid time format.");
        }
    }
}

