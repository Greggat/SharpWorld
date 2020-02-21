using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWorld.Game.Units
{
    public class Unit
    {
        protected string _name;

        protected int _hp;
        protected int _maxHp;

        protected int _level;
        protected int _attack;
        protected int _defense;


        public string GetName() => _name;

        public int GetHp() => _hp;
        public int GetMaxHp() => _maxHp;

        public int GetLevel() => _level;
        public int GetAttack() => _attack;
        public int GetDefense() => _defense;

        public virtual bool IsAlive()
        {
            return _hp > 0;
        }

        public virtual void Died()
        {

        }

        public virtual void Damage(Unit source, int damage)
        {
            _hp -= damage;
            if (!IsAlive())
            {
                _hp = 0;
                GameWorld.Instance.Log($"{_name} has died!");
                Died();
            }
            GameWorld.Instance.GetForm().UpdateHealthBars();
        }

        public virtual void Heal(int healAmount)
        {
            int oldHp = _hp;
            if (_hp + healAmount <= _maxHp)
                _hp += healAmount;
            else
                _hp = _maxHp;
            if (_hp > oldHp)
                GameWorld.Instance.Log($"{_name} restored {_hp - oldHp} hp!");
        }

        public virtual void Reset()
        {
            _hp = _maxHp;
        }
    }
}
