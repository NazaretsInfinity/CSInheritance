using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{


    internal abstract class Shape
    {
        static readonly protected Bitmap bits = new Bitmap(1000, 1000);
        static readonly int Xs = 50;
        static readonly int Xg = 850;
        static readonly int Ys = 50;
        static readonly int Yg = 850;
        static public readonly int SIZE = 100;

        int x, y;
        Color color;
        public int X
        { 
            get{ return x;}
            set 
            { 
                if(value < Xs) x= Xs;
                if(value > Xg) x= Xg;
                else x= value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value < Ys) x = Ys;
                if (value > Yg) x = Yg;
                else y = value;
            }
        }
        public Color Color { get; set; }
        // the same name of class type and object itself. Yet!
        // First 'Color' is in System drawing namespace
        //The second one is in Abstract

        public abstract double Perimeter();
        public abstract double Area();
        public abstract void Draw(PaintEventArgs e);
        public virtual void Info(PaintEventArgs e)
        {       
            Console.WriteLine($"Shape: {GetType().Name};\nPerimeter = {Perimeter()};\nArea = {Area()};");
            Draw(e);
        }

        public Shape(int x, int y, Color color){ X = x; Y = y; Color = color;}
    }
}
