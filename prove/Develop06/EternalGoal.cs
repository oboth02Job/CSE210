public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    public override void RecordGoal()
    {
        Console.WriteLine($"You earned {Points} points for completing {GoalName}.");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{GoalName} [ Forever incomplete ]");
    }

    public override void SaveGoal()
    {
        
    }
}
