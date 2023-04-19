using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        var num = -1;

        //negative 1 because the last number that will be entered is zero
        //zero will not be added for the total number that was entered
        var numsEntered = -1; 

        List<int> numbers = new List<int>();
        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            numbers.Add(num);
            numsEntered++;
        }
        float total = numbers.Sum();
        float ave = total / numsEntered;
        int max = numbers.Max();
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {max}");

    }
}