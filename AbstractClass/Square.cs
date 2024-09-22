using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Square : Rectangle
    {
        public Square(int x, int y,Color color, int width) : base(x, y,color, width, width){}
    }
}
