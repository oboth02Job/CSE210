using System;

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        Console.WriteLine("Welcome to Eternal Quest!");
        string userInput = "";
        
        while (userInput != "exit")
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record goal completion");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Exit");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Enter goal type (simple, eternal, checklist): ");
                    string goalType = Console.ReadLine();
                    goalManager.CreateGoal(goalType);
                    break;

                case "2":
                    Console.WriteLine("Enter the name of the goal to record completion: ");
                    string goalName = Console.ReadLine();
                    goalManager.RecordGoal(goalName);
                    break;

                case "3":
                    goalManager.DisplayGoals();
                    break;

                case "4":
                    goalManager.ShowScore();
                    break;

                case "5":
                    userInput = "exit";
                    break;

                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }
}
