using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Rectangle : Shape
    {
        int width,height;

        public int Width
        {
            get { return width; }
            set { if (value > SIZE) width = SIZE; else width = value; }
        }

        public int Height
        {
            get { return height; }
            set{if (value > SIZE) height = SIZE; else height = value;}
        }

        public Rectangle( int x,int y,Color color, int  width, int height ) : base(x, y,color)
        {
            Width = width;
            Height = height;
            Console.WriteLine($"NewRectangle: {GetHashCode()}");
        }

        public override double Perimeter() { return (Width + Height) * 2; }

        public override double Area() { return width * height; }

        public override void Draw()
        {
            Graphics buff = Graphics.FromImage(bits);
            
            Brush brush = new SolidBrush(Color);

            buff.FillRectangle(brush,X, Y, Width, Height);
            bits.Save("Shapes.jpg");
        }
        public override string ToString()
        {
           return base.ToString() +$"\nSides: {Width} , {Height}";
        }
    }
}
