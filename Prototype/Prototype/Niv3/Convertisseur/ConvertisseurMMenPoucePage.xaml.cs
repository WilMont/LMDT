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
            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_MM.IsVisible = true;
                BouttonChoixMM.IsVisible = false;
                BouttonChoixPouces.IsVisible = false;
                ImageConversion.IsVisible = false;
                LabelBtn1.IsVisible = false;
                LabelBtn2.IsVisible = false;
                FrameImage.IsVisible = false;
            });
        }

        public void Retour_millimètre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_MM.IsVisible = false;
                BouttonChoixMM.IsVisible = true;
                BouttonChoixPouces.IsVisible = true;
                ImageConversion.IsVisible = true;
                LabelBtn1.IsVisible = true;
                LabelBtn2.IsVisible = true;
                FrameImage.IsVisible = true;
            });
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ButtonChoixPouces(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Pouces.IsVisible = true;
                BouttonChoixMM.IsVisible = false;
                BouttonChoixPouces.IsVisible = false;
                ImageConversion.IsVisible = false;
                LabelBtn1.IsVisible = false;
                LabelBtn2.IsVisible = false;
                FrameImage.IsVisible = false;
            });
        }

        public void Retour_Pouce(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Pouces.IsVisible = false;
                BouttonChoixMM.IsVisible = true;
                BouttonChoixPouces.IsVisible = true;
                ImageConversion.IsVisible = true;
                LabelBtn1.IsVisible = true;
                LabelBtn2.IsVisible = true;
                FrameImage.IsVisible = true;
            });
        }
     
        /// ////////////////////////////////////////////////////////////////////////////////////////////////
      
        void Button_Click_MM(object sender, EventArgs args)
        {
            Button btn = (Button)sender;

            var text_MM = btn.Text.Substring(0, 6);
            var text_Pouces = btn.Text.Substring(7, 9);

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_MM.IsVisible = false;
                LabelBtn1.IsVisible = true;
                BouttonChoixMM.IsVisible = true;
                LabelBtn2.IsVisible = true;
                BouttonChoixPouces.IsVisible = true;
                ImageConversion.IsVisible = true;
                FrameImage.IsVisible = true;

                BouttonChoixMM.Text = text_MM.Trim();
                BouttonChoixPouces.Text = text_Pouces.Trim();
            });
        }

        void Button_Click_Pouces(object sender, EventArgs args)
        {
            Button btn = (Button)sender;

            var text_MM = btn.Text.Substring(10, 6);
            var text_Pouces = btn.Text.Substring(0, 9);

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Pouces.IsVisible = false;
                LabelBtn1.IsVisible = true;
                BouttonChoixMM.IsVisible = true;
                LabelBtn2.IsVisible = true;
                BouttonChoixPouces.IsVisible = true;
                ImageConversion.IsVisible = true;
                FrameImage.IsVisible = true;

                BouttonChoixMM.Text = text_MM.Trim();
                BouttonChoixPouces.Text = text_Pouces.Trim();
            });
        }
    }
}