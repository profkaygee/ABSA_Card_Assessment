using ABSA_Card_Assessment.Models;

namespace ABSA_Card_Assessment.Enums
{
    internal class Deck
    {
        private readonly Card[] cards = new Card[52];
        private readonly string[] numbers = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public Deck()
        {
            var i = 0;

            // Add the clubs first
            foreach (var number in numbers)
            {
                cards[i] = new Card(number, Suit.Clubs);
                i++;
            }

            // Add the spades next
            foreach (var number in numbers)
            {
                cards[i] = new Card(number, Suit.Spades);
                i++;
            }

            // Add the hearts
            foreach (var number in numbers)
            {
                cards[i] = new Card(number, Suit.Hearts);
                i++;
            }

            // Add the diamonds
            foreach (var number in numbers)
            {
                cards[i] = new Card(number, Suit.Diamonds);
                i++;
            }
        }

        public Card[] Cards => cards;
    }
}
