using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prototype
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void BtnRechercheParNorme_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RechercheParNormePage());
        }

        async void BtnConvertisseurs_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConvertisseursPage());
        }
    }
}
