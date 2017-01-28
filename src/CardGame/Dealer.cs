namespace CardGame
{
    using System.Collections.Generic;
    using System.Linq;
    public class Dealer
    {
        int NoOfPlayers { get; set; }
        int NoOfCards { get; set; }
        public List<Player> Players = new List<Player>();
        Deck Deck { get; set; }
        public Dealer(int noOfPlayers, Deck deck, int noOfCards)
        {
            NoOfPlayers = noOfPlayers;
            Deck = deck;
            NoOfCards = noOfCards;
        }

        public void Deal()
        {
            var deck = Deck;
            int deckIndex = 0;
            FisherYatesAlgorithm.Shuffle(ref deck);
            for (int i = 0; i < NoOfCards; i++)
            {
                for (int j = 1; j <= NoOfPlayers; j++)
                {
                    //when dealing the first card, create the player
                    if (i == 0)
                    {
                        var player = new Player(j);
                        player.AddCard(deck.cards[deckIndex]);
                        Players.Add(player);
                        deckIndex++;
                    }
                    else
                    {
                        var player = Players.Where(x => x.PlayerId == j).First();
                        player.AddCard(deck.cards[deckIndex]);
                        deckIndex++;
                    }
                }
            }
        }
    }
}
