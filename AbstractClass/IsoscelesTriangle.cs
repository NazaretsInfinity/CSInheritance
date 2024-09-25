using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{
    internal class IsoscelesTriangle: Triangles, IHaveHeight
    {
        double side, lateral;
        public double Side
        {
            get => side; set => side = value > SIZE ? SIZE : value;
        }

        public double Lateral
        {
            get => lateral; set => lateral = value > SIZE ? SIZE : value;
        }
        public IsoscelesTriangle(int x, int y, Color color, double side, double lateral) : base(x, y, color)
        {
            Side = side;
            Lateral = lateral;
        }

        public override double Perimeter() => 2 * Lateral+ Side;

        public override double Area() => GetHeight() * Side / 2;

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 5);
            Point[] points = {new Point(X, Y), new Point(X + (int)Side / 2, Y - (int)GetHeight()), new Point(X + (int)Side, Y) };
            e.Graphics.DrawPolygon(pen, points);
        }

        public void DrawHeight(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 2);
            e.Graphics.DrawLine(pen, X + (int)Side / 2, Y - (int)GetHeight(), X + (int)Side / 2, Y);
        }

        public override void Info(PaintEventArgs e)
        {
            base.Info(e);
            DrawHeight(e);
            Console.WriteLine($"lateral side: {Lateral}\n side: {Side}");
        }
        public double GetHeight() => Math.Sqrt(Math.Pow(Lateral, 2) - Math.Pow(Side/2,2));

    }
}
