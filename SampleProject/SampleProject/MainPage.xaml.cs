using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleProject
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        void OnTranslate(object sender, EventArgs e)
        {
            DisplayAlert("Prabhat", "hello", "ok");
        }
    }
}
