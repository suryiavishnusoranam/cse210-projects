/*
Vishnu Soranam
1/7/2023
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string vs_first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string vs_last = Console.ReadLine();

        Console.WriteLine($"Your name is {vs_last}, {vs_first} {vs_last}.");
    }
}