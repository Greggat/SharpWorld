using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpWorld.Game.Units;
using SharpWorld.Game.Items;

namespace SharpWorld.Game.Items
{
    class Loot
    {
        private Unit _owner;

        private List<(Item item, float chance)> _loot;
        //---------Maybe change this to a struct?

        List<Item> GetLootDrop()
        {
            var lootDrops = new List<Item>();
            foreach(var loot in _loot)
            {
                int winnerRoll = Convert.ToInt32(1F - loot.chance * 10000F);
                // Double check the math here later..
                // The winner roll with an accuracy of up to 4 decimals

                int roll = Helpers.Helper.GetRandom(0, 1000);

                //If they roll higher than winning roll, give them the item.
                if (roll > winnerRoll)
                    lootDrops.Add(loot.item);
            }

            return lootDrops;
        }
    }
}
