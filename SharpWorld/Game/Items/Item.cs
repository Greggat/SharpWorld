using SharpWorld.Game.Units;

namespace SharpWorld.Game.Items
{
    public class Item
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public Item(string name)
        {
            Name = name;
        }

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
