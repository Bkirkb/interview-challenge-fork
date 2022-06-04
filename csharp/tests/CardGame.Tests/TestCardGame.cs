using System.Collections.Generic;
using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class TestCardGame
    {
        [Test]
        public void TestShuffle()
        {
            PackOfCardsCreator cardCreator = new();
            PackOfCards cards = (PackOfCards)cardCreator.Create();
            cards.Shuffle();
            Assert.AreEqual(cards.Count, 52);
        }

        [Test]
        public void TestCreate()
        {
            PackOfCardsCreator cardCreator = new();
            PackOfCards cards = (PackOfCards)cardCreator.Create();
            Assert.AreEqual(cards.Count, 52);
        }

    }
}
