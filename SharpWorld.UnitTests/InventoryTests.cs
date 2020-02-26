using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpWorld.Game.Items;
using SharpWorld.Game.Units;

namespace SharpWorld.UnitTests
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void RemoveItem_ItemRemoved_ReturnsTrue()
        {
            //Arrange
            Unit unit = new Unit();
            Inventory inventory = new Inventory(unit);
            var result = inventory.AddItem(new Item("Item"), false);

            //Act
            if (result)
                result = inventory.RemoveItem("Item");

            //Assert
            Assert.IsTrue(result);
        }
    }
}
