using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person, IShootable
    {
        public string shooter;

        public Hunter(string fName, string lName, string camera = "Sony Alpha 100") : base(fName, lName) // Passing to base class for property assignment
        {
            shooter = camera;
        }

        public Hunter() { } // Have to have paramterless constructor for derived classes as well - not inherited
        public override string? ToString()
        {
            return $"{base.ToString()} Camera: {shooter}"; // Accesses Persons ToString() which inherits Objects ToString()
        }

        public override string GetFullName() => $"{FirstName} {LastName} is a hunter!";

        public string Shoot()
        {
            return $"{GetFullName()} takes a photo with their {shooter}";
        }
    }
}
