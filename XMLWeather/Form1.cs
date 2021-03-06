﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();
        Day d = new Day();
        List<PictureBox> conditionOutput = new List<PictureBox>();
        
        public Form1()
        {
            InitializeComponent();
            //try
            {
                GetData();
                ExtractCurrent();
                ExtractForecast();
            }
            //catch
            {
                //MessageBox.Show("Please connect to a network.");
            }


            // open weather screen for todays weather
            //CurrentScreen cs = new CurrentScreen();
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData.xml");
            // mulit day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData7Day.xml");
       
        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");
            
            XmlNode parent;
            parent = doc.DocumentElement;
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "city")
                {
                    d.location = child.Attributes["name"].Value;
                }

                //if (child.Name == "precipitation")
                //{
                //    d.precipitation = child.Attributes["value"].Value;

                //}

                if (child.Name == "temperature")
                {
                    d.tempHigh = child.Attributes["max"].Value;
                    d.tempLow = child.Attributes["min"].Value;
                    d.currentTemp = Convert.ToString(Math.Round(Convert.ToDouble(child.Attributes["value"].Value)));
                }

                if (child.Name == "wind")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "speed")
                        {
                            d.windSpeed = grandChild.Attributes["value"].Value;
                        }

                        if (grandChild.Name == "direction")
                        {
                            d.windDirection = grandChild.Attributes["code"].Value;
                        }
                    }
                }

                if (child.Name == "weather")
                {
                    d.conditionID = child.Attributes["number"].Value;
                    d.condition = child.Attributes["value"].Value;
                }
            }
            days.Add(d);
        }
              
        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            d = new Day();

            XmlNode parent;
            parent = doc.DocumentElement;
            foreach (XmlNode child in parent.ChildNodes)
            {

                if (child.Name == "forecast")
                {
                    int counter = 0;
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (counter == 0)
                        {
                            days[0].date = grandChild.Attributes["day"].Value;
                            counter++;
                        }

                        if (grandChild.Name == "time")
                        {
                            d.date = grandChild.Attributes["day"].Value;
                        }

                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                        {
                            d.date = grandChild.Attributes["day"].Value;

                            if (greatGrandChild.Name == "symbol")
                            {
                                d.condition = greatGrandChild.Attributes["name"].Value;
                                d.conditionID = greatGrandChild.Attributes["number"].Value;

                            }

                            if (greatGrandChild.Name == "precipitation" && greatGrandChild.Attributes.Count > 0)
                            {
                                d.precipitation = greatGrandChild.Attributes["value"].Value;
                            }

                            if (greatGrandChild.Name == "precipitation" && greatGrandChild.Attributes.Count == 0)
                            {
                                d.precipitation = "0";
                            }

                            if (greatGrandChild.Name == "temperature")
                            {
                                d.tempHigh = greatGrandChild.Attributes["max"].Value;
                                d.tempLow = greatGrandChild.Attributes["min"].Value;
                                days.Add(d);
                                d = new Day();
                                
                            }



                            
                        }
                    }
                }
            }
            days.RemoveAt(1);
        }
    }
}
