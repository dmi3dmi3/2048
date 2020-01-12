using System;
using SimpleRandom;

namespace _2048.Classes
{
    class Cell: ICloneable
    {
        public int Value { get; private set; }
        public bool IsFull { get; private set; }
        public bool IsUpgraded { set; get; }

        public event EventHandler Win;

        public Cell(bool full)
        {
            IsFull = full;
            Value = full ? RandValue() : 0;
            IsUpgraded = false;
        }

        public Cell(int val)
        {
            if (val != 0)
            {
                IsFull = true;
                Value = val;
            }
            else
            {
                IsFull = false;
                Value = 0;
            }
        }

        public object Clone()
        {
            var cell = new Cell(Value)
            {
                IsUpgraded = IsUpgraded
            };
            return cell;
        }

        public bool IsEmpty() => !IsFull;

        public void Upgrade()
        {
            Value *= 2;
            IsUpgraded = true;
            if (Value == 2048)
                Win?.Invoke(this, new EventArgs());
        }

        public void Fill()
        {
            IsFull = true;
            Value = RandValue(); 
        }

        public void Clear()
        {
            IsFull = false;
            Value = 0;
        }

        private static int RandValue() => 
            MyRandom.RandomInt(10) == 0
                ? 4 
                : 2;

        public override string ToString() => 
            Value != 0 
                ? Value.ToString() 
                : "";
    }

}
