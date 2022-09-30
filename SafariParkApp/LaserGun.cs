using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {
        }

        public override string Shoot()
        {
            return $"{base.Shoot()}: BEAM BEAM BEAM";
        }

    }
}
