using Fall2022_Car_Workshop;


// Workshop - Creating a car application that acts as a garage where a user could manage basic vehicle inventory
// and perform service tasks on specific vehicles. We also want to be able to buy and sell cars.

// Setup - Organize application data
var vehicles = new List<Vehicle>();
var money = 20000m;
Vehicle activeVehicle;

// Prompt our user - display a menu with particular tasks the user can engage with
// NOTE - We always need a way to exit the application (without control c, skip)

// First, ask user for garage name, setup their first vehicle
Console.WriteLine("Welcome to your brand new garage!");
Console.WriteLine("What is your name?");
// string? - nullable string, meaning the value can be either a string or null
var garageName = Console.ReadLine();
if(garageName == null)
{
    garageName = "Default";
}
Console.Clear();
Console.WriteLine("Would you like to start with a car or a bike?\n1. Car\n2. Bike");
switch (Console.ReadLine())
{
    case "2":
        // Create bike
        // some kind of method that steps the user through a creation process, and returns a bike
        // do the same for bike that we do for car
        activeVehicle = Bike.CreateBike();
        vehicles.Add(activeVehicle);
        break;
    default:
        // Create car
        // some kind of method that steps the user through a creation process, and returns a car
        activeVehicle = Car.CreateCar();
        vehicles.Add(activeVehicle);
        break;
}

// then, we go into a while loop and prompt the user based on what we want our application to look like.
var running = true;
while (running)
{
    Console.Clear();
    Console.WriteLine($"The {garageName} Garage!");
    Console.WriteLine($"You have ${money} remaining.");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1: Buy a new vehicle\n2: Sell a vehicle\n3: Swap vehicles\n4: List all vehicles\nQ: Quit application");
    var option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.Clear();
            // generate a random car/bike
            Vehicle toBuy = Vehicle.RandomVehicle();
            // we need to list information about that vehicle
            toBuy.Display();
            // ask user if they want to buy?
            Console.WriteLine("Would you like to buy this vehicle? (Y/N)");
            // if so (and they have enough dough) then add to inventory and update cash
            var response = Console.ReadLine();
            if(response == "Y")
            {
                // add to inventory and update cash
                if(money >= toBuy.Cost)
                {
                    vehicles.Add(toBuy);
                    money -= toBuy.Cost;
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Maybe next time.");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            break;
        case "2":
            // option 1
            break;
        case "3":
            // option 1
            break;
        case "Q":
            running = false;
            break;
        default:
            Console.WriteLine("Please select one of the provided options.");
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
            break;
    }
    Tick();
}
Console.WriteLine("Thanks for playing!");
// we'll want to create methods that support the options we provide to our users

// this method runs after the passing of time (at the end of each loop for us)
// local method, no need for access modifiers
// if you want to access variables in program, don't make the method static
void Tick()
{
    money -= 250;
}