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
    public partial class RechercheParDiametrePage : ContentPage
    {
        public RechercheParDiametrePage()
        {
            InitializeComponent();
        }


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

            var textDiametre = texteBouton.Substring(1, debutPas - 1);
            var textPas = texteBouton.Substring(debutPas + 1, debutForet - debutPas - 1);
            var textForet = texteBouton.Substring(debutForet + 1);

            Device.BeginInvokeOnMainThread(() => {
                Tab_Diametre.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
                BoutonChoixDiametre.Text = textDiametre.Trim();
                BoutonChoixPas.BackgroundColor = Color.SaddleBrown;
                BoutonChoixPas.Text = "Choisir";
                BoutonChoixForet.Text = "Choisir";
                BoutonChoixForet.BackgroundColor = Color.Gray;
            });
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////::

        public void ButtonChoixPas_Clicked(object sender, EventArgs args)
        {
            if (BoutonChoixDiametre.Text != "Choisir")
            {
                Device.BeginInvokeOnMainThread(() => {
                    Tab_Pas.IsVisible = true;
                    TabBtnLabelDiametre.IsVisible = false;
                    TabBtnLabelPas.IsVisible = false;
                    TabBtnLabelPerçage.IsVisible = false;


                    switch (BoutonChoixDiametre.Text)
                    {
                        case "3":
                            RAZdesIsVisible();
                            BoutonChoixPasM3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "4":
                            RAZdesIsVisible();
                            BoutonChoixPasM4_1.IsVisible = true;
                            BoutonChoixPasM4_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "5":
                            RAZdesIsVisible();
                            BoutonChoixPasM5_1.IsVisible = true;
                            BoutonChoixPasM5_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "6":
                            RAZdesIsVisible();
                            BoutonChoixPasM6_1.IsVisible = true;
                            BoutonChoixPasM6_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "7":
                            RAZdesIsVisible();
                            BoutonChoixPasM7.IsVisible = true;
                            AttributionRow();
                            break;
                        case "8":
                            RAZdesIsVisible();
                            BoutonChoixPasM8_1.IsVisible = true;
                            BoutonChoixPasM8_2.IsVisible = true;
                            BoutonChoixPasM8_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "9":
                            RAZdesIsVisible();
                            BoutonChoixPasM9_1.IsVisible = true;
                            BoutonChoixPasM9_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "10":
                            RAZdesIsVisible();
                            BoutonChoixPasM10_1.IsVisible = true;
                            BoutonChoixPasM10_2.IsVisible = true;
                            BoutonChoixPasM10_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "11":
                            RAZdesIsVisible();
                            BoutonChoixPasM11_1.IsVisible = true;
                            BoutonChoixPasM11_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "12":
                            RAZdesIsVisible();
                            BoutonChoixPasM12_1.IsVisible = true;
                            BoutonChoixPasM12_2.IsVisible = true;
                            BoutonChoixPasM12_3.IsVisible = true;
                            BoutonChoixPasM12_4.IsVisible = true;
                            AttributionRow();

                            break;
                        case "13":
                            RAZdesIsVisible();
                            BoutonChoixPasM13_1.IsVisible = true;
                            BoutonChoixPasM13_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "14":
                            RAZdesIsVisible();
                            BoutonChoixPasM14_1.IsVisible = true;
                            BoutonChoixPasM14_2.IsVisible = true;
                            BoutonChoixPasM14_3.IsVisible = true;
                            BoutonChoixPasM14_4.IsVisible = true;
                            AttributionRow();
                            break;
                        case "15":
                            RAZdesIsVisible();
                            BoutonChoixPasM15_1.IsVisible = true;
                            BoutonChoixPasM15_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "16":
                            RAZdesIsVisible();
                            BoutonChoixPasM16_1.IsVisible = true;
                            BoutonChoixPasM16_2.IsVisible = true;
                            BoutonChoixPasM16_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "18":
                            RAZdesIsVisible();
                            BoutonChoixPasM18_1.IsVisible = true;
                            BoutonChoixPasM18_2.IsVisible = true;
                            BoutonChoixPasM18_3.IsVisible = true;
                            BoutonChoixPasM18_4.IsVisible = true;
                            AttributionRow();
                            break;
                        case "20":
                            RAZdesIsVisible();
                            BoutonChoixPasM20_1.IsVisible = true;
                            BoutonChoixPasM20_2.IsVisible = true;
                            BoutonChoixPasM20_3.IsVisible = true;
                            BoutonChoixPasM20_4.IsVisible = true;
                            AttributionRow();
                            break;
                        case "21":
                            RAZdesIsVisible();
                            BoutonChoixPasM21.IsVisible = true;
                            AttributionRow();
                            break;
                        case "22":
                            RAZdesIsVisible();
                            BoutonChoixPasM22_1.IsVisible = true;
                            BoutonChoixPasM22_2.IsVisible = true;
                            BoutonChoixPasM22_3.IsVisible = true;
                            BoutonChoixPasM22_4.IsVisible = true;
                            AttributionRow();
                            break;
                        case "23":
                            RAZdesIsVisible();
                            BoutonChoixPasM23.IsVisible = true;
                            AttributionRow();
                            break;
                        case "24":
                            RAZdesIsVisible();
                            BoutonChoixPasM24_1.IsVisible = true;
                            BoutonChoixPasM24_2.IsVisible = true;
                            BoutonChoixPasM24_3.IsVisible = true;
                            BoutonChoixPasM24_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "25":
                            RAZdesIsVisible();
                            BoutonChoixPasM25_1.IsVisible = true;
                            BoutonChoixPasM25_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "26":
                            RAZdesIsVisible();
                            BoutonChoixPasM26_3.IsVisible = true;
                            BoutonChoixPasM26_3.IsVisible = true;
                            BoutonChoixPasM26_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "27":
                            RAZdesIsVisible();
                            BoutonChoixPasM27_1.IsVisible = true;
                            BoutonChoixPasM27_2.IsVisible = true;
                            BoutonChoixPasM27_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "28":
                            RAZdesIsVisible();
                            BoutonChoixPasM28_1.IsVisible = true;
                            BoutonChoixPasM28_2.IsVisible = true;
                            BoutonChoixPasM28_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "29":
                            RAZdesIsVisible();
                            BoutonChoixPasM29.IsVisible = true;
                            AttributionRow();
                            break;
                        case "30":
                            RAZdesIsVisible();
                            BoutonChoixPasM30_1.IsVisible = true;
                            BoutonChoixPasM30_2.IsVisible = true;
                            BoutonChoixPasM30_3.IsVisible = true;
                            BoutonChoixPasM30_4.IsVisible = true;
                            BoutonChoixPasM30_5.IsVisible = true;
                            AttributionRow();
                            break;
                        case "32":
                            RAZdesIsVisible();
                            BoutonChoixPasM32_1.IsVisible = true;
                            BoutonChoixPasM32_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "33":
                            RAZdesIsVisible();
                            BoutonChoixPasM33_1.IsVisible = true;
                            BoutonChoixPasM33_2.IsVisible = true;
                            BoutonChoixPasM33_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "34":
                            RAZdesIsVisible();
                            BoutonChoixPasM34_1.IsVisible = true;
                            BoutonChoixPasM34_2.IsVisible = true;
                            AttributionRow();
                            break;
                        case "35":
                            RAZdesIsVisible();
                            BoutonChoixPasM35.IsVisible = true;
                            AttributionRow();
                            break;
                        case "36":
                            RAZdesIsVisible();
                            BoutonChoixPasM36_1.IsVisible = true;
                            BoutonChoixPasM36_2.IsVisible = true;
                            BoutonChoixPasM36_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "38":
                            RAZdesIsVisible();
                            BoutonChoixPasM38.IsVisible = true;
                            AttributionRow();
                            break;
                        case "39":
                            RAZdesIsVisible();
                            BoutonChoixPasM39_1.IsVisible = true;
                            BoutonChoixPasM39_2.IsVisible = true;
                            BoutonChoixPasM39_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "40":
                            RAZdesIsVisible();
                            BoutonChoixPasM40_1.IsVisible = true;
                            BoutonChoixPasM40_2.IsVisible = true;
                            BoutonChoixPasM40_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "42":
                            RAZdesIsVisible();
                            BoutonChoixPasM42_1.IsVisible = true;
                            BoutonChoixPasM42_2.IsVisible = true;
                            BoutonChoixPasM42_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "45":
                            RAZdesIsVisible();
                            BoutonChoixPasM45_1.IsVisible = true;
                            BoutonChoixPasM45_2.IsVisible = true;
                            BoutonChoixPasM45_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "48":
                            RAZdesIsVisible();
                            BoutonChoixPasM48_1.IsVisible = true;
                            BoutonChoixPasM48_2.IsVisible = true;
                            BoutonChoixPasM48_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "50":
                            RAZdesIsVisible();
                            BoutonChoixPasM50_1.IsVisible = true;
                            BoutonChoixPasM50_2.IsVisible = true;
                            BoutonChoixPasM50_3.IsVisible = true;
                            AttributionRow();
                            break;
                        case "52":
                            RAZdesIsVisible();
                            BoutonChoixPasM52_1.IsVisible = true;
                            BoutonChoixPasM52_2.IsVisible = true;
                            BoutonChoixPasM52_3.IsVisible = true;
                            AttributionRow();
                            break;
                    }
                });
            }
        }

        public void ButtonValeurPas_Clicked(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            BoutonChoixPas.Text = btn.Text;
            var doubleChoixDiametre = Convert.ToDouble(BoutonChoixDiametre.Text);
            var doubleChoixPas = Convert.ToDouble(btn.Text);

            var doubleChoixForet = doubleChoixDiametre - doubleChoixPas;

            BoutonChoixForet.Text = Convert.ToString(doubleChoixForet);

            Tab_Pas.IsVisible = false;
            TabBtnLabelDiametre.IsVisible = true;
            TabBtnLabelPas.IsVisible = true;
            TabBtnLabelPerçage.IsVisible = true;

            BoutonChoixForet.BackgroundColor = Color.SaddleBrown;
        }

        public void Retour_Pas(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => {
                Tab_Pas.IsVisible = false;
                TabBtnLabelDiametre.IsVisible = true;
                TabBtnLabelPas.IsVisible = true;
                TabBtnLabelPerçage.IsVisible = true;
            });
        }

        // Remet toutes les propriétés "IsVisible" des boutons de Pas à 'False'
        // pour ne pas que les anciens pas d'une ancienne norme séléctionnée ne réaparaissent.
        public void RAZdesIsVisible()
        {
            BoutonChoixPasM3.IsVisible = false;
            BoutonChoixPasM4_1.IsVisible = false;
            BoutonChoixPasM4_2.IsVisible = false;
            BoutonChoixPasM5_1.IsVisible = false;
            BoutonChoixPasM5_2.IsVisible = false;
            BoutonChoixPasM6_1.IsVisible = false;
            BoutonChoixPasM6_2.IsVisible = false;
            BoutonChoixPasM7.IsVisible = false;
            BoutonChoixPasM8_1.IsVisible = false;
            BoutonChoixPasM8_2.IsVisible = false;
            BoutonChoixPasM8_3.IsVisible = false;
            BoutonChoixPasM9_1.IsVisible = false;
            BoutonChoixPasM9_2.IsVisible = false;
            BoutonChoixPasM10_1.IsVisible = false;
            BoutonChoixPasM10_2.IsVisible = false;
            BoutonChoixPasM10_3.IsVisible = false;
            BoutonChoixPasM11_1.IsVisible = false;
            BoutonChoixPasM11_2.IsVisible = false;
            BoutonChoixPasM12_1.IsVisible = false;
            BoutonChoixPasM12_2.IsVisible = false;
            BoutonChoixPasM12_3.IsVisible = false;
            BoutonChoixPasM12_4.IsVisible = false;
            BoutonChoixPasM13_1.IsVisible = false;
            BoutonChoixPasM13_2.IsVisible = false;
            BoutonChoixPasM14_1.IsVisible = false;
            BoutonChoixPasM14_2.IsVisible = false;
            BoutonChoixPasM14_3.IsVisible = false;
            BoutonChoixPasM14_4.IsVisible = false;
            BoutonChoixPasM15_1.IsVisible = false;
            BoutonChoixPasM15_2.IsVisible = false;
            BoutonChoixPasM16_1.IsVisible = false;
            BoutonChoixPasM16_2.IsVisible = false;
            BoutonChoixPasM16_3.IsVisible = false;
            BoutonChoixPasM18_1.IsVisible = false;
            BoutonChoixPasM18_2.IsVisible = false;
            BoutonChoixPasM18_3.IsVisible = false;
            BoutonChoixPasM18_4.IsVisible = false;
            BoutonChoixPasM20_1.IsVisible = false;
            BoutonChoixPasM20_2.IsVisible = false;
            BoutonChoixPasM20_3.IsVisible = false;
            BoutonChoixPasM20_4.IsVisible = false;
            BoutonChoixPasM21.IsVisible = false;
            BoutonChoixPasM22_1.IsVisible = false;
            BoutonChoixPasM22_2.IsVisible = false;
            BoutonChoixPasM22_3.IsVisible = false;
            BoutonChoixPasM22_4.IsVisible = false;
            BoutonChoixPasM23.IsVisible = false;
            BoutonChoixPasM24_1.IsVisible = false;
            BoutonChoixPasM24_2.IsVisible = false;
            BoutonChoixPasM24_3.IsVisible = false;
            BoutonChoixPasM24_4.IsVisible = false;
            BoutonChoixPasM25_1.IsVisible = false;
            BoutonChoixPasM25_2.IsVisible = false;
            BoutonChoixPasM26_1.IsVisible = false;
            BoutonChoixPasM26_2.IsVisible = false;
            BoutonChoixPasM26_3.IsVisible = false;
            BoutonChoixPasM27_1.IsVisible = false;
            BoutonChoixPasM27_2.IsVisible = false;
            BoutonChoixPasM27_3.IsVisible = false;
            BoutonChoixPasM28_1.IsVisible = false;
            BoutonChoixPasM28_2.IsVisible = false;
            BoutonChoixPasM28_3.IsVisible = false;
            BoutonChoixPasM29.IsVisible = false;
            BoutonChoixPasM30_1.IsVisible = false;
            BoutonChoixPasM30_2.IsVisible = false;
            BoutonChoixPasM30_3.IsVisible = false;
            BoutonChoixPasM30_4.IsVisible = false;
            BoutonChoixPasM30_5.IsVisible = false;
            BoutonChoixPasM32_1.IsVisible = false;
            BoutonChoixPasM32_2.IsVisible = false;
            BoutonChoixPasM33_1.IsVisible = false;
            BoutonChoixPasM33_2.IsVisible = false;
            BoutonChoixPasM33_3.IsVisible = false;
            BoutonChoixPasM34_1.IsVisible = false;
            BoutonChoixPasM34_2.IsVisible = false;
            BoutonChoixPasM35.IsVisible = false;
            BoutonChoixPasM36_1.IsVisible = false;
            BoutonChoixPasM36_2.IsVisible = false;
            BoutonChoixPasM36_3.IsVisible = false;
            BoutonChoixPasM38.IsVisible = false;
            BoutonChoixPasM39_1.IsVisible = false;
            BoutonChoixPasM39_2.IsVisible = false;
            BoutonChoixPasM39_3.IsVisible = false;
            BoutonChoixPasM40_1.IsVisible = false;
            BoutonChoixPasM40_2.IsVisible = false;
            BoutonChoixPasM40_3.IsVisible = false;
            BoutonChoixPasM42_1.IsVisible = false;
            BoutonChoixPasM42_2.IsVisible = false;
            BoutonChoixPasM42_3.IsVisible = false;
            BoutonChoixPasM45_1.IsVisible = false;
            BoutonChoixPasM45_2.IsVisible = false;
            BoutonChoixPasM45_3.IsVisible = false;
            BoutonChoixPasM48_1.IsVisible = false;
            BoutonChoixPasM48_2.IsVisible = false;
            BoutonChoixPasM48_3.IsVisible = false;
            BoutonChoixPasM50_1.IsVisible = false;
            BoutonChoixPasM50_2.IsVisible = false;
            BoutonChoixPasM50_3.IsVisible = false;
            BoutonChoixPasM52_1.IsVisible = false;
            BoutonChoixPasM52_2.IsVisible = false;
            BoutonChoixPasM52_3.IsVisible = false;
        }

        public void AttributionRow()
        {
            Button[] tabBoutons = new Button[]{
                        BoutonChoixPasM3,      // 0
                        BoutonChoixPasM4_1,    // 1  
                        BoutonChoixPasM4_2,    // 2
                        BoutonChoixPasM5_1,    // 3  
                        BoutonChoixPasM5_2,    // 4  
                        BoutonChoixPasM6_1,    // 5  
                        BoutonChoixPasM6_2,    // 6  
                        BoutonChoixPasM7,      // 7  
                        BoutonChoixPasM8_1,    // 8  
                        BoutonChoixPasM8_2,    // 9  
                        BoutonChoixPasM8_3,    // 10 
                        BoutonChoixPasM9_1,    // 11 
                        BoutonChoixPasM9_2,    // 12 
                        BoutonChoixPasM10_1,   // 13 
                        BoutonChoixPasM10_2,   // 14 
                        BoutonChoixPasM10_3,   // 15 
                        BoutonChoixPasM11_1,   // 16 
                        BoutonChoixPasM11_2,   // 17 
                        BoutonChoixPasM12_1,   // 18 
                        BoutonChoixPasM12_2,   // 19 
                        BoutonChoixPasM12_3,   // 20 
                        BoutonChoixPasM12_4,   // 21 
                        BoutonChoixPasM13_1,   // 22 
                        BoutonChoixPasM13_2,   // 23 
                        BoutonChoixPasM14_1,   // 24 
                        BoutonChoixPasM14_2,   // 25 
                        BoutonChoixPasM14_3,   // 26 
                        BoutonChoixPasM14_4,   // 27 
                        BoutonChoixPasM15_1,   // 28 
                        BoutonChoixPasM15_2,   // 29 
                        BoutonChoixPasM16_1,   // 30 
                        BoutonChoixPasM16_2,   // 31 
                        BoutonChoixPasM16_3,   // 32 
                        BoutonChoixPasM18_1,   // 33 
                        BoutonChoixPasM18_2,   // 34 
                        BoutonChoixPasM18_3,   // 35 
                        BoutonChoixPasM18_4,   // 36 
                        BoutonChoixPasM20_1,   // 37 
                        BoutonChoixPasM20_2,   // 38 
                        BoutonChoixPasM20_3,   // 39 
                        BoutonChoixPasM20_4,   // 40 
                        BoutonChoixPasM21,     // 41 
                        BoutonChoixPasM22_1,   // 42 
                        BoutonChoixPasM22_2,   // 43 
                        BoutonChoixPasM22_3,   // 44 
                        BoutonChoixPasM22_4,   // 45 
                        BoutonChoixPasM23,     // 46 
                        BoutonChoixPasM24_1,   // 47 
                        BoutonChoixPasM24_2,   // 48 
                        BoutonChoixPasM24_3,   // 49 
                        BoutonChoixPasM24_4,   // 50 
                        BoutonChoixPasM25_1,   // 51 
                        BoutonChoixPasM25_2,   // 52 
                        BoutonChoixPasM26_1,   // 53 
                        BoutonChoixPasM26_2,   // 54 
                        BoutonChoixPasM26_3,   // 55 
                        BoutonChoixPasM27_1,   // 56 
                        BoutonChoixPasM27_2,   // 57 
                        BoutonChoixPasM27_3,   // 58 
                        BoutonChoixPasM28_1,   // 59 
                        BoutonChoixPasM28_2,   // 60 
                        BoutonChoixPasM28_3,   // 61 
                        BoutonChoixPasM29,     // 62 
                        BoutonChoixPasM30_1,   // 63 
                        BoutonChoixPasM30_2,   // 64 
                        BoutonChoixPasM30_3,   // 65 
                        BoutonChoixPasM30_4,   // 66 
                        BoutonChoixPasM30_5,   // 67 
                        BoutonChoixPasM32_1,   // 68 
                        BoutonChoixPasM32_2,   // 69 
                        BoutonChoixPasM33_1,   // 70 
                        BoutonChoixPasM33_2,   // 71 
                        BoutonChoixPasM33_3,   // 72 
                        BoutonChoixPasM34_1,   // 73 
                        BoutonChoixPasM34_2,   // 74 
                        BoutonChoixPasM35,     // 75 
                        BoutonChoixPasM36_1,   // 76 
                        BoutonChoixPasM36_2,   // 77 
                        BoutonChoixPasM36_3,   // 78 
                        BoutonChoixPasM38,     // 79 
                        BoutonChoixPasM39_1,   // 80 
                        BoutonChoixPasM39_2,   // 81 
                        BoutonChoixPasM39_3,   // 82 
                        BoutonChoixPasM40_1,   // 83 
                        BoutonChoixPasM40_2,   // 84 
                        BoutonChoixPasM40_3,   // 85 
                        BoutonChoixPasM42_1,   // 86 
                        BoutonChoixPasM42_2,   // 87 
                        BoutonChoixPasM42_3,   // 88 
                        BoutonChoixPasM45_1,   // 89 
                        BoutonChoixPasM45_2,   // 90 
                        BoutonChoixPasM45_3,   // 91 
                        BoutonChoixPasM48_1,   // 92 
                        BoutonChoixPasM48_2,   // 93 
                        BoutonChoixPasM48_3,   // 94 
                        BoutonChoixPasM50_1,   // 95 
                        BoutonChoixPasM50_2,   // 96 
                        BoutonChoixPasM50_3,   // 97 
                        BoutonChoixPasM52_1,   // 98 
                        BoutonChoixPasM52_2,   // 99 
                        BoutonChoixPasM52_3,   // 100
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
    }
}