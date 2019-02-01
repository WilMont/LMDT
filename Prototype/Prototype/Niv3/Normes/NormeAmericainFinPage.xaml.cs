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
	public partial class NormeAmericainFinPage : ContentPage
	{
		public NormeAmericainFinPage ()
		{
			InitializeComponent ();
		}

        //\\\_||_///////////////////////////\\\_||_///
        ///\\\  ///FONCTIONS POUR LE DIAMETRE\\\  ////
        ////\\\///////////////////////////////\\\/////

        //ButtonDiametre_Clicked(): Affiche la liste des diamètres disponibles quand on clique sur le bouton "Diamètre".
        public void BoutonDiametre_Clicked(object sender, EventArgs args)
        {

            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = true;
                TabBtnLabelDiametre.IsVisible = false;
                TabBtnLabelPas.IsVisible = false;
                TabBtnLabelPerçage.IsVisible = false;
            });
        }

        // RetourDiametre_Clicked(): Désaffiche la liste des diamètres pour réapparaître sur le menu avec les trois boutons (Diamètre, Pas et Perçage)
        // lorsque l'on clique sur le bouton retour.
        public void RetourDiametre_Clicked(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
            });
        }

        // BoutonChoixDiametre_Clicked(): Ferme la liste de diamètres et affiche le diamètre, le pas et le perçage correspondant
        // quand l'utilisateur choisi (a cliqué sur) son diamètre.
        public void BoutonChoixDiametre_Clicked(object sender, EventArgs args)
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
                BoutonDiametre.Text = texteDiametre;

                if (BoutonDiametre.Text == texteDiametre && BoutonDiametre.Text != "1''")
                {
                    BoutonPas.Text = textePas;
                    BoutonForet.Text = texteForet;
                    BoutonForet.BackgroundColor = Color.Gray;
                    BoutonForet.BorderColor = Color.Black;
                    BoutonPas.BackgroundColor = Color.Gray;
                    BoutonPas.BorderColor = Color.Black;
                }
                else
                {
                    BoutonPas.Text = "Choisir";
                    BoutonForet.Text = "Choisir";
                    BoutonPas.BackgroundColor = Color.SaddleBrown;
                    BoutonPas.BorderColor = Color.Chocolate;
                }

            });
        }

        //\\\_||_//////////////////////\\\_||_///
        ///\\\  ///FONCTIONS POUR LE PAS\\\  ////
        ////\\\//////////////////////////\\\/////

        // BoutonPas_Clicked(): Affiche la liste des pas disponibles pour la norme précédemment séléctionnée lorsque l'on clique sur le bouton "Pas".
        public void BoutonPas_Clicked(object sender, EventArgs args)
        {
            if (BoutonDiametre.Text == "1''")
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

        // BoutonValeurPas_Clicked(): Lorsque l'utilisateur clique sur le pas qu'il souhaite, la liste des pas se ferme pour revenir sur la page avec
        // les 3 boutons (Diamètre, Pas et Perçage). Affiche également le perçage correspondant au pas choisi pour le diamètre ' 1" '.
        public void BoutonValeurPas_Clicked(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            BoutonPas.Text = btn.Text;

            Tab_Pas.IsVisible = false;
            TabBtnLabelDiametre.IsVisible = true;
            TabBtnLabelPas.IsVisible = true;
            TabBtnLabelPerçage.IsVisible = true;

            if (BoutonDiametre.Text == "1''" && BoutonPas.Text == "12")
            {
                BoutonForet.Text = "23.25";
            }
            else if (BoutonDiametre.Text == "1''" && BoutonPas.Text == "14")
            {
                BoutonForet.Text = "23.5";
            }
        }

        // RetourPas_Clicked(): Désaffiche la liste des pas pour réapparaître sur le menu avec les trois boutons (Diamètre, Pas et Perçage)
        // lorsque l'on clique sur le bouton retour.
        public void RetourPas_Clicked(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
            });
        }

        // AttributionRow(): Fais en sorte que les choix de pas apparaissent en haut de la liste.
        // (sans cette fonction les éléments restent à leur position définie dans le fichier XAML et peuvent donc apparaître en milieu de page).
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