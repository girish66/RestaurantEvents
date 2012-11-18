using System.Collections.Generic;
using System.Linq;
using RestaurantEventThing.Core.Events;

namespace RestaurantEventThing.Core.Actors
{
    public class Customer
    {
        public List<Dish> OrderedItems { get; set; }
        public List<Dish> DelieveredItems { get; set; }


        public Customer()
        {
            OrderedItems = new List<Dish>();
            DelieveredItems = new List<Dish>();
        }

        public void PlaceOrder(OrderPlacedEvent items)
        {
            items.Items.ForEach(x => OrderedItems.Add(x));
        }


        public void ReceiveOrder(OrderReadyEvent ready)
        {
            foreach (var incoming in ready.Items)
            {
                var item = OrderedItems.First(x => incoming.GetType() == x.GetType());
                DelieveredItems.Add(item);
                OrderedItems.Remove(item);
            }
        }
    }
}