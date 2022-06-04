using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.CardGame;

public interface IPackOfCards : IReadOnlyCollection<ICard>
{
    IPackOfCards Shuffle();
    ICard TakeCardFromTopOfPack();
    public List<ICard> Cards { get; set; }
}

public class PackOfCards : IPackOfCards
{
    public PackOfCards(List<ICard> cards)
    {
        Cards = cards;
    }

    public List<ICard> Cards { get; set; }
    public int Count => Cards.Count();
    public IEnumerator<ICard> GetEnumerator() => throw new NotImplementedException();
    public IPackOfCards Shuffle()
    {
        PackOfCardsCreator creator = new();
        Random rand = new Random();
        IPackOfCards cardsReturn = creator.Create();
        this.Cards = cardsReturn.Cards.OrderBy(_ => rand.Next()).ToList();
        return cardsReturn;
    }
    public ICard TakeCardFromTopOfPack()
    {
        ICard topCard = Cards.FirstOrDefault();
        Cards.RemoveAt(0);
        return topCard;
    }
    IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
}
