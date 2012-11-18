using System.Collections.Generic;

namespace RestaurantEventThing.Core.Events
{
    public class OrderReadyEvent : IDomainEvent
    {
        public List<Dish> Items { get; set; }

        public OrderReadyEvent()
        {
            Items = new List<Dish>();
        }
    }
}