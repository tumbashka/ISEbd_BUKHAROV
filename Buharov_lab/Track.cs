using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    class Track
    {

        public int CountWheels { private set; get; }

        private const int TrackLength = 80;

        public Track(int countWheels)
        {
            CountWheels = countWheels;
        }

        public int getWheelSize()
        {
            return TrackLength / CountWheels;
        }

        public void addWheels()
        {
            if (CountWheels < 6)
            {
                ++CountWheels;
            }
        }
        public void removeWheels()
        {
            if (CountWheels > 4)
            {
                --CountWheels;
            }
        }

        public void DrawWheel(Graphics g, float _startPosX, float _startPosY)
        {
            Pen blackPen = new Pen(Color.Black);
            Brush redBrush = new SolidBrush(Color.Red);
            int wheelSize = getWheelSize();

            g.FillRectangle(redBrush, _startPosX + wheelSize / 2, _startPosY + 45, TrackLength - wheelSize, wheelSize);// красный задник колес
            g.FillEllipse(redBrush, _startPosX, _startPosY + 45, wheelSize, wheelSize);
            g.FillEllipse(redBrush, _startPosX + TrackLength - wheelSize, _startPosY + 45, wheelSize, wheelSize);

            for (int i = 0; i < CountWheels; i++)
            {
                g.DrawEllipse(blackPen, _startPosX + i * wheelSize, _startPosY + 45, wheelSize, wheelSize);
            }

        }
    }
}
