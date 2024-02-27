﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OrderCancellerApp
{
    public class SiparislerDAO
    {
        public List<Siparisler> TumSiparisleriGetir()
        {
            string computerName = Environment.MachineName;
            string connectionString = "";
            connectionString = $"Data Source={computerName}\\DESENERP;Initial Catalog=DesenPOS;Persist Security Info=True;User ID=sa;Password=DesenErp.12345;";
            string showCommand = "SELECT NickName,Aciklama,Odendi,Kapandi,SiparisNo FROM POSSiparis";
            List<Siparisler> returnThese = new List<Siparisler>();
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand showCommandSQL = new SqlCommand(showCommand, sqlConnection);
            using (SqlDataReader reader = showCommandSQL.ExecuteReader())
            {
                while (reader.Read())
                {
                    Siparisler a = new Siparisler
                    {
                        NickName = reader.GetString(0),
                        Aciklama = reader.GetString(1),
                        Odendi = reader.GetInt32(2),
                        Kapandi = reader.GetInt32(3),
                        SiparisNo = reader.GetInt32(4),
                    };
                    returnThese.Add(a);
                }
            }
            return returnThese;
        }
    }
}