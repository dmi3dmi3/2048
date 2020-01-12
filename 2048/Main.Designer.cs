using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _2048.Properties;

namespace _2048
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            this.panel1 = new Panel();
            this.lbl33 = new Label();
            this.lbl32 = new Label();
            this.lbl31 = new Label();
            this.lbl30 = new Label();
            this.lbl23 = new Label();
            this.lbl22 = new Label();
            this.lbl21 = new Label();
            this.lbl20 = new Label();
            this.lbl13 = new Label();
            this.lbl12 = new Label();
            this.lbl11 = new Label();
            this.lbl10 = new Label();
            this.lbl03 = new Label();
            this.lbl02 = new Label();
            this.lbl01 = new Label();
            this.lbl00 = new Label();
            this.lblTextScore = new Label();
            this.lblScore = new Label();
            this.checkBox1 = new CheckBox();
            this.menuStrip1 = new MenuStrip();
            this.menuToolStripMenuItem = new ToolStripMenuItem();
            this.restartToolStripMenuItem = new ToolStripMenuItem();
            this.clearRecordToolStripMenuItem = new ToolStripMenuItem();
            this.closeToolStripMenuItem = new ToolStripMenuItem();
            this.lblRecord = new Label();
            this.label2 = new Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = SystemColors.Window;
            this.panel1.BorderStyle = BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl33);
            this.panel1.Controls.Add(this.lbl32);
            this.panel1.Controls.Add(this.lbl31);
            this.panel1.Controls.Add(this.lbl30);
            this.panel1.Controls.Add(this.lbl23);
            this.panel1.Controls.Add(this.lbl22);
            this.panel1.Controls.Add(this.lbl21);
            this.panel1.Controls.Add(this.lbl20);
            this.panel1.Controls.Add(this.lbl13);
            this.panel1.Controls.Add(this.lbl12);
            this.panel1.Controls.Add(this.lbl11);
            this.panel1.Controls.Add(this.lbl10);
            this.panel1.Controls.Add(this.lbl03);
            this.panel1.Controls.Add(this.lbl02);
            this.panel1.Controls.Add(this.lbl01);
            this.panel1.Controls.Add(this.lbl00);
            this.panel1.Location = new Point(12, 63);
            this.panel1.Margin = new Padding(2);
            this.panel1.MaximumSize = new Size(334, 334);
            this.panel1.MinimumSize = new Size(334, 334);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Padding(2);
            this.panel1.Size = new Size(334, 334);
            this.panel1.TabIndex = 0;
            // 
            // lbl33
            // 
            this.lbl33.AutoSize = true;
            this.lbl33.BorderStyle = BorderStyle.FixedSingle;
            this.lbl33.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl33.Location = new Point(248, 248);
            this.lbl33.MaximumSize = new Size(80, 80);
            this.lbl33.MinimumSize = new Size(80, 80);
            this.lbl33.Name = "lbl33";
            this.lbl33.Size = new Size(80, 80);
            this.lbl33.TabIndex = 16;
            this.lbl33.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl32
            // 
            this.lbl32.AutoSize = true;
            this.lbl32.BorderStyle = BorderStyle.FixedSingle;
            this.lbl32.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl32.Location = new Point(248, 166);
            this.lbl32.MaximumSize = new Size(80, 80);
            this.lbl32.MinimumSize = new Size(80, 80);
            this.lbl32.Name = "lbl32";
            this.lbl32.Size = new Size(80, 80);
            this.lbl32.TabIndex = 15;
            this.lbl32.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl31
            // 
            this.lbl31.AutoSize = true;
            this.lbl31.BorderStyle = BorderStyle.FixedSingle;
            this.lbl31.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl31.Location = new Point(248, 84);
            this.lbl31.MaximumSize = new Size(80, 80);
            this.lbl31.MinimumSize = new Size(80, 80);
            this.lbl31.Name = "lbl31";
            this.lbl31.Size = new Size(80, 80);
            this.lbl31.TabIndex = 14;
            this.lbl31.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl30
            // 
            this.lbl30.AutoSize = true;
            this.lbl30.BorderStyle = BorderStyle.FixedSingle;
            this.lbl30.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl30.Location = new Point(248, 2);
            this.lbl30.MaximumSize = new Size(80, 80);
            this.lbl30.MinimumSize = new Size(80, 80);
            this.lbl30.Name = "lbl30";
            this.lbl30.Size = new Size(80, 80);
            this.lbl30.TabIndex = 13;
            this.lbl30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl23
            // 
            this.lbl23.AutoSize = true;
            this.lbl23.BorderStyle = BorderStyle.FixedSingle;
            this.lbl23.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl23.Location = new Point(166, 248);
            this.lbl23.MaximumSize = new Size(80, 80);
            this.lbl23.MinimumSize = new Size(80, 80);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new Size(80, 80);
            this.lbl23.TabIndex = 12;
            this.lbl23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl22
            // 
            this.lbl22.AutoSize = true;
            this.lbl22.BorderStyle = BorderStyle.FixedSingle;
            this.lbl22.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl22.Location = new Point(166, 166);
            this.lbl22.MaximumSize = new Size(80, 80);
            this.lbl22.MinimumSize = new Size(80, 80);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new Size(80, 80);
            this.lbl22.TabIndex = 11;
            this.lbl22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.BorderStyle = BorderStyle.FixedSingle;
            this.lbl21.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl21.Location = new Point(166, 84);
            this.lbl21.MaximumSize = new Size(80, 80);
            this.lbl21.MinimumSize = new Size(80, 80);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new Size(80, 80);
            this.lbl21.TabIndex = 10;
            this.lbl21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.BorderStyle = BorderStyle.FixedSingle;
            this.lbl20.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl20.Location = new Point(166, 2);
            this.lbl20.MaximumSize = new Size(80, 80);
            this.lbl20.MinimumSize = new Size(80, 80);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new Size(80, 80);
            this.lbl20.TabIndex = 9;
            this.lbl20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.BorderStyle = BorderStyle.FixedSingle;
            this.lbl13.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl13.Location = new Point(84, 248);
            this.lbl13.MaximumSize = new Size(80, 80);
            this.lbl13.MinimumSize = new Size(80, 80);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new Size(80, 80);
            this.lbl13.TabIndex = 8;
            this.lbl13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BorderStyle = BorderStyle.FixedSingle;
            this.lbl12.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl12.Location = new Point(84, 166);
            this.lbl12.MaximumSize = new Size(80, 80);
            this.lbl12.MinimumSize = new Size(80, 80);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new Size(80, 80);
            this.lbl12.TabIndex = 7;
            this.lbl12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BorderStyle = BorderStyle.FixedSingle;
            this.lbl11.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl11.Location = new Point(84, 84);
            this.lbl11.MaximumSize = new Size(80, 80);
            this.lbl11.MinimumSize = new Size(80, 80);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new Size(80, 80);
            this.lbl11.TabIndex = 6;
            this.lbl11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BorderStyle = BorderStyle.FixedSingle;
            this.lbl10.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl10.Location = new Point(84, 2);
            this.lbl10.MaximumSize = new Size(80, 80);
            this.lbl10.MinimumSize = new Size(80, 80);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new Size(80, 80);
            this.lbl10.TabIndex = 5;
            this.lbl10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.BorderStyle = BorderStyle.FixedSingle;
            this.lbl03.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl03.Location = new Point(2, 248);
            this.lbl03.MaximumSize = new Size(80, 80);
            this.lbl03.MinimumSize = new Size(80, 80);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new Size(80, 80);
            this.lbl03.TabIndex = 4;
            this.lbl03.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.BorderStyle = BorderStyle.FixedSingle;
            this.lbl02.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl02.Location = new Point(2, 166);
            this.lbl02.MaximumSize = new Size(80, 80);
            this.lbl02.MinimumSize = new Size(80, 80);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new Size(80, 80);
            this.lbl02.TabIndex = 3;
            this.lbl02.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.BorderStyle = BorderStyle.FixedSingle;
            this.lbl01.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl01.Location = new Point(2, 84);
            this.lbl01.MaximumSize = new Size(80, 80);
            this.lbl01.MinimumSize = new Size(80, 80);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new Size(80, 80);
            this.lbl01.TabIndex = 2;
            this.lbl01.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl00
            // 
            this.lbl00.AutoSize = true;
            this.lbl00.BorderStyle = BorderStyle.FixedSingle;
            this.lbl00.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lbl00.Location = new Point(2, 2);
            this.lbl00.MaximumSize = new Size(80, 80);
            this.lbl00.MinimumSize = new Size(80, 80);
            this.lbl00.Name = "lbl00";
            this.lbl00.Size = new Size(80, 80);
            this.lbl00.TabIndex = 1;
            this.lbl00.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTextScore
            // 
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lblTextScore.Image = Resources.BG;
            this.lblTextScore.Location = new Point(12, 29);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.Size = new Size(73, 23);
            this.lblTextScore.TabIndex = 1;
            this.lblTextScore.Text = "Score:";
            this.lblTextScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = SystemColors.Window;
            this.lblScore.BorderStyle = BorderStyle.FixedSingle;
            this.lblScore.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new Point(98, 29);
            this.lblScore.MinimumSize = new Size(40, 15);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new Size(40, 25);
            this.lblScore.TabIndex = 2;
            this.lblScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new Point(109, 396);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(96, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Show previous";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = Resources.BG;
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(354, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.clearRecordToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.restartToolStripMenuItem.ShortcutKeys = Keys.F2;
            this.restartToolStripMenuItem.Size = new Size(139, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // clearRecordToolStripMenuItem
            // 
            this.clearRecordToolStripMenuItem.Name = "clearRecordToolStripMenuItem";
            this.clearRecordToolStripMenuItem.Size = new Size(139, 22);
            this.clearRecordToolStripMenuItem.Text = "Reset record";
            this.clearRecordToolStripMenuItem.Click += new EventHandler(this.clearRecordToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = Keys.F4;
            this.closeToolStripMenuItem.Size = new Size(139, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BackColor = SystemColors.Window;
            this.lblRecord.BorderStyle = BorderStyle.FixedSingle;
            this.lblRecord.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.lblRecord.Location = new Point(262, 29);
            this.lblRecord.MinimumSize = new Size(40, 15);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new Size(40, 25);
            this.lblRecord.TabIndex = 11;
            this.lblRecord.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label2.Image = Resources.BG;
            this.label2.Location = new Point(176, 29);
            this.label2.Name = "label2";
            this.label2.Size = new Size(85, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Record:";
            this.label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = Resources.BG;
            this.ClientSize = new Size(354, 400);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "2048";
            this.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new KeyEventHandler(this.MainForm_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lbl33;
        private Label lbl32;
        private Label lbl31;
        private Label lbl30;
        private Label lbl23;
        private Label lbl22;
        private Label lbl21;
        private Label lbl20;
        private Label lbl13;
        private Label lbl12;
        private Label lbl11;
        private Label lbl10;
        private Label lbl03;
        private Label lbl02;
        private Label lbl01;
        private Label lbl00;
        private Label lblTextScore;
        private Label lblScore;
        private CheckBox checkBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Label lblRecord;
        private Label label2;
        private ToolStripMenuItem clearRecordToolStripMenuItem;
    }
}

