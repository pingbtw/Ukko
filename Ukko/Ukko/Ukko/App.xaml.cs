﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ukko.Services;
using Ukko.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Ukko
{
    public partial class App : Application
    {
        public static string AzureBackendUrl = "http://localhost:5000";

        public App()
        {
            InitializeComponent();

            MainPage = new UkkoTest();
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
