using System;

namespace _2048.Classes
{
    [Serializable]
    class SaveBuffer
    {
        public int[,] SaveBoard = new int[4, 4];
        public int SaveScore;
        public int SaveBestScore;

        public SaveBuffer(GameBoard gb)
        {
            for (var i = 0; i < 4; i++)
                for (var j = 0; j < 4; j++)
                {
                    if (gb[i, j].IsFull)
                        SaveBoard[i, j] = gb[i, j].Value;
                    else
                        SaveBoard[i, j] = 0;
                }
            SaveScore = gb.Score;
            SaveBestScore = gb.BestScore;
        }
    }
}
