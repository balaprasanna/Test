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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button1 has been clicked");
            MessageBox.Show("Height is =" + btnbutton1.Height + "width is =" + btnbutton1.Width);
        }
    }
}
