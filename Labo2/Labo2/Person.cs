using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public abstract class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public Person(string name, string firstName)
        {
            Name = name;
            FirstName = firstName;
        }

        public override string ToString()
        {
            return Name + " " + FirstName;
        }

        public abstract bool HasHisBirthday();


    }
}
