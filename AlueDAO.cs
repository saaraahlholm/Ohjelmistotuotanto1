using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class AlueDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn;";

        public List<Alue> lataaKaikkiAlueet()
        {
            //Aloittaa tyhjällä listalla
            List<Alue> palautaalueet = new List<Alue>();

            //Yhdistää mysql serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            //Sql-lauseke mikä Hakee kaikki alueet
            MySqlCommand command = new MySqlCommand("SELECT * FROM ALUE", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Alue alue = new Alue
                    {
                        alue_id = reader.GetInt32(0),
                        nimi = reader.GetString(1)
                    };
                    palautaalueet.Add(alue);
                }
            }
            connection.Close();

            return palautaalueet;
        }


        public List<Alue> etsiAlue(string hakusana)
        {
            //Aloittaa tyhjällä listalla
            List<Alue> palautanama = new List<Alue>();

            //Yhdistää mysql serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string searchWildPhrase = "%" + hakusana + "%";
            //Sql-lauseke mikä Hakee kaikki alueet
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM ALUE WHERE NIMI LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Alue alue = new Alue
                    {
                        alue_id = reader.GetInt32(0),
                        nimi = reader.GetString(1)
                    };
                    palautanama.Add(alue);
                }
            }
            connection.Close();

            return palautanama;
        }

        internal int lisaaAlue(Alue alue, List<Alue> alueet)
        {
            bool loytyi = false;

            //Tarkistetaan onko kyseinen alue jo olemassa.
            foreach (Alue a in alueet)
            {
                if (a.nimi == alue.nimi)
                {
                    loytyi = true;
                }
            }

            if (loytyi == false) //Jos aluetta ei ollut olemassa, niin lisätään tietokantaan
            {
                //Yhdistää mysql serveriin
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();


                //Sql-lauseke mikä Hakee kaikki alueet
                MySqlCommand command = new MySqlCommand("INSERT INTO `alue`(`nimi`) VALUES (@nimi)", connection);


                command.Parameters.AddWithValue("@nimi", alue.nimi);

                int newRows = command.ExecuteNonQuery();


                connection.Close();

                return newRows;
            }
            else
            {
                return 0;
            }
            
                
            
               
        }


        internal int muokkaaAlue(Alue alue, int alue_id)
        {
            //Yhdistää mysql serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            //Sql-lauseke mikä Hakee kaikki alueet
            MySqlCommand command = new MySqlCommand("UPDATE `alue` SET `nimi`=@nimi WHERE `alue_id`=@alue_id", connection);


            command.Parameters.AddWithValue("@nimi", alue.nimi);
            command.Parameters.AddWithValue("@alue_id", alue_id);

            int updatedRows = command.ExecuteNonQuery();


            connection.Close();

            return updatedRows;
        }

        internal int poistaAlue(int alue_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Poista mökki, jonka mokki_id tulee parametrina
            MySqlCommand command = new MySqlCommand("DELETE FROM `alue` WHERE `alue`.`alue_id` = @alue_id", connection);
            command.Parameters.AddWithValue("@alue_id", alue_id);

            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }




    }
}
