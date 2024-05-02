using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace OrderCancellerApp
{
    public class SiparislerDAO
    {
        internal static string connectionString = InitializeConnection();
        static string InitializeConnection()
        {
            try
            {
                if (File.Exists(@"C:\DesenPOS\DesenPos.exe.config"))
                {
                    ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = @"C:\DesenPOS\DesenPos.exe.config"
                    };
                    Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMapping, ConfigurationUserLevel.None);
                    return configuration.AppSettings.Settings["baglanti"].Value;
                }
                else if (File.Exists(@"C:\DesenPOS\DesenPOS\DesenPos.exe.config"))
                {
                    ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = @"C:\DesenPOS\DesenPOS\DesenPos.exe.config"
                    };
                    Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMapping, ConfigurationUserLevel.None);
                    return configuration.AppSettings.Settings["baglanti"].Value;
                }
                else if (File.Exists(@"D:\DesenPOS\DesenPos.exe.config"))
                {
                    ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = @"D:\DesenPOS\DesenPos.exe.config"
                    };
                    Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMapping, ConfigurationUserLevel.None);
                    return configuration.AppSettings.Settings["baglanti"].Value;
                }
                else if (File.Exists(@"D:\DesenPOS\DesenPOS\DesenPos.exe.config"))
                {
                    ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = @"D:\DesenPOS\DesenPos.exe.config"
                    };
                    Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMapping, ConfigurationUserLevel.None);
                    return configuration.AppSettings.Settings["baglanti"].Value;
                }
                else
                {
                    ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = @"D:\DesenPos.exe.config"
                    };
                    Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMapping, ConfigurationUserLevel.None);
                    return configuration.AppSettings.Settings["baglanti"].Value;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(@"Veritabanı bulunamadı. Bilgisayarınızda YemekPOS'un yüklü olduğundan emin olunuz. Eğer yüklüyse, tüm dosyaların C:\DesenPOS klasörünün içinde olduğundan emin olun." + ex.Message);
                return "";
            }
        }
        public static List<Siparisler> TumSiparisleriGetir(decimal sonXGun, string connectionString)
        {
            sonXGun = (int)sonXGun;
            List<Siparisler> returnThese = new List<Siparisler>();
            try
            {
                string showCommand = $"SELECT TOP 100 CekNo,SiparisNo,Tarih,Odendi,Kapandi FROM POSSiparis WHERE SysAktif=1 AND Kapandi=0 AND (SiparisDurumu = 0 OR SiparisDurumu = 1 OR SiparisDurumu = 2) AND Tarih > GETDATE() - {sonXGun} ORDER BY Tarih DESC";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand showCommandSQL = new SqlCommand(showCommand, sqlConnection);
                using (SqlDataReader reader = showCommandSQL.ExecuteReader())
                {
                    if (reader.GetDataTypeName(1) == "nvarchar")
                    {
                        while (reader.Read())
                        {
                            Siparisler a = new Siparisler
                            {
                                ÇekNo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                SiparişNo = reader.IsDBNull(1) ? "null" : reader.GetString(1),
                                Tarih = reader.IsDBNull(2) ? new DateTime(2000, 10, 10) : reader.GetDateTime(2),
                                Ödendi = reader.IsDBNull(3) ? false : reader.GetBoolean(3),
                                Kapandı = reader.IsDBNull(4) ? false : reader.GetBoolean(4),
                            };
                            returnThese.Add(a);
                        }
                    }
                    else if (reader.GetDataTypeName(1) == "int")
                    {
                        while (reader.Read())
                        {
                            Siparisler a = new Siparisler
                            {
                                ÇekNo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                SiparişNo =reader.IsDBNull(1) ? "null" : reader.GetInt32(1).ToString(),
                                Tarih = reader.IsDBNull(2) ? new DateTime(2000, 10, 10) : reader.GetDateTime(2),
                                Ödendi = reader.IsDBNull(3) ? false : reader.GetBoolean(3),
                                Kapandı = reader.IsDBNull(4) ? false : reader.GetBoolean(4),
                            };
                            returnThese.Add(a);
                        }
                    }
                    }
                return returnThese;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnThese;
        }
    }
}