using Fall2022_Car_Workshop;
using NUnit.Framework;

namespace CarTests
{
    public class Tests
    {

        //Three A's of TDD
        //1. Arrange - arrange our data, what objects/variables are we using? Let's get them set up before continuing
        //2. Act - What are we going to do with that data? What methods are going to run?
        //3. Assert - What do we expect to see? 

        public Car testCar;

        [SetUp]
        public void Setup()
        {
            testCar = new Car();
        }

        [Test]
        public void Constructor_Should_Return_Initial_Value_Of_False_For_IsRunning()
        {
            //Arrange - This is being taken care of by our Setup method on line 17

            //Act - Also being taken care of with Setup method

            //Assert
            Assert.AreEqual(false, testCar.IsRunning);
        }

        [Test]
        public void Accelerate_Should_Increase_Speed_By_5()
        {
            //Arrange - taken care of in Setup method

            //Act 
            testCar.Accelerate();

            //Assert
            Assert.AreEqual(5, testCar.Speed);
        }
    }
}