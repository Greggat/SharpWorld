using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SharpWorld.Game.Zones;
using SharpWorld.Game.Items;
using SharpWorld.Helpers;

namespace SharpWorld.Game.Units
{
    public class Player : Unit
    {
        private Zone _zone;
        public Zone GetZone() => _zone;
        private Monster _target;
        public Monster GetTarget() => _target;
        private bool _inCombat;
        public bool InCombat() => _inCombat;
        private bool _runaway;

        private int _xp;

        private Inventory _inventory;
        public List<Item> GetInventory() => _inventory.GetItems();

        public Player(string name)
        {
            _name = name;

            _hp = 10;
            _maxHp = _hp;

            _level = 1;
            _attack = 1;
            _defense = 1;

            _xp = 0;

            _inventory = new Inventory(this);

            //test inventory
            _inventory.AddItem(new Food("Cooked Shrimp",4), true);
            GameWorld.Instance.Log($"Your character, {_name}, has been created!");
        }
        private void LevelUp()
        {
            _xp -= Convert.ToInt32(Config.BaseXpRequirement * Math.Pow(Config.XpRequirementRatio, _level));

            _level++;
            _maxHp++;
            _hp++;
            _attack++;
            _defense++;
            GameWorld.Instance.Log($"You leveled up to {_level}!");
        }
        public void AddXp(int xp)
        {
            _xp += xp;
            while (_xp >= (Config.BaseXpRequirement * Math.Pow(Config.XpRequirementRatio, _level)))
                LevelUp();
            GameWorld.Instance.GetForm().UpdateCharacterUI();
        }
        private void Attack(Monster monster)
        {
            int damage = Helper.GetRandom(0, _attack);
            if (damage > 0)
            {
                if (!Config.DisableDamageLog)
                    GameWorld.Instance.Log($"{_name} attacked {monster.GetName()} for {damage} damage!");
                monster.Damage(this, damage);
                AddXp(damage * Config.ExpRate);
            }
            else
            {
                if (!Config.DisableDamageLog)
                    GameWorld.Instance.Log("You missed!");
            }
        }
        public async Task Fight(Monster monster)
        {
            _target = monster;
            _inCombat = true;
            while(this.IsAlive() && monster.IsAlive())
            {
                Attack(monster);
                await Task.Delay(Config.CombatTickRate);
                if (monster.IsAlive())
                {
                    monster.Retaliate(this);
                    if (_runaway)
                    {
                        GameWorld.Instance.Log("You ran away!");
                        _runaway = false;
                        break;
                    }
                }
                await Task.Delay(Config.CombatTickRate);
            }
            _inCombat = false;
            monster.Reset();
            if (!IsAlive())
            {
                GameWorld.Instance.GetForm().UpdateHealthBars();
                await Task.Delay(5000);
                GameWorld.Instance.Log("You have respawned.");
                Reset();
            }
            GameWorld.Instance.GetForm().UpdateHealthBars();
        }
        public void Run()
        {
            _runaway = true;
        }
        public override void Died()
        {
            GameWorld.Instance.Log("You have died and lost all your items!\nRespawning in 5 seconds.");
        }
        public void EnterZone(Zone zone)
        {
            if (_level >= zone.LevelRequirement)
            {
                _zone = zone;
                GameWorld.Instance.GetForm().UpdateMonstersUI();
                GameWorld.Instance.Log($"[Enter Zone] {_name} has entered {_zone.Name}.");
            }
        }
    }
}
