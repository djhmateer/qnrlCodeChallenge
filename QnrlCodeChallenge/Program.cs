using System;

namespace QnrlCodeChallenge
{
    class Program
    {
        static void Main()
        {
            // Use a enum to represent cards
            Card a = Card.Club;

            // 5 random cards
            var rnd = new Random();
            for (var i = 0; i < 5; i++)
            {
                var card = (Card)rnd.Next(0, 4);
                Console.WriteLine(card);
            }
        }
    }

    enum Card
    {
        Heart,
        Diamond,
        Club,
        Spade
    }
}
