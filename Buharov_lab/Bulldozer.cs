﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    class Bulldozer : Tractor, IComparable<Bulldozer>, IEquatable<Bulldozer>
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

        public Bulldozer(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                BucketRaised = Convert.ToBoolean(strs[4]);
                WindowOpen = Convert.ToBoolean(strs[5]);
            }
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + BucketRaised + ";" + WindowOpen;
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

        public int CompareTo(Bulldozer other)
        {
            var res = (this is Tractor).CompareTo(other is Tractor);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (BucketRaised != other.BucketRaised)
            {
                return BucketRaised.CompareTo(other.BucketRaised);
            }
            if (WindowOpen != other.WindowOpen)
            {
                return WindowOpen.CompareTo(other.WindowOpen);
            }
            if (CountWheels != other.CountWheels)
            {
                return CountWheels.CompareTo(other.CountWheels);
            }
            return 0;
        }

        public bool Equals(Bulldozer other)
        {
            var res = (this as Tractor).Equals(other as Tractor);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (BucketRaised != other.BucketRaised)
            {
                return false;
            }
            if (WindowOpen != other.WindowOpen)
            {
                return false;
            }
            if (CountWheels != other.CountWheels)
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
            if (!(obj is Bulldozer tractorObj))
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
