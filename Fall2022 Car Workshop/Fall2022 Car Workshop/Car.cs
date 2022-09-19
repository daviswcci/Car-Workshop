using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Car_Workshop
{
    internal class Car : Vehicle, IAudible, IEquatable<Car>, IColorable
    {
        // properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        // Constructor
        public Car()
        {
            Make = "Chrysler";
            Model = "PT Cruiser";
            Speed = 0;
            TopSpeed = 150;
            Cost = -1500;
        }

        // Methods
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
    }
}
