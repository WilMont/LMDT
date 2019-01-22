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
    public partial class NormeMetriqueFinPage : ContentPage
    {
        public NormeMetriqueFinPage()
        {
            InitializeComponent();

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void ButtonChoixDiametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = true;
                TabBtnLabelDiametre.IsVisible = false;
                TabBtnLabelPas.IsVisible = false;
                TabBtnLabelPerçage.IsVisible = false;
            });
        }

        public void Retour_Diametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
            });
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        void Button_Click(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            var texteBouton = btn.Text;

            var debutDiametre = texteBouton.IndexOf('D');
            var debutPas = texteBouton.IndexOf('P');
            var debutForet = texteBouton.IndexOf('F');

            var textDiametre = texteBouton.Substring(1, debutPas-1);
            var textPas = texteBouton.Substring(debutPas+1, debutForet-debutPas-1);
            var textForet = texteBouton.Substring(debutForet+1);

            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = textDiametre;
                BouttonChoixPas.Text = textPas;
                BouttonChoixForet.Text = textForet;
                BouttonChoixPas.BackgroundColor = Color.SaddleBrown;
            });
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////::

        public void ButtonChoixPas_Clicked(object sender, EventArgs args)
            {
                Device.BeginInvokeOnMainThread(() => {
                    Tab_Pas.IsVisible = true;
                    TabBtnLabelDiametre.IsVisible = false;
                    TabBtnLabelPas.IsVisible = false;
                    TabBtnLabelPerçage.IsVisible = false;

                    switch (BouttonChoixDiametre.Text)
                    {
                        case "3":

                            break;
                        case "4":

                            break;
                        case "5":

                            break;
                        case "6":

                            break;
                        case "7":

                            break;
                    }
                });
            }
        public void Retour_Pas(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
            });
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}