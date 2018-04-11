using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppDilmah
{
	public partial class Dashboard : ContentPage
	{
		public Dashboard ()
		{
			InitializeComponent ();
		}

        public void test_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("START ORDER", "Clicked", "OK");
        }

        public void onlinetab_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("SEARCH FOOD", "Clicked", "OK");

        }

        public void table_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("LOGIN PAGE", "Clicked", "OK");
        }

        public void onbar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("ABOUT US", "Clicked", "OK");
        }

        public void Vedio_btn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("LOCATIONS", "Clicked", "OK");
        }

        public void Exit_btn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("EXIT", "Clicked", "OK");
        }
    }
}
