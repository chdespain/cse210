using System;

class Program
{
    static void Main(string[] args)
    {
        
        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F < 60
        string letter = "F";
        Console.Write("What is your grade? ");
        string gradePercentage = Console.ReadLine();
        float gradeFloat = float.Parse(gradePercentage);

        bool passing = false;

        if (gradeFloat >= 90)
        {
            letter = "A";
            passing = true;
        }
        else if (gradeFloat >= 80)
        {
            letter = "B";
            passing = true;
        }
        else if (gradeFloat >= 70)
        {
            letter = "C";
            passing = true;
        }
        else if (gradeFloat >= 60)
        {
            letter = "D";
            passing = false;
        }
        else
        {
            letter = "F";
            passing = false;
        }


        Console.WriteLine($"Your grade is a {letter}!");
        if (passing)
        {
            Console.WriteLine("You are passing your class! Good job!");
        }
        else
        {
            Console.WriteLine("You need to improve your grades. Keep working!");
        }


    }
}