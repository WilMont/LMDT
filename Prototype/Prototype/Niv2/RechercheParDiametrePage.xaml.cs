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

        public void ButtonChoixDiametre_clicked(object sender, EventArgs args)
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

        public void ButtonChoixPas_clicked(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = true;
                TabBtnLabelDiametre.IsVisible = false;
                TabBtnLabelPas.IsVisible = false;
                TabBtnLabelPerçage.IsVisible = false;
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




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void Button_Click(object sender, EventArgs args)
        {
            Button btn = (Button)sender;

            var textDiametre = btn.Text.Substring(0, 18);
            var textPas1 = btn.Text.Substring(19, 11);
            var textPas2 = btn.Text.Substring(31, 11);
            var textPas3 = btn.Text.Substring(43, 11);
            var textPas4 = btn.Text.Substring(55, 11);
            var textPas5 = btn.Text.Substring(67, 11);
            var textPerçage1 = btn.Text.Substring(79, 5);
            var textPerçage2 = btn.Text.Substring(85, 5);
            var textPerçage3 = btn.Text.Substring(91, 5);
            var textPerçage4 = btn.Text.Substring(97, 5);
            var textPerçage5 = btn.Text.Substring(103, 5);

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;

                BoutonChoixDiametre.Text = textDiametre;

                BtnPasChoix1.Text = textPerçage1 + textPas1;
                BtnPasChoix2.Text = textPerçage2 + textPas2;
                BtnPasChoix3.Text = textPerçage3 + textPas3;
                BtnPasChoix4.Text = textPerçage4 + textPas4;
                BtnPasChoix5.Text = textPerçage5 + textPas5;

                BtnPasChoix1Front.Text = textPas1;
                BtnPasChoix2Front.Text = textPas2;
                BtnPasChoix3Front.Text = textPas3;
                BtnPasChoix4Front.Text = textPas4;
                BtnPasChoix5Front.Text = textPas5;

                BouttonChoixPas.BackgroundColor = Color.SaddleBrown;
                BouttonChoixPas.BorderColor = Color.Chocolate;
                BouttonChoixPas.Text = "Choisir";
            });
        }

        void ButtonPas_Click(object sender, EventArgs args)
        {
            Button btn = (Button)sender;

            var textPourPerçage = btn.Text.Substring(0, 5);
            var textPas = btn.Text.Substring(5, 11);

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Pas.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;

                BouttonChoixPas.Text = textPas;
                BoutonChoixPerçage.Text = textPourPerçage;
            });
        }

    }
}