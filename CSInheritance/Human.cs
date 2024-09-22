using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInheritance
{
    internal class Human
    {
        static readonly int TYPE_WIDTH = 10;
        static readonly int LN_WIDTH = 12;
        static readonly int FN_WIDTH = 7;
        static readonly int AGE = 5;
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public uint Age { get; set; }

        public Human(string lastName = "", string firstName="",  uint age =0)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"Hconstructor: {GetHashCode()}");
        }
        public Human(Human other)
        {
            LastName = other.LastName;
            FirstName = other.FirstName;
            Age = other.Age;
            Console.WriteLine($"H_COPYconstructor: {GetHashCode()}");
        }
        ~Human()
        {
            Console.WriteLine($"Hdestructor: {GetHashCode()}");                
        }

        public override string ToString()
        {
            return  (base.ToString().Split('.').Last()+":") + $" {LastName},{FirstName},{Age}";    
        }

        public virtual string ToFileString()
        {
            return (base.ToString().Split('.').Last() + ",") + $" {LastName},{FirstName},{Age},";
        }

        public Human Parse(string info)
        {
            string[] tokens = info.Split(' ');
            LastName = tokens[1];
            FirstName = tokens[2];
            Age = Convert.ToUInt32(tokens[3]);
            return this;
        }

        public virtual Human Init(string[] values)
        {
            LastName=values[1];
            FirstName=values[2];
            Age=Convert.ToUInt32(values[3]);
            return this;
        }
    }
}
