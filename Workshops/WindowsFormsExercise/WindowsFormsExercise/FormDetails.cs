﻿using System;
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
    public partial class FormDetails : Form
    {
        public FormDetails()
        {
            InitializeComponent();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            this.Height = 300;
            this.Width = 400;
            btnReset.Text = "Reset";
            btnReset.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            btnReset.Location = new System.Drawing.Point(200, 200);
        }
    }
}
