//frontend code

using System;
using Game;

class Program
{
    static void Main()
    {
        Gameplay();
    }
    public static void Gameplay()
    {
        Console.WriteLine("Welcome to Hangman!");
        Hangman hangman = new Hangman(-1);
        string underscores = string.Join(" ", hangman.ActiveGuesses);
        Console.WriteLine(underscores);
        while(!hangman.isComplete)
        {
        Console.WriteLine("Guess a letter:");
        string input = Console.ReadLine();
        Console.WriteLine(hangman.TryALetter(input));
        }  
        Console.WriteLine("You guessed it! The word is " + hangman.ChosenWord + "!");
        Console.WriteLine("Play again? (Y/N)");
        string response = Console.ReadLine();
        if (response[0].ToString().ToUpper() == "Y")
        {
            Gameplay();
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
}