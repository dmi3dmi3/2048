using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool Check(int i)
        {
            return i <= Y2;
        }
        public Coordinate Get(Coordinate p)
        {
            return new Coordinate(p.X, p.Y - 1);
        }
        public int Change(int i)
        {
            return ++i;
        }
    }
}
