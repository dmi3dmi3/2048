using _2048.Interfaces;
using SimpleRandom;
using System;
using System.Collections;
using System.Drawing;
using System.Linq;

namespace _2048.Classes
{
    internal class GameBoard : ICloneable
    {
        public Cell[,] Board = new Cell[4, 4];
        public GameBoard CheckGb;
        public int Score { private set; get; }
        public int BestScore { private set; get; }
        public int NumCols { private set; get; }
        public int NumRows { private set; get; }
        public int MaxValue = 4096 - 1;
        public event EventHandler Lose;

        public Cell this[Point point]
        {
            set => Board[point.X, point.Y] = value;
            get => Board[point.X, point.Y];
        }

        public Cell this[int a, int b]
        {
            set => Board[a, b] = value;
            get => Board[a, b];
        }

        public IEnumerator GetEnumerator() => Board.GetEnumerator();

        public GameBoard()
        {
            NumCols = 4;
            NumRows = 4;
            Score = 0;
            BestScore = 0;
            for (var i = 0; i < NumCols; i++)
                for (var j = 0; j < NumRows; j++)
                    Board[i, j] = new Cell(false);
        }

        public GameBoard(SaveBuffer sb)
        {
            Score = sb.SaveScore;
            BestScore = sb.SaveBestScore;
            for (var i = 0; i < 4; i++)
                for (var j = 0; j < 4; j++)
                {
                    this[i, j] = new Cell(sb.SaveBoard[i, j]);
                }
        }

        public object Clone()
        {
            var gb = new GameBoard
            {
                Score = Score,
                NumCols = NumCols,
                NumRows = NumRows
            };
            for (var i = 0; i < 4; i++)
                for (var j = 0; j < 4; j++)
                    gb[i, j] = (Cell)this[i, j].Clone();
            return gb;
        }

        public int CountEmptyCells() => Board.Cast<Cell>().Count(cell => cell.IsEmpty());

        public void FillCell()
        {
            var num = MyRandom.RandomInt(CountEmptyCells());
            foreach (var cell in Board)
            {
                if (!cell.IsEmpty())
                    continue;

                if (num == 0)
                {
                    cell.Fill();
                    break;
                }
                num--;
            }
        }
        public void Restart()
        {
            Score = 0;
            foreach (var cell in Board)
                cell.Clear();
            FillCell();
            FillCell();
            FillCell();
        }
        public bool CheckEmpty(Point p) => IsWalkable(p) && this[p].IsEmpty();

        public bool IsWalkable(Point p) => p.X >= 0 && p.X <= 3 && p.Y >= 0 && p.Y <= 3;

        public void Move(ISides side)
        {
            var current = new Point();
            Score -= 1;
            ClearUpgrades();
            CheckGb = (GameBoard)Clone();
            for (var i = side.X1; side.Check(i); i = side.Change(i))
                for (var j = side.Y1; side.Check(j); j = side.Change(j))
                {
                    current.X = i;
                    current.Y = j;
                    if (!this[current].IsFull)
                        continue;

                    while (CheckEmpty(side.Get(current)))
                    {
                        var tmp = this[side.Get(current)];
                        this[side.Get(current)] = this[current];
                        this[current] = tmp;
                        current = side.Get(current);
                    }

                    if (!IsWalkable(side.Get(current)))
                        continue;

                    if (this[current].Value == this[side.Get(current)].Value && !this[side.Get(current)].IsUpgraded && this[current].Value < MaxValue)
                    {
                        this[side.Get(current)].Upgrade();
                        this[current].Clear();
                        Score += this[side.Get(current)].Value;
                    }
                }

            if (!IsEqualBoards(CheckGb))
            {
                FillCell();
                if (CountEmptyCells() == 0)
                    CheckLose();
            }

            if (Score > BestScore)
                BestScore = Score;
        }

        public bool IsEqualBoards(GameBoard gb)
        {
            for (var i = 0; i < 4; i++)
                for (var j = 0; j < 4; j++)
                    if (this[i, j].Value != gb[i, j].Value)
                        return false;
            return true;
        }
        public void ClearUpgrades()
        {
            foreach (var cell in Board)
                cell.IsUpgraded = false;
        }

        public void CheckLose()
        {
            var down = new Down();
            var right = new Right();
            for (var i = 0; i < 4; i++)
                for (var j = 0; j < 4; j++)
                {
                    var current = new Point(i, j);

                    if (this[current].Value >= MaxValue)
                        continue;

                    if (IsWalkable(down.Get(current)))
                        if (this[current].Value == this[down.Get(current)].Value)
                            return;

                    if (IsWalkable(right.Get(current)))
                        if (this[current].Value == this[right.Get(current)].Value)
                            return;
                }

            Lose?.Invoke(this, new EventArgs());
        }

        public void ResetRecord() => BestScore = 0;
    }
}
