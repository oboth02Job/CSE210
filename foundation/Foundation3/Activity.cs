using System;
using System.Collections.Generic;

// Base class
public abstract class Activity
{
    private string _date;
    private int _duration; // in minutes

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string Date => _date;
    public int Duration => _duration;

    public abstract double GetDistance(); // Distance in miles or kilometers
    public abstract double GetSpeed(); // Speed in mph or kph
    public abstract double GetPace(); // Pace in minutes per mile or km

    public virtual string GetSummary()
    {
        return $"{Date} ({Duration} min): Distance: {GetDistance():F2}, Speed: {GetSpeed():F2}, Pace: {GetPace():F2}";
    }
}