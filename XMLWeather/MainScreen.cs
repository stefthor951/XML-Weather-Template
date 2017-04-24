﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            currentDateOutput.Text = Form1.days[0].date;
            #region checking the different conditions and setting picture as appropriate.

            #endregion

            //cityOutput.Text = Form1.days[0].location;
            //tempLabel.Text = Form1.days[0].currentTemp;
            //minOutput.Text = Form1.days[0].tempLow;
            //maxOutput.Text = Form1.days[0].tempHigh;
        }
    }
}
