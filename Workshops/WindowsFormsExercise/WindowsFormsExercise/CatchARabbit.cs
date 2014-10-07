using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercise
{
    public partial class CatchARabbit : Form
    {
        public CatchARabbit()
        {
            InitializeComponent();
        }

        private void btnRabbit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRabbit_MouseDown(object sender, MouseEventArgs e)
        {
            btnRabbit.ForeColor = System.Drawing.Color.AliceBlue;
        }

        private void btnRabbit_MouseUp(object sender, MouseEventArgs e)
        {
            btnRabbit.ForeColor = System.Drawing.Color.DarkBlue;
            Random r = new Random();

            int x = r.Next(800);
            int y = r.Next(600);
            btnRabbit.Location = new System.Drawing.Point(x, y);
        }

        private void btnRabbit_MouseMove(object sender, MouseEventArgs e)
        {
            btnRabbit.ForeColor = System.Drawing.Color.DarkBlue;
            Random r = new Random();

            int x = r.Next(800);
            int y = r.Next(600);
            btnRabbit.Location = new System.Drawing.Point(x, y);
        }
    }
}
