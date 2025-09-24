using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        String username;
        int favnum;
        int birthyear;
        int numsquared;

        DisplayWelcome();

        username = PromptUserName();
        favnum = PromptUserNumber();
        numsquared = SquareNumber(favnum);

        PromptUserBirthYear(out birthyear);

        DisplayResult(username, numsquared, birthyear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthyear)
    {
        Console.Write("Please enter the year you were born: ");
        birthyear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int n)
    {
        return n * n;
    }

    static void DisplayResult(String name, int n, int birthyear)
    {
        Console.WriteLine($"{name}, the square of your number is " + n);
        Console.WriteLine($"{name}, you will turn " + (2025 - birthyear) + " this year.");
    }
}