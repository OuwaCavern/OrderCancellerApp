using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrderCancellerApp
{
    public class SiparislerDAO
    {
        private string connectionString = "";
        static string InitializeConnection()
        {
            ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
            {
                ExeConfigFilename = @"C:\DesenPOS\DesenPos.exe.config"
            };
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMapping, ConfigurationUserLevel.None);
            return configuration.AppSettings.Settings["baglanti"].Value;
        }
        public List<Siparisler> TumSiparisleriGetir()
        {
            connectionString = InitializeConnection();
            string showCommand = $"SELECT CekNo,Tarih,Odendi,Kapandi,SiparisNo FROM POSSiparis WHERE SysAktif=1 AND SiparisDurumu <> 3 AND SiparisDurumu <> 8";
            List<Siparisler> returnThese = new List<Siparisler>();
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand showCommandSQL = new SqlCommand(showCommand, sqlConnection);
            using (SqlDataReader reader = showCommandSQL.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        Siparisler a = new Siparisler
                        {
                            ÇekNo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            Tarih = reader.IsDBNull(1) ? new DateTime(2000, 10, 10) : reader.GetDateTime(1),
                            Ödendi = reader.IsDBNull(2) ? false : reader.GetBoolean(2),
                            Kapandı = reader.IsDBNull(3) ? false : reader.GetBoolean(3),
                            SiparişNo = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                        };
                        returnThese.Add(a);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return returnThese;
        }
    }
}