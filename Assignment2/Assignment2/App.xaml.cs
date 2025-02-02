﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            DatabaseManager.createConnection();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
