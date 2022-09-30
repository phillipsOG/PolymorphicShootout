using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IMovable
    {
        //public readonly string _firstName = ""; // Can access globally but readonly
        //private string _lastName = "";

        //Property versions
        //private set only allows setting via Constructor
        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";

        private int _age;

        //public int Age { get; set; } // public refers to the method { get; set; } not the variable itself

        // Same as above
        // But syntacticly correct and is easily extensible for the future
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _age = value;
            }
        }

        Point3D position;

        public Person(string firstName, string lastName, int age = 18)
        {
            //_firstName = firstName;
            //_lastName = lastName;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            //_firstName = firstName;
            //_lastName = lastName;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string? ToString()
        {
            return $"{base.ToString()} Full name: {GetFullName()}"; // Accesses Object's version of ToString(), not Person's
        }

        //public string FullName => $"{_firstName} {_lastName}"; // get only i.e. readonly

        //public string GetFullName() => $"{_firstName} {_lastName}";
        public virtual string GetFullName() => $"{FirstName} {LastName}";

        //public string GetNickname() => $"{_firstName.First()}-dog {_lastName}ino";
        public string GetNickname() => $"{FirstName.First()}-dog {LastName}ino";

        public string Move()
        {
            return "Walking along.";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times.";
        }
    }
}