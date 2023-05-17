using System;

public class Activity {
    private string _activityName = "";
    private string _activityDescription = "";
    private int _activityDuration = 0;

    //Constructors
    public Activity(string activityName, string activityDescription) {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    //Getters
    public int GetDuration() {
        return _activityDuration;
    }
    //Methods
    public void DisplayStart() {
        Console.WriteLine($"Welcome to {_activityName}. ");
        Console.WriteLine($"{_activityDescription}");
        InputDuration();
        Console.WriteLine($"Get ready...");
        Countdown();
    }
    public void DisplayEnd() {
        Console.WriteLine($"Great job! You completed {_activityName} for {_activityDuration} seconds.");
        Thread.Sleep(2000);
        Console.WriteLine();
    }

    public void InputDuration() {
        Console.Write("How long, in seconds, would you like this session? ");
        int duration = int.Parse(Console.ReadLine());
        _activityDuration = duration;

    }
    public void Countdown() {
        for (int i = 3; i > 0; i--) {
            Console.WriteLine($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}