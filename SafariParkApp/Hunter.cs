using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }

        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName) // Passing to base class for property assignment
        {
            Shooter = shooter;
        }

        public Hunter() { } // Have to have paramterless constructor for derived classes as well - not inherited
        public override string? ToString()
        {
            return $"{base.ToString()}"; // Accesses Persons ToString() which inherits Objects ToString()
        }

        //public override string GetFullName() => $"{FirstName} {LastName} is a hunter!";

        public string Shoot()
        {
            return $"{GetFullName()} takes a shot with their {Shooter.Shoot()}";
        }
    }
}
