using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace PhotoShop
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool czyRysuje;
        Point ptkStartu;
        SolidColorBrush pisak;
        Line kreskaPoprzednia;

        public MainPage()
        {
            this.InitializeComponent();
            czyRysuje = false;
            pisak = new SolidColorBrush(Windows.UI.Colors.Black);
        }

        private void poleRysowania_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            czyRysuje = true;
            ptkStartu = e.GetCurrentPoint(poleRysowania).Position;
        }

        private void poleRysowania_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            //zmiana pozycji kursora - teraz jest w punkcie ptkAkt
            if (czyRysuje == true)
            {
                //dodac linie od punktu poprzedniego do aktualnego
                Point ptkAkt = e.GetCurrentPoint(poleRysowania).Position;
                //linia z ptkStartu do ptkAkt
                var kreska = new Line
                {
                    X1 = ptkAkt.X,
                    Y1 = ptkAkt.Y,
                    X2 = ptkStartu.X,
                    Y2 = ptkStartu.Y,
                    StrokeThickness = kreskaGruba.Value,
                    Stroke = pisak,
                    StrokeStartLineCap = PenLineCap.Round,
                    StrokeEndLineCap = PenLineCap.Round
                };

                poleRysowania.Children.Add(kreska);

                if(rbDowolna.IsChecked == true)
                {
                    ptkStartu = ptkAkt;
                }
                else if (rbProsta.IsChecked == true)
                {
                    if (kreskaPoprzednia != null) {poleRysowania.Children.Remove(kreskaPoprzednia);}
                    kreskaPoprzednia = kreska;
                }
                
            }
        }

        private void poleRysowania_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            czyRysuje = false;
            kreskaPoprzednia = null;
        }

        private void kolorPisaka(object sender, PointerRoutedEventArgs e)
        {
            var kwadracik = e.OriginalSource as Rectangle;
            pisak = kwadracik.Fill as SolidColorBrush;
        }
    }
}
