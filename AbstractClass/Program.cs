using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace AbstractClass
{
    internal class Program
    {

        static void Main(string[] args)
        {

            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window = new System.Drawing.Rectangle
                (
                Console.WindowLeft, Console.WindowTop,
                Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics, window);



            // cont of shapes
            Shape[] shapes = {
            new Rectangle(500, 75, Color.DarkOliveGreen, 100, 60),
            new Square(500, 150, Color.DarkKhaki, 80),
            new Circle(500, 240, Color.CadetBlue, 80),
            new EquiLateralTriangle(500, 400, Color.DarkOrchid, 80),
            new IsoscelesTriangle(600, 240, Color.IndianRed, 80,95),
            new RectangularTriangle(600,400, Color.Indigo, 1600, 100)
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Info(e);
            }
        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
    }
}
