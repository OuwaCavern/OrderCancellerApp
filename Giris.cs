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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kullaniciGirisi = textBox1.Text;
        }
        private void girisButonu_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "DesenErp.12345")
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
