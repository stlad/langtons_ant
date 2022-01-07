using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langtons_ant
{
    public class Ant
    {
        public Model.Direction Direction { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Ant(Point pt) => new Ant(pt.X, pt.Y);
        public Ant(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
    }
}
