using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace WeatherApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            var indexPage = new WeatherPage();
            Core.SetPage("index",indexPage);
            MainPage = new NavigationPage(indexPage);

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
