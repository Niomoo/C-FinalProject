﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Form_HabitChecking testForm = new Form_HabitChecking();
            testForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("MMdd");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
