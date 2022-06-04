using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.CardGame;

public interface IPackOfCards : IReadOnlyCollection<ICard>
{
    void Shuffle();
    ICard TakeCardFromTopOfPack();
}

public class PackOfCards : IPackOfCards
{
    public PackOfCards(List<ICard> cards)
    {
        Cards = cards;
    }
    public List<ICard> Cards;
    public int Count => Cards.Count();
    public IEnumerator<ICard> GetEnumerator() => throw new NotImplementedException();
    public void Shuffle()
    {
        PackOfCardsCreator creator = new();
        PackOfCards cards = (PackOfCards)creator.Create();
        Random rand = new Random();
        Cards = cards.OrderBy(cards_ => rand.Next()).ToList();
    }
    public ICard TakeCardFromTopOfPack()
    {
        ICard topCard = (ICard)Cards.Take(1);
        Cards.Remove(topCard);
        return topCard;
    }
    IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
}
