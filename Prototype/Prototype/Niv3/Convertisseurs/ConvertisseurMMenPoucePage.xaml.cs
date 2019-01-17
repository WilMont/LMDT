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
    public partial class ConvertisseurMMenPouce : ContentPage
    {
        public ConvertisseurMMenPouce()
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
                BouttonChoixPouces.IsVisible = false;
                ImageConversion.IsVisible = false;
                FrameImage.IsVisible = false;
            });
        }

        public void Retour_millimètre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_MM.IsVisible = false;
                BouttonChoixMM.IsVisible = true;
                BouttonChoixPouces.IsVisible = true;
                ImageConversion.IsVisible = true;
                FrameImage.IsVisible = true;
            });
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ButtonChoixPouces(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pouces.IsVisible = true;
                BouttonChoixMM.IsVisible = false;
                BouttonChoixPouces.IsVisible = false;
                ImageConversion.IsVisible = false;
                FrameImage.IsVisible = false;
            });
        }

        public void Retour_Pouce(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pouces.IsVisible = false;
                BouttonChoixMM.IsVisible = true;
                BouttonChoixPouces.IsVisible = true;
                ImageConversion.IsVisible = true;
                FrameImage.IsVisible = true;
            });
        }
    }
}