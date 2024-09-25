using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{
    internal class RectangularTriangle : Triangles , IHaveHeight
    {
        double cathetus1, cathetus2;

        public double Cathetus1
        {
            get => cathetus1;
            set => cathetus1 = value > SIZE ? SIZE : value;
        }
        public double Cathetus2
        {
            get => cathetus2;
            set => cathetus2 = value > SIZE ? SIZE : value;
        }
        public RectangularTriangle(int x, int y, Color color,double cathetus1, double cathetus2) : base(x,y,color)
        {
           Cathetus1 = cathetus1;
            Cathetus2 = cathetus2;
        }

        public double GetHypotenuse() => Math.Sqrt(Math.Pow(Cathetus1, 2) +  Math.Pow(Cathetus2, 2));

        public double GetHeight() => (Cathetus1 * Cathetus2) / GetHypotenuse();

        public override double Perimeter() => Cathetus1 + Cathetus2 + GetHypotenuse();
        public override double Area() => Cathetus1 * Cathetus2 / 2;

        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 5);
            Point[] points = { new Point(X, Y), new Point(X, Y - (int)Cathetus1), new Point(X + (int)Cathetus2, Y) };
            e.Graphics.DrawPolygon(pen, points);
        }

        public void DrawHeight(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, 2);
            e.Graphics.DrawLine(pen, X, Y, X + (int)GetHeight(), Y - (int)GetHeight());
        }

        public override void Info(PaintEventArgs e)
        {
            base.Info(e);
            DrawHeight(e);
            Console.WriteLine($"First cathetus: {Cathetus1}\nSecond cathetus: {Cathetus2}");
        }
    }
}
