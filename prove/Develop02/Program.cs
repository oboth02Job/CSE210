using System;

class Program
{
    
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Daily Journal!");

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the Journal to a CSV File");
            Console.WriteLine("4. Save the Journal to a JSON File");
            Console.WriteLine("5. Load the Journal from a CSV File");
            Console.WriteLine("6. Load the Journal from a JSON File");
            Console.WriteLine("7. Set Daily Reminder");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option (1-8): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter the filename to save the journal (CSV): ");
                    string saveCsvFile = Console.ReadLine();
                    journal.SaveToCsv(saveCsvFile);
                    break;
                case "4":
                    Console.Write("Enter the filename to save the journal (JSON): ");
                    string saveJsonFile = Console.ReadLine();
                    journal.SaveToJson(saveJsonFile);
                    break;
                case "5":
                    Console.Write("Enter the filename to load the journal (CSV): ");
                    string loadCsvFile = Console.ReadLine();
                    journal.LoadFromCsv(loadCsvFile);
                    break;
                case "6":
                    Console.Write("Enter the filename to load the journal (JSON): ");
                    string loadJsonFile = Console.ReadLine();
                    journal.LoadFromJson(loadJsonFile);
                    break;
                case "7":
                    journal.SetDailyReminder();
                    break;
                case "8":
                    Console.WriteLine("Goodbye! Keep journaling!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

