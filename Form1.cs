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
        
        string connectionString = $"Data Source={Environment.MachineName}\\DESENERP;Initial Catalog=DesenPOS;Persist Security Info=True;User ID=sa;Password=DesenErp.12345;";
        SqlConnection sqlConnection;
        string siparisNOInput = "";

        public void siparisNOGirdisi_TextChanged(object sender, EventArgs e)
        {
            siparisNOInput = siparisNOGirdisi.Text;
        }

        private void iptalButonu_Click(object sender, EventArgs e)
        {
            SiparisIptal();
            void SiparisIptal()
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string updateQuery = $"declare @SiparisNoYaziniz nvarchar(100)='{siparisNOInput}'\r\nupdate POSSiparis set SiparisDurumu= 8,Odendi = 0 , Kapandi = 1, SysAktif=0 where SiparisNo=@SiparisNoYaziniz;\r\n\r\ninsert into SistemTarihce\r\n(KayitId\r\n,Tablo\r\n,Tarih\r\n,RowVersion\r\n,SysAktif\r\n,SysKayitTarihi\r\n,SysKaydedenKullanici\r\n,Aciklama)\r\n\r\nselect \r\ns.Id,'POSSiparis',GETDATE(),0,1,GETDATE(),'ManuelKapatildi','güncelleme' from POSSiparis s where s.SiparisNo=@SiparisNoYaziniz";
                SqlCommand insertCommand = new SqlCommand(updateQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Sipariş 'iptal edildi' durumuna getirildi..");
            }
        }

        private void teslimButonu_Click(object sender, EventArgs e)
        {
            SiparisTeslim();
            void SiparisTeslim()
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string updateQuery = $"declare @SiparisNoYaziniz nvarchar(100)='{siparisNOInput}'\r\nupdate POSSiparis set SiparisDurumu= 3,Odendi = 1 , Kapandi = 1, SysAktif=1 where SiparisNo=@SiparisNoYaziniz;\r\n\r\ninsert into SistemTarihce\r\n(KayitId\r\n,Tablo\r\n,Tarih\r\n,RowVersion\r\n,SysAktif\r\n,SysKayitTarihi\r\n,SysKaydedenKullanici\r\n,Aciklama)\r\n\r\nselect \r\ns.Id,'POSSiparis',GETDATE(),0,1,GETDATE(),'ManuelKapatildi','güncelleme' from POSSiparis s where s.SiparisNo=@SiparisNoYaziniz";
                SqlCommand insertCommand = new SqlCommand(updateQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Sipariş 'teslim edildi' durumuna getirildi.");
            }
        }
    }
}
