using System;
using System.Windows.Forms;

namespace OrderCancellerApp
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void sifreGirisi_TextChanged(object sender, EventArgs e)
        {
            string kullaniciGirisi = sifreGirisi.Text;
        }
        private void girisButonu_Click(object sender, EventArgs e)
        {
            if (sifreGirisi.Text == "DesenErp.12345")
            {
                Program.BasariliGirisiAyarla(true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen tekrar deneyiniz.");
            }
        }
    }
}
