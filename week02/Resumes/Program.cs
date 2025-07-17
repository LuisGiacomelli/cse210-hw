using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Job 1
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Job 2.
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2025;

        // Display company:
        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        // Display jobs:
        // job1.Display();
        // job2.Display();

        // Resume 1
        Resume resume1 = new Resume();
        resume1._name = "Luis Giacomelli";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.Display();

    }

}