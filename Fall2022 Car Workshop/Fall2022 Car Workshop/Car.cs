using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Car_Workshop
{
    public class Car : Vehicle, IAudible, IEquatable<Car>, IColorable
    {
        // properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool IsRunning { get; set; }

        // Constructor
        public Car()
        {
            Make = "Chrysler";
            Model = "PT Cruiser";
            Speed = 0;
            TopSpeed = 150;
            Cost = -1500;
            IsRunning = false;
        }

        public Car(string make, string model, int speed, int topspeed, string color, decimal cost, bool isRunning)
        {
            Make=make;
            Model=model;
            Speed=speed;
            TopSpeed=topspeed;
            Color=color;
            Cost=cost;
            IsRunning=isRunning;
        }

        // Methods

        public static Car CreateCar()
        {
            // prompt the user using the console to create a new car
            // return the car the user created
            return new Car();
        }

        public void ChangeMake(string make)
        {
            Make = make;
        }

        public override void ChangeCost(decimal cost)
        {
            Cost = cost;
        }

        public override string ToStringRepresentation()
        {
            // alternative to string concatenation is string literals
            return $"Make: {Make} \nModel: {Model} \nTop Speed: {TopSpeed} \nCost: {Cost}";
        }

        public void MakeSound()
        {
            Console.WriteLine("HONK!!!");
            Console.Beep();
        }

        public bool Equals(Car? other)
        {
            return true;
        }

        public void SetColor(string color)
        {
            Color = color;
        }

        public bool CompareColor(IColorable other)
        {
            return Color == other.Color;
        }

        public void Accelerate()
        {
            Speed += 5;
        }
    }
}
