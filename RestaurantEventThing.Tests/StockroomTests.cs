using System.Collections.Generic;
using NUnit.Framework;
using RestaurantEventThing.Core;
using RestaurantEventThing.Core.Actors;
using RestaurantEventThing.Core.Events;

namespace RestaurantEventThing.Tests
{
    [TestFixture]
    public class StockroomTests
    {
        [Test]
        public void WhenAnOrderIsPlacedInventoryIsDepleted()
        {
            var sw = new StockRoom();
            sw.AddDish(1, new Cheeseburger());
            sw.AddDish(1, new CrabFries());
            sw.OrderPlaced(new OrderPlacedEvent{ Items = new List<Dish> { new Cheeseburger(), new CrabFries()}});

            Assert.AreEqual(0, sw.GetStockLevel<Cheeseburger>());
            Assert.AreEqual(0, sw.GetStockLevel<CrabFries>());
        }

        [Test]
        public void WhenAnOrderIsPlacedAnItemMovedToKitchenEventIsRaised()
        {
            
        }

    }
}