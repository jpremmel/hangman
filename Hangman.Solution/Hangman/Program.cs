//frontend code

using System;
using Game;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Hangman!");
        Hangman hangman = new Hangman(0);
        string underscores = string.Join(" ", hangman.ActiveGuesses);
        Console.WriteLine(underscores);

        while(!hangman.isComplete)
        {
        Console.WriteLine("Guess a letter:");
        string input = Console.ReadLine();
        Console.WriteLine(hangman.TryALetter(input));
        }  
        Console.WriteLine("You guessed it! The word is " + hangman.ChosenWord);
    }
}