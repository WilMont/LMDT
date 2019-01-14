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
	public partial class RechercheParDiametrePage : ContentPage
	{
		public RechercheParDiametrePage ()
		{
			InitializeComponent ();
		}


        public bool EtatTabDiametre = false;
        public bool EtatTabPas = false;
        public bool EtatTabPerçage = false;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        public void ButtonChoixDiametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = true;
                BouttonChoixDiametre.IsVisible = false;
                BouttonChoixPas.IsVisible = false;
                BouttonChoixPerçage.IsVisible = false;
                  });
        }

        public void Retour_Diametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixPerçage.IsVisible = true;
            });
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ButtonChoixPas(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = true;
                BouttonChoixDiametre.IsVisible = false;
                BouttonChoixPas.IsVisible = false;
                BouttonChoixPerçage.IsVisible = false;
            });
        }

        public void Retour_Pas(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixPerçage.IsVisible = true;
            });
        }
        

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void ButtonChoixPerçage(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Perçage.IsVisible = true;
                BouttonChoixDiametre.IsVisible = false;
                BouttonChoixPas.IsVisible = false;
                BouttonChoixPerçage.IsVisible = false;
            });
        }

        public void Retour_Perçage(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Perçage.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixPerçage.IsVisible = true;
            });
        }

    }
}