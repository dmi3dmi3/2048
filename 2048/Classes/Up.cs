using System.Drawing;
using _2048.Interfaces;

namespace _2048.Classes
{
    class Up : ISides
    {
        public int X1 { get; }
        public int X2 { get; }
        public int Y1 { get; }
        public int Y2 { get; }

        public Up()
        {
            X1 = 0;
            X2 = 3;
            Y1 = 1;
            Y2 = 3;     
        }

        public bool Check(int i) => i <= Y2;

        public Point Get(Point p) => new Point(p.X, p.Y - 1);

        public int Change(int i) => ++i;
    }
}
