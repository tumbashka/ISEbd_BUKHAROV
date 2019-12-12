using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    class Bulldozer : Tractor
    {
        private const int BulldozerWidth = 120;

        private const int BulldozerHeight = 70;

        public bool BucketRaised { private set; get; }

        public bool WindowOpen { private set; get; }

        public int CountWheels { private set; get; }

        public Color DopColor { private set; get; }

        public Bulldozer(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bucketRaised, bool windowOpen) :
            base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            BucketRaised = bucketRaised;
            WindowOpen = windowOpen;

        }

        public override void DrawVehicle(Graphics g)
        {
            Pen DopColorPen = new Pen(DopColor);
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush blackBrush = new SolidBrush(Color.Black);

            base.DrawVehicle(g);
            if (!WindowOpen)
            {
                g.FillRectangle(blueBrush, _startPosX + 19, _startPosY + 9, 21, 21);// окно
            }

            g.FillRectangle(blackBrush, _startPosX + 60, _startPosY + 30, 30, 10);// отрисовка ковша
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(DopColorPen, _startPosX + 82 - i, _startPosY + 10 + i, _startPosX + 100 - i, _startPosY + 60 + i);
            }
            for (int i = 0; i < 3; i++)
            {
                g.DrawLine(DopColorPen, _startPosX + 100 - i, _startPosY + 60 + i * 2, _startPosX + 120 - i, _startPosY + 60 + i * 2);
            }
            for (int i = 0; i < 3; i++)
            {
                g.DrawLine(DopColorPen, _startPosX + 82 - i, _startPosY + 10 + i * 3, _startPosX + 102 + i, _startPosY - 2 + i * 2);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
