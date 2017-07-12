using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.Classes
{
    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }
        public Coordinate(int a, int b)
        {
            X = a;
            Y = b;
        }
        public void Set(int a, int b)
        {
            X = a;
            Y = b;
        }
    }
}
