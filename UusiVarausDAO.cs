using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mokkiprojekti
{
    internal class UusiVarausDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn";

        //Etsi mökki hakuehdoilla
        public List<JObject> etsiMokki(DateTime saapuminen, DateTime lahto, string alueid, string henkilolkm, string hinta)
        {
            List<JObject> palautaNama = new List<JObject>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query =  "SELECT * FROM mokki WHERE mokki.mokki_id NOT IN ( SELECT mokki_mokki_id FROM varaus WHERE( (varattu_alkupvm BETWEEN @varattu_alkupvm AND @varattu_loppupvm) OR(varattu_loppupvm BETWEEN @varattu_alkupvm AND @varattu_loppupvm)  OR (@varattu_alkupvm BETWEEN varattu_alkupvm AND varattu_loppupvm)  OR (@varattu_loppupvm BETWEEN varattu_alkupvm AND varattu_loppupvm)))";
            if (alueid != "")
            {
                query += " AND alue_id = @alue_id";
            }
            if (henkilolkm != "")
            {
                query += " AND henkilomaara >= @henkilolkm";
            }
            if (hinta != "")
            {
                query += " AND hinta <= @hinta";
            }
            
            using (MySqlCommand command = new(query, connection))
            {
                command.Parameters.AddWithValue("@varattu_alkupvm", saapuminen);
                command.Parameters.AddWithValue("@varattu_loppupvm", lahto);

                if (alueid != "")
                {
                    command.Parameters.AddWithValue("@alue_id", alueid);
                }
                if (henkilolkm != "")
                {
                    command.Parameters.AddWithValue("@henkilolkm", henkilolkm);
                }
                if (hinta != "")
                {
                    command.Parameters.AddWithValue("@hinta", hinta);
                }
            
                // Suoritetaan kysely ja haetaan tulokset
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        JObject mokki = new JObject();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            mokki.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                        }
                        palautaNama.Add(mokki);
                    }
                    connection.Close();
                    return palautaNama;
                }
            }
        }

        //Etsitään mökin alueen palvelut
        internal List<Palvelu> etsiPalvelut(string alueID)
        {
            List<Palvelu> palautaNama = new List<Palvelu>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT nimi FROM palvelu WHERE alue_id = @alueID", connection);
            command.Parameters.AddWithValue("@alueID", alueID);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Palvelu p = new Palvelu()
                    {
                        nimi = reader.GetString(0),
                    };
                    palautaNama.Add(p);
                };
                connection.Close();
                return palautaNama;
            }
        }

        //Etsitään varauksen ID, jotta voidaan tehdä varauksen_palvelut
        internal int haeVarauksenID(Varaus v)
        {
            int ID = 0;

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT varaus_id FROM varaus WHERE asiakas_id = @asiakas_id AND mokki_mokki_id = @mokki_mokki_id AND varattu_alkupvm = @varattu_alkupvm AND varattu_loppupvm = @varattu_loppupvm";
            command.Parameters.AddWithValue("@asiakas_id", v.asiakas_id);
            command.Parameters.AddWithValue("@mokki_mokki_id", v.mokki_mokki_id);
            command.Parameters.AddWithValue("@varattu_alkupvm", v.varattu_alkupvm);
            command.Parameters.AddWithValue("@varattu_loppupvm", v.varattu_loppupvm);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int varausID;
                    if (int.TryParse(reader["varaus_id"].ToString(), out varausID))
                    {
                        ID = varausID;
                    }
                }
            }
            connection.Close();
            return ID;
        }

        //Haetaan palvelun_id, jotta voidaan tehdä varauksen_palvelut
        internal int haePalvelunID(string palvelu)
        {
            int ID = 0;

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT palvelu_id FROM palvelu WHERE nimi = @nimi";
            command.Parameters.AddWithValue("@nimi", palvelu);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int palveluID;
                    if (int.TryParse(reader["palvelu_id"].ToString(), out palveluID))
                    {
                        ID = palveluID;
                    }
                }
            }
            connection.Close();
            return ID;
        }

        //Lisätään varaus
        internal string lisaaVaraus(Varaus varaus)
        {
        
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            
            MySqlCommand command = new MySqlCommand("INSERT INTO varaus (asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm)" +
                "VALUES (@asiakas_id, @mokki_mokki_id, @varattu_pvm, @vahvistus_pvm, @varattu_alkupvm, @varattu_loppupvm)" , connection);
            command.Parameters.AddWithValue("@asiakas_id", varaus.asiakas_id);
            command.Parameters.AddWithValue("@mokki_mokki_id", varaus.mokki_mokki_id);
            command.Parameters.AddWithValue("@varattu_pvm", varaus.varattu_pvm);
            command.Parameters.AddWithValue("@vahvistus_pvm", varaus.vahvistus_pvm);
            command.Parameters.AddWithValue("@varattu_alkupvm", varaus.varattu_alkupvm);
            command.Parameters.AddWithValue("@varattu_loppupvm", varaus.varattu_loppupvm);
            command.ExecuteNonQuery(); 
            connection.Close();
            return "Varaus tehty onnistuneesti!";
        }

        //Lisätään varauksen_palvelut
        internal void lisaaVarauksenPalvelut(VarauksenPalvelut vp)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO varauksen_palvelut (varaus_id, palvelu_id, lkm)" +
                "VALUES (@varaus_id, @palvelu_id, @lkm)", connection);
            command.Parameters.AddWithValue("@varaus_id", vp.varaus_id);
            command.Parameters.AddWithValue("@palvelu_id", vp.palvelu_id);
            command.Parameters.AddWithValue("@lkm", vp.lkm);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

}

