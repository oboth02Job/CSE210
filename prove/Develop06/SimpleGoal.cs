public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    public override void RecordGoal()
    {
        IsCompleted = true;
        Console.WriteLine($"You completed the goal: {GoalName}, earning {Points} points!");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{GoalName} [ {(IsCompleted ? "X" : " ")} ]");
    }

    public override void SaveGoal()
    {
        // Implement saving logic if needed
    }
}
