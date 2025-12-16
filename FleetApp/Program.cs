using System;

namespace BaseVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            DeliveryTruck truck1 = new DeliveryTruck("Standart Truck", 100);
            RefrigeratedTruck truck2 = new RefrigeratedTruck("Ice Cream Truck", 100);
            LuxuryCourierVan truck3 = new LuxuryCourierVan("VIP Van", 50);

            truck1.StartEngine();
            truck2.StartEngine();
            truck3.StartEngine();

            truck1.LoadCargo(200);
            truck1.UnloadCargo(500);

            IDeliverable[] myFleet = { truck1, truck2, truck3 };

            foreach (IDeliverable vehicle in myFleet)
            {
                Console.WriteLine($"Does it require Special Docking? {vehicle.RequiresSpecialDocking}");
                vehicle.LoadCargo(50);
            }
        }
    }
}