using System.Drawing;
using _2048.Interfaces;

namespace _2048.Classes
{
    class Left : ISides
    {
        public int X1 { get; }
        public int X2 { get; }
        public int Y1 { get; }
        public int Y2 { get; }

        public Left()
        {
            X1 = 1;
            X2 = 3;
            Y1 = 0;
            Y2 = 3;
        }
        public bool Check(int i) => i <= X2;

        public Point Get(Point p) => new Point(p.X - 1, p.Y);

        public int Change(int i) => ++i;
    }
}
