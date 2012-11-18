using RestaurantEventThing.Core;
using RestaurantEventThing.Core.Actors;
using RestaurantEventThing.Core.Events;

namespace QuickConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockroom = new StockRoom();
            new Setup().Execute(stockroom);


            var joe = new Customer();
            

            var order = new OrderPlacedEvent();
            order.Items.Add(new MillerLite());
            order.Items.Add(new BaconCheeseBurger());

            var kitchen = new Kitchen();


            EventManager.Register<OrderPlacedEvent>(joe.PlaceOrder);
            EventManager.Register<OrderPlacedEvent>(stockroom.OrderPlaced);
            EventManager.Register<ItemMovedToKitchenEvent>(kitchen.Cook);
            EventManager.Register<OrderReadyEvent>(joe.ReceiveOrder);
            


            EventManager.Raise(order);

            //customer places order
            //stockroom moves order to kitchen
            //kithcen prepared order
            //waitstaff delivers order
            //waitstaff checks on customer
            //waitstaff delivers bill
            //customer pasys
            //marketing sends a thanks a lot email
            //waitstaff delivers reciept
            //Done!


        }
    }
}
