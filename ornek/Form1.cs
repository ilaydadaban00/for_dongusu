﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbNotlar.Items.Clear();
            for(int i = 0; i < 10; i++)
            {
                int puan=rnd.Next(0,100);
               
                
                    lbNotlar.Items.Add(puan);
                

            }
            
        }

    }
}
