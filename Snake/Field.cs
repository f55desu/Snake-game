using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
	public partial class Field : Form
	{
        private int rI, rJ;
        private int width = 520;
        private int height = 420;
        private int dirX, dirY;
        private int score = 0; // счёт 
        private PictureBox fruit; // картинка фрукта
        private int sizeOfSides = 20;

        public Field()
		{
            InitializeComponent();
            Generate_borders();
            Generate_Fruit();
            timer.Tick += new EventHandler(Update);
            timer.Start();
            this.KeyDown += new KeyEventHandler(OKP);
        }

        private void Generate_borders()
        {
            PictureBox BorderTop = new PictureBox();
            BorderTop.BackColor = Color.Black;
            BorderTop.Location = new Point(width - 420, 0);
            BorderTop.Size = new Size(width - 100, 20);
            this.Controls.Add(BorderTop);

            PictureBox BorderBottom = new PictureBox();
            BorderBottom.BackColor = Color.Black;
            BorderBottom.Location = new Point(width - 420, height - 20);
            BorderBottom.Size = new Size(width - 100, 20);
            this.Controls.Add(BorderBottom);

            PictureBox BorderLeft = new PictureBox();
            BorderLeft.BackColor = Color.Black;
            BorderLeft.Location = new Point(width - 420, 0);
            BorderLeft.Size = new Size(20, height);
            this.Controls.Add(BorderLeft);

            PictureBox BorderRight = new PictureBox();
            BorderRight.BackColor = Color.Black;
            BorderRight.Location = new Point(width - 20, 0);
            BorderRight.Size = new Size(20, height);
            this.Controls.Add(BorderRight);
        }

        private void Generate_Fruit()
        {
            // генерация фрукта
            fruit = new PictureBox();
            fruit.BackColor = Color.Red;
            fruit.Size = new Size(sizeOfSides, sizeOfSides);

            Random r = new Random();
            rI = r.Next(width - 420 + sizeOfSides, width - sizeOfSides);
            int tempI = rI % sizeOfSides;
            rI -= tempI;
            rJ = r.Next(sizeOfSides, height - sizeOfSides);
            int tempJ = rJ % sizeOfSides;
            rJ -= tempJ;
            rI++;
            rJ++;
            fruit.Location = new Point(rI, rJ);
            this.Controls.Add(fruit);
        }

        private void Update(Object myObject, EventArgs eventsArgs)
        {
            Head.Location = new Point(Head.Location.X + dirX * sizeOfSides, Head.Location.Y + dirY * sizeOfSides);
        }

		private void Score_Label_Click(object sender, EventArgs e)
		{
            //возможно будет вестись подсчёт очков
            MessageBox.Show("Здесь будет таблица рекордов", "В разработке...", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "Up":
                    dirY = -1;
                    dirX = 0;
                    break;
                case "Down":
                    dirY = 1;
                    dirX = 0;
                    break;
                case "Space":
                    timer.Stop();
                    MessageBox.Show("Press Space to continue.", "Game paused", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer.Start();
                    break;
                case "Escape":
                    timer.Stop();
                    MessageBox.Show("Press Space to continue.", "Game paused", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer.Start();
                    break;
            }

        }
	}
}
