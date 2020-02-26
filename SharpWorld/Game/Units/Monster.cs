using SharpWorld.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWorld.Game.Units
{
    public class Monster : Unit
    {
        public Monster()
        {
            _name = "Null Monster";
        }
        public Monster(string name, int level, int hp, int attack, int defense)
        {
            _name = name;

            _hp = hp;
            _maxHp = hp;

            _level = level;
            _baseAttack = attack;
            _baseDefense = defense;
        }

        public virtual void Retaliate(Unit unit)
        {
            int damage = Helper.GetRandom(0, _baseAttack);
            if (damage > 0)
            {
                if (!Config.DisableDamageLog)
                    GameWorld.Instance.Log($"{_name} attacked {unit.Name} for {damage} damage!");
                unit.Damage(this, damage);
            }
            else
            {
                if (!Config.DisableDamageLog)
                    GameWorld.Instance.Log($"{_name} missed its attack!");
            }
        }

        public override void Died()
        {
            
        }
        public override string ToString()
        {
            return $"{_name} Lvl: {_level}";
        }
    }
}
