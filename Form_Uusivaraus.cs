using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mokkiprojekti
{
    public partial class Form_Uusivaraus : Form
    {
        public Form_Uusivaraus()
        {
            InitializeComponent();
        }

        readonly string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn"; //Yhteyslause
        BindingSource mokkiBindingSource = new BindingSource();
        List<JObject> mokit = new List<JObject>();
        List<Palvelu> palvelut = new List<Palvelu>();
        List<Varaus> varaukset = new List<Varaus>();
        int rowClicked = -1;

        //Liikkuminen formilta toiselle
        private void etusivuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Tällä paluu etusivulle. Pitäisikö olla joku "haluatko poistua nykyiseltä sivulta" kysely?
            Form_Aloitus newForm = new Form_Aloitus();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            newForm.ShowDialog();
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
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void hallinnoiVarauksiaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form_Varaukset newForm = new Form_Varaukset();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void hallinnoiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_AlueetPalvelut newForm = new Form_AlueetPalvelut();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void raportointiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_AlueetPalvelutRapsa newForm = new Form_AlueetPalvelutRapsa();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void mökitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Mokit newForm = new Form_Mokit();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void asiakasjärjestelmäToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Asiakkaat newForm = new Form_Asiakkaat();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void laskutusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Laskutus newForm = new Form_Laskutus();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void ohjeetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Ohjeet newForm = new Form_Ohjeet();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
        private void Form_Uusivaraus_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dtpSaapuminen.MinDate = DateTime.Today;
            dtpLahto.MinDate = DateTime.Today.AddDays(1);

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Haetaan alueet comboboxiin
            MySqlCommand command = new MySqlCommand("SELECT alue_id, nimi FROM alue", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string alue_id = reader.GetInt32("alue_id").ToString();
                    string nimi = reader.GetString("nimi");
                    string comboItem = alue_id + " - " + nimi;
                    cbAlue.Items.Add(comboItem);
                }
            }

            //Ladataan postinumerot comboboxiin
            MySqlCommand postikasky = new MySqlCommand("SELECT postinro FROM posti", connection);
            AutoCompleteStringCollection kokoelma = new AutoCompleteStringCollection();

            using (MySqlDataReader reader = postikasky.ExecuteReader())
            {
                while (reader.Read())
                {
                    kokoelma.Add(reader.GetString(0));
                }

                cbPostinro.AutoCompleteCustomSource = kokoelma;
            }
            connection.Close();
        }

        //Mökin hakeminen hakuehdoilla
        private void btnEtsi_Click(object sender, EventArgs e)
        {
            try
            {
                UusiVarausDAO uusivarausDAO = new UusiVarausDAO();
                mokit = uusivarausDAO.etsiMokki(dtpSaapuminen.Value, dtpLahto.Value, cbAlue.Text, dupHenkilomaara.Text, cbHinta.Text);  //haetaan listaan kaikki mökit
                mokkiBindingSource.DataSource = mokit;
                dgvMokit.DataSource = mokkiBindingSource; //Asettaa tiedot datagridviewiin
                lblValittumokki.Text = "";
                cbLisapalvelu.Text = "";
            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Varauksen tekeminen
        private void btnTeeVaraus_Click(object sender, EventArgs e)  
        {
            try
            {
                AsiakasDAO asiakasDAO = new AsiakasDAO();
                UusiVarausDAO uusivarausDAO = new UusiVarausDAO();
                rowClicked = dgvMokit.CurrentRow.Index;

                if (!cbEiPalveluita.Checked) //Jos varaukselle valittu palvelu..
                {
                    if (tarkistaPalvelunTiedot() == false) //..Tarkista lisäpalvelun syötteet
                        return;
                }

                Asiakas asiakas = new Asiakas  //Asiakkaan tiedot olioon
                {
                    postinro = cbPostinro.Text,
                    etunimi = tbEtunimi.Text,
                    sukunimi = tbSukunimi.Text,
                    lahiosoite = tbLahiosoite.Text,
                    email = tbEmail.Text,
                    puhelinnro = tbPuhelinnumero.Text,
                };

                if (tarkistaTiedot() == false) //tarkista asiakkaan tietojen syötteet
                    return;

                if (tarkistaOnkoEmailOlemassa() == true) // Jos email EI löytynyt, niin lisätään asiakas tietokantaan
                {
                    AsiakasDAO ad = new AsiakasDAO();
                    int result = ad.lisaaUusiAsiakas(asiakas);
                }

                Varaus v = new Varaus //Varauksen tiedot olioon
                {
                    asiakas_id = asiakasDAO.haeAsiakkaanID(tbEmail.Text), //Haetaan asiakkaan tiedot tietokannasta. 
                    mokki_mokki_id = ((JValue)dgvMokit.Rows[rowClicked].Cells[0].Value).Value<int>(),
                    varattu_pvm = DateTime.Today,
                    varattu_alkupvm = dtpSaapuminen.Value.Date.AddHours(0).AddMinutes(0),
                    varattu_loppupvm = dtpLahto.Value.Date.AddHours(0).AddMinutes(0),
                    vahvistus_pvm = dtpSaapuminen.Value.Date.AddHours(0).AddMinutes(0).AddDays(-2),
                };

                string tulos = uusivarausDAO.lisaaVaraus(v); //Lisätään varaus tietokantaan

                if (!cbEiPalveluita.Checked) //Jos varaukselle oli valittu palveluita, niin viedään tietokantaan
                {
                    VarauksenPalvelut vp = new VarauksenPalvelut  //Tiedot varauksenPalvelut olioon
                    {
                        varaus_id = uusivarausDAO.haeVarauksenID(v),
                        palvelu_id = uusivarausDAO.haePalvelunID(cbLisapalvelu.Text),
                        lkm = int.Parse(tbPalvelunLkm.Text),
                    };

                    uusivarausDAO.lisaaVarauksenPalvelut(vp); //Lisätään tietokantaan
                }

                MessageBox.Show(tulos);
                mokit = uusivarausDAO.etsiMokki(dtpSaapuminen.Value, dtpLahto.Value, cbAlue.Text, dupHenkilomaara.Text, cbHinta.Text); //haetaan listaan kaikki hakuehtoihin sopivat mökit uudelleen
                mokkiBindingSource.DataSource = mokit;  
                dgvMokit.DataSource = mokkiBindingSource;
            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            tyhjennalomake();
            gbMokkiJaPalvelut.Enabled = false;
            gbVaraajantiedot.Enabled = false;
            cbEiPalveluita.Checked = false;
        }

        //Datagridview klikki
        private void dgvMokit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowClicked = dgvMokit.CurrentRow.Index;
            lblValittumokki.Text = dgvMokit.Rows[rowClicked].Cells[3].Value.ToString();
            lblValittumokki.Visible = true;

            UusiVarausDAO uusivarausDAO = new UusiVarausDAO();
            palvelut = uusivarausDAO.etsiPalvelut(dgvMokit.Rows[rowClicked].Cells[1].Value.ToString());
            cbLisapalvelu.DataSource = palvelut;
            cbLisapalvelu.DisplayMember = "nimi";
            cbLisapalvelu.ValueMember = "palvelu_id";
            gbMokkiJaPalvelut.Enabled = true;
            gbVaraajantiedot.Enabled = true;
        }

        private bool tarkistaPalvelunTiedot()
        {
            if (cbLisapalvelu.Text == String.Empty || tbPalvelunLkm.Text == String.Empty)
            {
                MessageBox.Show("Tarkista lisäpavelun tiedot.");
                return false;
            }
            else
                return true;
        }

        private bool tarkistaTiedot()
        {
            if (tbEmail.Text == String.Empty || tbEtunimi.Text == String.Empty || tbSukunimi.Text == String.Empty || tbLahiosoite.Text == String.Empty || tbPuhelinnumero.Text == String.Empty || cbPostinro.Text == String.Empty)
            {
                MessageBox.Show("Kaikki tiedot ovat pakollisia.");
                return false;
            }
            if (tbEmail.Text != "")
            {
                string email = tbEmail.Text;

                // Tarkistetaan sähköpostiosoitteen oikeellisuus
                if (!Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                {
                    MessageBox.Show("Sähköpostiosoite ei ole oikeassa muodossa.");
                    return false;
                }
                else
                    return true;
            }
            else
                return true;
        }

        private bool tarkistaOnkoEmailOlemassa()
        {
            string email = tbEmail.Text;
            MySqlConnection connection = new MySqlConnection(connectionString);//yhdistää mysql servulle
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM asiakas WHERE email = @email", connection);
                command.Parameters.AddWithValue("@email", email);
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Asiakas " + tbEtunimi.Text + " " + tbSukunimi.Text + " löytyi jo järjestelmästä. Käytetään järjestelmän tietoja.");
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();
                    return true;
                }
            }
        }

        private void tyhjennalomake()
        {
            cbPostinro.Text = "";
            tbEtunimi.Text = "";
            tbSukunimi.Text = "";
            tbLahiosoite.Text = "";
            tbEmail.Text = "";
            tbPuhelinnumero.Text = "";
            lblValittumokki.Text = "";
            cbLisapalvelu.Text = "";
            tbPalvelunLkm.Text = "";
        }
        private void cbEiPalveluita_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEiPalveluita.Checked)
            {
                cbLisapalvelu.Enabled = false;
                tbPalvelunLkm.Enabled = false;
            }
            else
            {
                cbLisapalvelu.Enabled = true;
                tbPalvelunLkm.Enabled = true;
            }
        }

        //Etunimen syötteet
        private void tbEtunimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbEtunimi_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEtunimi.Text))
            {
                string input = tbEtunimi.Text;
                string output = input.Substring(0, 1).ToUpper() + input.Substring(1);
                tbEtunimi.Text = output;
            }
        }

        //Sukunimen syötteet
        private void tbSukunimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbSukunimi_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSukunimi.Text))
            {
                string input = tbSukunimi.Text;
                string output = input.Substring(0, 1).ToUpper() + input.Substring(1);
                tbSukunimi.Text = output;
            }
        }

        //Osoitesyöte
        private void tbLahiosoite_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbLahiosoite.Text))
            {
                string input = tbLahiosoite.Text;
                string output = input.Substring(0, 1).ToUpper() + input.Substring(1);
                tbLahiosoite.Text = output;
            }
        }

        //Puhelinnumerosyöte
        private void tbPuhelinnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
        //Kun varaukselle valitaan alkupäivän, niin lähtöpäivä automaattisesti yksi isompi
        private void dtpSaapuminen_ValueChanged(object sender, EventArgs e)
        {
            dtpLahto.MinDate = dtpSaapuminen.Value.AddDays(1);
        }

        private void tbPalvelunLkm_Leave(object sender, EventArgs e)
        {
            if (cbLisapalvelu.Text != "" && tbPalvelunLkm.Text == "")
            {
                MessageBox.Show("Jos palvelu valittu, määrä ei voi olla tyhjä!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPalvelunLkm.Focus();
            }
        }
    }
}
