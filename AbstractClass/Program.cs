using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;


namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle  myrec= new Rectangle(60, 70, Color.DarkOliveGreen, 100, 60);
            Square mysq = new Square(60,150,Color.DarkKhaki, 80);
            Circle mycirc = new Circle(60,240, Color.SteelBlue, 80);
            Console.WriteLine(myrec);
            Console.WriteLine(mysq);
            Console.WriteLine(mycirc);
            Process.Start("mspaint", "Shapes.jpg");
        }

       
    }
}
