using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWorld.Game.Units.Bosses
{
    class ToxicSerpent : Monster
    {
        public ToxicSerpent()
        {
            _name = "Toxic Serpent";
            _level = 10;
            _hp = 50;
            _maxHp = 50;

            _attack = 5;
            _defense = 5;
        }

        public override void Retaliate(Unit unit)
        {
            base.Retaliate(unit);
            if (unit.IsAlive())
            {
                unit.Damage(this, 1);
                GameWorld.Instance.Log("The serpent's poisonous gas damages you for 1hp!");
            }
        }

        public override void Died()
        {
            GameWorld.Instance.Log("Congratulations, you have defeated the Toxic Serpent. " +
                "The serpent has reigned over the garden for decades. " +
                "Many lives have been saved thanks to you." +
                "Take the serpents fang as your reward!");
        }
    }
}
