using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ScanDemo.Services;
using ScanDemo.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace ScanDemo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            AppCenter.Start("ios=9813026e-ea39-4951-8ca7-e93cc3f2dc47;", typeof(Analytics), typeof(Crashes));

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
