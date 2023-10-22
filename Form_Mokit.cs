using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mokkiprojekti
{
    public partial class Form_Mokit : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn";
        MySqlConnection connection;
   
        readonly BindingSource mokkiBindingSource = new BindingSource();
        readonly BindingSource mokinvarausBindingSource = new BindingSource();

        List<Mokki> mokit = new List<Mokki>();

        public Form_Mokit()
        {
            InitializeComponent();
        }

        private void Form_Mokit_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            connection = new MySqlConnection(connectionString);
            connection.Open();

            //Ladataan postinumerot lomakkeelle käyttöön
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

            //Haetaan alueet lomakkeelle
            MySqlCommand aluekasky = new MySqlCommand("SELECT alue_id, nimi FROM alue", connection);
            using (MySqlDataReader reader = aluekasky.ExecuteReader())
            {
                while (reader.Read())
                {
                    string alue_id = reader.GetInt32("alue_id").ToString();
                    string nimi = reader.GetString("nimi");
                    string comboItem = alue_id + " - " + nimi;
                    cbAlueId.Items.Add(comboItem);
                }
                if (cbAlueId.Items.Count > 0)
                {
                    cbAlueId.SelectedIndex = 0;
                }
            }
            connection.Close();
        }


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

        //Tästä alkaa sivun elementtien toiminnallinen koodi
        //Ladataan mökit datagridviewiin
        private void btnLataaKaikki_Click(object sender, EventArgs e)
        {
            MokkiDAO mokkiDAO = new MokkiDAO();
            mokit = mokkiDAO.lataaKaikkiMokit();    //haetaan listaan kaikki mökit
            mokkiBindingSource.DataSource = mokit;  //yhdistää listan datagridview
            dgvMokki.DataSource = mokkiBindingSource;
        }

        //lisätään mökki tietokantaan
        private void btnLisaaMokki_Click(object sender, EventArgs e)
        {
            try
            {
                string alue = cbAlueId.Text;
                string ID = alue[0].ToString();

                //Tehdään mokki-olio, jolle annetaan tiedot lomakkeen textboxeista
                Mokki mokki = new Mokki
                {
                    alue_id = int.Parse(ID),
                    postinro = cbPostinro.Text,
                    mokkinimi = tbMokinNimi2.Text,
                    katuosoite = tbKatuosoite.Text,
                    hinta = double.Parse(tbHinta.Text),
                    kuvaus = tbKuvaus.Text,
                    henkilomaara = int.Parse(tbHenkilomaara.Text),
                    varustelu = tbVarustelu.Text
                };

                if (tarkistaSyotteet() == false)
                    return;

                MokkiDAO mokkiDAO = new MokkiDAO();
                string tulos = mokkiDAO.lisaaMokki(mokki, mokit); //Parametrina äsken tehty mökki-olio, metodissa lisätään uusi mökki ja palauttaa muutettujen rivien määrän
                MessageBox.Show(tulos);
                tyhjennalomake();

                dgvMokki.DataSource = null;
                mokkiBindingSource.DataSource = mokkiDAO.lataaKaikkiMokit();
                dgvMokki.DataSource = mokkiBindingSource;
                mokit = mokkiDAO.lataaKaikkiMokit(); //mokit listan päivitys
            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Tämä kopioi tiedot dgv:stä laatikoihin
        private void btnKopioi_Click(object sender, EventArgs e)
        {
            int rowClicked = dgvMokki.CurrentRow.Index; //rivi mitä klikattiin
            Mokki editMe = mokit[rowClicked];
            cbPostinro.Text = editMe.postinro.ToString();
            tbMokinNimi2.Text = editMe.mokkinimi;
            tbKatuosoite.Text = editMe.katuosoite;
            tbHinta.Text = editMe.hinta.ToString();
            tbKuvaus.Text = editMe.kuvaus;
            tbHenkilomaara.Text = editMe.henkilomaara.ToString();
            tbVarustelu.Text = editMe.varustelu;
            cbAlueId.Text = editMe.alue_id.ToString();
        }

        //mökin päivitys tietokantaan
        private void btnViePaivitys_Click(object sender, EventArgs e)
        {
            int rowClicked = dgvMokki.CurrentRow.Index; //rivi mitä klikattiin
            int mokki_id = (int)dgvMokki.Rows[rowClicked].Cells[0].Value;

            try
            {
                DialogResult result = MessageBox.Show("Päivitetäänkö mökin tiedot? ", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Mokki mokki = new Mokki
                    {
                        alue_id = int.Parse(cbAlueId.Text),
                        postinro = cbPostinro.Text,
                        mokkinimi = tbMokinNimi2.Text,
                        katuosoite = tbKatuosoite.Text,
                        hinta = double.Parse(tbHinta.Text),
                        kuvaus = tbKuvaus.Text,
                        henkilomaara = int.Parse(tbHenkilomaara.Text),
                        varustelu = tbVarustelu.Text
                    };

                    if (tarkistaSyotteet() == false)
                        return;
                    MokkiDAO mokkiDAO = new MokkiDAO();
                    int tulos = mokkiDAO.paivitaMokki(mokki, mokki_id);
                    MessageBox.Show(tulos + " mökki päivitetty.");
                    tyhjennalomake();

                    dgvMokki.DataSource = null;
                    mokkiBindingSource.DataSource = mokkiDAO.lataaKaikkiMokit();
                    dgvMokki.DataSource = mokkiBindingSource;
                    mokit = mokkiDAO.lataaKaikkiMokit(); //mokit listan päivitys
                }
                else if (result == DialogResult.No)
                {
                    tyhjennalomake();
                }
            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Mökin poistaminen

        private void btnPoista_Click(object sender, EventArgs e)
        {
            int rowClicked = dgvMokki.CurrentRow.Index; //rivi mitä klikattiin
            int mokki_id = (int)dgvMokki.Rows[rowClicked].Cells[0].Value;

            try
            {
                DialogResult result = MessageBox.Show("Poistetaanko mökki tunnisteella: " + mokki_id, "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tarkistaSyotteet();
                    MokkiDAO mokkiDAO = new MokkiDAO();
                    int tulos = mokkiDAO.poistaMokki(mokki_id);
                    MessageBox.Show("Poistettu " + tulos + " mökki");
                    tyhjennalomake();

                    dgvMokki.DataSource = null;
                    mokkiBindingSource.DataSource = mokkiDAO.lataaKaikkiMokit();
                    dgvMokki.DataSource = mokkiBindingSource;
                    mokit = mokkiDAO.lataaKaikkiMokit(); //mokit listan päivitys
                }
                else if (result == DialogResult.No)
                {
                    tyhjennalomake();
                }

            }
            catch
            {
                MessageBox.Show("Mökille on tehty varauksia, joten sitä ei voi poistaa järjestelmästä", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool tarkistaSyotteet()
        {
            if (cbPostinro.Text == String.Empty || tbMokinNimi2.Text == String.Empty || tbKatuosoite.Text == String.Empty || tbHinta.Text == String.Empty || tbKuvaus.Text == String.Empty || tbHenkilomaara.Text == String.Empty || tbVarustelu.Text == String.Empty)
            {
                MessageBox.Show("Kaikki tiedot ovat pakollisia.");
                tbMokinNimi2.Focus();
                return false;
            }
            else
                return true;
        }

        private void btnEtsi_Click(object sender, EventArgs e)
        {
            try
            {
                MokkiDAO mokkiDAO = new MokkiDAO();
                mokit = mokkiDAO.etsiMokki(tbEtsi.Text);    //haetaan listaan kaikki mökit
                mokkiBindingSource.DataSource = mokit;  //yhdistää listan datagridview
                dgvMokki.DataSource = mokkiBindingSource;
                tbEtsi.Text = "";
            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnViePaivitys.Enabled = true;
            btnPoista.Enabled = true;
            btnKopioi.Enabled = true;
        }

        //Kun klikataan mäkymästä mökkiä, sille tehdyt varaukset näkyvät alla
        private void dgvMokki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowClicked = dgvMokki.CurrentRow.Index; //rivi mitä klikattiin
            MokkiDAO mokkiDAO = new MokkiDAO();
            mokinvarausBindingSource.DataSource = mokkiDAO.haeMokinVarauksetUsingJoin((int)dgvMokki.Rows[rowClicked].Cells[0].Value);
            dgvMokinVaraukset.DataSource = mokinvarausBindingSource;
            btnKopioi.Enabled = true;
            btnViePaivitys.Enabled = true;
            btnPoista.Enabled = true;

        }

        //Mökin nimi syötteet
        private void tbMokinNimi_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMokinNimi2.Text))
            {
                string input = tbMokinNimi2.Text;
                string output = input.Substring(0, 1).ToUpper() + input.Substring(1);
                tbMokinNimi2.Text = output;
            }
        }

        //Katuosoite syötteet
        private void tbKatuosoite_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKatuosoite.Text))
            {
                string input = tbKatuosoite.Text;
                string output = input.Substring(0, 1).ToUpper() + input.Substring(1);
                tbKatuosoite.Text = output;
            }
        }

        //Postinumeron syötteet
        private void cbPostinro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        
        //Hinta syötteet
        private void tbHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbHinta_Validating(object sender, CancelEventArgs e)
        {

            if (double.Parse(tbHinta.Text) > 2000)
            {
                e.Cancel = true;
                MessageBox.Show("Hinta voi olla max. 2000€/yö", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbHinta.Focus();
            }
        }

        //Henkilomäärä syötteet
        private void tbHenkilomaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void tbHenkilomaara_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbHenkilomaara.Text, out int value) || value > 50)
            {
                e.Cancel = true;
                MessageBox.Show("Henkilomäärän pitää olla väliltä 1-50", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbHenkilomaara.Focus();
            }
        }

        //Kun mökin lisäys, muokkaus tai poisto onnistui/peruutettu
        public void tyhjennalomake()
        {
            cbPostinro.Text = "";
            tbMokinNimi2.Text = "";
            tbKatuosoite.Text = "";
            tbHinta.Text = "";
            tbKuvaus.Text = "";
            tbHenkilomaara.Text = "";
            tbVarustelu.Text = "";
            cbAlueId.Text = "";
        }
    }
}