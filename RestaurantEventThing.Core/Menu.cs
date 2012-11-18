using System.Collections.Generic;

namespace RestaurantEventThing.Core
{
    public class Menu
    {
        public List<Dish> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new List<Dish>();
        }
    }
}