namespace SafariParkApp;

internal class Program
{
    static void Main(string[] args)
    {
        #region Commented Code
        /*
        Person cathy = new Person("Catherine", "French", 35);
        //Console.WriteLine(cathy.GetFullName());

        Person peter = new Person("Peter", "Bellaby", 29);
        //Console.WriteLine(peter.FullName);

        Person laura = new Person("Laura", "Tozer"); // Ignores optional parameter constructor
        Person cesar = new Person();

        cathy.Age = 30;
        Console.WriteLine($"Cathy is now {cathy.Age}");

        //Console.WriteLine($"Cathy's first name is {cathy._firstName}"); // Can access due to public but is protected by readonly

        var syed = new Person("Syed", "Ahmed") { Age = 18 }; // set Age property
        //syed.Age = 20;

        var list = new ShoppingList { Bread = 2, Potato = 6, Lemon = 11 }; // Able to optionally assign properties compared to parametered constructors

        Point3D p = new Point3D(1, 2);
        Point3D origin;

        p.Translate(1, -1, 0);
        int x = 3;
        */

        //Hunter laura = new Hunter("Laura", "Tozer", "Sony Beta 10000") { Age = 21 };
        //Console.WriteLine(laura.Shoot());

        //Hunter lizzie = new Hunter() { FirstName = "Elizabeth", LastName = "Windsor", Age = 99 }; // Does not work without parameterless constructor
        //lizzie.shooter = lizzie.FirstName;
        //Console.WriteLine(lizzie.Shoot());
        //Console.WriteLine(lizzie);

        //var lewis = new Person() { FirstName = "Lewis" };
        //laura.shooter = lizzie.shooter;
        //Console.WriteLine(laura.Shoot());

        //Console.WriteLine("Lewis ToString() " + lewis);
        //Console.WriteLine("Lewis GetHashCode() " + lewis.GetHashCode());
        //Console.WriteLine("Lewis GetType() " + lewis.GetType());
        //Console.WriteLine("Lewis Equals(adam) is " + lewis.Equals(lizzie));

        //List<Object> safariObjects = new List<Object>()
        //{
        //    new object(),
        //    new Person() {FirstName = "Connor", LastName = "Phillips"},
        //    new Hunter("Jai", "Kothari", "Poke-cam"),
        //    new Vehicle(5, 200)
        //};



        //var michael = new Hunter("Michael", "Davies");
        //Console.WriteLine(michael.Move());

        //var movables = new List<IMovable>()
        //{
        //    michael,
        //    lewis,
        //    lizzie,
        //    laura,
        //    new Vehicle(3, 5) {NumPassengers = 1}
        //};

        //foreach (var m in movables)
        //{
        //    Console.WriteLine(m.Move());
        //}
        #endregion

        #region Polymorphic Shootout
        var superSoaker = new WaterPistol("Supersoaker");
        var laser = new LaserGun("LASERBEAMR");
        var waterPistol = new WaterPistol("Water Pistol");
        var gatlingLaser = new LaserGun("Gatling Laser");

        var hunterShootable1 = new Hunter("John", "Doe", laser);
        var hunterShootable2 = new Hunter("Connor", "Phillips", superSoaker);
        var hunterShootable3 = new Hunter("Adam", "Reed", gatlingLaser);
        var hunterShootable4 = new Hunter("Bruce", "Wayne", waterPistol);
        var camera = new Camera("Nikon 3000");

        var hunterList = new List<IShootable>()
        {
            hunterShootable1,
            hunterShootable2,
            hunterShootable3,
            hunterShootable4
        };

        foreach (var item in hunterList)
        {
            //Console.WriteLine(item);
            Console.WriteLine(item.Shoot());
        }

        #endregion
    }

    public static void SpartaWrite(Object obj)
    {
        
        if (obj is Person) // Checks type is Person
        {
            var p = (Person)obj;
            Console.WriteLine("Console log: " + p.GetFullName());
        }
        else
        {
            Console.WriteLine("Console log: " + obj.ToString());
        }
    }
}