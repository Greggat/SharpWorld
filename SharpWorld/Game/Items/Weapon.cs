using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWorld.Game.Items
{
    enum WeaponType
    {
        MainHand,
        Offhand
    }
    class Weapon : Item
    {
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public WeaponType Type { get; private set; }

        public Weapon(string name, int attack, int defense, WeaponType type) : base(name)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
            Type = type;
        }
    }
}
