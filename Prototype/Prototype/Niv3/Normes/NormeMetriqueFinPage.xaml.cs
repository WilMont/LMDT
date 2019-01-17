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
	public partial class NormeMetriqueFinPage : ContentPage
	{
        public NormeMetriqueFinPage ()
		{
            InitializeComponent();


        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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


        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DiametreChoix_2(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "1";
                BouttonChoixPas.Text = "0.25";
                BouttonChoixForet.Text = "0.75";

                PasChoix2.IsVisible = true;
            });
        }

        public void DiametreChoix_3(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "1.1";
                BouttonChoixPas.Text = "0.25";
                BouttonChoixForet.Text = "0.85";

                PasChoix3.IsVisible = true;
            });
        }

        public void DiametreChoix_4(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "1.2";
                BouttonChoixPas.Text = "0.25";
                BouttonChoixForet.Text = "0.95";
            });
        }
        public void DiametreChoix_5(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "1.4";
                BouttonChoixPas.Text = "0.25";
                BouttonChoixForet.Text = "1.15";
            });
        }
        public void DiametreChoix_6(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "1.6";
                BouttonChoixPas.Text = "0.35";
                BouttonChoixForet.Text = "1.25";
            });
        }
        public void DiametreChoix_7(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "1.7";
                BouttonChoixPas.Text = "0.35";
                BouttonChoixForet.Text = "1.35";
            });
        }
        public void DiametreChoix_8(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "1.8";
                BouttonChoixPas.Text = "0.35";
                BouttonChoixForet.Text = "1.45";
            });
        }
        public void DiametreChoix_9(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "2";
                BouttonChoixPas.Text = "0.40";
                BouttonChoixForet.Text = "1.6";
            });
        }
        public void DiametreChoix_10(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "2.2";
                BouttonChoixPas.Text = "0.45";
                BouttonChoixForet.Text = "1.75";
            });
        }
        public void DiametreChoix_11(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "2.3";
                BouttonChoixPas.Text = "0.40";
                BouttonChoixForet.Text = "1.9";
            });
        }
        public void DiametreChoix_12(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "2.5";
                BouttonChoixPas.Text = "0.45";
                BouttonChoixForet.Text = "2.05";
            });
        }
        public void DiametreChoix_13(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "2.6";
                BouttonChoixPas.Text = "0.45";
                BouttonChoixForet.Text = "2.15";
            });
        }
        public void DiametreChoix_14(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "3";
                BouttonChoixPas.Text = "0.50";
                BouttonChoixForet.Text = "2.5";
            });
        }
        public void DiametreChoix_15(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "3.5";
                BouttonChoixPas.Text = "0.60";
                BouttonChoixForet.Text = "2.9";
            });
        }
        public void DiametreChoix_16(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "4";
                BouttonChoixPas.Text = "0.70";
                BouttonChoixForet.Text = "3.3";
            });
        }
        public void DiametreChoix_17(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "4.5";
                BouttonChoixPas.Text = "0.75";
                BouttonChoixForet.Text = "3.75";
            });
        }
        public void DiametreChoix_18(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "5";
                BouttonChoixPas.Text = "0.80";
                BouttonChoixForet.Text = "4.2";
            });
        }
        public void DiametreChoix_19(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "5.5";
                BouttonChoixPas.Text = "0.90";
                BouttonChoixForet.Text = "4.6";
            });
        }
        public void DiametreChoix_20(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "6";
                BouttonChoixPas.Text = "1.00";
                BouttonChoixForet.Text = "5";
            });
        }
        public void DiametreChoix_21(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "7";
                BouttonChoixPas.Text = "1.00";
                BouttonChoixForet.Text = "6";
            });
        }
        public void DiametreChoix_22(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "8";
                BouttonChoixPas.Text = "1.25";
                BouttonChoixForet.Text = "6.8";
            });
        }
        public void DiametreChoix_23(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "9";
                BouttonChoixPas.Text = "1.25";
                BouttonChoixForet.Text = "7.8";
            });
        }
        public void DiametreChoix_24(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "10";
                BouttonChoixPas.Text = "1.50";
                BouttonChoixForet.Text = "8.5";
            });
        }
        public void DiametreChoix_25(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "11";
                BouttonChoixPas.Text = "1.50";
                BouttonChoixForet.Text = "9.5";
            });
        }
        public void DiametreChoix_26(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "12";
                BouttonChoixPas.Text = "1.75";
                BouttonChoixForet.Text = "10.2";
            });
        }
        public void DiametreChoix_27(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "14";
                BouttonChoixPas.Text = "2.00";
                BouttonChoixForet.Text = "12";
            });
        }
        public void DiametreChoix_28(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "16";
                BouttonChoixPas.Text = "2.00";
                BouttonChoixForet.Text = "14";
            });
        }
        public void DiametreChoix_29(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "18";
                BouttonChoixPas.Text = "2.50";
                BouttonChoixForet.Text = "15.5";
            });
        }
        public void DiametreChoix_30(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "20";
                BouttonChoixPas.Text = "2.50";
                BouttonChoixForet.Text = "17.5";
            });
        }
        public void DiametreChoix_31(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "22";
                BouttonChoixPas.Text = "2.50";
                BouttonChoixForet.Text = "19.5";
            });
        }
        public void DiametreChoix_32(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "24";
                BouttonChoixPas.Text = "3.00";
                BouttonChoixForet.Text = "21";
            });
        }
        public void DiametreChoix_33(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "27";
                BouttonChoixPas.Text = "3.00";
                BouttonChoixForet.Text = "24";
            });
        }
        public void DiametreChoix_34(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "30";
                BouttonChoixPas.Text = "3.50";
                BouttonChoixForet.Text = "26.5";
            });
        }
        public void DiametreChoix_35(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "33";
                BouttonChoixPas.Text = "3.50";
                BouttonChoixForet.Text = "29.5";
            });
        }
        public void DiametreChoix_36(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "36";
                BouttonChoixPas.Text = "4.00";
                BouttonChoixForet.Text = "32";
            });
        }
        public void DiametreChoix_37(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "39";
                BouttonChoixPas.Text = "4.00";
                BouttonChoixForet.Text = "35";
            });
        }
        public void DiametreChoix_38(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "42";
                BouttonChoixPas.Text = "4.50";
                BouttonChoixForet.Text = "37.5";
            });
        }

    }
}