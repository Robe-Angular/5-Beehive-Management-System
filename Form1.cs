﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Beehive_Management_System
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" },175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "String patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                "Egg care", "Baby bee tutoring", "Hive maintenance", "String patrol" }, 155);
            queen = new Queen(workers);
        }
        
        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(jobComboBox.Text, (int)shifts.Value) == false)
                MessageBox.Show($"No workers are available to do the job '{jobComboBox.Text}'",
                    "The queen bee says:");
            else
                MessageBox.Show($"The job'{jobComboBox.Text}' will be done in {shifts.Value} shifts",
                    "The queen bee says:");
        }

        private void workTheNextShiftButton_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
