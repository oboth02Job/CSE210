public class ChecklistGoal : Goal
{
    private int GoalCount;
    private int CompletedCount;
    private int BonusPoints;

    public ChecklistGoal(string name, int points, int goalCount, int bonusPoints) : base(name)
    {
        Points = points;
        GoalCount = goalCount;
        CompletedCount = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordGoal()
    {
        if (CompletedCount < GoalCount)
        {
            CompletedCount++;
            Console.WriteLine($"You completed {GoalName}, earning {Points} points. {CompletedCount}/{GoalCount} completed.");
        }

        if (CompletedCount == GoalCount)
        {
            Console.WriteLine($"Congratulations! You've completed {GoalName} and earned a bonus of {BonusPoints} points!");
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{GoalName} [ {CompletedCount}/{GoalCount} ]");
    }

    public override void SaveGoal()
    {
        // Implement saving logic if needed
    }
}
