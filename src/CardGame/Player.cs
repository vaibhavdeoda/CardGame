namespace CardGame
{
    using System.Collections.Generic;

    public class Player
    {
        public int PlayerId { get; set; }
        public List<Card> Hand = new List<Card>();

        public Player(int playerId)
        {
            PlayerId = playerId;
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
        }
    }
}
