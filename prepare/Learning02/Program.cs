using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine();

        Job job1 = new Job();
        job1.jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

        Job job2 = new Job();
        job2.jobTitle = "Manager";
        job2._company = "Apple";
        job2.startYear = 2022;
        job2.endYear = 2023;

        // Console.WriteLine(job1.jobTitle);
        // job1.Display();
        // job2.Display();

        Resume resume = new Resume();
        resume.name = "Joshua R";
        resume.jobs.Add(job1);
        resume.jobs.Add(job2);

        //Prints all the details needed
        resume.DisplayResume();
        Console.WriteLine();

        // Console.WriteLine(resume.jobs[0].jobTitle);
        
    }
}


