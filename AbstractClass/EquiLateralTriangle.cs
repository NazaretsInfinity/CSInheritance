using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace AbstractClass
{
    internal class EquiLateralTriangle : Triangles, IHaveHeight
    {
        double side;

        public double Side { get => side; set => side = value > SIZE ? SIZE : value;
        }
        public EquiLateralTriangle(int x, int y, Color color, double side) : base(x, y, color)
        {
            Side = side;
        }

        public override double Perimeter() => Side * 3;

        public override double Area() => GetHeight() * Side / 2;

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 5);
            Point[] points = { new Point(X,Y),  new Point(X+(int)side/2,Y-(int)GetHeight()), new Point(X +(int)Side ,Y) };
            e.Graphics.DrawPolygon(pen, points);
        }

        public void DrawHeight(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 2);
            e.Graphics.DrawLine(pen, X + (int)Side / 2, Y - (int)GetHeight(), X + (int)Side / 2, Y);
        }
        public double GetHeight() => Math.Sqrt(Math.Pow(side,2) - Math.Pow(side/2,2));

        public override void Info(PaintEventArgs e)
        {
            base.Info(e);
            Console.WriteLine($"\nSide: {Side}");   
            Draw(e);
            DrawHeight(e);
        }

    }
}
