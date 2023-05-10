using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment ass1 = new Assignment("Joshua R","Programming With Classes");
        Console.WriteLine(ass1.GetSummary());
        MathAssignment math1 = new MathAssignment("Ave R", "Math", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment write1 = new WritingAssignment("Shai R", "European History", "The Causes of World War II");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());
    }
}

class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment()
    {

    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"name: {_studentName} - \ntopic: '{_topic}'";
    }
    public string GetStudentName()
    {
        return _studentName;
    }

}

class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}

class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string studentName,string topic, string title) :  base (studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}