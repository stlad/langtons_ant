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
        public Model ParentModel { get; private set; }
        public Model.Direction Direction { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Ant(Model parent, int x = 0, int y = 0)
        {
            ParentModel = parent;
            X = x;
            Y = y;
        }


        /// <summary> поворот муравья в заданном направлении. 1: вправо на 90 ;-1: лево на 90 </summary>
        /// <param name="d">направление поворота</param>
        private void Rotate(int d = 0)
        {
            var len = Enum.GetNames(typeof(Model.Direction)).Length;
            var pos = (int)Direction;
            Direction = (Model.Direction)((len + pos + d % len) % len);
        }

        /// <summary> шаг вдоль направления движения </summary>
        private void StepForward()
        {
            switch(Direction)
            {
                case Model.Direction.Up:
                    Y -= 1;
                    break;
                case Model.Direction.Down:
                    Y += 1;
                    break;
                case Model.Direction.Left:
                    X -= 1;
                    break;
                case Model.Direction.Right:
                    X += 1;
                    break;
            }    
        }


        public Model.CellStates CheckState() => ParentModel.Map.Table[X][Y].state;

        public static void GoLeft(Ant ant)
        {
            ant.ParentModel.Map.Table[ant.X][ant.Y].state = Model.CellStates.White;
            ant.Rotate(-1);
            ant.StepForward();
        }

        public static void GoRight(Ant ant)
        {

            ant.ParentModel.Map.Table[ant.X][ant.Y].state = Model.CellStates.Black;
            ant.Rotate(1);
            ant.StepForward();
        }


    }
}
