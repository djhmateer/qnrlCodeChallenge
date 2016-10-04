using System;
using System.Collections.Generic;
using System.Linq;

// asdf
namespace QnrlCodeChallenge
{
    class Program
    {
        static void Main()
        {
            var deck = new Deck();
            deck.Shuffle();

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine("total cards: " + deck.Cards.Count);
        }
    }

    class Deck
    {
        // Field (was called List in spec.. prefer Cards)
        public IList<Card> Cards;
        // Property
        public int NumberOfCards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            // Populate 52 cards in order
            for (int i = 0; i < 4; i++)
            {
                // Get suit based on int value of enum
                var suit = (Suit)i;
                for (int j = 1; j < 14; j++)
                {
                    var rank = (Rank)j;
                    Cards.Add(new Card { Suit = suit, Rank = rank });
                }
            }
        }
        
        // can see that they want encapsulation
        // will go down that road but next stop would be a more data structure style of OO
        // with more testable functions eg 
        // public IList<Card> Shuffle(IList<Card> input)
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

    enum WorldBuilderStatus
    {
        NotProcessed = 0,
        Processed = 1,
        Stale = 2
    }

    class Thing
    {
        public Thing()
        {
            var x = 1;
            if (x == (int)WorldBuilderStatus.Processed)
            {
                // asdf
            }
        }
    }
}
