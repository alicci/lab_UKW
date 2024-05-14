using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESEL
{
    public class SprawdzeniePoprawnosci
    {
        private byte[] PESEL = new byte[11];
        private bool poprawnosc = false;

        public SprawdzeniePoprawnosci(String NrPESEL) { 
         
            if (NrPESEL.Length != 11)
            {
                poprawnosc = false;
            }
            else
            {
                for (int i = 0; i < 11;  i++)
                {
                    if (Char.IsDigit(NrPESEL[i]))
                    {
                        PESEL[i] = Byte.Parse(NrPESEL[i].ToString());
                    }
                    
                }
                if (sprawdzSume() && sprawdzMiesiac() && sprawdzDzien())
                {
                    poprawnosc = true;
                }
                else { poprawnosc = false; }
            }
        }

        public bool czyPoprawny() { return poprawnosc; }

        public int getRok()
        {
            int rok;
            int miesiac;
            rok = 10 * PESEL[0];
            rok += PESEL[1];
            miesiac = 10 * PESEL[2];
            miesiac += PESEL[3];
            if (miesiac > 80 && miesiac < 93)
            {
                rok += 1800;
            }
            else if (miesiac > 0 && miesiac < 13)
            {
                rok += 1900;
            }
            else if (miesiac > 20 && miesiac < 33)
            {
                rok += 2000;
            }
            else if (miesiac > 40 && miesiac < 53)
            {
                rok += 2100;
            }
            else if (miesiac > 60 && miesiac < 73)
            {
                rok += 2200;
            }
            return rok;
        }

        public int getMiesiac()
        {
            int miesiac = 10 * PESEL[2] + PESEL[3];

            if (miesiac > 80) miesiac -= 80;
            else if (miesiac > 60) miesiac -= 60;
            else if (miesiac > 40) miesiac -= 40;
            else if (miesiac > 20) miesiac -= 20;

            return miesiac;
        }


        public int getDzien()
        {
            int dzien;
            dzien = 10 * PESEL[4];
            dzien += PESEL[5];
            return dzien;
        }

        public String getPlec()
        {
            if (poprawnosc)
            {
                if (PESEL[9] % 2 == 1)
                {
                    return "Mezczyzna";
                }
                else
                {
                    return "Kobieta";
                }
            }
            else return "-";
        }

        private bool sprawdzSume()
        {
            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                suma += wagi[i] * PESEL[i];
            }

            int kontrolna = (10 - (suma % 10)) % 10;

            return kontrolna == PESEL[10];
        }

        private bool sprawdzMiesiac()
        {
            int month = getMiesiac();
            int day = getDzien();
            if (month > 0 && month < 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool sprawdzDzien()
        {
            int day = getDzien();
            int month = getMiesiac();
            bool czyRokPrzestepny = rokPrzestepny(getRok());

            if ((day > 0 && day < 32) &&
                ((day <= 30 && (month == 4 || month == 6 || month == 9 || month == 11)) ||
                 (day <= 29 && month == 2 && czyRokPrzestepny) ||
                 (day <= 28 && month == 2 && !czyRokPrzestepny) ||
                 (day <= 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool rokPrzestepny(int rok)
        {
            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
                return true;
            else
                return false;
        }
    }
}
