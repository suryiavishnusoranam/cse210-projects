/*
Vishnu Soranam
1/18/2023
*/
using System;

public class Resume
{
    public string _vsname;

    public List<Job> _vsjobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_vsname}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _vsjobs)
        {
            job.Display();
        }
    }
}
