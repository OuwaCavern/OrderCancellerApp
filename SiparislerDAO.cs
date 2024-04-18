﻿using System;
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
            try
            {
                try
                {
                    ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = @"C:\DesenPOS\DesenPos.exe.config"
                    };
                    Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMapping, ConfigurationUserLevel.None);
                    return configuration.AppSettings.Settings["baglanti"].Value;
                }
                catch (Exception ex)
                {
                    ExeConfigurationFileMap fileMapping = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = @"D:\DesenPOS\DesenPos.exe.config"
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
        public List<Siparisler> TumSiparisleriGetir()
        {
            List<Siparisler> returnThese = new List<Siparisler>();
            try
            {
                connectionString = InitializeConnection();
                string showCommand = $"SELECT TOP 100 CekNo,Tarih,Odendi,Kapandi,SiparisNo FROM POSSiparis WHERE SysAktif=1 AND Kapandi=0 AND (SiparisDurumu = 0 OR SiparisDurumu = 1 OR SiparisDurumu = 2) ORDER BY Tarih DESC";
                SqlConnection sqlConnection;
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand showCommandSQL = new SqlCommand(showCommand, sqlConnection);
                using (SqlDataReader reader = showCommandSQL.ExecuteReader())
                {
                    if (reader.GetDataTypeName(4) == "nvarchar")
                    {
                        while (reader.Read())
                        {
                            Siparisler a = new Siparisler
                            {
                                ÇekNo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                Tarih = reader.IsDBNull(1) ? new DateTime(2000, 10, 10) : reader.GetDateTime(1),
                                Ödendi = reader.IsDBNull(2) ? false : reader.GetBoolean(2),
                                Kapandı = reader.IsDBNull(3) ? false : reader.GetBoolean(3),
                                SiparişNo = reader.IsDBNull(4) ? "null" : reader.GetString(4),
                            };
                            returnThese.Add(a);
                        }
                    }
                    else if (reader.GetDataTypeName(4) == "int")
                    {
                        while (reader.Read())
                        {
                            Siparisler a = new Siparisler
                            {
                                ÇekNo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                                Tarih = reader.IsDBNull(1) ? new DateTime(2000, 10, 10) : reader.GetDateTime(1),
                                Ödendi = reader.IsDBNull(2) ? false : reader.GetBoolean(2),
                                Kapandı = reader.IsDBNull(3) ? false : reader.GetBoolean(3),
                                SiparişNo =reader.IsDBNull(4) ? "null" : reader.GetInt32(4).ToString(),
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