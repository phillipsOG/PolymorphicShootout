﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {
        }

        public override string Shoot()
        {
            return $"{base.Shoot()}: WET WET WET";
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
