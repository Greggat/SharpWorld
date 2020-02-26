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
        protected int _baseAttack;
        protected int _baseDefense;


        public string Name => _name;
        public int Level => _level;

        public int Hp => _hp;
        public virtual int MaxHp => _maxHp;
        public virtual int Attack => _baseAttack;
        public virtual int Defense => _baseDefense;

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
