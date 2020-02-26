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
        //Zones
        private Zone _zone;
        public Zone GetZone() => _zone;

        //Combat
        private Monster _target;
        public Monster GetTarget() => _target;
        private bool _inCombat;
        public bool InCombat() => _inCombat;
        private bool _runaway;

        //Equipment
        private Weapon _mainWeapon;
        private Weapon _offhandWeapon;
        private Inventory _inventory;
        public List<Item> GetInventory() => _inventory.GetItems();

        //stats
        public override int MaxHp => base.MaxHp;
        public override int Attack => _baseAttack + (_mainWeapon?.Attack ?? 0) + (_offhandWeapon?.Attack ?? 0);
        public override int Defense => _baseAttack + (_mainWeapon?.Defense ?? 0) + (_offhandWeapon?.Defense ?? 0);

        private int _xp;

        public Player(string name)
        {
            _name = name;

            _hp = 10;
            _maxHp = _hp;

            _level = 1;
            _baseAttack = 1;
            _baseDefense = 1;

            _xp = 0;

            _inventory = new Inventory(this);

            //test inventory
            _inventory.AddItem(new Food("Cooked Shrimp",4), true);
            _mainWeapon = new Weapon("Dagger",5,0,WeaponType.MainHand);
            GameWorld.Instance.Log($"Your character, {_name}, has been created!");
        }
        private void LevelUp()
        {
            _xp -= Convert.ToInt32(Config.BaseXpRequirement * Math.Pow(Config.XpRequirementRatio, _level));

            _level++;
            _maxHp++;
            _hp++;
            _baseAttack++;
            _baseDefense++;
            GameWorld.Instance.Log($"You leveled up to {_level}!");
        }
        public void AddXp(int xp)
        {
            _xp += xp;
            while (_xp >= (Config.BaseXpRequirement * Math.Pow(Config.XpRequirementRatio, _level)))
                LevelUp();
            GameWorld.Instance.GetForm().UpdateCharacterUI();
        }
        private void AttackMonster(Monster monster)
        {
            int damage = Helper.GetRandom(0, Attack);
            if (damage > 0)
            {
                if (!Config.DisableDamageLog)
                    GameWorld.Instance.Log($"{_name} attacked {monster.Name} for {damage} damage!");
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
                AttackMonster(monster);
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
