using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkiprojekti
{
    public partial class Form_AlueetPalvelutRapsa : Form
    {

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn;";



        List<JObject> palautaVaraukset = new List<JObject>();
        BindingSource varausBindingSource = new BindingSource();
        BindingSource varauksenpalvelutBindingSource = new BindingSource();
        List<JObject> mokit = new List<JObject>();
        List<Varaus> varaukset = new List<Varaus>();
        List<VarauksenPalvelut> varauksenpalvelut = new List<VarauksenPalvelut>();
        public Form_AlueetPalvelutRapsa()
        {
            InitializeComponent();
        }


        //Liikkuminen formilta toiselle
        private void etusivuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Tällä paluu etusivulle. Pitäisikö olla joku "haluatko poistua nykyiseltä sivulta" kysely?
            Form_Aloitus newForm = new Form_Aloitus();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            // Piilota nykyinen ikkuna
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Sulje nykyinen ikkuna
            this.Close();
        }

        private void lopetusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Oletko varma, että haluat sulkea sovelluksen?", "Info", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes) //Jos vastaus kyllä, niin sulkee ohjelman
            {
                Application.Exit();
            }
        }

        private void uusivarausToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Uusivaraus newForm = new Form_Uusivaraus();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            // Piilota nykyinen ikkuna
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Sulje nykyinen ikkuna
            this.Close();
        }

        private void hallinnoiVarauksiaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form_Varaukset newForm = new Form_Varaukset();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            // Piilota nykyinen ikkuna
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Sulje nykyinen ikkuna
            this.Close();
        }


        private void hallinnoiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_AlueetPalvelut newForm = new Form_AlueetPalvelut();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            // Piilota nykyinen ikkuna
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Sulje nykyinen ikkuna
            this.Close();
        }

        private void raportointiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_AlueetPalvelutRapsa newForm = new Form_AlueetPalvelutRapsa();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            // Piilota nykyinen ikkuna
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Sulje nykyinen ikkuna
            this.Close();
        }


        private void mökitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Mokit newForm = new Form_Mokit();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            // Piilota nykyinen ikkuna
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Sulje nykyinen ikkuna
            this.Close();
        }

        private void asiakasjärjestelmäToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Asiakkaat newForm = new Form_Asiakkaat();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            // Piilota nykyinen ikkuna
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Sulje nykyinen ikkuna
            this.Close();
        }

        private void laskutusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Laskutus newForm = new Form_Laskutus();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            // Piilota nykyinen ikkuna
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Sulje nykyinen ikkuna
            this.Close();
        }

        private void ohjeetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Ohjeet newForm = new Form_Ohjeet();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            // Piilota nykyinen ikkuna
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Sulje nykyinen ikkuna
            this.Close();
        }

        private void Form_AlueetPalvelutRapsa_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            MySqlConnection connection = new MySqlConnection(connectionString);//yhdistää mysql servulle
            connection.Open();
            MySqlCommand aluekasky = new MySqlCommand("SELECT alue_id FROM alue", connection);
            AutoCompleteStringCollection kokoelma = new AutoCompleteStringCollection();

            using (MySqlDataReader reader = aluekasky.ExecuteReader())
            {
                while (reader.Read())
                {
                    kokoelma.Add(reader.GetString(0));
                }

                cbAlueetrapsa.AutoCompleteCustomSource = kokoelma;

            }


            //Haetaan alueet lomakkeelle
            MySqlCommand command1 = new MySqlCommand("SELECT alue_id, nimi FROM alue", connection);
            using (MySqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    string alue_id = reader.GetInt32("alue_id").ToString();
                    string nimi = reader.GetString("nimi");
                    string comboItem = alue_id + " " + nimi;
                    cbAlueetrapsa.Items.Add(comboItem);
                }
                if (cbAlueetrapsa.Items.Count > 0)
                {
                    cbAlueetrapsa.SelectedIndex = 0;
                }
            }
            connection.Close();
        }

        private void btnHaemajoitukset_Click(object sender, EventArgs e)
        {
            AluepalvelurapsaDAO aluepalvelurapsaDAO = new AluepalvelurapsaDAO();
            mokit = aluepalvelurapsaDAO.etsiVarattuMokki(dtpSaapumispvm.Value, dtpLahtopvm.Value, cbAlueetrapsa.Text);  //haetaan listaan kaikki mökit
            varausBindingSource.DataSource = mokit;
            dgvVaratutmajoitukset.DataSource = varausBindingSource; //Asettaa tiedot datagridviewiin

        }


        private void btnLataakaikki_Click(object sender, EventArgs e)
        {
            AluepalvelurapsaDAO aluepalvelurapsaDAO = new AluepalvelurapsaDAO();
            //varaukset = aluepalvelurapsaDAO.lataaKaikkiVaraukset();    //haetaan listaan kaikki varatutmökit
            //varausBindingSource.DataSource = varaukset;  //yhdistää listan datagridview
            //dgvVaratutmajoitukset.DataSource = varausBindingSource;

            varauksenpalvelut = aluepalvelurapsaDAO.haeVarattujenMokkienPalvelutUsingJoin(dtpSaapumispvm.Value, dtpLahtopvm.Value, cbAlueetrapsa.Text);    //haetaan listaan kaikki ostetut palvelut
            varauksenpalvelutBindingSource.DataSource = varauksenpalvelut;  //yhdistää listan datagridview
            dgvOstetutpalvelut.DataSource = varauksenpalvelutBindingSource;
        }

  
    }
}
