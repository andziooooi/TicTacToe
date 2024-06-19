﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class StartPage : Form
    {
        public bool guest = false;
        public StartPage()
        {
            InitializeComponent();
        }


        private void playwithcomputer(object sender, EventArgs e)
        {
            Close();
        }

        private void Username_Click(object sender, EventArgs e)
        {
            Username.Clear();
        }

        private void playwithguest(object sender, EventArgs e)
        {
            guest = true;
            Close();
        }
    }
}