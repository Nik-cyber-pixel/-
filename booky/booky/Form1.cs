﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace booky
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(user);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void user()
        {
            Application.Run(new user());
        }

        private void admin()
        {
            Application.Run(new admin());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(admin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
