using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInheritance
{
    internal class Student : Human
    {
     static readonly int SPECIALITY = 24;
     static readonly int GROUP = 8;
     static readonly int RATING = 5;
     static readonly int ATTENDANCE = 5;
            
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
            return base.ToString() +$" {Speciality.PadRight(SPECIALITY)} {Group.PadRight(GROUP)} {Rating.ToString().PadRight(RATING)} {Attendance.ToString().PadRight(ATTENDANCE)}";
        }

        public override string ToFileString()
        {
            return  base.ToFileString() + $"{Speciality}, {Group}, {Attendance}, {Rating}";
        }

        public override Human Init(string[] values)
        {
            base.Init(values);
            Speciality = values[4];
            Group = values[5];
            Rating = Convert.ToDouble(values[6]);
            Attendance = Convert.ToDouble(values[7]);
            return this;
        }
    }
}
