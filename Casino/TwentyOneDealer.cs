﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Casino.TwentyOne
{
    public class TwentyOneDealer: Dealer
    {
        public List<Card> Hand { get; set; } = new List<Card>();
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
