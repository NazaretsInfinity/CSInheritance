﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Circle : Shape
    {
        int radius; 
        public int Radius
        {
            get { return radius; }
            set { if (value > SIZE) radius = SIZE; else radius = value; }
        }

       public Circle(int x, int y, Color color ,int radius): base(x,y,color)
        {
            Radius = radius;
            Console.WriteLine($"NewCircle {GetHashCode()}");
        }

        public override double Perimeter()
		{
			return Radius* Math.PI * 2;
        }
        public override double Area()
        {
           return Math.Pow(Radius,2)*Math.PI;
        }

        public override void Draw()
        {
            Graphics buff = Graphics.FromImage(bits);

            Brush brush = new SolidBrush(Color);

            buff.FillEllipse(brush, X,Y,Radius,Radius);
            bits.Save("Shapes.jpg");
        }
        public override string ToString()
        {
            return base.ToString() + $"Radius: {Radius}";
        }
    }
}
