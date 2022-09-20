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
Console.WriteLine("Would you like to start with a car or a bike?\n1. Car\n 2. Bike");
switch (Console.ReadLine())
{
    case "2":
        // Create bike
        // some kind of method that steps the user through a creation process, and returns a bike
        // do the same for bike that we do for car
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
    // prompting here
    var option = Console.ReadLine();
    switch (option)
    {
        case "1":
            // option 1
            break;
        case "Q":
            running = false;
            break;
    }
}
Console.WriteLine("Thanks for playing!");
// we'll want to create methods that support the options we provide to our users
