using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!\n");
        Random random_number = new Random();
        int magic_number = random_number.Next(1, 100);

        int guess_number = 0;

        while (magic_number != guess_number)
        {
            Console.Write("What is your guess? ");
            guess_number = int.Parse(Console.ReadLine());

            if (magic_number > guess_number)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!\n");
            }
        }
    }
}