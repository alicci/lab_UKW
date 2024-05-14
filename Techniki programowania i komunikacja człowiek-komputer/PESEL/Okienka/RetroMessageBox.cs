using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PESEL.Okienka
{
    public partial class RetroMessageBox : Form
    {
        public RetroMessageBox(string komunikat, string tytul)
        {
            InitializeComponent();

            labelKomunikat.Text = komunikat;
            Text = tytul;
        }

        private void RetroMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_MouseHover(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.PaleGreen;
            buttonOk.ForeColor = System.Drawing.Color.Black;
        }

        private void buttonOk_MouseLeave(object sender, EventArgs e)
        {
            buttonOk.BackColor = Color.Black;
            buttonOk.ForeColor = System.Drawing.Color.PaleGreen;
        }
    }
}
