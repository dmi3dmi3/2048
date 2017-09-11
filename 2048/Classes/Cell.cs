using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048.Classes
{
    class Cell: ICloneable
    {
        public int Value
        {
            get;
            private set;
        }
        public bool IsFull
        {
            get;
            private set;
        }
        public bool isUpgrated
        {
            set;
            get;
        }
        public event EventHandler Win;

        public Cell(bool full)
        {
            IsFull = full;
            if (full)
                Value = RandValue();
            else
                Value = 0;
            isUpgrated = false;
        }
        public Cell(int val)
        {
            if (val != 0)
            {
                IsFull = true;
                Value = val;
            }else
            {
                IsFull = false;
                Value = 0;
            }
        }

        public object Clone()
        {
            Cell cell = new Cell(this.Value);
            cell.isUpgrated = this.isUpgrated;
            return cell;
        }
        public bool IsEmpty()
        {
            return !IsFull;
        }
        public void Upgrade()
        {
            Value *= 2;
            isUpgrated = true;
            if (Value == 2048)
                Win(this, new EventArgs());
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
        private int RandValue()
        {

            if (MyRandom.RandomInt(10) == 0)
            {
                return 4;
            }
            else
            {
                return 2;
            }
        }
        public override string ToString()
        {
            if (this.Value != 0)
                return this.Value.ToString();
            else
                return "";
        }
    }

}
