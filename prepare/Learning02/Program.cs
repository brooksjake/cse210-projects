using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startyear = "2009";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Google";
        job2._startyear = "2002";
        job2._endYear = "2009";

        Resume rs = new Resume();
        rs._name = "Randy Smith";
        rs._jobs.Add(job1);
        rs._jobs.Add(job2);

        rs.Display();

        

    }
}