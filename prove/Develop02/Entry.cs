using System;

class Entry
{
    // public string date = "";
    // public string prompt = "";
    // public string ans = "";
    
    public string _date;
    public string _prompt;
    public string _ans;
    

    public void ShowEntry()
    {   
        Console.WriteLine();
        Console.WriteLine($"{_date} {_prompt}");
        Console.WriteLine($"{_ans}");
    }
}