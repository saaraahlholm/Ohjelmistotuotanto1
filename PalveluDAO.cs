using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class PalveluDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn;";

        public List<Palvelu> lataaKaikkiPalvelut()
        {
            //Aloittaa tyhjällä listalla
            List<Palvelu> palautapalvelut = new List<Palvelu>();

            //Yhdistää mysql serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            //Sql-lauseke mikä Hakee kaikki palvelut
            MySqlCommand command = new MySqlCommand("SELECT * FROM PALVELU", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Palvelu palvelu = new Palvelu
                    {
                        palvelu_id = reader.GetInt32(0),
                        alue_id = reader.GetInt32(1),
                        nimi = reader.GetString(2),
                        tyyppi =reader.GetInt32(3),
                        kuvaus = reader.GetString(4),
                        hinta = reader.GetDouble(5),
                        alv = reader.GetDouble(6)

                    };
                    palautapalvelut.Add(palvelu);
                }
            }
            connection.Close();

            return palautapalvelut;
        }


        public List<Palvelu> etsiPalvelu(string hakusana)
        {
            //Aloittaa tyhjällä listalla
            List<Palvelu> palautanama = new List<Palvelu>();

            //Yhdistää mysql serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + hakusana + "%";
            //Sql-lauseke mikä Hakee kaikki palvelut
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM PALVELU WHERE NIMI LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;
            

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Palvelu p = new Palvelu
                    {
                        palvelu_id = reader.GetInt32(0),
                        alue_id = reader.GetInt32(1),
                        nimi = reader.GetString(2),
                        tyyppi = reader.GetInt32(3),
                        kuvaus = reader.GetString(4),
                        hinta = reader.GetDouble(5),
                        alv = reader.GetDouble(6)

                    };
                    palautanama.Add(p);
                }
            }
            connection.Close();

            return palautanama;
        }

        internal int lisaaPalvelu(Palvelu palvelu, List<Palvelu> palvelut)
        {
            bool loytyi = false;

            //Tarkistetaan onko palvelu jo olemassa
            foreach (Palvelu p in palvelut)
            {
                if (p.nimi == palvelu.nimi)
                {
                    loytyi = true;
                }
            }

            if (loytyi == false) //Jos palvelua ei ollut olemassa, niin lisätään tietokantaan
            {
                //Yhdistää mysql serveriin
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();


                //Sql-lauseke mikä Hakee kaikki palvelut
                MySqlCommand command = new MySqlCommand("INSERT INTO `palvelu`(`alue_id`,`nimi`, `tyyppi`, `kuvaus`, `hinta`, `alv`)" +
                    "VALUES (@alue_id, @nimi, @tyyppi, @kuvaus, @hinta, @alv)", connection);

                command.Parameters.AddWithValue("@alue_id", palvelu.alue_id);
                command.Parameters.AddWithValue("@nimi", palvelu.nimi);
                command.Parameters.AddWithValue("@tyyppi", palvelu.tyyppi);
                command.Parameters.AddWithValue("@kuvaus", palvelu.kuvaus);
                command.Parameters.AddWithValue("@hinta", palvelu.hinta);
                command.Parameters.AddWithValue("@alv", palvelu.alv);

                int newRows = command.ExecuteNonQuery();

                connection.Close();

                return newRows;
            }
            else
            {
                return 0;
            }

        }


        internal int muokkaaPalvelu(Palvelu palvelu, int palvelu_id)
        {
            //Yhdistää mysql serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            //Sql-lauseke mikä Hakee kaikki palvelut
            MySqlCommand command = new MySqlCommand("UPDATE `palvelu` SET `alue_id`=@alue_id, `nimi`=@nimi, `tyyppi`=@tyyppi, `kuvaus`=@kuvaus, `hinta`=@hinta, `alv`=@alv WHERE `palvelu_id`=@palvelu_id", connection);

            command.Parameters.AddWithValue("@alue_id", palvelu.alue_id);
            command.Parameters.AddWithValue("@nimi", palvelu.nimi);
            command.Parameters.AddWithValue("@tyyppi", palvelu.tyyppi);
            command.Parameters.AddWithValue("@kuvaus", palvelu.kuvaus);
            command.Parameters.AddWithValue("@hinta", palvelu.hinta);
            command.Parameters.AddWithValue("@alv", palvelu.alv);
            command.Parameters.AddWithValue("@palvelu_id", palvelu_id);


            int updatedRows = command.ExecuteNonQuery();

            connection.Close();

            return updatedRows;

        }


        internal int poistaPalvelu(int palvelu_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Poista palvelu, jonka palvelu_id tulee parametrina
            MySqlCommand command = new MySqlCommand("DELETE FROM `palvelu` WHERE `palvelu`.`palvelu_id` = @palvelu_id", connection);
            command.Parameters.AddWithValue("@palvelu_id", palvelu_id);

            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }


    }
}
