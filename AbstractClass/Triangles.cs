using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract class Triangles : Shape 
    {
        public Triangles(int x, int y, Color color) : base(x, y, color) { }
        ~Triangles() { }
    }
}
