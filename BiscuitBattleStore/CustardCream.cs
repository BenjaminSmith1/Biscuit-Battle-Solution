using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    //chose custard creams because i was eating one when i started this
    //code was adapted from the NiceBiscuit class
    public class CustardCream : IBiscuitCard
    {
        public string Name { get; set; }
        public Dictionary<BiscuitAttribute, int> Stats { get; set; }
        public int Quality => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public CustardCream()
        {

            //some random numbers
            Stats = new Dictionary<BiscuitAttribute, int>
            {
                { BiscuitAttribute.DunkIntegrity, 70 },
                { BiscuitAttribute.Moistness, 50 },
                { BiscuitAttribute.Snap, 30 },
                { BiscuitAttribute.Sweetness, 60 },
                { BiscuitAttribute.Texture, 80 }
            };

            Name = "Custard Cream";
            //how do you even describe a custard cream???????
            Description = "A sandwich biscuit with a creamy, custard-flavoured centre surrounded by ornately decorated biscuit layers ";
        }
    }
}
