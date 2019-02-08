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
        public RechercheParDiametrePage()
        {
            InitializeComponent();
        }

        public void ButtonChoixDiametre_clicked(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = true;
                TabBtnLabelDiametre.IsVisible = false;
                TabBtnLabelPas.IsVisible = false;
                TabBtnLabelPerçage.IsVisible = false;
                Tab_Diametre.ForceLayout();
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
        ///
        public void ButtonChoixPas_clicked(object sender, EventArgs args)
        {
            if (BouttonChoixPas.BackgroundColor != Color.Gray) { 
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = true;
                TabBtnLabelDiametre.IsVisible = false;
                TabBtnLabelPas.IsVisible = false;
                TabBtnLabelPerçage.IsVisible = false;
            });
            }
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
            var textPas6 = btn.Text.Substring(79, 11);
            var textPas7 = btn.Text.Substring(91, 11);
            var textPas8 = btn.Text.Substring(103, 11);
            var textPerçage1 = btn.Text.Substring(115, 5);
            var textPerçage2 = btn.Text.Substring(121, 5);
            var textPerçage3 = btn.Text.Substring(127, 5);
            var textPerçage4 = btn.Text.Substring(133, 5);
            var textPerçage5 = btn.Text.Substring(139, 5);
            var textPerçage6 = btn.Text.Substring(145, 5);
            var textPerçage7 = btn.Text.Substring(151, 5);
            var textPerçage8 = btn.Text.Substring(157, 5);

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;

                BoutonChoixDiametre.Text = textDiametre.Trim();

                BtnPasChoix1.Text = textPerçage1 + textPas1;
                BtnPasChoix2.Text = textPerçage2 + textPas2;
                BtnPasChoix3.Text = textPerçage3 + textPas3;
                BtnPasChoix4.Text = textPerçage4 + textPas4;
                BtnPasChoix5.Text = textPerçage5 + textPas5;
                BtnPasChoix6.Text = textPerçage6 + textPas6;
                BtnPasChoix7.Text = textPerçage7 + textPas7;
                BtnPasChoix8.Text = textPerçage8 + textPas8;

                BtnPasChoix1Front.Text = textPas1;
                BtnPasChoix2Front.Text = textPas2;
                BtnPasChoix3Front.Text = textPas3;
                BtnPasChoix4Front.Text = textPas4;
                BtnPasChoix5Front.Text = textPas5;
                BtnPasChoix6Front.Text = textPas6;
                BtnPasChoix7Front.Text = textPas7;
                BtnPasChoix8Front.Text = textPas8;

                if (BtnPasChoix1Front.Text == "###########")
                {
                    BtnPasChoix1.IsVisible = false;
                    BtnPasChoix1Front.IsVisible = false;
                } else {
                    BtnPasChoix1.IsVisible = true;
                    BtnPasChoix1Front.IsVisible = true;
                }

                if (BtnPasChoix2Front.Text == "###########")
                {
                    BtnPasChoix2.IsVisible = false;
                    BtnPasChoix2Front.IsVisible = false;
                } else {
                    BtnPasChoix2.IsVisible = true;
                    BtnPasChoix2Front.IsVisible = true;
                }

                if (BtnPasChoix3Front.Text == "###########")
                {
                    BtnPasChoix3.IsVisible = false;
                    BtnPasChoix3Front.IsVisible = false;
                } else {
                    BtnPasChoix3.IsVisible = true;
                    BtnPasChoix3Front.IsVisible = true;
                }

                if (BtnPasChoix4Front.Text == "###########")
                {
                    BtnPasChoix4.IsVisible = false;
                    BtnPasChoix4Front.IsVisible = false;
                } else {
                    BtnPasChoix4.IsVisible = true;
                    BtnPasChoix4Front.IsVisible = true;
                }

                if (BtnPasChoix5Front.Text == "###########")
                {
                    BtnPasChoix5.IsVisible = false;
                    BtnPasChoix5Front.IsVisible = false;
                } else {
                    BtnPasChoix5.IsVisible = true;
                    BtnPasChoix5Front.IsVisible = true;
                }

                if (BtnPasChoix6Front.Text == "###########")
                {
                    BtnPasChoix6.IsVisible = false;
                    BtnPasChoix6Front.IsVisible = false;
                } else {
                    BtnPasChoix6.IsVisible = true;
                    BtnPasChoix6Front.IsVisible = true;
                }

                if (BtnPasChoix7Front.Text == "###########")
                {
                    BtnPasChoix7.IsVisible = false;
                    BtnPasChoix7Front.IsVisible = false;
                } else {
                    BtnPasChoix7.IsVisible = true;
                    BtnPasChoix7Front.IsVisible = true;
                }

                if (BtnPasChoix8Front.Text == "###########")
                {
                    BtnPasChoix8.IsVisible = false;
                    BtnPasChoix8Front.IsVisible = false;
                } else {
                    BtnPasChoix8.IsVisible = true;
                    BtnPasChoix8Front.IsVisible = true;
                }

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

                BouttonChoixPas.Text = textPas.Trim();
                BoutonChoixPerçage.Text = textPourPerçage.Trim();
            });
        }

    }
}