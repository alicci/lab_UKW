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
    public partial class Form1 : Form
    {
        private Bankomat bankomat;
        public Form1()
        {
            InitializeComponent();
            bankomat = new Bankomat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelBanknoty.Text = bankomat.GetBanknotesInfo();
        }

        private void buttonWyplac_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxKwota.Text, out int amount))
            {
                string result = bankomat.WyplacPieniadze(amount);
                MessageBox.Show(result);
                OdswiezBanknoty();
            }
            else
            {
                MessageBox.Show("Podaj poprawną kwotę.");
            }
            textBoxKwota.Clear();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Login login = new Login(bankomat);
            login.ShowDialog();
        }

        private void OdswiezBanknoty()
        {
            
            labelBanknoty.Text = bankomat.GetBanknotesInfo();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            OdswiezBanknoty();
        }
    }
}
