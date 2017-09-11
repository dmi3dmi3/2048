using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2048.Classes
{
    static class MyRandom
    {
        static public int RandomInt(int a)
        {
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[1];
            new RNGCryptoServiceProvider().GetBytes(randomNumber);
            return randomNumber[0] % a;

        }
    }
}
