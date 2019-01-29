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
	public partial class TestRechercheParDiametre : ContentPage
	{
		public TestRechercheParDiametre ()
		{
			InitializeComponent ();
		}

        public void TestFonction()
        {
            string[] Tableau = new string[]
            {
                "D1   P0,25 F0,75",  // METRIQUE / M
                "D1,1 P0,25 F0,85",  // METRIQUE / M
                "D1,2 P0,25 F0,95",  // METRIQUE / M
                "D1,4 P0,25 F1,15",  // METRIQUE / M
                "D1,6 P0,35 F1,25",  // METRIQUE / M
                "D1,7 P0,35 F1,35",  // METRIQUE / M
                "D1,8 P0,35 F1,45",  // METRIQUE / M
                "D2   P0.40 F1,6 ",  // METRIQUE / M
                "D2,2 P0,45 F1,75",  // METRIQUE / M
                "D2,3 P0,40 F1,9 ",  // METRIQUE / M
                "D2,5 P0.45 F2,05",  // METRIQUE / M
                "D2,6 P0,45 F2,15",  // METRIQUE / M
                "D3   P0.50 F2,5 ",  // METRIQUE / M
                "D3,5 P0,60 F2,9 ",  // METRIQUE / M
                "D4   P0.70 F3,3 ",  // METRIQUE / M
                "D4,5 P0,75 F3,75",  // METRIQUE / M
                "D5   P0.80 F4,2 ",  // METRIQUE / M
                "D5,5 P0,90 F4,6 ",  // METRIQUE / M
                "D6   P1.00 F5   ",  // METRIQUE / M
                "D7   P1.00 F6   ",  // METRIQUE / M
                "D8   P1.25 F6,8 ",  // METRIQUE / M
                "D9   P1,25 F7,8 ",  // METRIQUE / M
                "D10  P1.50 F8,5 ",  // METRIQUE / M
                "D11  P1.50 F9,5 ",  // METRIQUE / M
                "D12  P1.75 F10,2",  // METRIQUE / M
                "D14  P2.00 F12  ",  // METRIQUE / M
                "D16  P2.00 F14  ",  // METRIQUE / M
                "D18  P2.50 F15,5",  // METRIQUE / M
                "D20  P2.50 F17,5",  // METRIQUE / M
                "D22  P2.50 F19,5",  // METRIQUE / M
                "D24  P3.00 F21  ",  // METRIQUE / M
                "D27  P3,00 F24  ",  // METRIQUE / M
                "D30  P3,50 F26,5",  // METRIQUE / M
                "D33  P3,50 F29,5",  // METRIQUE / M
                "D36  P4,00 F32  ",  // METRIQUE / M
                "D39  P4,00 F35  ",  // METRIQUE / M
                "D42  P4,50 F37,5",  // METRIQUE / M
                "D45  P4,50 F40,5",  // METRIQUE / M
                "D48  P5,00 F43  ",  // METRIQUE / M
                "D52  P5,00 F47  ",  // METRIQUE / M
                "D56  P5,50 F50,5",  // METRIQUE / M
                "D60  P5,50 F54,5",  // METRIQUE / M
            };

        }

	}
}