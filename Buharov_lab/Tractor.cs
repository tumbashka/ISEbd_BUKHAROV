using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    public class Tractor : Vehicle
    {
        protected const int carWidth = 120;

        protected const int carHeight = 70;

        public OrnamentEnum WheelNumb { private set; get; }

        public Color OrnamentColor { protected set; get; }

        IOrnament ornament;

        public Tractor(int maxSpeed, float weight, Color mainColor, OrnamentEnum wheelNumb, Color ornamentColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            WheelNumb = wheelNumb;
            OrnamentColor = ornamentColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawVehicle(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush MainBrush = new SolidBrush(MainColor);

            g.DrawRectangle(blackPen, _startPosX + 19, _startPosY + 9, 21, 21);// обводка окна
            g.FillRectangle(MainBrush, _startPosX + 10, _startPosY + 30, 60, 20);// оранжевый корпус

            switch (new Random().Next(0, 3))
            {
                case 0:
                    ornament = new DefaultWheels(_startPosX, _startPosY);
                    break;
                case 1:
                    ornament = new RectWheels(_startPosX, _startPosY);
                    break;
                case 2:
                    ornament = new MarkWheels(_startPosX, _startPosY);
                    break;
                default:
                    ornament = new DefaultWheels(_startPosX, _startPosY);
                    break;
            }

            ornament.OrnamentDraw(g, WheelNumb, OrnamentColor);

        }
    }
}
