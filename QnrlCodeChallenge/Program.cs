using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static System.Enum;

namespace QnrlCodeChallenge
{
    class Program
    {
        static void Main()
        {
            // Create a deck with 2 jokers
            var deck = new Deck();
            Console.WriteLine($"no cards in deck {deck.Count}");

            deck.Shuffle();
            //foreach (var card in deck.ListOfCards) Console.WriteLine(card);

            // Deal 2 hands with 5 cards each, one after the other
            var hand1 = new Hand(deck);
            var hand2 = new Hand(deck);

            // Each hand takes it in turns to draw 5 cards from the deck. 
            for (int i = 0; i < 5; i++)
            {
                hand1.DrawFromDeck();
                hand2.DrawFromDeck();
            }

            Console.WriteLine($"no cards in deck {deck.Count}");


            Console.WriteLine(hand1);
            Console.WriteLine(hand2);

            // Sort on the cards in the hands
            hand1.ListOfCards.Sort();
            hand2.ListOfCards.Sort();

            Console.WriteLine(hand1);
            Console.WriteLine(hand2);

            // Make the first hand give the second hand 2 cards
            var cardToGive1 = hand1.GiveCardFromHand();
            var cardToGive2 = hand1.GiveCardFromHand();
            hand2.ReceiveCard(cardToGive1);
            hand2.ReceiveCard(cardToGive2);

            Console.WriteLine(hand1);
            Console.WriteLine(hand2);

            Console.ReadLine();
        }
    }

    // Cards - Class : CardCollection abstract class (ListOfCards)
    // Hand - Class : Cards.. Hand 'is a' Cards
    // Deck - Class : Cards.  Deck 'is a' Cards

    // Card - Class
    // Suit - enum
    // Rank - enum

    abstract class CardCollection
    {
        public List<Card> ListOfCards;
    }

    class Cards : CardCollection
    {
        public int Count => ListOfCards.Count;

        public void DrawCards(int num)
        {}

        public Card DrawFirstCardFromDeck()
        {
            var x = ListOfCards[0];
            ListOfCards.RemoveAt(0);
            return x;
        }

        public void AddCard(Card card)
        {
            ListOfCards.Add(card);
        }

        public void AddCards(List<Card> cards)
        {}

        public void Shuffle()
        {
            var shuffled = new List<Card>();
            var unshuffled = ListOfCards.ToList();

            int count = unshuffled.Count;
            var rnd = new Random();
            for (var i = 0; i < count; i++)
            {
                // get a random card from the unshuffled list
                var index = rnd.Next(0, unshuffled.Count - 1);
                var card = unshuffled[index];

                // put onto new shuffled list
                shuffled.Add(card);

                // delete from old unshuffled list
                unshuffled.RemoveAt(index);
            }
            ListOfCards = shuffled;
        }
    }

    class Deck : Cards
    {
        public Deck()
        {
            ListOfCards = new List<Card>();
            foreach (Suit suit in GetValues(typeof(Suit)))
            {
                if (suit == Suit.Joker) continue;
                foreach (Rank rank in GetValues(typeof(Rank)))
                {
                    if (rank == Rank.Joker) continue;
                    AddCard(new Card { Suit = suit, Rank = rank });
                }
            }
            AddCard(new Card { Suit = Suit.Joker, Rank = Rank.Joker});
            AddCard(new Card { Suit = Suit.Joker, Rank = Rank.Joker});
        }

        public override string ToString()
        {
            return ListOfCards.Aggregate("", (x, card) => x + (card + Environment.NewLine));
        }
    }

    class Hand : Cards
    {
        Deck _deck;

        public Hand(Deck deck)
        {
            _deck = deck;
            ListOfCards = new List<Card>();
        }

        public void DrawFromDeck()
        {
            var card = _deck.DrawFirstCardFromDeck();
            ListOfCards.Add(card);
        }

        public Card GiveCardFromHand()
        {
            var card = ListOfCards[0];
            ListOfCards.RemoveAt(0);
            return card;
        }

        public void ReceiveCard(Card card)
        {
            ListOfCards.Add(card);
        }

        public override string ToString()
        {
            return ListOfCards.Aggregate("", (x, card) => x + (card + Environment.NewLine));
        }
    }

    class Card : IComparable<Card>
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public override string ToString()
        {
            return Rank == Rank.Joker ? "Joker" : Rank + " of " + Suit;
        }

        // Suit is ignored
        public int CompareTo(Card other)
        {
            return Rank.CompareTo(other.Rank);
        }
    }

    enum Suit
    {
        Hearts = 0,
        Diamonds = 1,
        Clubs = 2,
        Spades = 3,
        Joker = 4
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
        King = 13,
        Joker = 14
    }
}

// testing icomparable
//var cards = new List<Card>();
//var card5 = new Card {Rank = Rank.Five};
//var card7 = new Card {Rank = Rank.Seven};
//var card9 = new Card {Rank = Rank.Nine};
//cards.Add(card7);
//cards.Add(card5);
//cards.Add(card9);
//foreach (var card in cards) Console.WriteLine(card);
//// Sorts in ascending order as we've implemented IComparable
//cards.Sort();
//foreach (var card in cards) Console.WriteLine(card);