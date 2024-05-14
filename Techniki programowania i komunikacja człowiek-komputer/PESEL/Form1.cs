using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PESEL.Okienka;

namespace PESEL
{
    public partial class Form1 : Form
    {
        
        private static SprawdzeniePoprawnosci Sprawdz;
        public Form1()
        {
            InitializeComponent();
        }
       private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = dateTimePicker1.Text;
        }
        private void buttonSprawdz_Click(object sender, EventArgs e)
        {

            String NrPESEL = textBoxPESEL.Text;
            DateTime dataUrodzenia = dateTimePicker1.Value;
            

            //stworzenie instacji klasy SprawdzeniePoprawnosci z parametrem NrPESEL podanym przez uzytkownika
            Sprawdz = new SprawdzeniePoprawnosci(NrPESEL);

            int rok = Sprawdz.getRok();
            int miesiac = Sprawdz.getMiesiac();
            int dzien = Sprawdz.getDzien();
            string plec = Sprawdz.getPlec();
            //DateTime dataPESEL = new DateTime(rok, miesiac,dzien);

            //sprawdzenie zgodnosci podanej w kalendarzu daty urodzenia z nr PESEL
            bool zgodnosc = (dataUrodzenia.Year == rok && dataUrodzenia.Month == miesiac && dataUrodzenia.Day == dzien);


            if (Sprawdz.czyPoprawny() && zgodnosc)
            {
                RetroMessageBox retroMessageBox = new RetroMessageBox("Podany nr PESEL jest poprawny i zgodny z zaznaczona data urodzenia :)" + "\n\n" + new DateTime(rok, miesiac, dzien).ToShortDateString() + "\n" + plec, "Poprawnosc nr PESEL");
                retroMessageBox.ShowDialog();
            }
            else if (Sprawdz.czyPoprawny() == true  && zgodnosc == false)
            {
                RetroMessageBox retroMessageBox = new RetroMessageBox("Podany nr PESEL jest poprawny, ale nie jest zgodny z zaznaczona data urodzenia!" + "\n\n" + new DateTime(rok, miesiac, dzien).ToShortDateString() + "\n" +  plec, "Poprawnosc nr PESEL");
                retroMessageBox.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(NrPESEL))
            {
                RetroMessageBox retroMessageBox = new RetroMessageBox("Wprowadz nr PESEL!", "Poprawnosc nr PESEL");
                retroMessageBox.ShowDialog();
            }
            else
            {
                RetroMessageBox retroMessageBox = new RetroMessageBox("Podany nr PESEL jest niepoprawny :(", "Poprawnosc nr PESEL");
                retroMessageBox.ShowDialog();
            }
        }

        private void buttonSprawdz_MouseHover(object sender, EventArgs e)
        {
            buttonSprawdz.BackColor = Color.PaleGreen;
            buttonSprawdz.ForeColor = System.Drawing.Color.Black;
        }

        private void buttonSprawdz_MouseLeave(object sender, EventArgs e)
        {
            buttonSprawdz.BackColor = Color.Black;
            buttonSprawdz.ForeColor = System.Drawing.Color.PaleGreen;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = dateTimePicker1.Text;
        }
    }
}
