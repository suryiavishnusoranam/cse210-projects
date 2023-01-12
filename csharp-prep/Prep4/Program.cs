/*
Vishnu Soranam
1/11/2023
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> vs_numbers = new List<int>();
        int vs_userNumber = -1;
        while (vs_userNumber != 0)
        {
            Console.Write("Enter a number (choose 0 to quit): ");
            
            string userResponse = Console.ReadLine();
            vs_userNumber = int.Parse(userResponse);
            
            if (vs_userNumber != 0)
            {
                vs_numbers.Add(vs_userNumber);
            }
        }

        int vs_sum = 0;
        foreach (int number in vs_numbers)
        {
            vs_sum += number;
        }

        Console.WriteLine($"The sum is: {vs_sum}");
        float average = ((float)vs_sum) / vs_numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int vs_max = vs_numbers[0];

        foreach (int number in vs_numbers)
        {
            if (number > vs_max)
            {
                vs_max = number;
            }
        }

        Console.WriteLine($"The max is: {vs_max}");
    }
}