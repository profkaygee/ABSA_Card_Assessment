using ABSA_Card_Assessment.Models;
using System;

namespace ABSA_Card_Assessment
{
    public static class Shuffler
    {
        public static Card[] Shuffle(int times, Card[] deckCards)
        {
            var random = new Random();

            // We shuffle from the end
            for (var i = times - 1; i > 0; i--)
            {
                var randomSpot1 = random.Next(0, 52);
                var randomSpot2 = random.Next(0, 52);

                do
                {
                    randomSpot2 = random.Next(0, 52);
                } while (randomSpot1 == randomSpot2);

                // Swap the cards
                var temp = deckCards[randomSpot1];
                deckCards[randomSpot1] = deckCards[randomSpot2];
                deckCards[randomSpot2] = temp;

                // Better way of writing it will be below, but less readable
                // (deckCards[i], deckCards[randomSpot]) = (deckCards[randomSpot], deckCards[i]);
            }

            return deckCards;
        }
    }
}