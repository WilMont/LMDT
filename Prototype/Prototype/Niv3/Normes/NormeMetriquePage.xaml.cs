using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype.Normes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NormeMetriquePage : ContentPage
	{
		public NormeMetriquePage ()
		{
			InitializeComponent ();
		}

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        public void ButtonChoixDiametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = true;
                BouttonChoixDiametre.IsVisible = false;
                BouttonChoixPas.IsVisible = false;
                BouttonChoixForet.IsVisible = false;
            });
        }

        public void Retour_Diametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
            });
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ButtonChoixPas(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = true;
                BouttonChoixDiametre.IsVisible = false;
                BouttonChoixPas.IsVisible = false;
                BouttonChoixForet.IsVisible = false;
            });
        }

        public void Retour_Pas(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
            });
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void ButtonChoixForet(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Foret.IsVisible = true;
                BouttonChoixDiametre.IsVisible = false;
                BouttonChoixPas.IsVisible = false;
                BouttonChoixForet.IsVisible = false;
            });
        }

        public void Retour_Foret(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Foret.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
            });
        }
    }
}