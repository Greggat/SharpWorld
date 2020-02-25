using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpWorld.Game.Items;

namespace SharpWorld.UnitTests
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void RemoveItem_ItemRemoved_ReturnsTrue()
        {
            //Arrange
            Inventory inventory = new Inventory();
            var result = inventory.AddItem(new Item("Item"), false);

            //Act
            if (result)
                result = inventory.RemoveItem("Item");

            //Assert
            Assert.IsTrue(result);
        }
    }
}
