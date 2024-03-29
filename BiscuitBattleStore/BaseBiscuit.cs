﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    //base biscuit class for the random generation of cards
    public class GenericBiscuit : IBiscuitCard
    {
        public string Name { get; set; }
        public Dictionary<BiscuitAttribute, int> Stats { get; set; }
        public int Quality => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public GenericBiscuit(Dictionary<BiscuitAttribute,int> values, String title)
        {
            Stats = values;

            Name = title;
        }
    }
}
