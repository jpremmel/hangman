//backend code
using System.Text.RegularExpressions;
using System;

namespace Game
{
    public class Hangman
    {
        public string ChosenWord { get; set; }
        public char[] ActiveGuesses { get; set; }

        //constructor
        public Hangman(int i)
        {
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
            string[] possibleWords = { "aardvark", "pangolin", "quiz", "chinchilla", "armadillo", "walrus" };
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
            if (match.Success || letter.Length > 1){
               output = "Please try again.";
            }
            else
            {
                char charLetter = letter.ToCharArray()[0];
                if (ChosenWord.Contains(charLetter))
                {
                    int i = ChosenWord.IndexOf(charLetter);
                    ActiveGuesses[i] = charLetter;
                    output = string.Join(" ", ActiveGuesses);
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