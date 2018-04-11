using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace AppDilmah
{
	public partial class JasonDetailPage : ContentPage
	{
        private AddonPopup _popup;

        public JasonDetailPage()
        {
            InitializeComponent();
        }

        public void thePopupBox(object sender, EventArgs e)
        {
            _popup = new AddonPopup();
            _popup.AddonsSelected += OnAddonsSelected;
            Navigation.PushPopupAsync(_popup, true);
        }

        private void OnAddonsSelected(object sender, JsonItemNote e)
        {
            _popup.AddonsSelected -= OnAddonsSelected;
            var message = "User select:";
            foreach (var item in e.NoteInfo)
            {
                if (item.IsSelected)
                {
                    message += $" {item.Name}";
                }
            }
            DisplayAlert("Result", message, "Ok");
        }

    }
}
