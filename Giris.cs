using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
