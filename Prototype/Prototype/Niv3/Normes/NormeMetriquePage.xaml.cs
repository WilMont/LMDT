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
        public NormeMetriquePage()
        {
            InitializeComponent();
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

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Choix_2(object sender, EventArgs args)
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
        /**
        public void Choix_3(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
               
            });
        }
        public void Choix_4(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_5(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_6(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_7(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_8(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_9(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_10(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_11(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_12(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_13(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_14(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_15(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_16(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_17(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_18(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_19(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_20(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_21(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_22(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_23(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_24(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_25(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_26(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_27(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_28(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_29(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_30(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_31(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_32(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_33(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_34(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_35(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_36(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_37(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_38(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_39(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_40(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_41(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_42(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        }
        public void Choix_43(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                Btn2.Text = "0.25";
            });
        } **/
    }
}