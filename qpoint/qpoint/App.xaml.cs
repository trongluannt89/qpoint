using qpoint.Models;
using qpoint.Services;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace qpoint
{
    public partial class App : Application
    {
        public static RestManager restManager { get; private set; }        

        public App()
        {
            InitializeComponent();            
            MainPage = new MainPage();
            restManager = new RestManager(new RestService());
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
