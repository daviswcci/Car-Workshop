using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022_Car_Workshop
{
    // Abstraction - making a generic class that can be inherited by children classes by lending functionality
    public abstract class Vehicle
    {
        // When we use abstract on a property, we are declaring the getters and setters abstract, NOT the property itself
        public int Speed { get; set; }
        public int TopSpeed { get; set; }
        public int Cost { get; set; }

        // Because we used the abstract keyword, we were able to leave the implementation of these methods out
        public abstract string ToStringRepresentation();
        public abstract void ChangeCost(int cost);
        // But since we're in a class, we can implement methods if we'd like
        public static void Travel(int distance)
        {
            Console.WriteLine($"You traveled {distance} miles!");
        }

        public static Vehicle RandomVehicle()
        {
            // flip a coin
            Random random = new Random();
            var coin = random.Next();
            if(coin % 2 == 0)
            {
                // create a random car if heads
                return Car.RandomCar();
            }
            else
            {
                // create a random bike if tails
                return Bike.RandomBike();
            }

        }
        public abstract void Display();
    }
}
