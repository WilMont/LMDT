using Prototype.Niv3.Normes;
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

        async void Metrique_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeMetriquePage());
        }

        async void MetriqueFin_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeMetriqueFinPage());
        }

        async void Americain_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAmericainPage());
        }

        async void AmericainFin_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAmericainFinPage());
        }

        async void AmericainExtraFin_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAmericainExtraFinPage());
        }

        async void Anglais_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAnglaisPage());
        }

        async void AnglaisFin_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeAnglaisFinPage());
        }

        async void GazCylindrique_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeGazCylindriquePage());
        }

        async void GazCylindriqueAmericain_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeGazConiqueAmericainPage());
        }

        async void PasElectrique_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormePasElectriquePage());
        }

        async void Trapeze_Button(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NormeTrapezePage());
        }
    }
}