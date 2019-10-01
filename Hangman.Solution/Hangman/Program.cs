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
        Console.WriteLine("Guess a letter:");
        string input = Console.ReadLine();
        Console.WriteLine(hangman.TryALetter(input));
    }
}