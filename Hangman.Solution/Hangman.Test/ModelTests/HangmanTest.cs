//testing code
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Test
{
    [TestClass]
    public class HangmanTest
    {
        Hangman hangman = new Hangman(-1);

        [TestMethod]
        public void TryALetter_SingleLetterInputOnly_TryAgain()
        {
            Assert.AreEqual("Please try again.", hangman.TryALetter("10"));
        }

        [TestMethod]
        public void TryALetter_ChooseWord_Underscores()
        {
            Assert.AreEqual("_ _ _ _ _ _ _ _ ", hangman.PickWord(0));
        }
        
    }
}
