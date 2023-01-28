/*
Vishnu Soranam
1/18/2023
*/
using System;

public class Job
{
    public string _vsjobTitle;
    public string _vscompany;
    public int _vsstartYear;
    public int _vsendYear;

    public void Display()
    {
        Console.WriteLine($"{_vsjobTitle} ({_vscompany}) {_vsstartYear}-{_vsendYear}");
    }
}