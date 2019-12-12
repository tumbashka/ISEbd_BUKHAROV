using System;
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

        private ITransport tractor;

        public FormBulldozer()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tractor.DrawVehicle(gr);
            pictureBox.Image = bmp;
        }


        private void buttonCreateTractor_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tractor = new Tractor(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Orange, OrnamentEnum.Two, Color.Aquamarine);
            tractor.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width, pictureBox.Height);
            Draw();
        }
        private void buttonCreateBulldozer_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tractor = new Bulldozer(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Brown, Color.Orange, false, false, OrnamentEnum.Two, Color.Aquamarine);
            tractor.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width, pictureBox.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tractor.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    tractor.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    tractor.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    tractor.MoveTransport(Direction.Right);
                    break;

            }
            Draw();
        }
    }
}
