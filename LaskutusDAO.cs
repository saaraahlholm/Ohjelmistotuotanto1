using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokkiprojekti
{
    internal class LaskutusDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn";

        public List<Laskutus> hankiLaskut()
        {
            //Aloita tyhjällä listalla
            List<Laskutus> laskutuslista2= new List<Laskutus>();
            //Yhdistä MySQL serveriin
            MySqlConnection connection2= new MySqlConnection(connectionString);
            connection2.Open();
            //Määritä sql lause hakemaan kaikki laskut
            MySqlCommand command = new MySqlCommand("SELECT * FROM LASKU", connection2);

            //Laskutettavat lask1= new Laskutettavat();
            //DateTime evp=lask1.loppupvm.AddDays(14);

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read()) 
                {       
                    Laskutus l = new Laskutus()
                    {   
                        lasku_id = reader.GetInt32(0),
                        varaus_id = reader.GetInt32(1),
                        summa = reader.GetDouble(2),
                        alv = reader.GetDouble(3),
                        tila = reader.GetInt32(4),
                        erapva=reader.GetDateTime(5)
                    };
               
                    laskutuslista2.Add(l);
                }
            }
            connection2.Close();

                return laskutuslista2;
        }
        //Alla on lataakaikki-napin toimintoon tarvittava funktio. Koska lataa-napin korvaa hae-nappi,
        //sitä ei tarvita

        //public List<Laskutettavat> hankiVarausTiedot()
        //{


        //    //Aloita tyhjällä listalla
        //    List<Laskutettavat> varausLaskutusLista = new List<Laskutettavat>();
        //    //Yhdistä MySQL serveriin
        //    MySqlConnection connection = new MySqlConnection(connectionString);
        //    connection.Open();
        //    //Määritä sql lause hakemaan kaikki Asiakkaan tiedot, joita tarvitaan laskun luomiseen
        //    MySqlCommand command = new MySqlCommand();
        //    command.CommandText =
        //        command.CommandText = "SELECT * FROM laskutettavat3";
        //    command.Connection= connection;
        //    //MySqlCommand command2 = new MySqlCommand();
        //    //command2.CommandText = "SELECT ISNULL(palvelu_id,'')";
        //    using (MySqlDataReader reader = command.ExecuteReader())
        //    {

        //        while (reader.Read())
        //        {
        //            Laskutettavat laskutettavat = new Laskutettavat()
        //            {
        //                varaus_id = reader.GetInt32(0),
        //                etunimi = reader.GetString(1),
        //                sukunimi = reader.GetString(2),
        //                email = reader.GetString(3),
        //                mokkinimi = reader.GetString(4),
        //                hintaperyo = reader.GetDouble(5),
        //                reissuaika = reader.GetInt32(6),
        //                palvelu_id = reader.GetInt32(7),
        //                palvelunimi = reader.GetString(8),
        //                palvhinta = reader.GetDouble(9),
        //                palvmaara = reader.GetInt32(10),
        //                kokhinta = reader.GetDouble(11),
        //                loppupvm = reader.GetDateTime(12)

        //            };

                  
        //            varausLaskutusLista.Add(laskutettavat);
        //        }
        //    }
           
        //    connection.Close();

        //    return varausLaskutusLista;
        //}

        public List<JObject> haeLaskutetut(string haeTermi)
        {
            //Aloita tyhjällä listalla
            List<JObject> laskutuslista = new List<JObject>();
            //Yhdistä MySQL serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string haeJottae  = "%"+ haeTermi+"%";
            //Määritä sql lause hakemaan kaikki Asiakkaan tiedot, joita tarvitaan laskun luomiseen
            MySqlCommand command = new MySqlCommand();
            
            command.CommandText =
                command.CommandText = "SELECT * FROM laskutettavat3 WHERE  mokkinimi LIKE @hae OR email LIKE @hae OR etunimi LIKE @hae OR sukunimi LIKE @hae";
            //Hakee sähköpostin merkkien, mökkien nimien ja etu- ja sukunimien perusteella
            command.Parameters.AddWithValue("@hae", haeJottae);

            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    JObject LaskuJobject = new JObject();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        LaskuJobject.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());

                    }
                    laskutuslista.Add(LaskuJobject);
                }
            }
            connection.Close();



            return laskutuslista;
        }

        internal int lisaa1Lasku(Laskutus lasku)
        {
            // Aloita tyhjällä listalla
            List<Laskutus> laskutuslista2 = new List<Laskutus>();
            //Yhdistä MySQL serveriin
            MySqlConnection connection2 = new MySqlConnection(connectionString);
            connection2.Open();
            //Määritä sql lause hakemaan kaikki laskujen tiedot
            MySqlCommand command = new MySqlCommand("INSERT INTO `lasku`(`varaus_id`, `summa`, `alv`, `tila`,`erapva`) VALUES (@varausID, @summa, @alv, @tila, @erapva)", connection2);
            command.Parameters.AddWithValue("@varausID", lasku.varaus_id);
            command.Parameters.AddWithValue("@summa", lasku.summa);
            command.Parameters.AddWithValue("@alv", lasku.alv);
            command.Parameters.AddWithValue("@tila", lasku.tila);
            command.Parameters.AddWithValue("@erapva",lasku.erapva);

            int uudetrivit= command.ExecuteNonQuery();
            connection2.Close();

            return uudetrivit;
        }

        internal int poistaLasku(int lasku_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Poista mökki, jonka mokki_id tulee parametrina
            MySqlCommand command = new MySqlCommand("DELETE FROM `lasku` WHERE `lasku`.`lasku_id` = @lasku_id", connection);
            command.Parameters.AddWithValue("@lasku_id", lasku_id);

            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }
    }
}
