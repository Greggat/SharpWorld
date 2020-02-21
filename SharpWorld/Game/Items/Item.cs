using SharpWorld.Game.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWorld.Game.Items
{
    class Item
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public virtual void Use(Unit unit) 
        {
            GameWorld.Instance.Log("You can not use this item.");
            //placeholder for derived classes
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
