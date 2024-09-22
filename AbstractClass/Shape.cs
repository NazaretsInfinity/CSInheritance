using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{


    internal abstract class Shape
    {
        static public Bitmap bits = new Bitmap(1000, 1000);
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

        public abstract double Perimeter();
        public abstract double Area();
        public abstract void Draw();
        public override string ToString()
        {
            Draw();
            return $"Shape: {GetType().Name};\nPerimeter = {Perimeter()};\nArea = {Area()};";
        }

        public Shape(int x, int y, Color color){ X = x; Y = y; Color = color;}
    }
}
