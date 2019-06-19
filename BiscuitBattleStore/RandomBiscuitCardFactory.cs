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
            Dictionary<BiscuitAttribute, int> stats =RandomAttr();
            String name = RandomName(stats);
            return new GenericBiscuit(stats, name);
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
        private String RandomName(Dictionary<BiscuitAttribute, int> values) {
            string nme = "";
            int count = 0;
            foreach (KeyValuePair<BiscuitAttribute, int> item in values) {
                if (item.Value > 60) {
                    switch (count) {
                        case 0:
                            nme += "Unbreakable ";
                            break;
                        case 1:
                            nme += "Moist ";
                            break;
                        case 2:
                            nme += "Stiff ";
                            break;
                        case 3:
                            nme += "Sweet ";
                            break;
                        case 4:
                            nme += "Crisp ";
                            break;
                    }
                }
                count++;
            }
            nme += "Biscuit";
            return nme;
        }
    }
}
