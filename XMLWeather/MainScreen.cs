using System;
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

            Form1.days[0].condition = "800";
            #region checking the different conditions and setting picture as appropriate.
            if (Convert.ToInt16(Form1.days[0].condition) == 800)
            {
                currentConditionPicture.BackgroundImage = Properties.Resources.sunny;
            }
            else if (Convert.ToInt16(Form1.days[0].condition) > 199 && Convert.ToInt16(Form1.days[0].condition) < 300)
            {
                currentConditionPicture.BackgroundImage = Properties.Resources.thunderstorm;
            }
            else if (Convert.ToInt16(Form1.days[0].condition) > 299 && Convert.ToInt16(Form1.days[0].condition) < 400)
            {
                currentConditionPicture.BackgroundImage = Properties.Resources.rainsymbol;
            }
            #endregion

            //cityOutput.Text = Form1.days[0].location;
            //tempLabel.Text = Form1.days[0].currentTemp;
            //minOutput.Text = Form1.days[0].tempLow;
            //maxOutput.Text = Form1.days[0].tempHigh;
        }
    }
}
