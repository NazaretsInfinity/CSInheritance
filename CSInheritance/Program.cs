#define INHERITANCE
using CSInheritance;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{

    internal class Program
    {
        static Human HumanFactory(string type)
        {
            if (type.Contains("Student:"))return new Student("", "", 0, "", "", 0, 0);
            if (type.Contains("Graduate:"))return new Graduate("", "", 0, "", "", 0, 0, "", 0);
            if (type.Contains("Teacher:")) return new Teacher("", "", 0, "", 0);
            return new Human();
        }
        static void Main(string[] args)
        {
#if INHERITANCE1
            Student student = new Student("Tommy", "Hellfiger", 22, "Janitor", "Koko", 88, 97);
            Teacher teacher = new Teacher("Mark", "Hoffman", 37, "Executioner", 5);
            Console.WriteLine(student);
            Console.WriteLine(teacher); 
#endif
            Human tommy = new Human("Vercetty", "Tommy", 30);
            Human ricardo = new Human("Diaz", "Ricardo", 50);

            Human[] group =
            {
            new Student(tommy, "Theft", "Vice", 95, 98),
            new Teacher(ricardo, "Weapons distribution", 8),
            new Graduate("Pepe", "Popo", 32, "Dragons", "DN_22", 33, 44, "Minions", 5)
            };

            // SAVE
            StreamWriter filegroup = new StreamWriter("group.txt");

            foreach (Human i in  group)
            {
                filegroup.WriteLine(i.ToString());
            }

            filegroup.Close();
            Process.Start("notepad", "group.txt");

            // READ
            int am = 0;
            StreamReader groupread = new StreamReader("group.txt");
            while(!groupread.EndOfStream)
            {
                string buffer = groupread.ReadLine();
                ++am;
            }

            groupread.BaseStream.Seek(0, SeekOrigin.Begin); 

            Human[] humans = new Human[am];
            for(int i = 0; i< am; ++i)
            {
               string type = groupread.ReadLine();
                Console.WriteLine(type);
                humans[i] = HumanFactory(type);
                humans[i].Parse(type); 
            }
            groupread.ReadToEnd();

            foreach (Human i in humans)
            {
                Console.WriteLine($"\n{i.ToString()}");
            }
        }
    }
}
