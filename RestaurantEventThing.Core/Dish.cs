namespace RestaurantEventThing.Core
{
    public abstract class Dish
    {
        public decimal Price { get; set; }

        public Dish(decimal price)
        {
            Price = price;
        }
    }

    public class Cheeseburger : Dish
    {
        public Cheeseburger() : base(8.5m)
        {
        }
    }

    public class BaconCheeseBurger : Dish
    {
        public BaconCheeseBurger() : base(9.5m)
        {
        }
    }

    public class PotPie : Dish
    {
        public PotPie() : base(12.99m)
        {
        }
    }

    public class CheeseSteak : Dish
    {
        public CheeseSteak() : base(7M)
        {
        }
    }

    public class CrabFries : Dish
    {
        public CrabFries() : base(5m)
        {
        }
    }

    public class HotWings : Dish
    {
        public HotWings() :base(6.99M){}
    }

    public class Fries : Dish
    {
        public Fries() : base(2.5M)
        {

        }
    }

    public class MillerLite : Dish
    {
        public MillerLite() : base(1.5M)
        {
        }
    }

    public class CoorsLite : Dish
    {
        public CoorsLite() : base(1.5M)
        {
        }
    }

    public class Soda : Dish
    {
        public Soda() : base(2.5M)
        {
        }
    }

    public class IcedTea : Dish
    {
        public IcedTea() : base(2.5M)
        {
        }
    }

    public class Nachos : Dish
    {
        public Nachos() : base(7.0M)
        {
        }
    }

    public class BlackenedChickenSandwich : Dish
    {
        public BlackenedChickenSandwich() : base(7.99M)
        {
        }
    }

    public class Pizza : Dish
    {
        public Pizza() : base(10.5M)
        {
        }
    }

    public class Calzone : Dish
    {
        public Calzone() : base(9.99M)
        {
        }
    }

    public class VealScallopini : Dish
    {
        public VealScallopini() : base(18.5M)
        {
        }
    }

}