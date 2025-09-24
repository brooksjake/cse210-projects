using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the magic number between 1 and 100!");
        Random randgen = new Random();
        int magicnum = randgen.Next(1, 100);
        int guess;

        int count = 0;
        
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count += 1;

            if (guess == magicnum)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine("it took " + count + " guesses");
            }
            else if (guess > magicnum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

        } while (guess != magicnum);

    }
}