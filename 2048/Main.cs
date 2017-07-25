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
        }

        public void Lose(object sender, EventArgs args)
        {
            ShowTable();
            MessageBox.Show("Проиграно");
        }

        private Image ValueImage(int value)
        {
            switch (value)
            {
                case 2:
                    return _2048.Properties.Resources._2;
                case 4:
                    return _2048.Properties.Resources._4;
                case 8:
                    return _2048.Properties.Resources._8;
                case 16:
                    return _2048.Properties.Resources._16;
                case 32:
                    return _2048.Properties.Resources._32;
                case 64:
                    return _2048.Properties.Resources._64;
                case 128:
                    return _2048.Properties.Resources._128;
                case 256:
                    return _2048.Properties.Resources._256;
                case 512:
                    return _2048.Properties.Resources._512;
                case 1024:
                    return _2048.Properties.Resources._1024;
                case 2048:
                    return _2048.Properties.Resources._2048;
            }
            return _2048.Properties.Resources._0;
        }

        private void ShowTable()
        {
            lbl00.Image = ValueImage(table[0, 0].Value);
            lbl01.Image = ValueImage(table[0, 1].Value);
            lbl02.Image = ValueImage(table[0, 2].Value);
            lbl03.Image = ValueImage(table[0, 3].Value);
                
            lbl10.Image = ValueImage(table[1, 0].Value);
            lbl11.Image = ValueImage(table[1, 1].Value);
            lbl12.Image = ValueImage(table[1, 2].Value);
            lbl13.Image = ValueImage(table[1, 3].Value);
                 
            lbl20.Image = ValueImage(table[2, 0].Value);
            lbl21.Image = ValueImage(table[2, 1].Value);
            lbl22.Image = ValueImage(table[2, 2].Value);
            lbl23.Image = ValueImage(table[2, 3].Value);
                
            lbl30.Image = ValueImage(table[3, 0].Value);
            lbl31.Image = ValueImage(table[3, 1].Value);
            lbl32.Image = ValueImage(table[3, 2].Value);
            lbl33.Image = ValueImage(table[3, 3].Value);

            lblScore.Text = table.I_Score.ToString();
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
            ShowTable();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool flag = true;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (flag)
            switch (e.KeyCode)
            {
                case Keys.Down:
                    table.Move(new Down());
                    ShowTable();
                    flag = false;
                    break;
                case Keys.Up:
                    table.Move(new Up());
                    ShowTable();
                    flag = false;
                    break;
                case Keys.Left:
                    table.Move(new Left());
                    ShowTable();
                    flag = false;
                    break;
                case Keys.Right:
                    table.Move(new Right());
                    ShowTable();
                    flag = false;
                    break;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            flag = true;
        }

        /*
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.Msg == WM_KEYUP)
            {
                MessageBox.Show("1");
            }

            if ((msg.Msg == WM_KEYDOWN) && flag)
            {
                switch (keyData)
                {
                    case Keys.Down:
                        table.Move(new Down());
                        ShowTable();
                        flag = false;
                        break;
                    case Keys.Up:
                        table.Move(new Up());
                        ShowTable();
                        flag = false;
                        break;
                    case Keys.Left:
                        table.Move(new Left());
                        ShowTable();
                        flag = false;
                        break;
                    case Keys.Right:
                        table.Move(new Right());
                        ShowTable();
                        flag = false;
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public bool PreFilterMessage(ref Message msg)
        {
            if ((msg.Msg == WM_KEYUP))
            {
                flag = true;
                return true;
            }
            return false;
        }
        */
    }
}
