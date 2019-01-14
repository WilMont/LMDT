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
    public partial class RechercheParNormePage : ContentPage
    {
        public RechercheParNormePage()
        {
            InitializeComponent();
        }

        async void BtnNormeMetrique_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeMetriqueFin_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeAmericain_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeAmericainFin_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeAmericainExtraFin_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeAnglais_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeAnglaisFin_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeGazCylindrique_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeGazConiqueAmericain_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeGazConiqueAnglais_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormePasElectrique_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }

        async void BtnNormeTrapeze_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }
    }
}