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
	public partial class ConseilsMesurerUnFiletagePage : ContentPage
	{
		public ConseilsMesurerUnFiletagePage ()
		{
			InitializeComponent ();
        }

        bool EtatLabelsDiametre = false;
        public void AfficherLabelsDiametre(object sender, EventArgs args)
        {
            if (EtatLabelsDiametre == false)
            {

                Device.BeginInvokeOnMainThread(() => {
                    LabelsDiametre.IsVisible = true;

                    EtatLabelsDiametre = true;
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {
                    LabelsDiametre.IsVisible = false;

                    EtatLabelsDiametre = false;
                });
            }
        }

        bool EtatLabelsPas = false;
        public void AfficherLabelsPas(object sender, EventArgs args)
        {
            if (EtatLabelsPas == false)
            {

                Device.BeginInvokeOnMainThread(() => {
                    LabelsPas.IsVisible = true;

                    EtatLabelsPas = true;
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {
                    LabelsPas.IsVisible = false;

                    EtatLabelsPas = false;
                });
            }
        }

        bool EtatLabelsAngle = false;
        public void AfficherLabelsAngles(object sender, EventArgs args)
        {
            if (EtatLabelsAngle == false)
            {

                Device.BeginInvokeOnMainThread(() => {
                    LabelsAngle.IsVisible = true;

                    EtatLabelsAngle = true;
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {
                    LabelsAngle.IsVisible = false;

                    EtatLabelsAngle = false;
                });
            }
        }
    }
}