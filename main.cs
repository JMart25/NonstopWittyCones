using System;

class PerfectNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to check if it's perfect:");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (IsPerfect(number))
            {
                Console.WriteLine($"Perfect Number.");
            }
            else
            {
                Console.WriteLine($"Not a Perfect Number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static bool IsPerfect(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum == number;
    }
}
