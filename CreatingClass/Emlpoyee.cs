using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CreatingClass
{
    class Emlpoyee : Person
    {
        public string profession;
        public int salary;
        public Room room;


        public Emlpoyee(string name, DateTime birthdate, Genders gender, string _profession, int _salary, Room _room) : base(name, birthdate, gender) {
            profession = _profession;
            salary = _salary;
            room = _room;
        }

        override public string ToString()
        {
            string _string = "Name: " + name + " BirthDate: " + birthDate + " Gender: " + gender + " Profession: " + profession + " Salary: " + salary + " Room: " + room.num;
            return _string;
        }
        

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
