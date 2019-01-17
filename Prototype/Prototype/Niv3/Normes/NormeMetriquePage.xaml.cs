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

       


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /**
        void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.ClassId)
            {
                case Prototype.NormeMetriquePage.Choix_1:
                    //button1 was clicked
                    break;
                case btn.Id.MyButton2:
                    //button2 was clicked
                    break;
            }
        }
    
        public void Choix_1(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                BouttonChoixDiametre.IsVisible = true;
                BouttonChoixPas.IsVisible = true;
                BouttonChoixForet.IsVisible = true;
                BouttonChoixDiametre.Text = "1";
                BouttonChoixPas.Text = "0.25";
                BouttonChoixForet.Text = "0.75";
            });
        }

    
    **/


        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void Choix_2(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "1";
                BouttonChoixPas.Text = "0.25";
                BouttonChoixForet.Text = "0.75";
            });
        }

        public void Choix_3(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "1.1";
                BouttonChoixPas.Text = "0.25";
                BouttonChoixForet.Text = "0.85";
            });
        }

        public void Choix_4(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "1.2";
                BouttonChoixPas.Text = "0.25";
                BouttonChoixForet.Text = "0.95";
            });
        }
        public void Choix_5(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "1.4";
                BouttonChoixPas.Text = "0.25";
                BouttonChoixForet.Text = "1.15";
            });
        }
        public void Choix_6(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "1.6";
                BouttonChoixPas.Text = "0.35";
                BouttonChoixForet.Text = "1.25";
            });
        }
        public void Choix_7(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "1.7";
                BouttonChoixPas.Text = "0.35";
                BouttonChoixForet.Text = "1.35";
            });
        }
        public void Choix_8(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "1.8";
                BouttonChoixPas.Text = "0.35";
                BouttonChoixForet.Text = "1.45";
            });
        }
        public void Choix_9(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "2";
                BouttonChoixPas.Text = "0.40";
                BouttonChoixForet.Text = "1.6";
            });
        }
        public void Choix_10(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "2.2";
                BouttonChoixPas.Text = "0.45";
                BouttonChoixForet.Text = "1.75";
            });
        }
        public void Choix_11(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "2.3";
                BouttonChoixPas.Text = "0.40";
                BouttonChoixForet.Text = "1.9";
            });
        }
        public void Choix_12(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "2.5";
                BouttonChoixPas.Text = "0.45";
                BouttonChoixForet.Text = "2.05";
            });
        }
        public void Choix_13(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "2.6";
                BouttonChoixPas.Text = "0.45";
                BouttonChoixForet.Text = "2.15";
            });
        }
        public void Choix_14(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "3";
                BouttonChoixPas.Text = "0.50";
                BouttonChoixForet.Text = "2.5";
            });
        }
        public void Choix_15(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "3.5";
                BouttonChoixPas.Text = "0.60";
                BouttonChoixForet.Text = "2.9";
            });
        }
        public void Choix_16(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "4";
                BouttonChoixPas.Text = "0.70";
                BouttonChoixForet.Text = "3.3";
            });
        }
        public void Choix_17(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "4.5";
                BouttonChoixPas.Text = "0.75";
                BouttonChoixForet.Text = "3.75";
            });
        }
        public void Choix_18(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "5";
                BouttonChoixPas.Text = "0.80";
                BouttonChoixForet.Text = "4.2";
            });
        }
        public void Choix_19(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "5.5";
                BouttonChoixPas.Text = "0.90";
                BouttonChoixForet.Text = "4.6";
            });
        }
        public void Choix_20(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "6";
                BouttonChoixPas.Text = "1.00";
                BouttonChoixForet.Text = "5";
            });
        }
        public void Choix_21(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "7";
                BouttonChoixPas.Text = "1.00";
                BouttonChoixForet.Text = "6";
            });
        }
        public void Choix_22(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "8";
                BouttonChoixPas.Text = "1.25";
                BouttonChoixForet.Text = "6.8";
            });
        }
        public void Choix_23(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "9";
                BouttonChoixPas.Text = "1.25";
                BouttonChoixForet.Text = "7.8";
            });
        }
        public void Choix_24(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "10";
                BouttonChoixPas.Text = "1.50";
                BouttonChoixForet.Text = "8.5";
            });
        }
        public void Choix_25(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "11";
                BouttonChoixPas.Text = "1.50";
                BouttonChoixForet.Text = "9.5";
            });
        }
        public void Choix_26(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "12";
                BouttonChoixPas.Text = "1.75";
                BouttonChoixForet.Text = "10.2";
            });
        }
        public void Choix_27(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "14";
                BouttonChoixPas.Text = "2.00";
                BouttonChoixForet.Text = "12";
            });
        }
        public void Choix_28(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "16";
                BouttonChoixPas.Text = "2.00";
                BouttonChoixForet.Text = "14";
            });
        }
        public void Choix_29(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "18";
                BouttonChoixPas.Text = "2.50";
                BouttonChoixForet.Text = "15.5";
            });
        }
        public void Choix_30(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "20";
                BouttonChoixPas.Text = "2.50";
                BouttonChoixForet.Text = "17.5";
            });
        }
        public void Choix_31(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "22";
                BouttonChoixPas.Text = "2.50";
                BouttonChoixForet.Text = "19.5";
            });
        }
        public void Choix_32(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "24";
                BouttonChoixPas.Text = "3.00";
                BouttonChoixForet.Text = "21";
            });
        }
        public void Choix_33(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "27";
                BouttonChoixPas.Text = "3.00";
                BouttonChoixForet.Text = "24";
            });
        }
        public void Choix_34(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "30";
                BouttonChoixPas.Text = "3.50";
                BouttonChoixForet.Text = "26.5";
            });
        }
        public void Choix_35(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "33";
                BouttonChoixPas.Text = "3.50";
                BouttonChoixForet.Text = "29.5";
            });
        }
        public void Choix_36(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "36";
                BouttonChoixPas.Text = "4.00";
                BouttonChoixForet.Text = "32";
            });
        }
        public void Choix_37(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "39";
                BouttonChoixPas.Text = "4.00";
                BouttonChoixForet.Text = "35";
            });
        }
        public void Choix_38(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "42";
                BouttonChoixPas.Text = "4.50";
                BouttonChoixForet.Text = "37.5";
            });
        }
        public void Choix_39(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "45";
                BouttonChoixPas.Text = "4.50";
                BouttonChoixForet.Text = "40.5";
            });
        }
        public void Choix_40(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "48";
                BouttonChoixPas.Text = "5.00";
                BouttonChoixForet.Text = "43";
            });
        }
        public void Choix_41(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "52";
                BouttonChoixPas.Text = "5.00";
                BouttonChoixForet.Text = "47";
            });
        }
        public void Choix_42(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "56";
                BouttonChoixPas.Text = "5.50";
                BouttonChoixForet.Text = "50.5";
            });
        }
        public void Choix_43(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BouttonChoixDiametre.Text = "60";
                BouttonChoixPas.Text = "5.50";
                BouttonChoixForet.Text = "54.5";
            });
        }
    }
}