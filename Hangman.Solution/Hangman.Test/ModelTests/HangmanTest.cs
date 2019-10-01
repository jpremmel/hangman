//testing code
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Test
{
    [TestClass]
    public class HangmanTest
    {
        Hangman hangman = new Hangman();

        [TestMethod]
        public void TryALetter_SingleLetterInputOnly_TryAgain()
        {
            Assert.AreEqual("Please try again.", hangman.TryALetter("10"));
        }
        
    }
}
