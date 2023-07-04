using LeadresponseC66Device.Services;
using LeadresponseC66Device.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeadresponseC66Device
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
