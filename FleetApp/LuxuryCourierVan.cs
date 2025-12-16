using System;
using System.ComponentModel.Design;

namespace BaseVehicle
{
    public class LuxuryCourierVan : DeliveryTruck
    {
        private bool hasPremiumInterior;

        public LuxuryCourierVan(string name, int capacity) : base(name, capacity)
        {
            hasPremiumInterior = true; 
        }

        public void ActivateClimateControl()
        {
            if (hasPremiumInterior)
            {
                Console.WriteLine("Climate control on.");
            }
            else
            {
                Console.WriteLine("Standard AC on.");
            }
        }

        public override void StartEngine()
        {
            Console.WriteLine("Engine started smoothly.");
        }

        public override bool RequiresSpecialDocking
        {
            get { return true; }
        }
    }
}