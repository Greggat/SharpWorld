using SharpWorld.Game.Units;
using System.Collections.Generic;

namespace SharpWorld.Game.Items
{
    public class Inventory
    {
        private Unit _owner;

        private static int MaxItems = Config.MaxInventorySize;
        private List<Item> _items = new List<Item>();
        public List<Item> GetItems() => _items;
        
        public Inventory(Unit owner)
        {
            _owner = owner;
        }

        public bool AddItem(Item item, bool notify)
        {
            if (_items.Count < MaxItems && item != null)
            {
                if (notify)
                    GameWorld.Instance.Log($"{item.Name} was added to {_owner.Name}'s inventory.");
                _items.Add(item);
                return true;
            }
            else if (item == null)
            {
                if (notify)
                    GameWorld.Instance.Log("[Error] Tried adding a null item.");
                throw new System.ArgumentNullException("Can not add null item to inventory.");
            }
            else
            {
                if (notify)
                {
                    GameWorld.Instance.Log("Could not add item.");
                    GameWorld.Instance.Log($"{_owner.Name}'s inventory is full.");
                }
                return false;
            }
        }

        public bool RemoveItem(string itemName)
        {
            int itemIndex = _items.FindIndex(x => x.Name == itemName);
            if (itemIndex != -1)
            {
                _items.RemoveAt(itemIndex);
                return true;
            }
            else
                return false;
        }
        public bool RemoveItem(Item item) => RemoveItem(item.Name);
    }
}
