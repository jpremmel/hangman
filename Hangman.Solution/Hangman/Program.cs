//frontend code

using System;
using Game;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Hangman!");
        Hangman hangman = new Hangman(-1);
        string underscores = "";
        for (int j = 0; j < hangman.ChosenWord.Length; j++)
        {
            underscores += "_ ";
        }
        Console.WriteLine(underscores);
        Console.WriteLine("Guess a letter:");
        string input = Console.ReadLine();

    }
}