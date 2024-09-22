#define INHERITANCE
#define WRITE_TO_FILE
using CSInheritance;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{

    internal class Program
    {
        static void Main(string[] args)
        {
#if INHERITANCE1
            Student student = new Student("Tommy", "Hellfiger", 22, "Janitor", "Koko", 88, 97);
            Teacher teacher = new Teacher("Mark", "Hoffman", 37, "Executioner", 5);
            Console.WriteLine(student);
            Console.WriteLine(teacher); 
#endif
#if WRITE_TO_FILE
            Human tommy = new Human("Vercetty", "Tommy", 30);
            Human ricardo = new Human("Diaz", "Ricardo", 50);

            Human[] group =
            {
            new Student(tommy, "Theft", "Vice", 95, 98),
            new Teacher(ricardo, "Weapons distribution", 8),
            new Graduate("Pepe", "Popo", 32, "Dragons", "DN_22", 33, 44, "Minions", 5)
            };

            print(group);
            save(group, "humans.csv"); // comma separated values
                                      // CSV - general format of files to store tablets in text files.
                                     // READ  
#endif

           Human[] humans  = load("humans.csv");
            print(humans);
        }
        static void print(Human[] group)
        {
            for (int i = 0; i < group.Length; ++i)
            {
                Console.WriteLine($"\n{group[i].ToString()}"); //DownCast
            }
        }

        static void save(Human[] group, string filename)
        {
            StreamWriter filegroup = new StreamWriter(filename);

            foreach (Human i in group)
            {
                filegroup.WriteLine(i.ToFileString()); // DownCast
            }
            filegroup.Close();
           // Process.Start("excel", filename);
        }

        static Human[] load(string filename)
        {
            List<Human> list = new List<Human>();
            StreamReader sr = new StreamReader(filename);
            while (!(sr.EndOfStream))
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
                string[] values = buffer.Split(',');
                list.Add(HumanFactory(values[0]).Init(values));
            }
            sr.Close();
            return list.ToArray();
        }

        static Human HumanFactory(string type) // 
        {
            Human human = null;
            switch (type)
            {
                case "Human": human = new Human(); break;
                case "Student": human = new Student("", "", 0, "", "", 0, 0); break;
                case "Teacher": human = new Teacher("", "", 0, "", 0); break;
                case "Graduate": human = new Graduate("", "", 0, "", "", 0, 0, "", 0); break;
            }
            return human;
        }
    }
}
