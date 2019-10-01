//backend code
using System.Text.RegularExpressions;

namespace Game
{
    public class Hangman
    {
        
        
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

            }
            return output;
        }
    }
}