using System;

class Menu
{

    public void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choice.");
        Console.WriteLine();

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.WriteLine();
        Console.Write(">>> ");
    }
}