using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInheritance
{
    internal class Human
    {
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
            return  $"{GetType().Name}: {LastName} {FirstName} {Age} y/o";    
        }

        public virtual void Parse(string info)
        {
            string[] tokens = info.Split(' ');
            LastName = tokens[1];
            FirstName = tokens[2];
            Age = Convert.ToUInt32(tokens[3]);
        }
    }
}
