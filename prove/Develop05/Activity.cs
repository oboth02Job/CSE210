// Activity.cs
using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Starting: {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nWell done!");
        Thread.Sleep(2000);
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            foreach (char c in "|/-\\")
            {
                Console.Write($"\r{c}");
                Thread.Sleep(250);
            }
        }
        Console.Write("\r ");
    }

    public abstract void Perform();
}
