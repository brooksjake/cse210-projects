using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> listy = new List<int>();
        int newnum;
        int total = 0;
        int average;
        int biggest;

        do
        {
            Console.Write("Enter a new number: ");
            newnum = int.Parse(Console.ReadLine());
            if (newnum != 0)
            {
                listy.Add(newnum);
            }
        } while (newnum != 0);

        foreach (int n in listy)
        {
            total += n;
        }

        average = total / listy.Count;

        biggest = listy[0];

        for (int i = 1; i < listy.Count; i++)
        {
            if (listy[i] > biggest)
            {
                biggest = listy[i];
            }
        }

        Console.WriteLine("The sum is: " + total);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + biggest);
    }
}