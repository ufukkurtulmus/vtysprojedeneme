﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtysprojedeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ekle = new Form2();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeniMusteri ekle = new yeniMusteri();
            ekle.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
