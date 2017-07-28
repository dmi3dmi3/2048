using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.Classes
{
    [Serializable]
    class SaveBuffer
    {
        public int[,] SaveBoard = new int[4, 4];
        public int I_SaveScore;
        public int I_SaveBestScore;

        public SaveBuffer(GameBoard gb)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (gb[i, j].IsFull)
                        SaveBoard[i, j] = gb[i, j].Value;
                    else
                        SaveBoard[i, j] = 0;
                }
            I_SaveScore = gb.I_Score;
            I_SaveBestScore = gb.I_BestScore;
        }
    }
}
