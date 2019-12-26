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
    public partial class FormCarConfig : Form
    {

        ITransport vehicle = null;

        private event carDelegate eventAddCar;

        public FormCarConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelFuchsia.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawVehicle()
        {
            if (vehicle != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTakeVehicle.Width, pictureBoxTakeVehicle.Height);
                Graphics gr = Graphics.FromImage(bmp);
                vehicle.SetPosition(5, 5, pictureBoxTakeVehicle.Width, pictureBoxTakeVehicle.Height);
                vehicle.DrawVehicle(gr);
                pictureBoxTakeVehicle.Image = bmp;
            }
        }

        public void AddEvent(carDelegate ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new carDelegate(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }

        private void LabelTractor_MouseDown(object sender, MouseEventArgs e)
        {
            labelTractor.DoDragDrop(labelTractor.Text, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        private void LabelBulldozer_MouseDown(object sender, MouseEventArgs e)
        {
            labelBulldozer.DoDragDrop(labelBulldozer.Text, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        private void PanelVehicle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PanelVehicle_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Трактор":
                    vehicle = new Tractor(100, 500, Color.White);
                    break;
                case "Бульдозер":
                    vehicle = new Bulldozer(100, 500, Color.White, Color.Black, false, false);
                    break;
            }
            DrawVehicle();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (vehicle != null)
            {
                vehicle.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawVehicle();
            }
        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (vehicle != null)
            {
                if (vehicle is Bulldozer)
                {
                    (vehicle as Bulldozer).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawVehicle();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(vehicle);
            Close();
        }
    }
}
