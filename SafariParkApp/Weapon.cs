using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Weapon : IShootable
    {
        private readonly string _brand;

        public virtual string Shoot()
        {
            return $"{_brand}";
        }

        public new virtual string? ToString()
        {
            return base.ToString();
        }

        public Weapon(string brand)
        {
            _brand = brand;
        }
    }
}
