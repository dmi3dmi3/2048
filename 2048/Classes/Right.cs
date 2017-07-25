using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Interfaces;
using System.Drawing;

namespace _2048.Classes
{
    class Right : ISides
    {
        public int X1 { get; }
        public int X2 { get; }
        public int Y1 { get; }
        public int Y2 { get; }

        public Right()
        {
            X1 = 2;
            X2 = 0;
            Y1 = 3;
            Y2 = 0;
        }
        
        public bool Check(int i)
        {
            return i >= X2;
        }
        public Point Get(Point p)
        {
            return new Point(p.X + 1, p.Y);
        }
        public int Change(int i)
        {
            return --i;
        }
    }
}
