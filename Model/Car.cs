using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17.Model
{
    internal class Car : IVehicle
    {
        public double MileAge { get; private set; }
        public double Fuel { get; private set; }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }

        public Car(double fuel = 20, double fuelConsumption = 40, double tankCapacity = 10)
        {
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
            MileAge = 0;
        }

        public bool Drive(double kilometer)
        {
            double fuelNeeded = kilometer * FuelConsumption;

            if (fuelNeeded <= Fuel)
            {
                Fuel -= fuelNeeded;
                MileAge += kilometer;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Refuel(double amount)
        {
            if (Fuel + amount <= TankCapacity)
            {
                Fuel += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    }
