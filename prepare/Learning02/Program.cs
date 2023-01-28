/*
Vishnu Soranam
1/18/2023
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._vsjobTitle = "Software Engineer";
        job1._vscompany = "Microsoft";
        job1._vsstartYear = 2019;
        job1._vsendYear = 2022;

        Job job2 = new Job();
        job2._vsjobTitle = "Manager";
        job2._vscompany = "Apple";
        job2._vsstartYear = 2022;
        job2._vsendYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Vishnu Soranam";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}