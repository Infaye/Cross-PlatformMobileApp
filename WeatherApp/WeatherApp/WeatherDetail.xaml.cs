using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherDetail : ContentPage
    {

        public WeatherDetail()
        {
            InitializeComponent();
        }

        private void UpPage_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new WeatherPage());

        }

        private void DownPage_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}