using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DietMobileApp.Services;
using DietMobileApp.Views;

namespace DietMobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            DependencyService.Register<FoodDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
