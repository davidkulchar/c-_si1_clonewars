using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingClass
{
    class Person
    {
        public enum Genders {Male, Female};

        public string name;
        public DateTime birthDate;
        public Genders gender;

        public Person(string _name, DateTime _birthdate, Genders _gender)
        {
            name = _name;
            birthDate = _birthdate;
            gender = _gender;
        }

        override public string ToString()
        {
            string _string = "Name: " + name + " BirthDate: " + birthDate + " Gender: " + gender;
            return _string;
        }
    }
}
