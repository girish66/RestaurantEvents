using System.Collections.Generic;

namespace RestaurantEventThing.Core.Events
{
    public class OrderPlacedEvent : IDomainEvent
    {
        public List<Dish> Items { get; set; }

        public OrderPlacedEvent()
        {
            Items = new List<Dish>();
        }

    }
}