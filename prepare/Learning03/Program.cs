using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Fraction f3 = new Fraction (3, 4);
        Fraction f4 = new Fraction (1, 3);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}


// Create the Fraction class
// Create a class to hold fraction.
// The class should be in its own file.
// The class should have two attributes for the top and bottom numbers.
// Make sure the attributes are private.
class Fraction
{
    private int _top;
    private int _bottom;


// Create the Constructors
// Create the following constructors:
// Constructor that has no parameters that initializes the number to 1/1.
// Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
// Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


// Create the Getters and Setters
// Create getters and setters for both the top and the bottom values.
// In your Program.cs file, verify that you can call all of these methods and get the correct values, using setters to change the values and then getters to retrieve these new values and then display them to the console.
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

// Create methods to return the representations
// Create a method called GetFractionString that returns the fraction in the form 3/4.
// Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}