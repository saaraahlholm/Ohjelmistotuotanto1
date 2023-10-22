using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace Mokkiprojekti
{
    internal class VaraustenHallintaDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn;";
        //polku, johon yhteys muodostetaan
        public List<JObject> lataaVaraukset()
        {
            List<JObject> palautaNama = new List<JObject>();

            MySqlConnection connection = new MySqlConnection(connectionString); //yhdistää mysql servulle

            connection.Open(); //avataan yhteys

            MySqlCommand command = new MySqlCommand("SELECT v.varaus_id, v.asiakas_id, v.varattu_alkupvm, v.varattu_loppupvm, m.alue_id, v.mokki_mokki_id, vp.palvelu_id, p.nimi, vp.lkm, a.etunimi, a.sukunimi, a.email FROM asiakas a JOIN varaus v ON a.asiakas_id = v.asiakas_id LEFT JOIN varauksen_palvelut vp ON v.varaus_id = vp.varaus_id LEFT JOIN palvelu p ON vp.palvelu_id = p.palvelu_id LEFT JOIN alue al ON p.alue_id = al.alue_id JOIN mokki m ON v.mokki_mokki_id = m.mokki_id WHERE v.varattu_alkupvm > NOW();", connection);
     
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject varaus = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        varaus.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                    palautaNama.Add(varaus);
                }
            }
            connection.Close();

            return palautaNama;
        }
        public List<JObject> haeVarausta(string searchTerm)
        {
            List<JObject> palautaNama = new List<JObject>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT v.varaus_id, v.asiakas_id, v.varattu_alkupvm, v.varattu_loppupvm, al.alue_id, v.mokki_mokki_id, vp.palvelu_id, p.nimi, vp.lkm, a.etunimi, a.sukunimi, a.email FROM asiakas a JOIN varaus v ON v.asiakas_id = a.asiakas_id JOIN varauksen_palvelut vp ON vp.varaus_id = v.varaus_id JOIN palvelu p ON p.palvelu_id = vp.palvelu_id JOIN alue al ON p.alue_id = al.alue_id WHERE v.varattu_alkupvm > NOW() AND (a.etunimi LIKE @search OR a.sukunimi LIKE @search OR a.email LIKE @search)";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject varaus = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        varaus.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                    palautaNama.Add(varaus);
                }
            }
            connection.Close();

            return palautaNama;
        }
        internal int poistaVaraus(int varausid)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM varauksen_palvelut WHERE varaus_id = @varaus_id;", connection);
            MySqlCommand command2 = new MySqlCommand("DELETE FROM varaus WHERE varaus_id = @varaus_id;", connection);
            command.Parameters.AddWithValue("@varaus_id", varausid);
            command2.Parameters.AddWithValue("@varaus_id", varausid);
            int result = command.ExecuteNonQuery() + command2.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        internal int paivitaVaraus(Varaus varaus, int paivitavarausid, int palveluid, int lkm)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
       
            MySqlCommand command = new MySqlCommand("UPDATE varaus, varauksen_palvelut SET varattu_alkupvm = @varattu_alkupvm, varattu_loppupvm = @varattu_loppupvm, palvelu_id = @palvelu_id, lkm = @lkm WHERE varauksen_palvelut.varaus_id = @varaus_id AND varaus.varaus_id = @varaus_id;", connection);
            command.Parameters.AddWithValue("@varattu_alkupvm", varaus.varattu_alkupvm);
            command.Parameters.AddWithValue("@varattu_loppupvm", varaus.varattu_loppupvm);
            command.Parameters.AddWithValue("@varaus_id", paivitavarausid);
            command.Parameters.AddWithValue("@palvelu_id", palveluid);
            command.Parameters.AddWithValue("@lkm", lkm);
         
            int paivitetty = command.ExecuteNonQuery();

            connection.Close();
            
            return paivitetty;
        }
        internal List<JObject> etsiPalvelut(string alue_id)
        {
            List<JObject> palautaNama = new List<JObject>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT p.nimi FROM palvelu p JOIN alue a ON a.alue_id = p.alue_id WHERE a.alue_id = @alue_id", connection);
            command.Parameters.AddWithValue("@alue_id", alue_id);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject palvelu = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {

                        palvelu.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());

                    }
                    palautaNama.Add(palvelu);

                };

                connection.Close();

                return palautaNama;

            }
        }
        internal int haePalvelunID(string palvelu) //hakee ks. palvelun palvelu_id:n, että pystytään lisämään/muokkaamaan varauksen palvelua
        {
            int ID = 0;

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //määrittelee sql-kyselylauseen, jolla tieto haetaan
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
        internal int lisaaPalvelu(VarauksenPalvelut vp) //lisätään varaukselle uusi palvelu
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "INSERT INTO varauksen_palvelut (varaus_id, palvelu_id, lkm) VALUES (@varaus_id, @palvelu_id, @lkm)";
            command.Parameters.AddWithValue("@palvelu_id", vp.palvelu_id);
            command.Parameters.AddWithValue("@lkm", vp.lkm);
            command.Parameters.AddWithValue("@varaus_id", vp.varaus_id);
            command.Connection = connection;

            int lisatty = command.ExecuteNonQuery();

            connection.Close();

            return lisatty;
        }
    }
}
