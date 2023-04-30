using System;

class PrompGenerator
{
    
    string[] _prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    
    Random rnd = new Random(); //return a random value
    public string ShowPrompt() //need to change the return DATA TYPE since there is error "cannot convert void to string"
    {   //return a random string of prompts base on length of array
        //need to +1 since .Next only generate a random integer that is less than the specified maximum value.
        // Console.WriteLine(prompts[rnd.Next(0, prompts.Length)]);
        // Console.Write(">>> ");
        return _prompts[rnd.Next(0, _prompts.Length)];
    }
}