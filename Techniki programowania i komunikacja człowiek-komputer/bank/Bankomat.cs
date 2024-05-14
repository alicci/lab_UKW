using System;
using System.Collections.Generic;
using System.Linq;

namespace bank
{
    public class Bankomat
    {
        private Dictionary<int, int> banknoty;

        public Bankomat()
        {
            banknoty = new Dictionary<int, int>();
            banknoty.Add(10, 10);
            banknoty.Add(20, 10);
            banknoty.Add(50, 10);
            banknoty.Add(100, 10);
            banknoty.Add(200, 10);
            banknoty.Add(500, 10);
        }

        public string WyplacPieniadze(int kwota)
        {
            Dictionary<int, int> banknotyDoWyplaty = new Dictionary<int, int>(banknoty);
            Dictionary<int, int> banknotyWyplaty = new Dictionary<int, int>();

            foreach (var kvp in banknoty.OrderByDescending(x => x.Key))
            {
                int nominal = kvp.Key;
                int iloscDostepnychBanknotow = kvp.Value;
                int iloscBanknotow = Math.Min(kwota / nominal, iloscDostepnychBanknotow);
                if (iloscBanknotow > 0)
                {
                    kwota -= iloscBanknotow * nominal;
                    banknotyWyplaty.Add(nominal, iloscBanknotow);
                }
            }

            if (kwota == 0)
            {
                string result = "Wypłacono pieniądze:\n";
                foreach (var banknot in banknotyWyplaty)
                {
                    result += $"{banknot.Value}x{banknot.Key}zł\n";
                }

                foreach (var banknot in banknotyWyplaty)
                {
                    banknoty[banknot.Key] -= banknot.Value;
                }

                return result;
            }
            else
            {
                return "Brak możliwości wypłaty.";
            }
        }


        public void UzupelnijBanknoty(int nominal, int ilosc)
        {
            if (banknoty.ContainsKey(nominal))
            {
                banknoty[nominal] += ilosc;
            }
            else
            {
                banknoty.Add(nominal, ilosc);
            }
        }

        public void UsunBanknoty(int nominal, int ilosc)
        {
            if (banknoty.ContainsKey(nominal))
            {
                banknoty[nominal] = Math.Max(0, banknoty[nominal] - ilosc);
            }
        }

        public string GetBanknotesInfo()
        {
            string info = "Stan bankomatu:\n \n";
            int totalAmount = 0;
            foreach (var kvp in banknoty)
            {
                int nominal = kvp.Key;
                int ilosc = kvp.Value;
                info += $"{ilosc}x{nominal}zł\n";
                totalAmount += ilosc * nominal;
            }
            info += $"Łącznie: {totalAmount}zł";
            return info;
        }
    }
}