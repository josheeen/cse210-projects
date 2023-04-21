using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string name = PromptUserName();
        int squared = SquareNumber(PrompUserNumber());
        DisplayResult(name, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome To The Program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PrompUserNumber()
    {
        Console.Write("Enter you fave number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int num)
    {
        int squared = num * num;
        return squared;
    }

    static void DisplayResult(string name, int num)
    {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
}