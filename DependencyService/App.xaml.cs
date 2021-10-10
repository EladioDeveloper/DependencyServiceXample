using DependencyService.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DependencyService
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DependencyServicePage();
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
