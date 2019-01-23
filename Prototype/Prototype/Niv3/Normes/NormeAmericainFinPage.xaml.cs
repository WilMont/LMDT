using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype.Normes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NormeAmericainFinPage : ContentPage
	{
		public NormeAmericainFinPage ()
		{
			InitializeComponent ();
		}

        //\\\_||_///////////////////////////\\\_||_///
        ///\\\  ///FONCTIONS POUR LE DIAMETRE\\\  ////
        ////\\\///////////////////////////////\\\/////

        public void ButtonChoixDiametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = true;
                TabBtnLabelDiametre.IsVisible = false;
                TabBtnLabelPas.IsVisible = false;
                TabBtnLabelPerçage.IsVisible = false;
            });
        }

        public void Retour_Diametre(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
            });
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        void ButtonChoixDiametre_Clicked(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            var texteBouton = btn.Text;

            var debutDiametre = texteBouton.IndexOf('D');
            var debutPas = texteBouton.IndexOf('P');
            var debutForet = texteBouton.IndexOf('F');

            var sectionDiametre = texteBouton.Substring(1, debutPas - 1);
            var sectionPas = texteBouton.Substring(debutPas + 1, debutForet - debutPas - 1);
            var sectionForet = texteBouton.Substring(debutForet + 1);

            var texteDiametre = sectionDiametre.Trim();
            var textePas = sectionPas.Trim();
            var texteForet = sectionForet.Trim();

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BoutonChoixDiametre.Text = texteDiametre;
                BoutonChoixPas.BackgroundColor = Color.SaddleBrown;
                BoutonChoixForet.BackgroundColor = Color.Gray;

                    if (BoutonChoixDiametre.Text == texteDiametre && BoutonChoixDiametre.Text != "1''") {
                    BoutonChoixPas.Text = textePas;
                    BoutonChoixForet.Text = texteForet;
                    BoutonChoixForet.BackgroundColor = Color.SaddleBrown;
                    BoutonChoixPas.BackgroundColor = Color.SaddleBrown;
                } else
                {
                    BoutonChoixPas.Text = "Choisir";
                    BoutonChoixForet.Text = "Choisir";
                }
                
            });
        }

        //\\\_||_//////////////////////\\\_||_///
        ///\\\  ///FONCTIONS POUR LE PAS\\\  ////
        ////\\\//////////////////////////\\\/////

        public void ButtonChoixPas_Clicked(object sender, EventArgs args)
        {
            if (BoutonChoixDiametre.Text == "1''")
            {
                Device.BeginInvokeOnMainThread(() => {
                    Tab_Pas.IsVisible = true;
                    TabBtnLabelDiametre.IsVisible = false;
                    TabBtnLabelPas.IsVisible = false;
                    TabBtnLabelPerçage.IsVisible = false;

                    BoutonChoixPas1_1.IsVisible = true;
                    BoutonChoixPas1_2.IsVisible = true;
                    AttributionRow();
                });
            }
        }

        public void ButtonValeurPas_Clicked(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            BoutonChoixPas.Text = btn.Text;

            Tab_Pas.IsVisible = false;
            TabBtnLabelDiametre.IsVisible = true;
            TabBtnLabelPas.IsVisible = true;
            TabBtnLabelPerçage.IsVisible = true;

            if (BoutonChoixDiametre.Text == "1''" && BoutonChoixPas.Text == "12") {
                BoutonChoixForet.Text = "23.25";
                BoutonChoixForet.BackgroundColor = Color.SaddleBrown;
            } else if(BoutonChoixDiametre.Text == "1''" && BoutonChoixPas.Text == "14") {
                BoutonChoixForet.Text = "23.5";
                BoutonChoixForet.BackgroundColor = Color.SaddleBrown;
            }
        }

        // Désaffiche la liste des pas pour réapparaître sur le menu avec les trois boutons (Diamètre, Pas et Perçage)
        // lorsque l'on clique sur le bouton retour.
        public void Retour_Pas(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
            });
        }

        // AttributionRow(): Fais en sorte que les choix de pas apparaissent en haut de la liste.
        // (sans cette fonction les éléments restent à leur position définie dans le fichier XAML).
        public void AttributionRow()
        {
            Button[] tabBoutons = new Button[]{
                        BoutonChoixPas14,         // 0
                        BoutonChoixPas516,        // 1  
                        BoutonChoixPas38,         // 2
                        BoutonChoixPas716,        // 3  
                        BoutonChoixPas12,         // 4  
                        BoutonChoixPas916,        // 5  
                        BoutonChoixPas58,         // 6  
                        BoutonChoixPas34,         // 7  
                        BoutonChoixPas78,         // 8  
                        BoutonChoixPas1_1,        // 9  
                        BoutonChoixPas1_2,        // 10 
                        BoutonChoixPas1pouce18,   // 11 
                        BoutonChoixPas1pouce14,   // 12 
                        BoutonChoixPas1pouce38,   // 13 
                        BoutonChoixPas1pouce12,   // 14 
                        };

            int Row = 2;

            for (int i = 0; i < tabBoutons.Length; i++)
            {
                if (tabBoutons[i].IsVisible == true)
                {
                    Grid.SetRow(tabBoutons[i], Row);
                    Row++;
                }
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}