using SharpWorld.Game.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWorld.Game.Items
{
    public class Food : Item
    {
        public int HpRestoreAmount { get; protected set; }
        //Maybe we want to display how much the food heals for?

        public override void Use(Unit unit)
        {
            GameWorld.Instance.Log($"{unit.Name} ate {Name}.");
            unit.Heal(HpRestoreAmount);
        }

        public Food(string name, int hpRestoreAmount) : base(name)
        {
            Name = name;
            HpRestoreAmount = hpRestoreAmount;
        }
    }
}
