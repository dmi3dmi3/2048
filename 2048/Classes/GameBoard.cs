﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Interfaces;
using _2048;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _2048.Classes
{
    class GameBoard
    {
        Cell[,] board = new Cell[4, 4];

        public GameBoard checkGB;
        public int I_Score  { private set; get; }
        public int I_NumCols { get; }
        public int I_NumRows { get; }
        public Cell this[Coordinate point]
        {
            set { board[point.X, point.Y] = value; }
            get { return board[point.X, point.Y]; }
        }
        public Cell this[int a, int b]
        {
            set { board[a, b] = value; }
            get { return board[a, b]; }
        }

        public GameBoard()
        {
            I_NumCols = 4;
            I_NumRows = 4;
            I_Score = 0;
            for (int i = 0; i < I_NumCols; i++)
                for (int j = 0; j < I_NumRows; j++)
                    board[i,j] = new Cell(false);
        }
        public GameBoard(GameBoard gb)
        {
            I_NumCols = gb.I_NumCols;
            I_NumRows = gb.I_NumRows;
            I_Score = gb.I_Score;
            for (int i = 0; i < I_NumRows; i++)
                for (int j = 0; j < I_NumCols; j++)
                {
                    this[i, j] = new Cell(gb[i, j]);
                }
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
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[1];
            new RNGCryptoServiceProvider().GetBytes(randomNumber);
            int num = randomNumber[0] % CountEmptyCells();
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
        public bool CheckEmpty(Coordinate p)
        {
            if (IsWalkable(p))
                return this[p].IsEmpty();
            else
                return false;
        }
        public bool IsWalkable(Coordinate p)
        {
            if (p.X < 0 || p.X > 3 || p.Y < 0 || p.Y > 3)
                return false;
            return true;
        }
        public void Move(ISides side)
        {
            Coordinate cur = new Coordinate(); //current
            Cell tmp; //temporary
            I_Score -= 1;
            ClearUpgrates();
            checkGB = new GameBoard(this);
            for (int i = side.X1; side.Check(i); i = side.Change(i) )
                for(int j = side.Y1; side.Check(j); j = side.Change(j))
                {
                    cur.Set(i, j);
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
                            if (this[cur].Value == this[side.Get(cur)].Value && !this[side.Get(cur)].isUpgrated)
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
            }
        }
        public bool CheckWin()
        {
            foreach (Cell cell in board)
                if (cell.Value == 2048)
                {
                    return true;
                    break;
                }
            return false;
        }
        public bool CheckLose()
        {
            if (CountEmptyCells() == 0)
            {
                GameBoard tmp;

                tmp = new GameBoard(this);
                tmp.Move(new Right());
                if (!tmp.IsEqualBoards(this)) return false;

                tmp = new GameBoard(this);
                tmp.Move(new Left());
                if (!tmp.IsEqualBoards(this)) return false;

                tmp = new GameBoard(this);
                tmp.Move(new Up());
                if (!tmp.IsEqualBoards(this)) return false;

                tmp = new GameBoard(this);
                tmp.Move(new Down());
                if (!tmp.IsEqualBoards(this)) return false;

                return true;
            }
            return false;
        }
        public bool IsEqualBoards(GameBoard gb) 
        {
            for (int i = 0; i < I_NumRows; i++)
                for (int j = 0; j < I_NumCols; j++)
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
    }
}
