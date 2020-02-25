using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpWorld.Game.Units;

namespace SharpWorld.Game.Zones
{
    public class Zone
    {
        public string Name { get; }
        public int LevelRequirement { get; }
        public List<Monster> Monsters { get; }

        public Zone(string name, int levelRequirement, List<Monster> monsters)
        {
            Name = name;
            LevelRequirement = levelRequirement;
            Monsters = monsters;
        }

        public Monster FindMonster(string name)
        {
            foreach(var monster in Monsters)
            {
                if (monster.GetName() == name)
                    return monster;
            }
            return new Monster("Null Monster", 1, 0, 0, 0);
        }
    }
}
