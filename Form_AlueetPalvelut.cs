using MySql.Data.MySqlClient;
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
    public partial class Form_AlueetPalvelut : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn;";

        BindingSource palveluBindingSource = new BindingSource();
        BindingSource alueBindingSource = new BindingSource();

        List<Alue> alueet = new List<Alue>();
        List<Palvelu> palvelut = new List<Palvelu>();
        public Form_AlueetPalvelut()
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




        private void Form_AlueetPalvelut_Load(object sender, EventArgs e)
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

                cbAlueid.AutoCompleteCustomSource = kokoelma;

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
                    cbAlueid.Items.Add(comboItem);
                }
                if (cbAlueid.Items.Count > 0)
                {
                    cbAlueid.SelectedIndex = 0;
                }
            }
            connection.Close();




        }

        public void tyhjennaPalveluLomake()
        {
            cbAlueid.Text = "";
            tbPalvelunnimi.Text = "";
            tbTyyppi.Text = "";
            tbKuvaus.Text = "";
            tbHinta.Text = "";
            tbAlv.Text = "";
        }


        public void tyhjennaAlueLomake()
        {

            tbAlueennimi.Text = "";
        }

        private void btnLataaalue_Click(object sender, EventArgs e)
        {
            AlueDAO alueDAO = new AlueDAO();
            alueet = alueDAO.lataaKaikkiAlueet();    //haetaan listaan kaikki alueet
            alueBindingSource.DataSource = alueet;  //yhdistää listan datagridview
            dgvAlueet.DataSource = alueBindingSource;
        }

        private void btnLataapalvelu_Click(object sender, EventArgs e)
        {
            PalveluDAO palveluDAO = new PalveluDAO();
            palvelut = palveluDAO.lataaKaikkiPalvelut();    //haetaan listaan kaikki palvelut
            palveluBindingSource.DataSource = palvelut;  //yhdistää listan datagridview
            dgvPalvelut.DataSource = palveluBindingSource;
        }

        private void btnHaealue_Click(object sender, EventArgs e)
        {
            AlueDAO alueDAO = new AlueDAO();

            //Yhdistää aluelistan datagridviewiin
            alueBindingSource.DataSource = alueDAO.etsiAlue(tbHaealue.Text);

            dgvAlueet.DataSource = alueBindingSource;
        }

        private void btnHaepalvelu_Click(object sender, EventArgs e)
        {
            PalveluDAO palveluDAO = new PalveluDAO();

            //Yhdistää palvelulistan datagridviewiin
            palveluBindingSource.DataSource = palveluDAO.etsiPalvelu(tbHaepalvelu.Text);

            dgvPalvelut.DataSource = palveluBindingSource;
        }

        private void btnLisaaalue_Click(object sender, EventArgs e)
        {
            // Lisää uuden aluen databaseen
            Alue alue = new Alue
            {
                nimi = tbAlueennimi.Text,
            };

            if (tarkistaAlueenSyotteet() == false)
                return;

            AlueDAO alueDAO = new AlueDAO();
            int tulos = alueDAO.lisaaAlue(alue, alueet);
            MessageBox.Show(tulos + "Alue lisätty");

            dgvAlueet.DataSource = null;
            alueBindingSource.DataSource = alueDAO.lataaKaikkiAlueet();
            dgvAlueet.DataSource = alueBindingSource;
            alueet = alueDAO.lataaKaikkiAlueet(); //alue listan päivitys

        }

        private void btnLisaapalvelu_Click(object sender, EventArgs e)
        {

            try
            {
                string alue = cbAlueid.Text;
                string ID = alue[0].ToString();

                // Lisää uuden palvelun databaseen
                Palvelu palvelu = new Palvelu
                {
                    alue_id = int.Parse(ID),
                    nimi = tbPalvelunnimi.Text,
                    tyyppi = int.Parse(tbTyyppi.Text),
                    kuvaus = tbKuvaus.Text,
                    hinta = double.Parse(tbHinta.Text),
                    alv = double.Parse(tbAlv.Text),
                };

                if (tarkistaPalvelunSyotteet() == false)
                    return;

                PalveluDAO palveluDAO = new PalveluDAO();
                int result = palveluDAO.lisaaPalvelu(palvelu, palvelut);
                MessageBox.Show(result + "Palvelu lisätty");
                tyhjennaPalveluLomake();

                dgvPalvelut.DataSource = null;
                palveluBindingSource.DataSource = palveluDAO.lataaKaikkiPalvelut();
                dgvPalvelut.DataSource = palveluBindingSource;
                palvelut = palveluDAO.lataaKaikkiPalvelut(); //palvelulistan päivitys
            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMuokkaaaluetta_Click(object sender, EventArgs e)
        {
            int rowClicked = dgvAlueet.CurrentRow.Index; //rivi mitä klikattiin
            int alue_id = (int)dgvAlueet.Rows[rowClicked].Cells[0].Value;

            try
            {
                DialogResult result = MessageBox.Show("Päivitetäänkö alueen tiedot? ", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Alue alue = new Alue
                    {
                        nimi = tbAlueennimi.Text,
                    };

                    if (tarkistaAlueenSyotteet() == false)
                        return;

                    AlueDAO alueDAO = new AlueDAO();
                    int tulos = alueDAO.muokkaaAlue(alue, alue_id);
                    MessageBox.Show(tulos + " alue päivitetty.");
                    tyhjennaAlueLomake();

                    dgvAlueet.DataSource = null;
                    alueBindingSource.DataSource = alueDAO.lataaKaikkiAlueet();
                    dgvAlueet.DataSource = alueBindingSource;
                    alueet = alueDAO.lataaKaikkiAlueet(); //alueet listan päivitys
                }
                else if (result == DialogResult.No)
                {
                    tyhjennaAlueLomake();
                }
            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPoistaalue_Click(object sender, EventArgs e)
        {
            int rowClicked = dgvAlueet.CurrentRow.Index; //rivi mitä klikattiin
            int alue_id = (int)dgvAlueet.Rows[rowClicked].Cells[0].Value;

            try
            {
                DialogResult result = MessageBox.Show("Poistetaanko alue tunnisteella: " + alue_id, "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    AlueDAO alueDAO = new AlueDAO();
                    int tulos = alueDAO.poistaAlue(alue_id);
                    MessageBox.Show("Poistettu " + tulos + " alue");
                    tyhjennaAlueLomake();

                    dgvAlueet.DataSource = null;
                    alueBindingSource.DataSource = alueDAO.lataaKaikkiAlueet();
                    dgvAlueet.DataSource = alueBindingSource;
                    alueet = alueDAO.lataaKaikkiAlueet(); //alueet listan päivitys
                }
                else if (result == DialogResult.No)
                {
                    tyhjennaAlueLomake();
                }

            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKopioipalvelu_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvrivi = dgvPalvelut.CurrentRow; //rivi mitä klikattiin
            
            cbAlueid.Text = dgvrivi.Cells["alue_id"].Value.ToString();
            tbPalvelunnimi.Text = dgvrivi.Cells["nimi"].Value.ToString();
            tbTyyppi.Text = dgvrivi.Cells["tyyppi"].Value.ToString();
            tbKuvaus.Text = dgvrivi.Cells["kuvaus"].Value.ToString();
            tbHinta.Text = dgvrivi.Cells["hinta"].Value.ToString();
            tbAlv.Text = dgvrivi.Cells["alv"].Value.ToString();

        }

        private void btnKopioialue_Click(object sender, EventArgs e)
        {
            DataGridViewRow  dgvrivi = dgvAlueet.CurrentRow; //rivi mitä klikattiin
           
            tbAlueennimi.Text = dgvrivi.Cells["nimi"].Value.ToString();
        }

        private void btnPoistapalvelu_Click(object sender, EventArgs e)
        {
            int rowClicked = dgvPalvelut.CurrentRow.Index; //rivi mitä klikattiin
            int palvelu_id = (int)dgvPalvelut.Rows[rowClicked].Cells[0].Value;

            try
            {
                DialogResult result = MessageBox.Show("Poistetaanko palvelu tunnisteella: " + palvelu_id, "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    PalveluDAO palveluDAO = new PalveluDAO();
                    int tulos = palveluDAO.poistaPalvelu(palvelu_id);
                    MessageBox.Show("Poistettu " + tulos + " palvelu");
                    tyhjennaPalveluLomake();

                    dgvPalvelut.DataSource = null;
                    palveluBindingSource.DataSource = palveluDAO.lataaKaikkiPalvelut();
                    dgvPalvelut.DataSource = palveluBindingSource;
                    palvelut = palveluDAO.lataaKaikkiPalvelut(); //palvelu listan päivitys
                }
                else if (result == DialogResult.No)
                {
                    tyhjennaPalveluLomake();
                }

            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMuokkaapalvelua_Click(object sender, EventArgs e)
        {
            int rowClicked = dgvPalvelut.CurrentRow.Index; //rivi mitä klikattiin
            int palvelu_id = (int)dgvPalvelut.Rows[rowClicked].Cells[0].Value;

            try
            {
                DialogResult result = MessageBox.Show("Päivitetäänkö palvelun tiedot? ", "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Palvelu palvelu = new Palvelu
                    {
                        alue_id = int.Parse(cbAlueid.Text),
                        nimi = tbPalvelunnimi.Text,
                        tyyppi = int.Parse(tbTyyppi.Text),
                        kuvaus = tbKuvaus.Text,
                        hinta = double.Parse(tbHinta.Text),
                        alv = double.Parse(tbAlv.Text),
                    };

                    if (tarkistaPalvelunSyotteet() == false)
                        return;

                    PalveluDAO palveluDAO = new PalveluDAO();
                    int tulos = palveluDAO.muokkaaPalvelu(palvelu, palvelu_id);
                    MessageBox.Show(tulos + " palvelu päivitetty.");
                    tyhjennaAlueLomake();

                    dgvPalvelut.DataSource = null;
                    palveluBindingSource.DataSource = palveluDAO.lataaKaikkiPalvelut();
                    dgvPalvelut.DataSource = palveluBindingSource;
                    palvelut = palveluDAO.lataaKaikkiPalvelut(); //palvelu listan päivitys
                }
                else if (result == DialogResult.No)
                {
                    tyhjennaPalveluLomake();
                }
            }
            catch
            {
                MessageBox.Show("Tapahtui virhe! Tarkista tiedot tai tietokantayhteys", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool tarkistaPalvelunSyotteet()
        {
            if (cbAlueid.Text == String.Empty || tbPalvelunnimi.Text == String.Empty || tbTyyppi.Text == String.Empty || tbKuvaus.Text == String.Empty || tbHinta.Text == String.Empty || tbAlv.Text == String.Empty)
            {
                MessageBox.Show("Kaikki tiedot ovat pakollisia.");
                tbPalvelunnimi.Focus();
                return false;
            }
            else
                return true;
        }

        private bool tarkistaAlueenSyotteet()
        {
            if (tbAlueennimi.Text == String.Empty)
            {
                MessageBox.Show("Kaikki tiedot ovat pakollisia.");
                tbAlueennimi.Focus();
                return false;
            }
            else
                return true;
        }

        private void tbAlueennimi_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbAlueennimi.Text))
            {
                string input = tbAlueennimi.Text;
                string output = input.Substring(0, 1).ToUpper() + input.Substring(1);
                tbAlueennimi.Text = output;
            }
        }

        private void tbPalvelunnimi_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPalvelunnimi.Text))
            {
                string input = tbPalvelunnimi.Text;
                string output = input.Substring(0, 1).ToUpper() + input.Substring(1);
                tbPalvelunnimi.Text = output;
            }
        }

        private void tbKuvaus_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbKuvaus.Text))
            {
                string input = tbKuvaus.Text;
                string output = input.Substring(0, 1).ToUpper() + input.Substring(1);
                tbKuvaus.Text = output;
            }
        }

        private void tbTyyppi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbAlv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
