namespace CardGame
{
    public class Deck
    {
        public Card[] cards;
        private int[] values = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13 };
        public Deck()
        {
            cards = new Card[52];
            var index = 0;

            foreach (var suit in new[] { Suit.H, Suit.S, Suit.C, Suit.D })
            {
                for (var i = 0; i < 13; i++)
                {
                    cards[index++] = new Card(values[i], suit);
                }
            }
        }
    }
}
