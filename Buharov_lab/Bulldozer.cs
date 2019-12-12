using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    class Bulldozer
    {
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private const int BulldozerWidth = 100;

        private const int BulldozerHeight = 100;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public bool BucketRaised { private set; get; }

        public bool WindowOpen { private set; get; }

        public int CountWheels { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }
        public Bulldozer(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bucketRaised, bool windowOpen, int countWheels)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            BucketRaised = bucketRaised;
            WindowOpen = windowOpen;
            CountWheels = countWheels;

        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - BulldozerWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - BulldozerHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawBulldozer(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black);
            Pen orangePen = new Pen(Color.Orange);
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush orangeBrush = new SolidBrush(Color.Orange);

            if (!WindowOpen)
            {
                g.FillRectangle(blueBrush, _startPosX + 19, _startPosY + 9, 21, 21);// окно
            }
            g.DrawRectangle(blackPen, _startPosX + 19, _startPosY + 9, 21, 21);// обводка окна
            g.FillRectangle(orangeBrush, _startPosX + 10, _startPosY + 30, 60, 20);// оранжевый корпус

            g.FillEllipse(redBrush, _startPosX, _startPosY + 45, 20, 20);
            g.FillEllipse(redBrush, _startPosX + 60, _startPosY + 45, 20, 20);
            g.FillRectangle(redBrush, _startPosX + 10, _startPosY + 45, 60, 20);
            g.DrawEllipse(blackPen, _startPosX, _startPosY + 45, 20, 20);
            g.DrawEllipse(blackPen, _startPosX + 20, _startPosY + 45, 20, 20);
            g.DrawEllipse(blackPen, _startPosX + 40, _startPosY + 45, 20, 20);
            g.DrawEllipse(blackPen, _startPosX + 60, _startPosY + 45, 20, 20);

            g.FillRectangle(blackBrush, _startPosX + 60, _startPosY + 30, 30, 10);// отрисовка ковша
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(orangePen, _startPosX + 82 - i, _startPosY + 10 + i, _startPosX + 100 - i, _startPosY + 60 + i);
            }
            for (int i = 0; i < 3; i++)
            {
                g.DrawLine(orangePen, _startPosX + 100 - i, _startPosY + 60 + i * 2, _startPosX + 120 - i, _startPosY + 60 + i * 2);
            }
            for (int i = 0; i < 3; i++)
            {
                g.DrawLine(orangePen, _startPosX + 82 - i, _startPosY + 10 + i * 3, _startPosX + 102 + i, _startPosY - 2 + i * 2);
            }
        }
    }
}
