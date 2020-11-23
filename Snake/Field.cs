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
        private int _width = 800;
        private int _height = 800;

		public Field()
		{
			InitializeComponent();
            this.Width = _width;
            this.Height = _height;
            this.KeyDown += new KeyEventHandler(OKP);
		}

        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    Head.Location = new Point(Head.Location.X + 20, Head.Location.Y);
                    break;
                case "Left":
                    Head.Location = new Point(Head.Location.X - 20, Head.Location.Y);
                    break;
                case "Up":
                    Head.Location = new Point(Head.Location.X, Head.Location.Y - 20);
                    break;
                case "Down":
                    Head.Location = new Point(Head.Location.X, Head.Location.Y + 20);
                    break;
            }

        }
	}
}
