using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Iconize;
using OFBX.Services;
using OFBX.Views;

namespace OFBX
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.MaterialModule());

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
