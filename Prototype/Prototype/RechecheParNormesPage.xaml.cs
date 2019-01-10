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

            var listNormes = new ListView();
            listNormes.ItemsSource = new string[]
            {
                "METRIQUE / M",
                "METRIQUE FIN / MF",
                "AMERICAIN / UNC",
                "AMERICAIN FIN / UNF",
                "AMERICAIN EXTRA FIN / UNEF",
                "ANGLAIS / BSW",
                "ANGLAIS FIN / BSF",
                "GAZ CYLINDRIQUE / BSP",
                "GAZ CONIQUE AMERICAIN / NPT",
                "GAZ CONIQUE ANGLAIS / BSPT",
                "PAS ELECTRIQUE / PT",
                "TRAPEZE / TR",
            };
        }
    }
}