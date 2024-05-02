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
            connectionString = SiparislerDAO.connectionString;
        }

        private void siparisGoster_Click(object sender, EventArgs e)
        {
            siparisBindingSource.DataSource = SiparislerDAO.TumSiparisleriGetir(sonXGunGirdisi, SiparislerDAO.connectionString);
            siparisListesi.DataSource = siparisBindingSource;
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
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                try
                {
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
                        siparisNOInput = siparisNOInput.Trim();
                        string updateQuery = $"declare @SiparisNoYaziniz nvarchar(100)='{siparisNOInput}'\r\nupdate POSSiparis set SiparisDurumu= 8,Odendi = 0 , Kapandi = 1, SysAktif=0 where SiparisNo=@SiparisNoYaziniz;\r\n\r\ninsert into SistemTarihce\r\n(KayitId\r\n,Tablo\r\n,Tarih\r\n,RowVersion\r\n,SysAktif\r\n,SysKayitTarihi\r\n,SysKaydedenKullanici\r\n,Aciklama)\r\n\r\nselect \r\ns.Id,'POSSiparis',GETDATE(),0,1,GETDATE(),'ManuelKapatildi','güncelleme' from POSSiparis s where s.SiparisNo=@SiparisNoYaziniz";
                        SqlCommand insertCommand = new SqlCommand(updateQuery, sqlConnection);
                        insertCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                    MessageBox.Show("Sipariş 'iptal edildi' durumuna getirildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void teslimButonu_Click(object sender, EventArgs e)
        {
            SiparisTeslim();
            void SiparisTeslim()
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                try
                {
                    if (siparisNOInput.Contains(","))
                    {
                        string[] siparislerinTamami = siparisNOInput.Split(',');
                        foreach (string siparis in siparislerinTamami)
                        {
                            siparis.Trim();
                            string updateQuery = $"declare @SiparisNoYaziniz nvarchar(100)='{siparis}'\r\nupdate POSSiparis set SiparisDurumu= 3,Odendi = 1 , Kapandi = 1, SysAktif=1 where SiparisNo=@SiparisNoYaziniz;\r\n\r\ninsert into SistemTarihce\r\n(KayitId\r\n,Tablo\r\n,Tarih\r\n,RowVersion\r\n,SysAktif\r\n,SysKayitTarihi\r\n,SysKaydedenKullanici\r\n,Aciklama)\r\n\r\nselect \r\ns.Id,'POSSiparis',GETDATE(),0,1,GETDATE(),'ManuelKapatildi','güncelleme' from POSSiparis s where s.SiparisNo=@SiparisNoYaziniz";
                            SqlCommand insertCommand = new SqlCommand(updateQuery, sqlConnection);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        siparisNOInput = siparisNOInput.Trim();
                        string updateQuery = $"declare @SiparisNoYaziniz nvarchar(100)='{siparisNOInput}'\r\nupdate POSSiparis set SiparisDurumu= 3,Odendi = 1 , Kapandi = 1, SysAktif=1 where SiparisNo=@SiparisNoYaziniz;\r\n\r\ninsert into SistemTarihce\r\n(KayitId\r\n,Tablo\r\n,Tarih\r\n,RowVersion\r\n,SysAktif\r\n,SysKayitTarihi\r\n,SysKaydedenKullanici\r\n,Aciklama)\r\n\r\nselect \r\ns.Id,'POSSiparis',GETDATE(),0,1,GETDATE(),'ManuelKapatildi','güncelleme' from POSSiparis s where s.SiparisNo=@SiparisNoYaziniz";
                        SqlCommand insertCommand = new SqlCommand(updateQuery, sqlConnection);
                        insertCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                    MessageBox.Show("Sipariş 'teslim edildi' durumuna getirildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        decimal sonXGunGirdisi = 1;
        private void sonXGun_ValueChanged(object sender, EventArgs e)
        {
            sonXGunGirdisi = sonXGun.Value;
        }
    }
}
