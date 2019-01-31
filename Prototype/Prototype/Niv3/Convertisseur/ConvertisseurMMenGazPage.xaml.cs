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
		public ConvertisseurMMenGazPage ()
		{
			InitializeComponent ();
		}

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
        public void ButtonChoixMM(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_MM.IsVisible = true;
                BouttonChoixMM.IsVisible = false;
                BouttonChoixGaz.IsVisible = false;
                ImageConversion.IsVisible = false;
                LabelBtn1.IsVisible = false;
                LabelBtn2.IsVisible = false;
                FrameImage.IsVisible = false;
            });
        }

        public void Retour_millimètre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_MM.IsVisible = false;
                BouttonChoixMM.IsVisible = true;
                BouttonChoixGaz.IsVisible = true;
                ImageConversion.IsVisible = true;
                LabelBtn1.IsVisible = true;
                LabelBtn2.IsVisible = true;
                FrameImage.IsVisible = true;
            });
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ButtonChoixGaz(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Gaz.IsVisible = true;
                BouttonChoixMM.IsVisible = false;
                BouttonChoixGaz.IsVisible = false;
                ImageConversion.IsVisible = false;
                LabelBtn1.IsVisible = false;
                LabelBtn2.IsVisible = false;
                FrameImage.IsVisible = false;
            });
        }

        public void Retour_Gaz(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Gaz.IsVisible = false;
                BouttonChoixMM.IsVisible = true;
                BouttonChoixGaz.IsVisible = true;
                ImageConversion.IsVisible = true;
                LabelBtn1.IsVisible = true;
                LabelBtn2.IsVisible = true;
                FrameImage.IsVisible = true;
            });
        }

        void Button_Click_MM(object sender, EventArgs args)
        {
            Button btn = (Button)sender;

            var text_MM = btn.Text.Substring(0, 6);
            var text_Gaz = btn.Text.Substring(7, 9);

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_MM.IsVisible = false;
                LabelBtn1.IsVisible = true;
                BouttonChoixMM.IsVisible = true;
                LabelBtn2.IsVisible = true;
                BouttonChoixGaz.IsVisible = true;
                ImageConversion.IsVisible = true;
                FrameImage.IsVisible = true;

                BouttonChoixMM.Text = text_MM.Trim();
                BouttonChoixGaz.Text = text_Gaz.Trim();
            });
        }

        void Button_Click_Gaz(object sender, EventArgs args)
        {
            Button btn = (Button)sender;

            var text_MM = btn.Text.Substring(10, 6);
            var text_Gaz = btn.Text.Substring(0, 7);

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Gaz.IsVisible = false;
                LabelBtn1.IsVisible = true;
                BouttonChoixMM.IsVisible = true;
                LabelBtn2.IsVisible = true;
                BouttonChoixGaz.IsVisible = true;
                ImageConversion.IsVisible = true;
                FrameImage.IsVisible = true;

                BouttonChoixMM.Text = text_MM.Trim();
                BouttonChoixGaz.Text = text_Gaz.Trim();
            });
        }
    }
}