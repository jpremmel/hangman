//testing code
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Test
{
    [TestClass]
    public class HangmanTest
    {
        Hangman hangman = new Hangman(-1);
        Hangman aardvark = new Hangman(0);

        [TestMethod]
        public void TryALetter_SingleLetterInputOnly_TryAgain()
        {
            Assert.AreEqual("Please try again.", hangman.TryALetter("10"));
        }

        [TestMethod]
        public void TryALetter_ChooseWord_Underscores()
        {
            Hangman aardvark = new Hangman(0);
            char[] underscores = { '_', '_', '_', '_', '_', '_', '_', '_' };
            Assert.AreEqual(underscores.ToString(), aardvark.ActiveGuesses.ToString());
        }

        [TestMethod]
        public void TryALetter_LetterNotInWord_TryAgain()
        {
            Assert.AreEqual("This letter isn't in the word. Try again!", aardvark.TryALetter("l"));
        }

        
        
    }
}
