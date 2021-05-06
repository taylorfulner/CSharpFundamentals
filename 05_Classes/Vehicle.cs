using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Plane, Boat, Scooter }
    public class Vehicle
    {

        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }

        public Vehicle() { }



        //below are properties: access modifier (public, so other classes have access to it)
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }

        //constructor
        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turned on the vehicle");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turned off the vehicle");
        }

        public bool RightIndicator { get; set; }
        public bool LeftIndicator { get; set; }

        public void IndicateRight()
        {
            RightIndicator = true;
            LeftIndicator = false;
        }

        public void IndicateLeft()
        {
            LeftIndicator = true;
            RightIndicator = false;
        }

        public void TurnOnHazards ()
        {
            RightIndicator = true;
            LeftIndicator = true;
        }

        public void TurnOffHazards ()
        {
            RightIndicator = false;
            LeftIndicator = false;
        }

        //challenge: make indicator it's own custom class
        //          properties including IsFlashing
        //          method for TurnOn() and TurnOff()
    }

    public class Indicator
    {
        public bool IsFlashing { get; set; }

        public void TurnOn()
        {
            IsFlashing = true;
        }

        public void TurnOff()
        {
            IsFlashing = false;
        }
    }
}
