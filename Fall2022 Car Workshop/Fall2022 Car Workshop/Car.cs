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

        public Car(string make, string model, int topspeed, string color, int cost)
        {
            Make = make;
            Model = model;
            Speed = 0;
            TopSpeed = topspeed;
            Color = color;
            Cost = cost;
            IsRunning = false;
        }

        // Methods

        public static Car CreateCar()
        {
            // prompt the user using the console to create a new car
            // return the car the user created
            Console.WriteLine("What is the name of your car's make?");
            var make = Console.ReadLine();
            Console.WriteLine("What is the name of your car's model?");
            var model = Console.ReadLine();
            Console.WriteLine("What is the color of your car?");
            var color = Console.ReadLine();
            Console.WriteLine("How fast can your car go?");
            var topSpeed = int.Parse(Console.ReadLine());
            Random random = new Random();
            var cost = random.Next(5000, 15000);
            return new Car(make, model, topSpeed, color, cost);
        }

        public static Car RandomCar()
        {
            Random rng = new Random();
            return new Car("RandomMake", "RandomModel", rng.Next(80,150), "RandomColor", rng.Next(8000,25000));
        }

        public override void Display()
        {
            Console.WriteLine($"Type: Car - Make: {Make} - Model: {Model} - Color: {Color} - Cost: {Cost}");
        }

        public void ChangeMake(string make)
        {
            Make = make;
        }

        public override void ChangeCost(int cost)
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
