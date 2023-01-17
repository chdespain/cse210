using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        // Console.Write("Input a number to add: ");

        int numberToAdd;
        do
        {
            Console.Write("Input a number to add: ");
            numberToAdd = int.Parse(Console.ReadLine());
            numbers.Add(numberToAdd);
        } while (numberToAdd != 0);

        int sum = 0;
        foreach (int entry in numbers)
        {
            sum += entry;
        }
        String output = "The sum is " + sum + ".";
        Console.WriteLine(output);

        int numberOfEntries = numbers.Count;
        float avg = sum / numberOfEntries;
        output = "The average is " + avg + ".";
        Console.WriteLine(output);

        int largest = numbers.Max();
        output = "The largest number is " + largest + ".";
        Console.WriteLine(output);

    }
}