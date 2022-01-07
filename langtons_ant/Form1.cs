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
            e.Graphics.DrawString(ActiveModel.Map.ToString(), new Font("Arial", 20), Brushes.Black, new Point(100, 100));
            //e.Graphics.DrawString((-1%4).ToString(), new Font("Arial", 20), Brushes.Black, new Point(10, 10));

            //e.Graphics.DrawString((ActiveModel.Map.ants[0].Direction).ToString(), new Font("Arial", 20), Brushes.Black, new Point(100, 100));
        }

        public Form1()
        {
            InitializeComponent();
            ActiveModel = new Model();
            var b = new Button();
            Controls.Add(b);

            var timer = new Timer();
            timer.Interval = 500;//1000/600; 
            timer.Tick += (sender, args) =>
            {
                ActiveModel.NextWorldStep();
                Invalidate();
            };
            timer.Start();
        }

    }
}
