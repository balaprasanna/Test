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
    public partial class printBox : Form
    {
        public printBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have entered"+textBox1.TextLength+ "characters");
           
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show(""+radioButton1.Text);
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("" + radioButton2.Text);
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("" + radioButton3.Text);
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("" + radioButton4.Text);
            }
            if (radioButton5.Checked)
            {
                MessageBox.Show("" + radioButton5.Text);
            }
            if (radioButton6.Checked)
            {
                MessageBox.Show("" + radioButton6.Text);
            }
            
        }
    }
}
