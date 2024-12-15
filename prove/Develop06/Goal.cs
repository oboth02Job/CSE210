using System;

public abstract class Goal
{
    protected string GoalName;
    protected int Points;
    protected bool IsCompleted;

    public Goal(string name)
    {
        GoalName = name;
        IsCompleted = false;
    }

    public string GoalName => GoalName;
    public int Points => Points;
    public bool IsCompleted => IsCompleted;

    public abstract void RecordGoal();
    public abstract void DisplayGoal();
    public abstract void SaveGoal();
}
