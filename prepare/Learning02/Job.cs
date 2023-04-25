using System;

public class Job
{
    public string _company;
    public string jobTitle;
    public int startYear;
    public int endYear;

    public void Display()
    {
        Console.WriteLine($"{jobTitle} ({_company}) {startYear}-{endYear}");
    }
}