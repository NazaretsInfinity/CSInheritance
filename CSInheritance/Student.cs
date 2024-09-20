using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInheritance
{
    internal class Student : Human
    {
        public string Speciality {  get; set; }
        public string Group { get; set; }

        public double Rating { get; set; }
        public double Attendance { get; set; }

        public Student(string lastname, string firstname, uint age,
            string speciality, string group, double rating, double attendance)
            : base(lastname, firstname, age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"Sconstructor: {GetHashCode()}");

        }
        public Student(Human human, string speciality, string group, double rating, double attendance)
            : base(human)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"Sconstructor: {GetHashCode()}");
        }
        ~Student()
        {
          Console.WriteLine($"Hdestructor: {GetHashCode()}");            
        }

        public override string ToString()
        {
            return base.ToString() +$", {Speciality} - {Group}, {Rating}, {Attendance}";
        }
    }
}
