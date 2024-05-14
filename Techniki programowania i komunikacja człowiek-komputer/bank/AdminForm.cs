using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class AdminForm : Form
    {
        private Bankomat bankomat;
        public AdminForm(Bankomat bankomat)
        {
            InitializeComponent();
            this.bankomat = bankomat;
            RefreshBanknotesInfo();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {           
            comboBoxNominal.Items.AddRange(new object[] { 10, 20, 50, 100, 200, 500 });
            comboBoxNominal.SelectedIndex = 0;
        }
        

        private void RefreshBanknotesInfo()
        {
            labelBanknoty.Text = bankomat.GetBanknotesInfo();
        }

        private void buttonUzupelnij_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxNominal.SelectedItem.ToString(), out int nominal) && int.TryParse(textBoxIlosc.Text, out int ilosc))
            {
                bankomat.UzupelnijBanknoty(nominal, ilosc);
                MessageBox.Show($"Uzupełniono banknoty: {ilosc}x{nominal}zł");
                RefreshBanknotesInfo();
            }
            else
            {
                MessageBox.Show("Podaj poprawne wartości.");
            }
            
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxNominal.SelectedItem.ToString(), out int nominal) && int.TryParse(textBoxIlosc.Text, out int ilosc))
            {
                bankomat.UsunBanknoty(nominal, ilosc);
                MessageBox.Show($"Usunięto banknoty: {ilosc}x{nominal}zł");
                RefreshBanknotesInfo();
            }
            else
            {
                MessageBox.Show("Podaj poprawne wartości.");
            }
        }
    }
}
