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
            Speed = 0;
            TopSpeed = 50;
            Cost = 300;
        }

        // Methods
        public override void ChangeCost(decimal cost)
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
