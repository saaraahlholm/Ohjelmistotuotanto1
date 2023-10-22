using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class AluepalvelurapsaDAO
    {

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn;";

        //Etsi varaus hakuehdoilla
        public List<JObject> etsiVarattuMokki(DateTime saapuminen, DateTime lahto, string alueid)
        {
            List<JObject> palautaNama = new List<JObject>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM mokki WHERE mokki.mokki_id IN ( SELECT mokki_mokki_id FROM varaus WHERE( (varattu_alkupvm BETWEEN @varattu_alkupvm AND @varattu_loppupvm) OR(varattu_loppupvm BETWEEN @varattu_alkupvm AND @varattu_loppupvm)  OR (@varattu_alkupvm BETWEEN varattu_alkupvm AND varattu_loppupvm)  OR (@varattu_loppupvm BETWEEN varattu_alkupvm AND varattu_loppupvm)))";
            if (alueid != "")
            {
                query += " AND alue_id = @alue_id";
            }


            using (MySqlCommand command = new(query, connection))
            {
                command.Parameters.AddWithValue("@varattu_alkupvm", saapuminen);
                command.Parameters.AddWithValue("@varattu_loppupvm", lahto);
                command.Parameters.AddWithValue("@alue_id", alueid);

                /*if (alueid != "")
                {
                    command.Parameters.AddWithValue("@alue_id", alueid);
                }*/


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


        public List<Varaus> lataaKaikkiVaraukset()
        {
            //Aloittaa tyhjällä listalla
            List<Varaus> palautavaraukset = new List<Varaus>();

            //Yhdistää mysql serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            //Sql-lauseke mikä Hakee kaikki varaukset
            MySqlCommand command = new MySqlCommand("SELECT * FROM VARAUS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Varaus varaus = new Varaus
                    {

                        varaus_id = reader.GetInt32(0),
                        asiakas_id = reader.GetInt32(1),
                        mokki_mokki_id = reader.GetInt32(2),
                        varattu_pvm = (DateTime)reader.GetMySqlDateTime(3),
                        vahvistus_pvm = (DateTime)reader.GetMySqlDateTime(4),
                        varattu_alkupvm = (DateTime)reader.GetMySqlDateTime(5),
                        varattu_loppupvm = (DateTime)reader.GetMySqlDateTime(6)

                    };
                    palautavaraukset.Add(varaus);
                }
            }
            connection.Close();

            return palautavaraukset;
        }
        public List<VarauksenPalvelut> haeVarattujenMokkienPalvelutUsingJoin(DateTime saapuminen, DateTime lahto, string alueid)
        {

            //Aloittaa tyhjällä listalla
            List<VarauksenPalvelut> palautavarauksenpalvelut = new List<VarauksenPalvelut>();

            //Yhdistää mysql serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            //Sql-lauseke mikä Hakee kaikki varaukset
            MySqlCommand command = new MySqlCommand("SELECT * FROM varauksen_palvelut vp JOIN varaus v ON vp.varaus_id = v.varaus_id JOIN palvelu p ON vp.palvelu_id = p.palvelu_id JOIN alue a ON p.alue_id = a.alue_id WHERE a.alue_id = @alue_id AND (v.varattu_alkupvm BETWEEN @varattu_alkupvm AND @varattu_loppupvm OR v.varattu_loppupvm BETWEEN @varattu_alkupvm AND @varattu_loppupvm)", connection);
            command.Parameters.AddWithValue("@varattu_alkupvm", saapuminen);
            command.Parameters.AddWithValue("@varattu_loppupvm", lahto);
            command.Parameters.AddWithValue("@alue_id", alueid);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    VarauksenPalvelut varauksenpalvelut = new VarauksenPalvelut
                    {


                        varaus_id = reader.GetInt32(0),
                        palvelu_id = reader.GetInt32(1),
                        lkm = reader.GetInt32(2)

                    };
                    palautavarauksenpalvelut.Add(varauksenpalvelut);
                }
            }
            connection.Close();

            return palautavarauksenpalvelut;
        }

    }
}