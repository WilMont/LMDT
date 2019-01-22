﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype.Niv3.Normes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NormeTrapezePage : ContentPage
	{
		public NormeTrapezePage ()
		{
			InitializeComponent ();
		}

        public void ButtonChoixDiametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Diametre.IsVisible = true;
                TabBtnLabelDiametre.IsVisible = false;
                TabBtnLabelPas.IsVisible = false;
                TabBtnLabelPerçage.IsVisible = false;
            });
        }

        public void Retour_Diametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
            });
        }

        void Button_Click(object sender, EventArgs args)
        {
            Button btn = (Button)sender;

            var textDiametre = btn.Text.Substring(0, 2);
            var textPas = btn.Text.Substring(3, 1);
            var textForet = btn.Text.Substring(5, 5);

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = textDiametre;
                BouttonChoixPas.Text = textPas;
                BouttonChoixForet.Text = textForet;
            });
        }
    }
}