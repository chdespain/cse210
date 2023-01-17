using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // string magicNumberS = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberS);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;
    
        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number! ");
            string guessS = Console.ReadLine();
            guess = int.Parse(guessS);
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Congratulations!");
            }
        }
    }
}