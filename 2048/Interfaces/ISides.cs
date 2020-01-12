using System.Drawing;

namespace _2048.Interfaces
{
    interface ISides
    {
        int X1 { get;  }
        int X2 { get; }
        int Y1 { get; }
        int Y2 { get; }
        Point Get(Point point);
        int Change(int i);
        bool Check(int i);       
    }
}
