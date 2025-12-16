using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace BaseVehicle
{
    public class DeliveryTruck : IDeliverable
    {
        private string truckName;
        private int weight;
        private int maxCapacity;

        public DeliveryTruck(string name, int capacity)
        {
            truckName = name;
            maxCapacity = capacity;
            weight = 0;
        }

        public string name
        {
            get { return truckName; }
        }

        public int LoadWeight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    weight = 0;
                    Console.WriteLine("Warning! Capacity can't be Negative.");
                }
                else if (value > maxCapacity)
                {
                    weight = maxCapacity;
                    Console.WriteLine("Warning! Capacity can't Exceed Maximum Load Capacity.");
                }
                else
                {
                    weight = value;
                }
            }
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Delivery Truck engine started.");
        }

        public bool RequiresSpecialDocking
        {
            get { return false; }
        }

        public void LoadCargo (int currentWeight)
        {
            LoadWeight += currentWeight;
            Console.WriteLine($"Added {currentWeight} units to {truckName}");
        }

        public void UnloadCargo (int currentWeight)
        {
            LoadWeight -= currentWeight;
            Console.WriteLine($"Removed {currentWeight} units from {truckName}");
        }
    }
}