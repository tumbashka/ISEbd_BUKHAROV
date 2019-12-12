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
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width,
pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonParkingTractor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var tractor = new Tractor(100, 1000, dialog.Color);
                int place = parking + tractor;
                Draw();
            }
        }

        private void buttonParkingBulldozer_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var tractor = new Bulldozer(100, 1000, dialog.Color, dialogDop.Color,
                   false, false);
                    int place = parking + tractor;
                    Draw();
                }
            }
        }

        private void buttonTakeVehicle_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var tractor = parking - (Convert.ToInt32(maskedTextBox.Text) - 1);
                if (tractor != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeVehicle.Width,
                   pictureBoxTakeVehicle.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    tractor.SetPosition(5, 5, pictureBoxTakeVehicle.Width,
                   pictureBoxTakeVehicle.Height);
                    tractor.DrawVehicle(gr);
                    pictureBoxTakeVehicle.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeVehicle.Width,
                   pictureBoxTakeVehicle.Height);
                    pictureBoxTakeVehicle.Image = bmp;
                }
                Draw();
            }
        }
    }
}
