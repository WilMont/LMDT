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
    public partial class ConvertisseursPage : ContentPage
    {
        public ConvertisseursPage()
        {
            InitializeComponent();
        }

        async void MMenPouce_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConvertisseurMMenPouce());
        }

        async void MMenGaz_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ConvertisseurMMenGazPage());
        }
    }
}