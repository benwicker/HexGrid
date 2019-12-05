using System;
using System.Collections.Generic;

namespace Onitama
{
    public class Deck {

        public Deck()
        {
            Cards = new List<Card>() {
                new Card()
            }
        }

        public List<Card> Cards { get; set; }
    }
}