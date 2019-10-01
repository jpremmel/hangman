//backend code
using System.Text.RegularExpressions;
using System;

namespace Game
{
    public class Hangman
    {
        public string ChosenWord { get; set; }
        public char[] ActiveGuesses { get; set; }
        public bool isComplete { get; set; }

        //constructor
        public Hangman(int i)
        {
            isComplete = false;
            ChosenWord = PickWord(i);
            string underscores = "";
            for (int j = 0; j < ChosenWord.Length; j++)
            {
                underscores += "_";
            }
            ActiveGuesses = underscores.ToCharArray();
        }
     
        //methods
        public string PickWord(int i)
        {
            string[] possibleWords = { "aardvark", "penguin", "pangolin", "quiz", "chinchilla", "armadillo", "walrus", "beluga", "dolphin", "narwhal", "octopus", "leopard", "cthulhu", "kraken", "mermaid", "unicorn", "seahorse", "pegasus", "baboon", "snake", "fox", "lion", "monkey", "hedgehog", "butterfly", "eagle", "awkward", "bagpipes", "banjo", "pumpkin", "autumn", "candy", "dwarf", "fervid", "sphinx", "jinx", "waxy", "yacht", "zealous", "zombie", "swivel", "pixel", "kayak", "boat", "gazebo", "eyelash", "ghost" };
            string word = "";
            if (i < 0)
            {
                Random random = new Random();
                int generatedNumber = random.Next(0, possibleWords.Length-1);
                word = possibleWords[generatedNumber];
            }
            else
            {
                word = possibleWords[i];
            }    
            return word;
        }
        public string TryALetter(string letter)
        {
            string output = "";
            Regex regex = new Regex(@"[^a-zA-Z]");
            Match match = regex.Match(letter);
            if (match.Success || letter.Length > 1 || letter.Length < 1){
               output = "Please try again.";
            }
            else
            {
                char charLetter = letter.ToLower().ToCharArray()[0];
                if (ChosenWord.Contains(charLetter))
                {
                    for(int j = 0; j < ActiveGuesses.Length; j++)
                    {
                        if (ChosenWord[j] == charLetter)
                        {
                            ActiveGuesses[j] = charLetter;
                        }
                    }
                    output = string.Join(" ", ActiveGuesses);
                    if (!output.Contains('_'))
                    {
                        isComplete = true;
                    }
                }
                else
                {
                    output = "This letter isn't in the word. Try again!";
                }
            }
            return output;
        }
    }
}