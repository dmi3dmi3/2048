using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048.Classes;

namespace _2048
{
    public partial class MainForm: System.Windows.Forms.Form
    {
        private GameBoard table;
        private GameBoard checkTable;

        public MainForm()
        {
            InitializeComponent();

            table = new GameBoard();

            foreach (Cell cell in table)
            {
                cell.Win += new EventHandler(Win);
            }

            table.Lose += new EventHandler(Lose);

            table.Restart();
            ShowTable();
            
        }

        public void Win(Object sender, EventArgs args)
        {
            ShowTable();
            MessageBox.Show("Выиграно");
            BtnOnOff(false);
        }

        public void Lose(object sender, EventArgs args)
        {
            ShowTable();
            MessageBox.Show("Проиграно");
            BtnOnOff(false);
        }

        private void ShowTable()
        {
                lbl00.Text = table[0, 0].ToString();
                lbl01.Text = table[0, 1].ToString();
                lbl02.Text = table[0, 2].ToString();
                lbl03.Text = table[0, 3].ToString();
                                     
                lbl10.Text = table[1, 0].ToString();
                lbl11.Text = table[1, 1].ToString();
                lbl12.Text = table[1, 2].ToString();
                lbl13.Text = table[1, 3].ToString();
                                        
                lbl20.Text = table[2, 0].ToString();
                lbl21.Text = table[2, 1].ToString();
                lbl22.Text = table[2, 2].ToString();
                lbl23.Text = table[2, 3].ToString();
                                       
                lbl30.Text = table[3, 0].ToString();
                lbl31.Text = table[3, 1].ToString();
                lbl32.Text = table[3, 2].ToString();
                lbl33.Text = table[3, 3].ToString();

                lblScore.Text = table.I_Score.ToString();
        }

        private void BtnOnOff(bool flag)
        {
            btnDown.Enabled = flag;
            btnUp.Enabled = flag;
            btnRight.Enabled = flag;
            btnLeft.Enabled = flag;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            table.Move(new Right());
            ShowTable();
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            table.Move(new Left());
            ShowTable();
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            table.Move(new Down());
            ShowTable();
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            table.Move(new Up());
            ShowTable();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            table.Restart();
            BtnOnOff(true);
            ShowTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                GameBoard tb;
                tb = table.checkGB;
                lbl00.Text = tb[0, 0].ToString();
                lbl01.Text = tb[0, 1].ToString();
                lbl02.Text = tb[0, 2].ToString();
                lbl03.Text = tb[0, 3].ToString();

                lbl10.Text = tb[1, 0].ToString();
                lbl11.Text = tb[1, 1].ToString();
                lbl12.Text = tb[1, 2].ToString();
                lbl13.Text = tb[1, 3].ToString();

                lbl20.Text = tb[2, 0].ToString();
                lbl21.Text = tb[2, 1].ToString();
                lbl22.Text = tb[2, 2].ToString();
                lbl23.Text = tb[2, 3].ToString();

                lbl30.Text = tb[3, 0].ToString();
                lbl31.Text = tb[3, 1].ToString();
                lbl32.Text = tb[3, 2].ToString();
                lbl33.Text = tb[3, 3].ToString();

                lblScore.Text = tb.I_Score.ToString();
            }
            else
                ShowTable();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Restart();
            BtnOnOff(true);
            ShowTable();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
