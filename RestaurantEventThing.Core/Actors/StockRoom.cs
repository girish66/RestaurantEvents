using System.Collections.Generic;
using System.Linq;
using RestaurantEventThing.Core.Events;

namespace RestaurantEventThing.Core.Actors
{
    public class StockRoom
    {
        private List<KeyValuePair<int, Dish>> _inventory;

        public void AddDish(int quantity, Dish dish)
        {
            if (_inventory == null) _inventory = new List<KeyValuePair<int, Dish>>();
            _inventory.Add(new KeyValuePair<int, Dish>(quantity, dish));
        }

        public void OrderPlaced(OrderPlacedEvent args)
        {
            foreach (var orderItem in args.Items)
            {
                var item = _inventory.Single(x => x.Value.GetType() == orderItem.GetType());
                _inventory.Remove(item);
                _inventory.Add(new KeyValuePair<int, Dish>(item.Key-1, item.Value));
                
                EventManager.Raise(new ItemMovedToKitchenEvent(item.Value));
            }
        }

        public int GetStockLevel<TDish>()
        {
            var item = _inventory.FirstOrDefault(x => x.Value.GetType() == typeof (TDish));
            return item.Key;
        }
    }
}