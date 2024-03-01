using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrderCancellerApp
{
    public partial class Uygulama : Form
    {
        BindingSource siparisBindingSource = new BindingSource();
        private string connectionString = "";
        public Uygulama()
        {
            InitializeComponent();
            connectionString = InitializeConnection();
        }

        private void siparisGoster_Click(object sender, EventArgs e)
        {
            connectionString = InitializeConnection();
            SiparislerDAO siparislerDAO = new SiparislerDAO();

            siparisBindingSource.DataSource = siparislerDAO.TumSiparisleriGetir();
            siparisListesi.DataSource = siparisBindingSource;
        }


        static string InitializeConnection()
        {
            ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
            {
                ExeConfigFilename = @"C:\DesenPOS\DesenPos.exe.config"
            };
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMapping, ConfigurationUserLevel.None);
            return configuration.AppSettings.Settings["baglanti"].Value;
        }
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
                InitializeConnection();
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                if (siparisNOInput.Contains(","))
                {
                    string[] siparislerinTamami = siparisNOInput.Split(',');
                    foreach (string siparis in siparislerinTamami)
                    {
                        siparis.Trim();
                        string updateQuery = $"declare @SiparisNoYaziniz nvarchar(100)='{siparis}'\r\nupdate POSSiparis set SiparisDurumu= 8,Odendi = 0 , Kapandi = 1, SysAktif=0 where SiparisNo=@SiparisNoYaziniz;\r\n\r\ninsert into SistemTarihce\r\n(KayitId\r\n,Tablo\r\n,Tarih\r\n,RowVersion\r\n,SysAktif\r\n,SysKayitTarihi\r\n,SysKaydedenKullanici\r\n,Aciklama)\r\n\r\nselect \r\ns.Id,'POSSiparis',GETDATE(),0,1,GETDATE(),'ManuelKapatildi','güncelleme' from POSSiparis s where s.SiparisNo=@SiparisNoYaziniz";
                        SqlCommand insertCommand = new SqlCommand(updateQuery, sqlConnection);
                        insertCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    string updateQuery = $"declare @SiparisNoYaziniz nvarchar(100)='{siparisNOInput}'\r\nupdate POSSiparis set SiparisDurumu= 8,Odendi = 0 , Kapandi = 1, SysAktif=0 where SiparisNo=@SiparisNoYaziniz;\r\n\r\ninsert into SistemTarihce\r\n(KayitId\r\n,Tablo\r\n,Tarih\r\n,RowVersion\r\n,SysAktif\r\n,SysKayitTarihi\r\n,SysKaydedenKullanici\r\n,Aciklama)\r\n\r\nselect \r\ns.Id,'POSSiparis',GETDATE(),0,1,GETDATE(),'ManuelKapatildi','güncelleme' from POSSiparis s where s.SiparisNo=@SiparisNoYaziniz";
                    SqlCommand insertCommand = new SqlCommand(updateQuery, sqlConnection);
                    insertCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
                MessageBox.Show("Sipariş 'iptal edildi' durumuna getirildi.");
            }
        }

        private void teslimButonu_Click(object sender, EventArgs e)
        {
            SiparisTeslim();
            void SiparisTeslim()
            {
                InitializeConnection();
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                if (siparisNOInput.Contains(","))
                {
                    string[] siparislerinTamami = siparisNOInput.Split(',');
                    foreach (string siparis in  siparislerinTamami)
                    {
                        string updateQuery = $"declare @SiparisNoYaziniz nvarchar(100)='{siparis}'\r\nupdate POSSiparis set SiparisDurumu= 3,Odendi = 1 , Kapandi = 1, SysAktif=1 where SiparisNo=@SiparisNoYaziniz;\r\n\r\ninsert into SistemTarihce\r\n(KayitId\r\n,Tablo\r\n,Tarih\r\n,RowVersion\r\n,SysAktif\r\n,SysKayitTarihi\r\n,SysKaydedenKullanici\r\n,Aciklama)\r\n\r\nselect \r\ns.Id,'POSSiparis',GETDATE(),0,1,GETDATE(),'ManuelKapatildi','güncelleme' from POSSiparis s where s.SiparisNo=@SiparisNoYaziniz";
                        SqlCommand insertCommand = new SqlCommand(updateQuery, sqlConnection);
                        insertCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    string updateQuery = $"declare @SiparisNoYaziniz nvarchar(100)='{siparisNOInput}'\r\nupdate POSSiparis set SiparisDurumu= 3,Odendi = 1 , Kapandi = 1, SysAktif=1 where SiparisNo=@SiparisNoYaziniz;\r\n\r\ninsert into SistemTarihce\r\n(KayitId\r\n,Tablo\r\n,Tarih\r\n,RowVersion\r\n,SysAktif\r\n,SysKayitTarihi\r\n,SysKaydedenKullanici\r\n,Aciklama)\r\n\r\nselect \r\ns.Id,'POSSiparis',GETDATE(),0,1,GETDATE(),'ManuelKapatildi','güncelleme' from POSSiparis s where s.SiparisNo=@SiparisNoYaziniz";
                    SqlCommand insertCommand = new SqlCommand(updateQuery, sqlConnection);
                    insertCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
                MessageBox.Show("Sipariş 'teslim edildi' durumuna getirildi.");
            }
        }
    }
}
