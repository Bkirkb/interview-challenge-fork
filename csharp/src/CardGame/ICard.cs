namespace CodingChallenge.CardGame;
public interface ICard : IEquatable<ICard>
{
    Suit Suit { get; set; }

    Value Value { get; set; }
}

public class Card : ICard
{
    public Card(Suit suit, Value value)
    {
        Suit = suit;
        Value = value;
    }
    
    public Suit Suit { get; set; }
    public Value Value { get; set; }

    public bool Equals(ICard other) => throw new NotImplementedException();
}


