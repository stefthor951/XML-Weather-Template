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
            dayOutput1.Text = dayOutput.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            dayOutput2.Text = dayOutput.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            dayOutput3.Text = dayOutput.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();

            currentDateOutput.Text = Form1.days[0].date;
            dateOutput1.Text = Form1.days[1].date;
            dateOutput2.Text = Form1.days[2].date;
            dateOutput3.Text = Form1.days[3].date;

            tempOutput1.Text = "H: " + Form1.days[1].tempHigh + "°C" + "\n L: " + Form1.days[1].tempLow + "°C";
            tempOutput2.Text = "H: " + Form1.days[2].tempHigh + "°C" + "\n L: " + Form1.days[2].tempLow + "°C";
            tempOutput3.Text = "H: " + Form1.days[3].tempHigh + "°C" + "\n L: " + Form1.days[3].tempLow + "°C";

            precipitationOutput1.Text = Form1.days[1].precipitation + "mm ";
            precipitationOutput2.Text = Form1.days[2].precipitation + "mm ";
            precipitationOutput3.Text = Form1.days[3].precipitation + "mm ";

            currentConditionText.Text = Form1.days[0].condition + "   " + Form1.days[0].currentTemp + "°C";
            windOutput.Text = Form1.days[0].windSpeed + "km/h winds " + Form1.days[0].windDirection;


            #region checking the different conditionIDs for today and setting picture as appropriate.

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
            #region checking conditionIDs for day1

            if (Convert.ToInt16(Form1.days[1].conditionID) > 199 && Convert.ToInt16(Form1.days[1].conditionID) < 300)
            {
                conditionOutput1.BackgroundImage = Properties.Resources.thunderstorm;
            }
            else if (Convert.ToInt16(Form1.days[1].conditionID) > 299 && Convert.ToInt16(Form1.days[1].conditionID) < 600)
            {
                conditionOutput1.BackgroundImage = Properties.Resources.rainsymbol;
            }
            else if (Convert.ToInt16(Form1.days[1].conditionID) > 599 && Convert.ToInt16(Form1.days[1].conditionID) < 700)
            {
                conditionOutput1.BackgroundImage = Properties.Resources.snow;
            }
            else if (Convert.ToInt16(Form1.days[1].conditionID) > 699 && Convert.ToInt16(Form1.days[1].conditionID) < 800)
            {
                conditionOutput1.BackgroundImage = Properties.Resources.cloudy1;
            }
            else if (Convert.ToInt16(Form1.days[1].conditionID) == 800)
            {
                conditionOutput1.BackgroundImage = Properties.Resources.sunny;
            }
            else if (Convert.ToInt16(Form1.days[1].conditionID) > 800 && Convert.ToInt16(Form1.days[1].conditionID) < 900)
            {
                conditionOutput1.BackgroundImage = Properties.Resources.cloudy;
            }
            #endregion

            #region checking conditionIDs for day2

            if (Convert.ToInt16(Form1.days[2].conditionID) > 199 && Convert.ToInt16(Form1.days[2].conditionID) < 300)
            {
                conditionOutput2.BackgroundImage = Properties.Resources.thunderstorm;
            }
            else if (Convert.ToInt16(Form1.days[2].conditionID) > 299 && Convert.ToInt16(Form1.days[2].conditionID) < 600)
            {
                conditionOutput2.BackgroundImage = Properties.Resources.rainsymbol;
            }
            else if (Convert.ToInt16(Form1.days[2].conditionID) > 599 && Convert.ToInt16(Form1.days[2].conditionID) < 700)
            {
                conditionOutput2.BackgroundImage = Properties.Resources.snow;
            }
            else if (Convert.ToInt16(Form1.days[2].conditionID) > 699 && Convert.ToInt16(Form1.days[2].conditionID) < 800)
            {
                conditionOutput2.BackgroundImage = Properties.Resources.cloudy1;
            }
            else if (Convert.ToInt16(Form1.days[2].conditionID) == 800)
            {
                conditionOutput2.BackgroundImage = Properties.Resources.sunny;
            }
            else if (Convert.ToInt16(Form1.days[2].conditionID) > 800 && Convert.ToInt16(Form1.days[2].conditionID) < 900)
            {
                conditionOutput2.BackgroundImage = Properties.Resources.cloudy;
            }
            #endregion

            #region checking conditionIDs for day3

            if (Convert.ToInt16(Form1.days[3].conditionID) > 199 && Convert.ToInt16(Form1.days[3].conditionID) < 300)
            {
                conditionOutput3.BackgroundImage = Properties.Resources.thunderstorm;
            }
            else if (Convert.ToInt16(Form1.days[3].conditionID) > 299 && Convert.ToInt16(Form1.days[3].conditionID) < 600)
            {
                conditionOutput3.BackgroundImage = Properties.Resources.rainsymbol;
            }
            else if (Convert.ToInt16(Form1.days[3].conditionID) > 599 && Convert.ToInt16(Form1.days[3].conditionID) < 700)
            {
                conditionOutput3.BackgroundImage = Properties.Resources.snow;
            }
            else if (Convert.ToInt16(Form1.days[3].conditionID) > 699 && Convert.ToInt16(Form1.days[3].conditionID) < 800)
            {
                conditionOutput3.BackgroundImage = Properties.Resources.cloudy1;
            }
            else if (Convert.ToInt16(Form1.days[3].conditionID) == 800)
            {
                conditionOutput3.BackgroundImage = Properties.Resources.sunny;
            }
            else if (Convert.ToInt16(Form1.days[3].conditionID) > 800 && Convert.ToInt16(Form1.days[3].conditionID) < 900)
            {
                conditionOutput3.BackgroundImage = Properties.Resources.cloudy;
            }
            #endregion

            //cityOutput.Text = Form1.days[0].location;
            //tempLabel.Text = Form1.days[0].currentTemp;
            //minOutput.Text = Form1.days[0].tempLow;
            //maxOutput.Text = Form1.days[0].tempHigh;
        }
    }
}
