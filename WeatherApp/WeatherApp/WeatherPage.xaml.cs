﻿using System;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();

            
            //Set the default binding to a default object for now  
            BindingContext = new Weather();
        }

        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                Weather weather = await Core.GetWeather(zipCodeEntry.Text);
                BindingContext = weather;
                getWeatherBtn.Text = "Search Again";
            }
        }
        private async void UpPageBtn_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new WeatherDetail());
        }


        
    }
}