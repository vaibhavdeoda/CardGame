namespace CardGame
{
    using NUnit.Framework;
    [TestFixture]
    public class CardGameTests
    {
        [Test]
        public void TestDeckCreation()
        {
            var deck = new Deck();
            Assert.AreEqual(deck.cards.Length, 52);
        }

        [Test]
        public void TestShuffle()
        {
            var deck = new Deck();
            var oldValue = deck.cards[0].Value;
            var oldSuit = deck.cards[0].Suit;
            FisherYatesAlgorithm.Shuffle(ref deck);
            Assert.AreNotEqual(deck.cards[0].Value, oldValue);
            Assert.AreNotEqual(deck.cards[0].Suit,oldSuit);
        }
    }
}
