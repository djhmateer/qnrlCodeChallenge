using System;
using System.Collections.Generic;
using System.Linq;
using static System.Enum;

namespace QnrlCodeChallenge
{
    class Program
    {
        static void Main()
        {
            var deck = new Deck();
            var hand1 = new Hand(deck);
            var hand2 = new Hand(deck);

            deck.Shuffle();

            // Each hand takes it in turns to draw 5 cards from the deck.  Display the contents of the two hands.
            for (int i = 0; i < 5; i++)
            {
                hand1.Draw();
                hand2.Draw();
            }

            Console.WriteLine(hand1);
            Console.WriteLine(hand2);

            //foreach (var card in deck.Cards)
            //    Console.WriteLine(card);

            //Console.WriteLine(deck.DrawFirstCardFromDeck());
            //Console.WriteLine(deck);
            //Console.WriteLine("total cards: " + deck.Cards.Count);
        }
    }

    // Hand - Class
    // Deck - Class
    // Card - struct
    // Suit - enum
    // Rank - enum
    class Hand
    {
        Deck _deck;
        public List<Card> Cards = new List<Card>();

        public Hand(Deck deck)
        {
            _deck = deck;
        }

        public void Draw()
        {
            var card = _deck.DrawFirstCardFromDeck();
            Cards.Add(card);
        }

        public override string ToString()
        {
            var x = "";
            foreach (var card in Cards)
                x += card + Environment.NewLine;
            return x;
        }
    }

    class Deck
    {
        // Field (was called List in spec.. prefer Cards)
        public List<Card> Cards;
        // Property
        public int NumberOfCards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            // Populate 52 cards in order - Suit and Rank are enums
            foreach (Suit suit in GetValues(typeof(Suit)))
            {
                foreach (Rank rank in GetValues(typeof(Rank)))
                {
                    // Card is a struct
                    Cards.Add(new Card { Suit = suit, Rank = rank });
                }
            }
        }

        public override string ToString()
        {
            var x = "";
            foreach (var card in Cards)
                x += card + Environment.NewLine;
            return x;
        }

        public Card DrawFirstCardFromDeck()
        {
            var x = Cards[0];
            Cards.RemoveAt(0);
            return x;
        }

        public void Shuffle()
        {
            var shuffled = new List<Card>();
            var unshuffled = Cards.ToList();

            int count = unshuffled.Count;
            var rnd = new Random();
            for (var i = 0; i < count; i++)
            {
                // get a random card from the unshuffled list
                var index = rnd.Next(0, unshuffled.Count-1);
                var card = unshuffled[index];

                // put onto new shuffled list
                shuffled.Add(card);

                // delete from old unshuffled list
                unshuffled.RemoveAt(index);
            }

            Cards = shuffled;
        }
    }

    // struct ROT - small, immutable once created
    struct Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public override string ToString()
        {
            return Rank + " of " + Suit;
        }
    }

    enum Suit
    {
        Hearts = 0,
        Diamonds = 1,
        Clubs = 2,
        Spades = 3
    }

    enum Rank
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
}
