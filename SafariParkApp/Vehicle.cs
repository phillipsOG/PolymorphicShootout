using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle : IMovable
    {
        private readonly int _capacity;
        private readonly int _numPassengers;

        public int Position { get; private set; }
        public int Speed { get; init; } = 10;
        public int NumPassengers
        {
            get
            {
                return NumPassengers;
            }
            set
            {
                if (value > _capacity) throw new ArgumentOutOfRangeException(
                    "Number of passengers cannot be greater than capacity");
                else if (value < 0) throw new ArgumentOutOfRangeException(
                    "Number of passengers cannot be a negative value");

                NumPassengers = value;
            }
        }

        public Vehicle()
        {
        }

        public Vehicle(int capacity, int speed = 10)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException("Capacity cannot be negative");

            _capacity = capacity;
            Speed = speed;
        }

        // Move Vehicle once
        public string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public string Move(int times)
        {
            if (times < 0) throw new ArgumentOutOfRangeException("Argument cannot be negative");

            Position += Speed * times;
            return $"Moving along {times} times";
        }
    }
}
