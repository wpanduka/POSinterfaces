using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDilmah
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public void Clicktonext(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JasonDetailPage(),true);

           // DisplayAlert("Clicked", "Yes", "OK");
        }
    }
}
