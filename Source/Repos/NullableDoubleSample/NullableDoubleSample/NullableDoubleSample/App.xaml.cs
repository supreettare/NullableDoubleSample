using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NullableDoubleSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var person = new Person { Name = "Supreet" };
            MainPage = new NavigationPage(new MainPage(person)); 
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
