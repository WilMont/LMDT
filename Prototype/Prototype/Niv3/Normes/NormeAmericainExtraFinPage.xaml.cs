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
    public partial class NormeAmericainExtraFinPage : ContentPage
    {
        public NormeAmericainExtraFinPage()
        {
            InitializeComponent();
        }
        //\\\    ///////////////////////////\\\    ///
        ///\\\  ///FONCTIONS POUR LE DIAMETRE\\\  ////
        ////\\\///////////////////////////////\\\/////

        //ButtonDiametre_Clicked(): Affiche la liste des diamètres disponibles quand on clique sur le bouton "Diamètre".
        public void BoutonDiametre_Clicked(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => { // On affiche la liste des diamètres et on cache les boutons Diamètre, Pas et Foret.
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

        // ButtonChoixDiametre_Clicked(): Ferme la liste de diamètres et affiche le diamètre, le pas et le perçage correspondant
        // quand l'utilisateur choisi (a cliqué sur) son diamètre.
        public void ButtonChoixDiametre_Clicked(object sender, EventArgs args)
        {
            // On récupère le dernier bouton cliqué.
            Button btn = (Button)sender;
            var texteBouton = btn.Text;

            // On récupère l'index des lettres D, P et F dans la chaîne de caractères qui constitue le texte du bouton.
            var debutDiametre = texteBouton.IndexOf('D');
            var debutPas = texteBouton.IndexOf('P');
            var debutForet = texteBouton.IndexOf('F');

            // Dans le texte du bouton:
            var sectionDiametre = texteBouton.Substring(1, debutPas - 1); // On découpe la partie "Diametre" qui est le texte entre la lettre 'D' et 'P'.
            var sectionPas = texteBouton.Substring(debutPas + 1, debutForet - debutPas - 1); // On découpe la partie "Pas" qui est entre la lettre 'P' et 'F'.
            var sectionForet = texteBouton.Substring(debutForet + 1); // On découpe la partie "Foret" (donc Perçage) qui est le texte après la lettre 'F' jusqu'à la fin de la chaine de caractère.

            var texteDiametre = sectionDiametre.Trim(); // On supprime les espaces avec Trim(), on ne garde que le texte de chaque section.
            var textePas = sectionPas.Trim();
            var texteForet = sectionForet.Trim();

            Device.BeginInvokeOnMainThread(() =>
            {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;

                BoutonDiametre.Text = texteDiametre;

                BoutonPas.Text = textePas;

                BoutonForet.Text = texteForet;
            });
        }

    }
}