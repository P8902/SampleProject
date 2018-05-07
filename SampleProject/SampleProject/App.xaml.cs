using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace SampleProject
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new SampleProject.MainPage();
		}

		protected override void OnStart ()
		{
           // AppCenter.Start("android=0581d912-8d9c-4ff6-b2e7-880cb00a8cea;" +"uwp={Your UWP App secret here};" +"ios={Your iOS App secret here}",typeof(Analytics), typeof(Crashes));
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
