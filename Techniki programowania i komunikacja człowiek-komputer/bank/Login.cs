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
    public partial class Login : Form
    {
        private Bankomat bankomat;

        public Login(Bankomat bankomat)
        {
            InitializeComponent();
            this.bankomat = bankomat;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string haslo = textBoxHaslo.Text;

            if (Weryfikacja(login, haslo))
            {
                AdminForm adminForm = new AdminForm(bankomat);
                this.Hide();
                adminForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło. Spróbuj ponownie.");
            }
        }
        private bool Weryfikacja(string login, string haslo)
        {
            return login == "admin" && haslo == "admin";
        }
    }
}
