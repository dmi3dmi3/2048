using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048.Classes
{
    class Cell
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

        public Cell(Cell cell)
        {
            this.IsFull = cell.IsFull;
            this.Value = cell.Value;
            this.isUpgrated = cell.isUpgrated;
        }
        public Cell(bool full)
        {
            IsFull = full;
            if (full)
            {
                Value = RandValue();
            }
            isUpgrated = false;
        }
        public bool IsEmpty()
        {
            return !IsFull;
        }
        public void Upgrade()
        {
            Value *= 2;
            isUpgrated = true;
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
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[1];
            new RNGCryptoServiceProvider().GetBytes(randomNumber);
            if ((byte)((randomNumber[0] % 10)) == 0)
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
