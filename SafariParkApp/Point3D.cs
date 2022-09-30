﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public struct Point3D
    {
        private bool _inScope;

        public int x, y, z;

        public Point3D(int x, int y, int z = 0)
        {
            _inScope = false;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Translate(int x, int y, int z)
        {
            this.x += x;
            this.y += y;
            this.z += z;
        }
    }
}
