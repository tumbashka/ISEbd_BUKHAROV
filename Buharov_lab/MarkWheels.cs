using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    public class MarkWheels : IOrnament

    {
        public float _startPosX;
        public float _startPosY;
        public MarkWheels(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }
        public void drawCrest(Graphics g, int x, int y)
        {
            Pen blackPen = new Pen(Color.Black);
            g.DrawLine(blackPen, _startPosX + x, _startPosY + y + 10, _startPosX + x + 20, _startPosY + y + 20 - 10);
            g.DrawLine(blackPen, _startPosX + x + 10, _startPosY + y, _startPosX + x + 20 - 10, _startPosY + y + 20);
        }
        public void OrnamentDraw(Graphics g, OrnamentEnum numOrnament, Color color)
        {
            Pen blackPen = new Pen(Color.Black);
            Brush OrnamentBrush = new SolidBrush(color);

            g.FillEllipse(OrnamentBrush, _startPosX, _startPosY + 45, 20, 20);
            g.FillEllipse(OrnamentBrush, _startPosX + 60, _startPosY + 45, 20, 20);
            g.FillRectangle(OrnamentBrush, _startPosX + 10, _startPosY + 45, 60, 20);


            int smesh = 10 - Convert.ToInt32(Math.Sqrt(2) / 2 * 10);
            switch ((int)numOrnament)
            {
                case 0:
                    g.DrawEllipse(blackPen, _startPosX, _startPosY + 45, 20, 20);
                    drawCrest(g, 0, 45);

                    g.DrawEllipse(blackPen, _startPosX + 60, _startPosY + 45, 20, 20);
                    drawCrest(g, 60, 45);
                    break;
                case 1:
                    g.DrawEllipse(blackPen, _startPosX, _startPosY + 45, 20, 20);
                    drawCrest(g, 0, 45);
                    g.DrawEllipse(blackPen, _startPosX + 20, _startPosY + 45, 20, 20);
                    drawCrest(g, 20, 45);
                    g.DrawEllipse(blackPen, _startPosX + 40, _startPosY + 45, 20, 20);
                    drawCrest(g, 40, 45);
                    g.DrawEllipse(blackPen, _startPosX + 60, _startPosY + 45, 20, 20);
                    drawCrest(g, 60, 45);
                    break;
            }
        }
    }
}
