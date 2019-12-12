using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    public class DefaultWheels : IOrnament

    {
        public float _startPosX;
        public float _startPosY;
        public DefaultWheels(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }
        public void OrnamentDraw(Graphics g, OrnamentEnum numOrnament, Color color)
        {
            Pen blackPen = new Pen(Color.Black);
            Brush OrnamentBrush = new SolidBrush(color);

            g.FillEllipse(OrnamentBrush, _startPosX, _startPosY + 45, 20, 20);
            g.FillEllipse(OrnamentBrush, _startPosX + 60, _startPosY + 45, 20, 20);
            g.FillRectangle(OrnamentBrush, _startPosX + 10, _startPosY + 45, 60, 20);

            switch ((int)numOrnament)
            {
                case 0:
                    g.DrawEllipse(blackPen, _startPosX, _startPosY + 45, 20, 20);
                    g.DrawEllipse(blackPen, _startPosX + 60, _startPosY + 45, 20, 20);
                    break;
                case 1:
                    g.DrawEllipse(blackPen, _startPosX, _startPosY + 45, 20, 20);
                    g.DrawEllipse(blackPen, _startPosX + 20, _startPosY + 45, 20, 20);
                    g.DrawEllipse(blackPen, _startPosX + 40, _startPosY + 45, 20, 20);
                    g.DrawEllipse(blackPen, _startPosX + 60, _startPosY + 45, 20, 20);
                    break;
            }
        }
    }
}
