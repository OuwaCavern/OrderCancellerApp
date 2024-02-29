using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrderCancellerApp
{
    public class SiparislerDAO
    {
        public List<Siparisler> TumSiparisleriGetir()
        {
            string computerName = Environment.MachineName;
            string connectionString = "";
            connectionString = $"Data Source={computerName}\\DESENERP;Initial Catalog=DesenPOS;Persist Security Info=True;User ID=sa;Password=DesenErp.12345;";
            string showCommand = $"SELECT NickName,Aciklama,Odendi,Kapandi,SiparisNo FROM POSSiparis WHERE SysAktif=1 AND SiparisDurumu <> 3 AND SiparisDurumu <> 8";
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
                            MüşteriAdı = reader.IsDBNull(0) ? "null" : reader.GetString(0),
                            Açıklama = reader.IsDBNull(1) ? "null" : reader.GetString(1),
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