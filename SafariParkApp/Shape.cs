using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Shape
    {
        public abstract int CalculateArea(); //Definition with no implementation - Implement in Dervided classes
    }

    public class Rectangle : Shape
    {
        private int _height;
        private int _width;

        public override int CalculateArea()
        {
            return _height * _width;
        }
    }
}
