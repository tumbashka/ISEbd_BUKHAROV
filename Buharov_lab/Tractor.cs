using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    public class Tractor : Vehicle, IComparable<Tractor>, IEquatable<Tractor>
    {
        protected const int carWidth = 120;

        protected const int carHeight = 70;

        public Tractor(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Tractor(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
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

            g.FillEllipse(redBrush, _startPosX, _startPosY + 45, 20, 20);
            g.FillEllipse(redBrush, _startPosX + 60, _startPosY + 45, 20, 20);
            g.FillRectangle(redBrush, _startPosX + 10, _startPosY + 45, 60, 20);
            g.DrawEllipse(blackPen, _startPosX, _startPosY + 45, 20, 20);
            g.DrawEllipse(blackPen, _startPosX + 20, _startPosY + 45, 20, 20);
            g.DrawEllipse(blackPen, _startPosX + 40, _startPosY + 45, 20, 20);
            g.DrawEllipse(blackPen, _startPosX + 60, _startPosY + 45, 20, 20);

        }

        public int CompareTo(Tractor other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(Tractor other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Tractor tractorObj))
            {
                return false;
            }
            else
            {
                return Equals(tractorObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
