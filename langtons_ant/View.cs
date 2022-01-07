using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace langtons_ant
{
    public class View
    {
        //public static int TileSize => 
        //public static Point OffSetPoint = new Point(50, 50);

        

        public static void DrawMap(Model model, PaintEventArgs e, Size clientSize)
        {
            var tileSize = GetTileSize(model, clientSize);
            var offSet = GetOffset(model,clientSize, tileSize);
            var g = e.Graphics;
            for(int i=0;i<model.Map.Width;i++)
            {
                for(int j=0;j<model.Map.Height;j++)
                {
                    var rect = new Rectangle(offSet.X + i * tileSize, offSet.Y + j * tileSize, tileSize, tileSize);
                    
                    var state = model.Map.Table[i][j].state;
                    Color color;
                    switch (state)
                    {
                        case Model.CellStates.White:
                            color = Color.FromArgb(255, 220, 220, 220);
                            break;
                        case Model.CellStates.Black:
                            color = Color.FromArgb(255, 105, 105, 105);
                            break;
                        default:
                            color = Color.FromArgb(255, 0, 0, 0);
                            break;

                    }
                    g.FillRectangle(new SolidBrush(color), rect);
                    g.DrawRectangle(new Pen(Brushes.Black), rect);
                }
            }
        }

        private static Point GetOffset(Model model, Size clientSize, int tile)
        {

            int x =  (clientSize.Width-model.Map.Width*tile)/ 2;
            int y =  (clientSize.Height - model.Map.Height * tile) / 2;
            return new Point(x, y);
        }

        private static int GetTileSize(Model model, Size clientSize)
        {
            return Math.Min(clientSize.Height  / model.Map.Height, clientSize.Width  / model.Map.Width);
        }
    }
}
