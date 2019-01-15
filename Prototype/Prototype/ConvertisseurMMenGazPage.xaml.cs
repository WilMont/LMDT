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
    public partial class ConvertisseurMMenGazPage : ContentPage
    {
        public ConvertisseurMMenGazPage()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        public void ButtonChoixMM(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_MM.IsVisible = true;
                BouttonChoixMM.IsVisible = false;
                BouttonChoixGaz.IsVisible = false;
            });
        }

        public void Retour_millimètre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_MM.IsVisible = false;
                BouttonChoixMM.IsVisible = true;
                BouttonChoixGaz.IsVisible = true;
            });
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ButtonChoixGaz(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Gaz.IsVisible = true;
                BouttonChoixMM.IsVisible = false;
                BouttonChoixGaz.IsVisible = false;
            });
        }

        public void Retour_Gaz(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Gaz.IsVisible = false;
                BouttonChoixMM.IsVisible = true;
                BouttonChoixGaz.IsVisible = true;
            });
        }
    }
}