﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p29_Butoane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAfisare_Click(object sender, EventArgs e)
        {
            if (ButtonAfisare.Text == "Aici")
                ButtonAfisare.Text = "Apasa aici";
            else
                ButtonAfisare.Text = "Aici";
        }

    }
}
