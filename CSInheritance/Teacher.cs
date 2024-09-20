using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInheritance
{
    internal class Teacher : Human
    {
        public string Speciality { get; set; }
        public uint Experience {  get; set; }

        public Teacher(
            string lastname, string firstname, uint age,
            string speciality, uint experience) : base(lastname,firstname,age)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"Tconstructor: {GetHashCode()}");
        }

        public Teacher(Human human,
    string speciality, uint experience) : base(human)
        {
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"Tconstructor: {GetHashCode()}");
        }
        ~Teacher()
        {
            Console.WriteLine($"Tdestructor: {GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $", {Speciality} {Experience}";
        }
    }
}
