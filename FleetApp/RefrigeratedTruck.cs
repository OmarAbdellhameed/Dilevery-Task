using System;

namespace BaseVehicle
{
    public class RefrigeratedTruck : DeliveryTruck
    {
        public RefrigeratedTruck(string name, int capacity) : base(name, capacity)
        {
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{name} Engine started. Cooling system turned on.");
        }
    }
}