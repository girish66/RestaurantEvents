namespace RestaurantEventThing.Tests
{
    using NUnit.Framework;
    using RestaurantEventThing.Core;
    using RestaurantEventThing.Core.Actors;
    using RestaurantEventThing.Core.Events;


    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void DishDeliveredEventMovesFromOrderedToDelieveredColumn()
        {
            var customer = new Customer();
            customer.OrderedItems.Add(new MillerLite());
            customer.OrderedItems.Add(new Pizza());
            

            var ready = new OrderReadyEvent();
            ready.Items.Add(new MillerLite());
            ready.Items.Add(new Pizza());

            customer.ReceiveOrder(ready);

            Assert.IsEmpty(customer.OrderedItems);
            Assert.AreEqual(2, customer.DelieveredItems.Count);
        }
      
    }
}