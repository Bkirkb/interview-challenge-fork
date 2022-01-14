package codingchallenge.cardgame;

import java.util.Deque;

public interface IPackOfCards extends Iterable<ICard>
{
    void shuffle();

    ICard takeCardFromTopOfPack();

}