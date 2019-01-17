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
	public partial class ConseilsIncidentsEtResolutionsPage : ContentPage
	{
		public ConseilsIncidentsEtResolutionsPage ()
		{
			InitializeComponent ();
		}

        bool Incident1 = false;
        public void TaraudageTropGrand(object sender, EventArgs args)
        {
            if (Incident1 == false)
            {

                Device.BeginInvokeOnMainThread(() => {
                    TropGrand.IsVisible = true;

                    Incident1 = true;
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {
                    TropGrand.IsVisible = false;

                    Incident1 = false;
                });
            }
        }

        bool Incident2 = false;
        public void TaraudageTropSerré(object sender, EventArgs args)
        {
            if (Incident2 == false)
            {

                Device.BeginInvokeOnMainThread(() => {
                    TropSerré.IsVisible = true;

                    Incident2 = true;
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {
                    TropSerré.IsVisible = false;

                    Incident2 = false;
                });
            }
        }

        bool Incident3 = false;
        public void TaraudageCassé(object sender, EventArgs args)
        {
            if (Incident3 == false)
            {

                Device.BeginInvokeOnMainThread(() => {
                    Cassé.IsVisible = true;

                    Incident3 = true;
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {
                    Cassé.IsVisible = false;

                    Incident3 = false;
                });
            }
        }

        bool Incident4 = false;
        public void TaraudAbimé(object sender, EventArgs args)
        {
            if (Incident4 == false)
            {

                Device.BeginInvokeOnMainThread(() => {
                    MauvaisEtat.IsVisible = true;

                    Incident4 = true;
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {
                    MauvaisEtat.IsVisible = false;

                    Incident4 = false;
                });
            }
        }

        bool Incident5 = false;
        public void DuréeDeVieTropCourte(object sender, EventArgs args)
        {
            if (Incident5 == false)
            {

                Device.BeginInvokeOnMainThread(() => {
                    CourteVie.IsVisible = true;

                    Incident5 = true;
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {
                    CourteVie.IsVisible = false;

                    Incident5 = false;
                });
            }
        }
    }
}