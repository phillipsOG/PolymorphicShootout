using SafariParkApp;

namespace SafariParkTests
{
    public class VehicleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void WhenADefaultVehicleIsMovedTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenNumOfPassengersIsGreaterThanCapacityThrowArgumentOutOfRangeExcpetion()
        {
            Vehicle v = new Vehicle(10);
            Assert.That(() => v.NumPassengers = 11, Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contains("Number of passengers cannot be greater than capacity"));
        }

        [Test]
        public void WhenNumOfPassengersIsANegativeValueThrowArgumentOutOfRangeExcpetion()
        {
            Vehicle v = new Vehicle(10);
            Assert.That(() => v.NumPassengers = -1, Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contains("Number of passengers cannot be a negative value"));
        }

        [Test]
        public void WhenAVehicleIsGivenANegativeValueThrowArgumentOutOfRangeExcpetion()
        {
            bool exceptionThrown = false;
            try
            {
                Vehicle v = new Vehicle(-1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                exceptionThrown = true;
            }
            
            Assert.That(exceptionThrown);
        }

        [Test]
        public void WhenTheMoveMethodIsGivenANegativeValueThrowArgumentOutOfRangeExcpetion()
        {
            Vehicle v = new Vehicle();
            Assert.That(() => v.Move(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}