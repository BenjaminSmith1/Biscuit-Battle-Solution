using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Players
{
    public class CrazyAI : IPlayer
    {
        public (BiscuitAttribute Attr, int Score) DecideAttributeToPlay(IBiscuitCard m)
        {
            //picks a random attribute
            Console.WriteLine("Thinking....");
            Random ran = new Random();
            int rInt = ran.Next(1,5);
            //had to put the keys in a list to pick randomly
            List<BiscuitAttribute> BList = new List<BiscuitAttribute>(m.Stats.Keys);
            var attr = BList[rInt];
            return (attr, m.Stats[attr]);
        }
    }
}
