using ABSA_Card_Assessment.Enums;
using System;

namespace ABSA_Card_Assessment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("WELCOME TO CARD SHUFFLER!");
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How many times would you like to shuffle the cards? Type Exit to cancel");
            var entry = Console.ReadLine();
            Console.WriteLine();

            do
            {
                if (entry != null && entry.ToLower().Equals("exit"))
                {
                    break;
                }

                int.TryParse(entry, out var number);

                if (number <= 0)
                {
                    // Either the key pressed is invalid or is zero, push a message and try again.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Please try again");
                    Console.WriteLine();
                }
                else
                {
                    var deck = new Deck();
                    var shuffledCards = Shuffler.Shuffle(number, deck.Cards);

                    foreach (var shuffledCard in shuffledCards)
                    {
                        Console.WriteLine(shuffledCard.ToString());
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("How many times would you like to shuffle the cards? Type Exit to cancel");
                entry = Console.ReadLine();
                Console.WriteLine();

            } while (entry != null && !entry.ToLower().Equals("exit"));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Application exitting. Goodbye...");
        }
    }
}