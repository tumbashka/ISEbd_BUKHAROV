﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buharov_lab
{
    public partial class FormBulldozer : Form
    {

        private Bulldozer bulldozer;

        public FormBulldozer()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            bulldozer.DrawBulldozer(gr);
            pictureBox.Image = bmp;
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bulldozer = new Bulldozer(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red, Color.Yellow, true, false, 6);
            bulldozer.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width, pictureBox.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    bulldozer.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    bulldozer.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    bulldozer.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    bulldozer.MoveTransport(Direction.Right);
                    break;

            }
            Draw();
        }

    }
}
