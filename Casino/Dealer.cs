using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq;


namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());

            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            
            Console.WriteLine(card);

            using (StreamWriter file = new StreamWriter(@"C:\repos\tta_stuff\bootcamp_projects\tta_c_sharp\TwentyOne-master\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }

            Deck.Cards.RemoveAt(0);

        }

    }
}
