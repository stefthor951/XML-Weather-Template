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
            dayOutput.Text = DateTime.Now.AddDays(0).DayOfWeek.ToString();
            currentDateOutput.Text = Form1.days[0].date;
            currentConditionText.Text = Form1.days[0].condition + "   " + Form1.days[0].currentTemp + "°C";

            #region checking the different conditionIDs and setting picture as appropriate.

            if (Convert.ToInt16(Form1.days[0].conditionID) > 199 && Convert.ToInt16(Form1.days[0].conditionID) < 300)
            {
                currentConditionPicture.BackgroundImage = Properties.Resources.thunderstorm;
            }
            else if (Convert.ToInt16(Form1.days[0].conditionID) > 299 && Convert.ToInt16(Form1.days[0].conditionID) < 600)
            {
                currentConditionPicture.BackgroundImage = Properties.Resources.rainsymbol;
            }
            else if (Convert.ToInt16(Form1.days[0].conditionID) > 599 && Convert.ToInt16(Form1.days[0].conditionID) < 700)
            {
                currentConditionPicture.BackgroundImage = Properties.Resources.snow;
            }
            else if (Convert.ToInt16(Form1.days[0].conditionID) > 699 && Convert.ToInt16(Form1.days[0].conditionID) < 800)
            {
                currentConditionPicture.BackgroundImage = Properties.Resources.cloudy1;
            }
            else if (Convert.ToInt16(Form1.days[0].conditionID) == 800)
            {
                currentConditionPicture.BackgroundImage = Properties.Resources.sunny;
            }
            else if (Convert.ToInt16(Form1.days[0].conditionID) > 800 && Convert.ToInt16(Form1.days[0].conditionID) < 900)
            {
                currentConditionPicture.BackgroundImage = Properties.Resources.cloudy;
            }
            #endregion

            //cityOutput.Text = Form1.days[0].location;
            //tempLabel.Text = Form1.days[0].currentTemp;
            //minOutput.Text = Form1.days[0].tempLow;
            //maxOutput.Text = Form1.days[0].tempHigh;
        }
    }
}
