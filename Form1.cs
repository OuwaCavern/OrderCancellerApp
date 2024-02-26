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
    public partial class Uygulama : Form
    {
        public Uygulama()
        {
            InitializeComponent();
            int siparisNo = Convert.ToInt32(siparisNOGirdisi.Text);
            
            internal class SiparisZamanlari
            {
                public int ID {  get; set; }
                public int siparisNO {  get; set; }
                public string Ad {  get; set; }
            }
            internal class SiparisDAO
            {
                
            }
        }


    }
}
