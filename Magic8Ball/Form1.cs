﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        Random answer = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            int numberAnswer = answer.Next(1, 8);

            switch(numberAnswer)
            {
                case 1:
                    fortuneOutput.Text = "Without a doubt";
                    break;
                case 2:
                    fortuneOutput.Text = "It is possible...";
                    break;
                case 3:
                    fortuneOutput.Text = "Not a chance";
                    break;
                case 4:
                    fortuneOutput.Text = "Answer cloudy, try again";
                    break;
                case 5:
                    fortuneOutput.Text = "Most certainly";
                    break;
                case 6:
                    fortuneOutput.Text = "That is so unlikely it's not even funny";
                    break;
                case 7:
                    fortuneOutput.Text = "Unfortunately, no";
                    break;
                case 8:
                    fortuneOutput.Text = "Probably not";
                    break;
            }
        }
    }
}
