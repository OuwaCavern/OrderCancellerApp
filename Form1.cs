using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderCancellerApp
{
    public partial class Uygulama : Form
    {
        BindingSource siparisBindingSource = new BindingSource();
        public Uygulama()
        {
            InitializeComponent();
            
        }

        private void siparisGoster_Click(object sender, EventArgs e)
        {
            SiparislerDAO siparislerDAO = new SiparislerDAO();

            siparisBindingSource.DataSource = siparislerDAO.TumSiparisleriGetir();
            siparisListesi.DataSource = siparisBindingSource;
        }
    }
}
