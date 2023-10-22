using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Mokkiprojekti
{
    internal class MokkiDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn";

        //Haetaan kaikki mökit tietokannasta datagridview näkymään
        public List<Mokki> lataaKaikkiMokit()
        {
            //Tyhjä lista
            List<Mokki> palautaMokit = new List<Mokki>();

            //yhteys SQL-serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Haetaan kaikki tiedot mokki-taulusta
            MySqlCommand command = new MySqlCommand("SELECT `mokki_id` AS `Mökki ID`, `alue_id` AS 'Alue ID', `mokkinimi` AS 'Mökin nimi', `katuosoite` AS 'Osoite', `postinro` AS 'Postinumero', `hinta` AS 'Hinta', `henkilomaara` AS 'Henkilomäärä', `kuvaus` AS 'Kuvaus', `varustelu` AS 'Varustelu' FROM `mokki`", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Mokki mokki = new Mokki()
                    {
                        mokki_id = reader.GetInt32(0),
                        alue_id = reader.GetInt32(1),
                        mokkinimi = reader.GetString(2),
                        katuosoite = reader.GetString(3),
                        postinro = reader.GetString(4),
                        hinta = reader.GetDouble(5),
                        henkilomaara = reader.GetInt32(6),
                        kuvaus = reader.GetString(7),
                        varustelu = reader.GetString(8)

                    };

                    mokki.varaukset = haeMokinVaraus(mokki.mokki_id);
                    palautaMokit.Add(mokki);
                }
                connection.Close();

                return palautaMokit;
            }
        }

        //Lisätään mökki
        internal string lisaaMokki(Mokki mokki, List<Mokki> mokit)
        {
            bool loytyi = false;

            //Tarkistetaan onko kyseinen mökki jo olemassa. Identifiointi postinumero ja katuosoite
            foreach(Mokki m in mokit)
            {
                if(m.postinro == mokki.postinro && m.katuosoite == mokki.katuosoite )
                {
                    loytyi = true;
                }
            }

            if(loytyi == false) //Jos mökkiä ei ollut olemassa, niin lisätään tietokantaan
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand("INSERT INTO `mokki`( `alue_id`, `postinro`, `mokkinimi`, `katuosoite`, `hinta`, `kuvaus`, `henkilomaara`, `varustelu`) " +
                    "VALUES (@alue_id, @postinro, @mokkinimi, @katuosoite, @hinta, @kuvaus, @henkilomaara, @varustelu)", connection);
                command.Parameters.AddWithValue("@alue_id", mokki.alue_id);
                command.Parameters.AddWithValue("@postinro", mokki.postinro);
                command.Parameters.AddWithValue("@mokkinimi", mokki.mokkinimi);
                command.Parameters.AddWithValue("@katuosoite", mokki.katuosoite);
                command.Parameters.AddWithValue("@hinta", mokki.hinta);
                command.Parameters.AddWithValue("@kuvaus", mokki.kuvaus);
                command.Parameters.AddWithValue("@henkilomaara", mokki.henkilomaara);
                command.Parameters.AddWithValue("@varustelu", mokki.varustelu);

                int uusiRiviLkm = command.ExecuteNonQuery(); //Executenonquery tekee insert lauseen tietokantaan ja palauttaa rivien määrän, mihin muutoksia tehtiin

                connection.Close();

                return "Uusi mökki lisätty";
            }
            else
            {
                return "Mökki on jo olemassa";
            }
        }

        internal int poistaMokki(int mokki_id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Poista mökki, jonka mokki_id tulee parametrina
            MySqlCommand command = new MySqlCommand("DELETE FROM `mokki` WHERE `mokki`.`mokki_id` = @mokki_id", connection);
            command.Parameters.AddWithValue("@mokki_id", mokki_id);

            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        internal int paivitaMokki(Mokki mokki, int mokki_id)
        {
            //Avataan yhteys
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Päivitetään tietokantaan, muista katsoa parametrien järjestys!!
            MySqlCommand command = new MySqlCommand("UPDATE `mokki` SET `alue_id`=@alue_id, `postinro`=@postinro, " +
                "`mokkinimi`=@mokkinimi, `katuosoite`=@katuosoite, `hinta`=@hinta, `kuvaus`=@kuvaus, " +
                "`henkilomaara`=@henkilomaara, `varustelu`=@varustelu WHERE `mokki_id`=@mokki_id", connection);
            command.Parameters.AddWithValue("@alue_id", mokki.alue_id);
            command.Parameters.AddWithValue("@postinro", mokki.postinro);
            command.Parameters.AddWithValue("@mokkinimi", mokki.mokkinimi);
            command.Parameters.AddWithValue("@katuosoite", mokki.katuosoite);
            command.Parameters.AddWithValue("@hinta", mokki.hinta);
            command.Parameters.AddWithValue("@kuvaus", mokki.kuvaus);
            command.Parameters.AddWithValue("@henkilomaara", mokki.henkilomaara);
            command.Parameters.AddWithValue("@varustelu", mokki.varustelu);
            command.Parameters.AddWithValue("@mokki_id", mokki_id); //Tänne tulee mökki_id metodin parametrina form.Mokit puolelta

            int updatedRows = command.ExecuteNonQuery();
            connection.Close();
            return updatedRows;
        }

        public List<Varaus> haeMokinVaraus(int mokkiID)
        {
            //Tyhjä lista
            List<Varaus> palautaVaraukset = new List<Varaus>();

            //yhteys SQL-serveriin
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Haetaan tiedot tietokannasta
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM varaus WHERE mokki_mokki_id = @mokki_id";
            command.Parameters.AddWithValue("@mokki_id", mokkiID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Varaus varaus = new Varaus()
                    {
                        varaus_id = reader.GetInt32(0),
                        asiakas_id = reader.GetInt32(1),
                        mokki_mokki_id = reader.GetInt32(2),
                        varattu_pvm = reader.GetDateTime(3),
                        vahvistus_pvm = reader.GetDateTime(4),
                        varattu_alkupvm = reader.GetDateTime(5),
                        varattu_loppupvm = reader.GetDateTime(6)

                    };

                    palautaVaraukset.Add(varaus);
                }
                connection.Close();
                return palautaVaraukset;
            }
        }


        public List<JObject> haeMokinVarauksetUsingJoin(int mokkiID)
        {

            List<JObject> palautaVaraukset = new List<JObject>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Haetaan tiedot tietokannasta
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT varaus.`varaus_id` AS `Varaus ID`, varaus.`asiakas_id` AS `Asiakas ID`, mokki.`mokki_id` AS `Mökki ID`, mokki.`mokkinimi` AS `Mökin nimi`, " +
                "varaus.`varattu_pvm` `Varattu`, varaus.`varattu_alkupvm` AS `Saapuminen`, varaus.`varattu_loppupvm` AS `Lähtö` FROM `varaus`" +
                " JOIN mokki ON varaus.mokki_mokki_id  = mokki.mokki_id WHERE varaus.mokki_mokki_id = @mokki_id"; //Tähän voi nyt itse valita, mitä näkymiä tulee
            command.Parameters.AddWithValue("@mokki_id", mokkiID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject newVaraus = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newVaraus.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }

                    palautaVaraukset.Add(newVaraus);

                }

            }
            connection.Close();

            return palautaVaraukset;
        }

        //Etsi tietokannasta mökkiä hakusanalla
        public List<Mokki> etsiMokki(String hakusana)
        {

            List<Mokki> palautaNama = new List<Mokki>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchWildPhrase = "%" + hakusana + "%";

            //Haetaan kaikki tiedot tietokannasta
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM mokki " +
                "WHERE mokkinimi LIKE @search " +
                "OR katuosoite LIKE @search " +
                "OR kuvaus LIKE @search " +
                "OR varustelu LIKE @search " +
                "OR hinta LIKE @search " +
                "OR postinro LIKE @search " +
                "OR mokki_id LIKE @search " +
                "OR alue_id LIKE @search " +
                "OR henkilomaara LIKE @search";

            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Mokki mokki = new Mokki()
                    {
                        mokki_id = reader.GetInt32(0),
                        alue_id = reader.GetInt32(1),
                        postinro = reader.GetString(2),
                        mokkinimi = reader.GetString(3),
                        katuosoite = reader.GetString(4),
                        hinta = reader.GetDouble(5),
                        kuvaus = reader.GetString(6),
                        henkilomaara = reader.GetInt32(7),
                        varustelu = reader.GetString(8)

                    };
                    palautaNama.Add(mokki);
                }
                connection.Close();
                return palautaNama;
            }
        }
    }
}
