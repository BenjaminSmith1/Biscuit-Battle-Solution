using System;
using System.Collections.Generic;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class RandomBiscuitCardFactory : BaseBiscuitFactory
    {
        public override IBiscuitCard GetCard()
        {
            var ran = new Random();
            var choose = ran.Next(1, 7);
            switch (choose)
            {
                case 1:
                    return new NiceBiscuit();
                case 2:
                    return new DigestiveBiscuit();
                case 3:
                    return new PinkWaferBiscuit();
                case 4:
                    return new BalancedBiscuit();
                case 5:
                    return new GingernutBiscuit();
                case 6:
                    return new CustardCream();
                default:
                    return new BalancedBiscuit();
            }
        }
        private Dictionary<BiscuitAttribute, int> RandomAttr() {
            var ran = new Random();
            var Stats = new Dictionary<BiscuitAttribute, int>
            {
                { BiscuitAttribute.DunkIntegrity, ran.Next(0,100) },
                { BiscuitAttribute.Moistness, ran.Next(0,100) },
                { BiscuitAttribute.Snap, ran.Next(0,100) },
                { BiscuitAttribute.Sweetness, ran.Next(0,100) },
                { BiscuitAttribute.Texture, ran.Next(0,100) }
            };
            return Stats;
        }
    }
}
