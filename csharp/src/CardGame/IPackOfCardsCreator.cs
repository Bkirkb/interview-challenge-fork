using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.CardGame;

public interface IPackOfCardsCreator
{
    IPackOfCards Create();
}

public class PackOfCardsCreator : IPackOfCardsCreator
{
    public IPackOfCards Create()
    {
        Suit[] suits = (Suit[])Enum.GetValues(typeof(Suit));
        Value[] values = (Value[])Enum.GetValues(typeof(Value));
        List<ICard> cards = new();
        foreach (Suit suit in suits)
        {
            foreach (Value value in values)
            {
                Card card = new(suit, value);
                cards.Add(card);
            }
        }
        PackOfCards packOfCards = new(cards);
        Random rand = new Random();
        packOfCards.Shuffle();
        return packOfCards;
    }
}
