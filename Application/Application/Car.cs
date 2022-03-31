using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class Car:Vehicle
    {

        private double _currentFuel;
        private double _fuelCapacity;
        private double _fuelFor1Km;

        public double CurrentFuel {
            get
            {
                return _currentFuel;
            }
            set
            {
                if(value>0 && value <= FuelCapacity)
                {
                    value = _currentFuel;
                }
            }
         }

        public double  FuelCapacity 
        
        {
            get{
                return _fuelCapacity;
            }
            set {
                if (value > 0)
                {
                    value = _fuelCapacity;
                }
            }
        }

        public double FuelFor1Km
        {
            get
            {
                return _fuelFor1Km;
            }
            set
            {
                if (value > 0 && value <= FuelCapacity)
                {
                    value = _fuelFor1Km;
                }
            }
        }

        public override void Drive(double distance)
        {
            
            if (CurrentFuel >= FuelFor1Km * distance)
            {

                CurrentFuel -= FuelFor1Km * distance;
                Millage += distance;
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");
            }

        }
    }
}
