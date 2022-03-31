using ABSA_Card_Assessment.Enums;

namespace ABSA_Card_Assessment.Models
{
    public class Card
    {
        protected Suit Suit;
        protected string CardValue;

        public Card(string cardValue, Suit suit)
        {
            Suit = suit;
            CardValue = cardValue;
        }

        public override string ToString()
        {
            return $"{CardValue} of {Suit}";
        }
    }
}