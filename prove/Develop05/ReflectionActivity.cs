// ReflectionActivity.cs
using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private readonly string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity", "This activity helps you reflect on times in your life when you demonstrated strength and resilience.") {}

    public override void Perform()
    {
        StartMessage();

        Random random = new Random();
        Console.WriteLine("\n" + _prompts[random.Next(_prompts.Length)]);
        ShowSpinner(3);

        for (int i = 0; i < _duration / 10; i++) // Show one question every 10 seconds
        {
            Console.WriteLine("\n" + _questions[random.Next(_questions.Length)]);
            ShowSpinner(3);
        }

        EndMessage();
    }
}
