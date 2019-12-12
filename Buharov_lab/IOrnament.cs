using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buharov_lab
{
    public interface IOrnament
    {
        void OrnamentDraw(Graphics g, OrnamentEnum numOrnament, Color color);
    }
}
