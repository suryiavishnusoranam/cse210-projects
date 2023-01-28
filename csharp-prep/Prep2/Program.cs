/*
Vishnu Soranam
1/7/2023
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string vs_answer = Console.ReadLine();
        int vs_percent = int.Parse(vs_answer);

        string vs_letter = "";

        if (vs_percent >= 90)
        {
            vs_letter = "A";
        }
        else if (vs_percent >= 80)
        {
            vs_letter = "B";
        }
        else if (vs_percent >= 70)
        {
            vs_letter = "C";
        }
        else if (vs_percent >= 60)
        {
            vs_letter = "D";
        }
        else
        {
            vs_letter = "F";
        }

        Console.WriteLine($"Your grade is: {vs_letter}");
        
        if (vs_percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}