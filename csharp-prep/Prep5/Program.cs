/*
Vishnu Soranam
1/11/2023
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        vs_DisplayWelcomeMessage();
        string userName = vs_PromptUserName();
        int userNumber = vs_PromptUserNumber();
        int squaredNumber = vs_SquareNumber(userNumber);
        vs_DisplayResult(userName, squaredNumber);
    }

    static void vs_DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string vs_PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int vs_PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int vs_SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void vs_DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}