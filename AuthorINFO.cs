﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnScreenKeyboard
{
    public partial class AuthorINFO : Form
    {
        public AuthorINFO()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/imshawan/osk-onscreenkeyboard");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
      
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:imshawan.dev059@gmail.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
