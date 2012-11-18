namespace RestaurantEventThing.Core.Events
{
    public class ItemMovedToKitchenEvent : IDomainEvent
    {
        public Dish Item { get; set; }

        public ItemMovedToKitchenEvent(Dish item)
        {
            Item = item;
        }
    }
}