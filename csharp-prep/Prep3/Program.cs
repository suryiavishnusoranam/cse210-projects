/*
Vishnu Soranam
1/11/2023
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int vs_magicNumber = randomGenerator.Next(1, 101);
        int vs_guess = -1;
        while (vs_magicNumber != vs_guess)
        {
            Console.Write("What is your guess? (1-100) ");
            vs_guess = int.Parse(Console.ReadLine());

            if (vs_magicNumber > vs_guess)
            {
                Console.WriteLine("Guess higher");
            }
            else if (vs_magicNumber < vs_guess)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
                Console.WriteLine("Congratualations! You guessed it!");
            }

        }                    
    }
}