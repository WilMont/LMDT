using Prototype.Normes;
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
            await Navigation.PushAsync(new NormeMetriquePage());
        }

        async void BtnNormeMetriqueFin_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeMetriqueFinPage());
        }

        async void BtnNormeAmericain_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAmericainPage());
        }

        async void BtnNormeAmericainFin_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAmericainFinPage());
        }

        async void BtnNormeAmericainExtraFin_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAmericainExtraFinPage());
        }

        async void BtnNormeAnglais_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAnglaisPage());
        }

        async void BtnNormeAnglaisFin_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAnglaisFinPage());
        }

        async void BtnNormeGazCylindrique_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeGazCylindriquePage());
        }

        async void BtnNormeGazConiqueAmericain_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeGazConiqueAmericainPage());
        }

        async void BtnNormeGazConiqueAnglais_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeGazConiqueAnglaisPage());
        }

        async void BtnNormePasElectrique_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormePasElectriquePage());
        }

        async void BtnNormeTrapeze_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }
    }
}