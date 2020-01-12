using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using _2048.Classes;
using _2048.Properties;

namespace _2048
{
    public partial class MainForm: Form
    {
        private readonly GameBoard _table;

        public MainForm()
        {
            InitializeComponent();

            try
            {           
                FileStream fs = new FileStream("save.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                SaveBuffer sb = (SaveBuffer)bf.Deserialize(fs);
                _table = new GameBoard(sb);
            }
            catch (Exception)
            {
                _table = new GameBoard();
                _table.Restart();
            }

            foreach (Cell cell in _table)
                cell.Win += Win;

            _table.Lose += Lose;

            ShowTable();
        }

        private bool _endGameFlag;
        private bool _winFlag;
        bool _singleWinFlag = true;
        public void Win(Object sender, EventArgs args)
        {
            _winFlag = true;
        }

        public void Lose(object sender, EventArgs args)
        {
            _endGameFlag = true;
            ShowTable();
            MessageBox.Show("Game Over");
        }

        private Image ValueImage(int value)
        {
            switch (value)
            {
                case 0:
                    return Resources._0;
                case 2:
                    return Resources._2;
                case 4:
                    return Resources._4;
                case 8:
                    return Resources._8;
                case 16:
                    return Resources._16;
                case 32:
                    return Resources._32;
                case 64:
                    return Resources._64;
                case 128:
                    return Resources._128;
                case 256:
                    return Resources._256;
                case 512:
                    return Resources._512;
                case 1024:
                    return Resources._1024;
                case 2048:
                    return Resources._2048;
                case 4096:
                    return Resources._4096;
            }
            return Resources.Error;
        }

        private void ShowTable()
        {
            lbl00.Image = ValueImage(_table[0, 0].Value);
            lbl01.Image = ValueImage(_table[0, 1].Value);
            lbl02.Image = ValueImage(_table[0, 2].Value);
            lbl03.Image = ValueImage(_table[0, 3].Value);
                
            lbl10.Image = ValueImage(_table[1, 0].Value);
            lbl11.Image = ValueImage(_table[1, 1].Value);
            lbl12.Image = ValueImage(_table[1, 2].Value);
            lbl13.Image = ValueImage(_table[1, 3].Value);
                 
            lbl20.Image = ValueImage(_table[2, 0].Value);
            lbl21.Image = ValueImage(_table[2, 1].Value);
            lbl22.Image = ValueImage(_table[2, 2].Value);
            lbl23.Image = ValueImage(_table[2, 3].Value);
                
            lbl30.Image = ValueImage(_table[3, 0].Value);
            lbl31.Image = ValueImage(_table[3, 1].Value);
            lbl32.Image = ValueImage(_table[3, 2].Value);
            lbl33.Image = ValueImage(_table[3, 3].Value);

            lblScore.Text = _table.Score.ToString();
            lblRecord.Text = _table.BestScore.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var tb = _table.CheckGb;
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

                lblScore.Text = tb.Score.ToString();
            }
            else
                ShowTable();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _table.Restart();
            ShowTable();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool _flag = true;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (_flag && !_endGameFlag)
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.S:
                    _table.Move(new Down());
                    ShowTable();
                    _flag = false;
                    break;
                case Keys.Up:
                case Keys.W:
                    _table.Move(new Up());
                    ShowTable();
                    _flag = false;
                    break;
                case Keys.Left:
                case Keys.A:
                    _table.Move(new Left());
                    ShowTable();
                    _flag = false;
                    break;
                case Keys.Right:
                case Keys.D:
                    _table.Move(new Right());
                    ShowTable();
                    _flag = false;
                    break;
            }
            if (_winFlag && _singleWinFlag)
            {
                ShowTable();
                MessageBox.Show("    You win \nContinue playing");
                _singleWinFlag = false;
            }
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            _flag = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sb = new SaveBuffer(_table);
            try
            {
                FileStream fs;
                try
                {
                    fs = new FileStream("save.dat", FileMode.Truncate, FileAccess.Write);
                }
                catch (Exception)
                {
                    fs = new FileStream("save.dat", FileMode.Create, FileAccess.Write);
                }

                var bf = new BinaryFormatter();

                bf.Serialize(fs, sb);
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Сохранение результата не удалось");
            }        
        }

        private void clearRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _table.ResetRecord();
            ShowTable();
        }
    }
}
