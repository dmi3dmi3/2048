using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Interfaces;

namespace _2048.Classes
{
    class Down : ISides
    {
        public int X1 { get; }
        public int X2 { get; }
        public int Y1 { get; }
        public int Y2 { get; }

        public Down()
        {
            X1 = 3;
            X2 = 0;
            Y1 = 2;
            Y2 = 0;
        }
        public bool Check(int i)
        {
            return i >= Y2;
        }
        public Coordinate Get(Coordinate p)
        {
            return new Coordinate(p.X, p.Y + 1);
        }
        public int Change(int i)
        {
            return --i;
        }
    }
}
