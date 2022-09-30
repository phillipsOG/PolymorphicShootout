using SafariParkApp;

namespace SafariParkTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PersonConstructs_With_NoParameters()
        {
            var sut = new Person();

            Assert.That(sut, Is.InstanceOf<Person>());
        }

        [TestCase("Nish", "Mandel", 99)]
        public void PersonConstructs_With_FirstName_LastName_Age(string fName, string lName, int age)
        {
            var sut = new Person(fName, lName, age);

            Assert.That(sut.FirstName, Is.EqualTo(fName));
            Assert.That(sut.LastName, Is.EqualTo(lName));
            Assert.That(sut.Age, Is.EqualTo(age));
        }

        [Test]
        public void PersonGetFullName_Gets_BobBuilder()
        {
            //Arrange
            string expected = "Bob Builder";
            var sut = new Person("Bob", "Builder", 18);

            //Act
            string result = sut.GetFullName();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0, 0, 0)]
        [TestCase(10, 25, 5)]
        public void Point3DConstructs_With_Parameters(int testX, int testY, int testZ)
        {
            Point3D test3D = new Point3D(testX, testY, testZ);

            Assert.That(test3D.x, Is.EqualTo(testX));
            Assert.That(test3D.y, Is.EqualTo(testY));
            Assert.That(test3D.z, Is.EqualTo(testZ));
        }

        [Test]
        public void Point3D_TranslateMethod_ReturnsExpectedValues()
        {
            int[] testValues = { 1, -5, 2 };
            Point3D test3D = new Point3D(10, 10, 10);
            Point3D expected3D = new Point3D(11, 5, 12);

            test3D.Translate(testValues[0], testValues[1], testValues[2]);

            Assert.That(test3D, Is.EqualTo(expected3D));
        }

        #region Shootout Tests
        [Test]
        public void GivenAHunterObjectWithALaserGunIShootable_HunterShootMethod_ReturnsCorrectString()
        {
            var laser = new LaserGun("Laser Gun");
            var testHunter = new Hunter("John", "Doe", laser);

            string shootResult = testHunter.Shoot();
            string expectedResult = "John Doe takes a shot with their Laser Gun: BEAM BEAM BEAM";

            Assert.That(shootResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAHunterObjectWithAWaterGunIShootable_HunterShootMethod_ReturnsCorrectString()
        {
            var waterPistol = new WaterPistol("Water Gun");
            var testHunter = new Hunter("John", "Doe", waterPistol);

            string shootResult = testHunter.Shoot();
            string expectedResult = "John Doe takes a shot with their Water Gun: WET WET WET";

            Assert.That(shootResult, Is.EqualTo(expectedResult));
        }
        #endregion

    }
}