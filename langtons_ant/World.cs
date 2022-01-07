using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace langtons_ant
{
    public class World
    {
        public int Width { get; private set; }

        public int Height { get; private set; }

        public List<List<Cell>> Table { get; set; }

        public World(int w, int h)
        {
            Width = w;
            Height = h;
            Table = new List<List<Cell>>();
            for (int i=0;i<Width;i++)
            {
                Table.Add(new List<Cell>());
                for(int j=0;j<Height;j++)
                {
                    //Table[i][j] = new Cell();
                    Table[i].Add(new Cell());
                }
            }
        }

        public override string ToString()
        {
            var s = new StringBuilder();
            for (int i=0; i<Width;i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    s.Append(((int)Table[i][j].state));
                    s.Append(" ");
                }
                s.Append("\n");
            }
            return s.ToString();

        }
    }


    public class Cell
    {
        public Model.CellStates state { get; set; }

        public Cell()
        {
            state = Model.CellStates.White;
        }
    }

}
