using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int numberToSquare = PromptUserNumber();
        int squaredNumber = SquareNumber(numberToSquare);
        DisplayResult(userName, squaredNumber);

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    // PromptUserName - Asks for and returns the user's name (as a string)
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    // DisplayResult - Accepts the user's name and the squared number and displays them.

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNum = int.Parse(userInput);
        return userNum;
    }

    static int SquareNumber(int input)
    {
        double squaredDbl = Math.Pow(input, 2);
        int squaredInt = (int)squaredDbl;
        return squaredInt;
    }

    static void DisplayResult(string userName, int number)
    {
        Console.WriteLine($"{userName}, the square of your number is {number}");
    }
}