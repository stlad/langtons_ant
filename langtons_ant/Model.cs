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
        public enum Direction
        {
            Up,
            Right,
            Down,
            Left
        }

        public Dictionary<CellStates, Action<Ant>> Rules;
        public World Map { get; set; }

        public int Step { get; private set; }
        public Model()
        {
            Step = 0;
            Map = new World(50,50,this);

            Rules = new Dictionary<CellStates,Action<Ant>>();
            Rules[CellStates.White] = Ant.GoRight;
            Rules[CellStates.Black] = Ant.GoLeft;
        }

        public void NextWorldStep()
        {
            foreach(var ant in Map.ants)
            {
                var state = ant.CheckState();
                Rules[state](ant);
            }
            Step++;
        }
    }

}
