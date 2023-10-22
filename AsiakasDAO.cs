using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class AsiakasDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn;";
        //polku, johon yhteys muodostetaan
        public List<Asiakas> haeAsiakkaat()
        {
            List<Asiakas> palautaNama = new List<Asiakas>();

            MySqlConnection connection = new MySqlConnection(connectionString); //yhdistää mysql servulle

            connection.Open(); //avataan yhteys

            MySqlCommand command = new MySqlCommand("SELECT * FROM asiakas", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Asiakas a = new Asiakas
                    {
                        asiakas_id = reader.GetInt32(0),
                        postinro = reader.GetString(1),
                        etunimi = reader.GetString(2),
                        sukunimi = reader.GetString(3),
                        lahiosoite = reader.GetString(4),
                        email = reader.GetString(5),
                        puhelinnro = reader.GetString(6)
                    };

                    a.varaukset = naytaVaraukset(a.asiakas_id);

                    palautaNama.Add(a);
                }
            }
            connection.Close();

            return palautaNama;
        }

        public List<Asiakas> etsiAsiakasta(string searchTerm)
        {
            List<Asiakas> palautaNama = new List<Asiakas>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string searchWildPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM asiakas WHERE etunimi LIKE @search OR sukunimi LIKE @search OR email LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Asiakas a1 = new Asiakas
                    {
                        asiakas_id = reader.GetInt32(0),
                        postinro = reader.GetString(1),
                        etunimi = reader.GetString(2),
                        sukunimi = reader.GetString(3),
                        lahiosoite = reader.GetString(4),
                        email = reader.GetString(5),
                        puhelinnro = reader.GetString(6)
                    };
                    palautaNama.Add(a1);
                }
            }
            connection.Close();

            return palautaNama;
        }

        internal int lisaaUusiAsiakas(Asiakas asiakas)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `asiakas`(`postinro`, `etunimi`, `sukunimi`, `lahiosoite`, `email`, `puhelinnro`) VALUES (@postinro, @etunimi, @sukunimi, @lahiosoite, @email, @puhelinnro)", connection);

            command.Parameters.AddWithValue("@postinro", asiakas.postinro);
            command.Parameters.AddWithValue("@etunimi", asiakas.etunimi);
            command.Parameters.AddWithValue("@sukunimi", asiakas.sukunimi);
            command.Parameters.AddWithValue("@lahiosoite", asiakas.lahiosoite);
            command.Parameters.AddWithValue("@email", asiakas.email);
            command.Parameters.AddWithValue("@puhelinnro", asiakas.puhelinnro);

            int uudetRivit = command.ExecuteNonQuery();

            connection.Close();

            return uudetRivit;
        }

        public List<Varaus> naytaVaraukset(int asiakas_id)
        {
            List<Varaus> palautaNama = new List<Varaus>();

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            //määrittelee sql-kyselylauseen, jolla tieto haetaan
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM varaus WHERE asiakas_id = @asiakas_id";
            command.Parameters.AddWithValue("@asiakas_id", asiakas_id);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Varaus v = new Varaus
                    {
                        varaus_id = reader.GetInt32(0),
                        asiakas_id = reader.GetInt32(1),
                        mokki_mokki_id = reader.GetInt32(2),
                        varattu_pvm = reader.GetDateTime(3),
                        vahvistus_pvm = reader.GetDateTime(4),
                        varattu_alkupvm = reader.GetDateTime(5),
                        varattu_loppupvm = reader.GetDateTime(6),
                    };
                    palautaNama.Add(v);
                }
            }
            connection.Close();

            return palautaNama;
        }
        internal int poistaAsiakas(int asiakasid)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM `asiakas` WHERE `asiakas`.`asiakas_id` = @asiakas_id", connection);

            command.Parameters.AddWithValue("@asiakas_id", asiakasid);

            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        internal int paivitaAsiakas(Asiakas uusiAsiakas, int paivitaasiakasid)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("UPDATE `asiakas` SET `postinro`=@postinro,`etunimi`=@etunimi," +
                "`sukunimi`=@sukunimi,`lahiosoite`=@lahiosoite,`email`=@email,`puhelinnro`=@puhelinnro WHERE asiakas_id = @asiakas_id", connection);

            command.Parameters.AddWithValue("@postinro", uusiAsiakas.postinro);
            command.Parameters.AddWithValue("@etunimi", uusiAsiakas.etunimi);
            command.Parameters.AddWithValue("@sukunimi", uusiAsiakas.sukunimi);
            command.Parameters.AddWithValue("@lahiosoite", uusiAsiakas.lahiosoite);
            command.Parameters.AddWithValue("@email", uusiAsiakas.email);
            command.Parameters.AddWithValue("@puhelinnro", uusiAsiakas.puhelinnro);
            command.Parameters.AddWithValue("@asiakas_id", paivitaasiakasid);

            int uudetRivit = command.ExecuteNonQuery();

            connection.Close();

            return uudetRivit;
        }

        internal int haeAsiakkaanID(string email)
        {
            int ID = 0;

            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            //määrittelee sql-kyselylauseen, jolla tieto haetaan
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT asiakas_id FROM asiakas WHERE email = @email";
            command.Parameters.AddWithValue("@email", email);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int asiakasId;
                    if (int.TryParse(reader["asiakas_id"].ToString(), out asiakasId))
                    {
                        ID = asiakasId;
                    }
                }
            }
            connection.Close();

            return ID;
        }
    }
}
