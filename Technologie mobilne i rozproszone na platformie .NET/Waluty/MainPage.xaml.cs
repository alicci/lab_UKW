using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Waluty
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        const string daneNBP = "https://static.nbp.pl/dane/kursy/xml/LastA.xml";
        List<PozycjaTabeliA> daneKursowe;
        public MainPage()
        {
            this.InitializeComponent();
            daneKursowe = new List<PozycjaTabeliA>();
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var listonosz = new HttpClient();
            var dane = await listonosz.GetStringAsync(new Uri(daneNBP, UriKind.RelativeOrAbsolute));
            var daneXml = XDocument.Parse(dane);
            var tylkoPozycje = daneXml.Descendants("pozycja");
            daneKursowe = (from pojedynczaPozycja in tylkoPozycje
                           select new PozycjaTabeliA()
                           {
                               kod_waluty = pojedynczaPozycja.Element("kod_waluty").Value,
                               kurs_sredni = pojedynczaPozycja.Element("kurs_sredni").Value,
                               nazwa_waluty = pojedynczaPozycja.Element("nazwa_waluty").Value,
                               przelicznik = pojedynczaPozycja.Element("przelicznik").Value
                           }).ToList();

            daneKursowe.Insert(0, new PozycjaTabeliA { kod_waluty = "PLN", kurs_sredni = "1,0000", przelicznik = "1" });
            lbxZWaluty.ItemsSource = daneKursowe;
            lbxNaWalute.ItemsSource = daneKursowe;

            lbxNaWalute.SelectedIndex = 0;
            lbxZWaluty.SelectedIndex = 0;
        }
        private void Przelicz()
        {
            double kwota, kwotaPrzeliczona, kurs;
            if (!double.TryParse(txtKwota.Text, out kwota))
            {
                tbPrzeliczona.Text = "";
                return;
            }

            var WalutaZrodlowa = (PozycjaTabeliA)lbxZWaluty.SelectedItem;
            var WalutaDocelowa = (PozycjaTabeliA)lbxNaWalute.SelectedItem;
            double.TryParse(WalutaZrodlowa.kurs_sredni, out kurs);
            kwotaPrzeliczona = kwota * kurs;
            double.TryParse(WalutaDocelowa.kurs_sredni, out kurs);
            kwotaPrzeliczona /= kurs;

            tbPrzeliczona.Text = string.Format("{0:F2}", kwotaPrzeliczona);
        }

        private void txtKwota_TextChanged(object sender, TextChangedEventArgs e)
        {
            Przelicz();
        }

        private void lbxNaWalute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Przelicz();
        }

        private void lbxZWaluty_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Przelicz();
        }
    }
}
