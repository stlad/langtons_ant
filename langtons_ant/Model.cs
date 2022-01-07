using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langtons_ant
{
    public class Model
    {
        public enum CellStates
        {
            White,
            Black
        }
        public World Map { get; set; }
        public Model()
        {
            Map = new World(5,5);
        }

    }
}
