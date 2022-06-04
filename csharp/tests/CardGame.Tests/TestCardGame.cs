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
            IPackOfCards packOfCards = cardCreator.Create();
            packOfCards.TakeCardFromTopOfPack();
            packOfCards.Shuffle();
            Assert.AreEqual(packOfCards.Count, 52);
        }

        [Test]
        public void TestCreate()
        {
            PackOfCardsCreator cardCreator = new();
            IPackOfCards packOfCards = cardCreator.Create();
            Assert.AreEqual(packOfCards.Count, 52);
        }
        [Test]
        public void TestTakeOne()
        {
            PackOfCardsCreator cardCreator = new();
            IPackOfCards packOfCards = cardCreator.Create();
            packOfCards.TakeCardFromTopOfPack();
            packOfCards.TakeCardFromTopOfPack();
            Assert.AreEqual(packOfCards.Count, 50);
            
        }
        [Test]
        public void TestOrder()
        {
            PackOfCardsCreator cardCreator = new();
            IPackOfCards packOfCardsPreShuffle = cardCreator.Create();
            // Hard code first element of cards to be 7 of hearts
            packOfCardsPreShuffle.Cards[0].Suit = Suit.Hearts;
            packOfCardsPreShuffle.Cards[0].Value = Value.Seven;
            IPackOfCards packOfCardsPostShuffle = packOfCardsPreShuffle.Shuffle();
            List<ICard> preShuffle = packOfCardsPreShuffle.Cards;
            List<ICard> postShuffle = packOfCardsPostShuffle.Cards;
            // The odds of an assertion like this failing is incredibly low (Roughly 0.03%)
            Boolean sameCard = false;
            if (preShuffle[0].Suit.ToString() == "Hearts" & postShuffle[0].Suit.ToString() == "Hearts")
            {
                if (preShuffle[0].Value.ToString() == "Seven" && postShuffle[0].Value.ToString() == "Seven")
                {
                    sameCard = true;
                }
            }
            Assert.IsFalse(sameCard);
        }
    }
}
