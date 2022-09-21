using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Car_Workshop
{
    internal class Bike : Vehicle, IAudible, IColorable
    {
        // properties
        public string Brand { get; set; }
        public string Color { get; set; }
        
        // Constructor - default
        // this outlines what our default bike looks like, this DOES NOT create a new bike
        public Bike()
        {
            Brand = "Schwinn";
            Color = "Red";
            Speed = 0;
            TopSpeed = 50;
            Cost = 300;
        }

        public Bike(string brand, string color, int topSpeed, int cost)
        {
            Brand = brand;
            Color = color;
            Speed = 0;
            TopSpeed = topSpeed;
            Cost = cost;
        }

        // Methods

        public static Bike CreateBike()
        {
            Console.WriteLine("What is the name of your bike's brand?");
            var brand = Console.ReadLine();
            Console.WriteLine("What is the color of your bike?");
            var color = Console.ReadLine();
            Console.WriteLine("How fast can your bike go?");
            var topSpeed = int.Parse(Console.ReadLine());
            Random random = new Random();
            var cost = random.Next(1000,5000);
            return new Bike(brand, color, topSpeed, cost);
        }

        public static Bike RandomBike()
        {
            Random rng = new Random();
            List<string> brands = new List<string>() { "Schwinn", "GIANT", "Trek", "Specialized" };
            return new Bike(brands[ rng.Next(brands.Count) ], "RandomColor", rng.Next(80, 150), rng.Next(500, 6000));
        }

        public override void Display()
        {
            Console.WriteLine($"Type: Bike - Brand: {Brand} - Color: {Color} - Cost: {Cost}");
        }

        public override void ChangeCost(int cost)
        {
            Cost = cost;
        }

        public override string ToStringRepresentation()
        {
            // alternative to string concatenation is string literals
            return $"Brand: {Brand} \nTop Speed: {TopSpeed} \nCost: {Cost}";
        }

        public void MakeSound()
        {
            Console.WriteLine("Ring!");
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
