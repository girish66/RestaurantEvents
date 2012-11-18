using RestaurantEventThing.Core.Actors;

namespace RestaurantEventThing.Core
{
    public class Setup
    {
        public void Execute(StockRoom stockRoom)
        {
            stockRoom.AddDish(10, new Cheeseburger());
            stockRoom.AddDish(10, new BaconCheeseBurger());
            stockRoom.AddDish(10, new PotPie());
            stockRoom.AddDish(10, new CheeseSteak());
            stockRoom.AddDish(10, new CrabFries());
            stockRoom.AddDish(10, new HotWings());
            stockRoom.AddDish(10, new Fries());
            stockRoom.AddDish(10, new MillerLite());
            stockRoom.AddDish(10, new CoorsLite());
            stockRoom.AddDish(10, new Soda());
            stockRoom.AddDish(10, new IcedTea());
            stockRoom.AddDish(10, new Nachos());
            stockRoom.AddDish(10, new BlackenedChickenSandwich());
            stockRoom.AddDish(10, new Pizza());
            stockRoom.AddDish(10, new Calzone());
            stockRoom.AddDish(10, new VealScallopini());
        }
    }
}