using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace langtons_ant
{
    public partial class Form1 : Form
    {
        public Model ActiveModel;
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawString(ActiveModel.Map.ToString(), new Font("Arial", 20), Brushes.Black, new Point(20, 20));
        }

        public Form1()
        {
            InitializeComponent();
            ActiveModel = new Model();
            
        }
    }
}
