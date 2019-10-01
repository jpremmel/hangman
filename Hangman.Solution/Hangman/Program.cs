//frontend code

using System;
using Game;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Hangman!");
        Hangman hangman = new Hangman();
        Console.WriteLine(); //underscores for the computer's chosen word
        Console.WriteLine("Guess a letter:");
        string input = Console.ReadLine();

    }
}