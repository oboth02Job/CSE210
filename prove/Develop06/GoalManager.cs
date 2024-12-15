using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> Goals;
    private int TotalPoints;

    public GoalManager()
    {
        Goals = new List<Goal>();
        TotalPoints = 0;
    }

    public void CreateGoal(string goalType)
    {
        Console.WriteLine("Enter the name of your goal: ");
        string name = Console.ReadLine();

        if (goalType.ToLower() == "simple")
        {
            Console.WriteLine("Enter the points for this goal: ");
            int points = Convert.ToInt32(Console.ReadLine());
            Goals.Add(new SimpleGoal(name, points));
        }
        else if (goalType.ToLower() == "eternal")
        {
            Console.WriteLine("Enter the points for this goal: ");
            int points = Convert.ToInt32(Console.ReadLine());
            Goals.Add(new EternalGoal(name, points));
        }
        else if (goalType.ToLower() == "checklist")
        {
            Console.WriteLine("Enter the number of times to complete this goal: ");
            int goalCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the bonus points for this goal: ");
            int bonusPoints = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the points for each completion: ");
            int points = Convert.ToInt32(Console.ReadLine());
            Goals.Add(new ChecklistGoal(name, points, goalCount, bonusPoints));
        }
    }

    public void RecordGoal(string goalName)
    {
        foreach (var goal in Goals)
        {
            if (goal.GoalName == goalName && !goal.IsCompleted)
            {
                goal.RecordGoal();
                TotalPoints += goal.Points;
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            goal.DisplayGoal();
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Your current score is: {TotalPoints} points.");
    }

    public void SaveGoals()
    {
        // Implement saving goals to a file or other storage
    }

    public void LoadGoals()
    {
        // Implement loading goals from a file or other storage
    }
}
