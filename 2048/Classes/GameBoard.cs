using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Interfaces;
using _2048;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace _2048.Classes
{
    class GameBoard: ICloneable
    {
        public Cell[,] board = new Cell[4, 4];
        public GameBoard checkGB;
        public int I_Score { private set; get; }
        public int I_BestScore { private set; get; }
        public int I_NumCols { private set; get; }
        public int I_NumRows { private set; get; }
        public int MaxValue = 4096-1;
        public event EventHandler Lose;

        public Cell this[Point point]
        {
            set { board[point.X, point.Y] = value; }
            get { return board[point.X, point.Y]; }
        }
        public Cell this[int a, int b]
        {
            set { board[a, b] = value; }
            get { return board[a, b]; }
        }
        public IEnumerator GetEnumerator()
        {
            return board.GetEnumerator();
        }

        public GameBoard()
        {
            I_NumCols = 4;
            I_NumRows = 4;
            I_Score = 0;
            I_BestScore = 0;
            for (int i = 0; i < I_NumCols; i++)
                for (int j = 0; j < I_NumRows; j++)
                    board[i, j] = new Cell(false);
        }
        public GameBoard(SaveBuffer sb)
        {
            I_Score = sb.I_SaveScore;
            I_BestScore = sb.I_SaveBestScore;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    this[i, j] = new Cell(sb.SaveBoard[i, j]);
                }
        }

        public object Clone()
        {
            GameBoard gb = new GameBoard();
            gb.I_Score = this.I_Score;
            gb.I_NumCols = this.I_NumCols;
            gb.I_NumRows = this.I_NumRows;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    gb[i, j] = (Cell)this[i, j].Clone();
                }
            return gb;
        }
        public int CountEmptyCells()
        {
            int sum=0;
            foreach (Cell cell in board)
            {
                if (cell.IsEmpty())
                    sum++;
            }
            return sum;
        }
        public void FillCell()
        {
            int num = SimpleRandom.MyRandom.RandomInt(CountEmptyCells());
            foreach (Cell cell in board)
            {
                if (cell.IsEmpty())
                {                    
                    if (num == 0)
                    {                      
                        cell.Fill();
                        break;
                    }
                    num--;
                }

            }
        }
        public void Restart()
        {
            I_Score = 0;
            foreach (Cell cell in board)
                cell.Clear();
            FillCell();
            FillCell();
            FillCell();
        }
        public bool CheckEmpty(Point p)
        {
            if (IsWalkable(p))
                return this[p].IsEmpty();
            else
                return false;
        }
        public bool IsWalkable(Point p)
        {
            if (p.X < 0 || p.X > 3 || p.Y < 0 || p.Y > 3)
                return false;
            return true;
        }
        public void Move(ISides side)
        {
            Point cur = new Point(); //current
            Cell tmp; //temporary
            I_Score -= 1;
            ClearUpgrates();
            checkGB =  (GameBoard)this.Clone();//new GameBoard(this);
            for (int i = side.X1; side.Check(i); i = side.Change(i) )
                for(int j = side.Y1; side.Check(j); j = side.Change(j))
                {
                    cur.X = i;
                    cur.Y = j;                    
                    if (this[cur].IsFull)
                    {
                        while (CheckEmpty(side.Get(cur)))
                        {
                            tmp = this[side.Get(cur)];
                            this[side.Get(cur)] = this[cur];
                            this[cur] = tmp;                            
                            cur = side.Get(cur);
                        }
                        if (IsWalkable(side.Get(cur)))
                            if (this[cur].Value == this[side.Get(cur)].Value && !this[side.Get(cur)].isUpgrated && this[cur].Value< MaxValue)
                            {
                                this[side.Get(cur)].Upgrade();
                                this[cur].Clear();
                                I_Score += this[side.Get(cur)].Value;
                            }
                    }

                }
            if (!IsEqualBoards(checkGB))
            {
                FillCell();
                if (CountEmptyCells() == 0)
                    CheckLose();                
            }
            if (I_Score > I_BestScore)
                I_BestScore = I_Score;
        }
        public bool IsEqualBoards(GameBoard gb) 
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (this[i, j].Value != gb[i, j].Value)
                    {
                        return false;
                    }
                }
            return true;
        }
        public void ClearUpgrates()
        {
            foreach (Cell cell in board)
            {
                cell.isUpgrated = false;
            }
        } 
        public void CheckLose()
        {
            Down down = new Down();
            Right right = new Right();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    Point cur = new Point(i, j);
                    if (this[cur].Value < MaxValue)
                    {
                        if (IsWalkable(down.Get(cur)))
                            if (this[cur].Value == this[down.Get(cur)].Value)
                            {
                                return;
                            }
                        if (IsWalkable(right.Get(cur)))
                            if (this[cur].Value == this[right.Get(cur)].Value)
                            {
                                return;
                            }
                    }
                }

            Lose(this, new EventArgs());
        }
        public void ResetRecord()
        {
            I_BestScore = 0;
        }

    }
}
