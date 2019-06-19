using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Players
{
    public class EasyAI : IPlayer
    {
        public (BiscuitAttribute Attr, int Score) DecideAttributeToPlay(IBiscuitCard m)
        {   //plays the lowest attribute
            Console.WriteLine("Thinking....");
            Thread.Sleep(3000);
            var attr = m.Stats.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
            return (attr, m.Stats[attr]);
        }
    }
}
