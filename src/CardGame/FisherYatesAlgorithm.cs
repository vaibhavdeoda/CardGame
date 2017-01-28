namespace CardGame
{
    using System;
    //  http://en.wikipedia.org/wiki/Fisher-Yates_shuffle
    static public class FisherYatesAlgorithm
    {
        static Random r = new Random();
        static public void Shuffle(ref Deck deck)
        {
            for (int n = deck.cards.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                var temp = deck.cards[n];
                deck.cards[n] = deck.cards[k];
                deck.cards[k] = temp;
            }
        }
    }
}