using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInheritance
{
    internal class Graduate : Student
    {

        public string WorkTopic {  get; set; }
        public int WorkGrade {  get; set; }

        public Graduate(string lastname, string firstname, uint age,
            string speciality, string group, double rating, double attendance, string worktopic, int workgrade)
            : base(lastname, firstname, age, speciality, group, rating, attendance)
        {
         
            WorkTopic = worktopic;
            WorkGrade = workgrade;
            Console.WriteLine($"Gconstructor: {GetHashCode()}");
        }

        ~Graduate()
        {
            Console.WriteLine($"Gdestructor: {GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $", {WorkTopic}:  {WorkGrade}";
        }
    }
}
