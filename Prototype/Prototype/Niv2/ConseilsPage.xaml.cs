using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConseilsPage : ContentPage
	{
		public ConseilsPage ()
		{
			InitializeComponent ();
		}

        async void BtnMesurerUnFiletage_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConseilsMesurerUnFiletagePage());
        }

        async void IncidentsEtResolutions_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConseilsIncidentsEtResolutionsPage());
        }
    }
}