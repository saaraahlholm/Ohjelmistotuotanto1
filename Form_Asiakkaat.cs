using MySql.Data.MySqlClient;
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

namespace Mokkiprojekti
{
    public partial class Form_Asiakkaat : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn;";

        BindingSource asiakkaatbindingSource = new BindingSource();
        BindingSource varauksetbindingSource = new BindingSource();

        List<Asiakas> asiakkaat = new List<Asiakas>();
        public Form_Asiakkaat()
        {
            InitializeComponent();
            btnPoista.Enabled = false;
            BtnKopioiTiedot.Enabled = false;
            btnViePaivitys.Enabled = false;
        }

        //Liikkuminen formilta toiselle
        private void etusivuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Tällä paluu etusivulle. Pitäisikö olla joku "haluatko poistua nykyiseltä sivulta" kysely?
            Form_Aloitus newForm = new Form_Aloitus();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Piilota nykyinen ikkuna
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
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Piilota nykyinen ikkuna
            this.Close();
        }

        private void hallinnoiVarauksiaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form_Varaukset newForm = new Form_Varaukset();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;


            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Piilota nykyinen ikkuna
            this.Close();
        }


        private void hallinnoiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_AlueetPalvelut newForm = new Form_AlueetPalvelut();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Piilota nykyinen ikkuna
            this.Close();
        }

        private void raportointiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_AlueetPalvelutRapsa newForm = new Form_AlueetPalvelutRapsa();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            // Piilota nykyinen ikkuna
            this.Close();
        }


        private void mökitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Mokit newForm = new Form_Mokit();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            this.Close();
        }

        private void asiakasjärjestelmäToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Asiakkaat newForm = new Form_Asiakkaat();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            this.Close();
        }

        private void laskutusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Laskutus newForm = new Form_Laskutus();

            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;

            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            this.Close();
        }

        private void ohjeetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Ohjeet newForm = new Form_Ohjeet();
            newForm.Location = this.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            this.Hide();
            // Näytä uusi ikkuna
            newForm.ShowDialog();
            this.Close();
        }

        private void BtnLataaAsiakkaat_Click(object sender, EventArgs e)
        {
            AsiakasDAO asiakasDao = new AsiakasDAO();

            asiakkaat = asiakasDao.haeAsiakkaat();
            asiakkaatbindingSource.DataSource = asiakkaat;
            dgvAsiakkaat.DataSource = asiakkaatbindingSource;
        }

        private void btnLisaaAsiakas_Click(object sender, EventArgs e)
        {
            try
            {
                //lisätään uusi asiakas tietokantaan
                Asiakas asiakas = new Asiakas
                {
                    postinro = cbPostinumero.Text,
                    etunimi = tbEtunimi.Text,
                    sukunimi = tbSukunimi.Text,
                    lahiosoite = tbLahiosoite.Text,
                    email = tbEmail.Text,
                    puhelinnro = tbPuhelinnumero.Text

                };

                if (tarkistaTiedot() == false)

                    return;

                else
                {
                    if (tarkistaOnkoEmailOlemassa() == false)

                    {
                        MessageBox.Show("Sähköpostiosoite on jo käytössä.");
                        return;
                    }
                    if (tarkistaEmail() == false)
                        return;
                    else
                    {
                        AsiakasDAO ad = new AsiakasDAO();
                        int result = ad.lisaaUusiAsiakas(asiakas);
                        tyhjennaLomake();
                        btnPoista.Enabled = false;
                        btnViePaivitys.Enabled = false;
                        MessageBox.Show(result + " asiakas lisätty.");

                        dgvAsiakkaat.DataSource = null;
                        asiakkaatbindingSource.DataSource = ad.haeAsiakkaat();
                        dgvAsiakkaat.DataSource = asiakkaatbindingSource;
                        asiakkaat = ad.haeAsiakkaat();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tapahtui virhe. Tarkista tiedot.");
            }
        }

        private void dgvAsiakkaat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnKopioiTiedot.Enabled = true;

            DataGridView dataGridView = (DataGridView)sender;

            int clickedRow = dataGridView.CurrentRow.Index; //tarkastetaan, mitä (monettako) riviä klikattiin

            AsiakasDAO asiakasDao = new AsiakasDAO();

            varauksetbindingSource.DataSource = asiakkaat[clickedRow].varaukset;

            dgvAsiakkaanVaraukset.DataSource = varauksetbindingSource;
        }

        private void btnViePaivitys_Click(object sender, EventArgs e)
        {
            DataGridViewRow rivi = dgvAsiakkaat.CurrentRow;

            Asiakas a = new Asiakas
            {
                postinro = cbPostinumero.Text,
                etunimi = tbEtunimi.Text,
                sukunimi = tbSukunimi.Text,
                lahiosoite = tbLahiosoite.Text,
                email = tbEmail.Text,
                puhelinnro = tbPuhelinnumero.Text,
            };


            int rowClicked = dgvAsiakkaat.CurrentRow.Index; //rivi mitä klikattiin
            int asiakas_id = (int)dgvAsiakkaat.Rows[rowClicked].Cells[0].Value;

            DialogResult dr = MessageBox.Show("Päivitetäänkö asiakkaan tiedot tunnisteella: " + asiakas_id, "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool ok = false;
                if (tarkistaTiedot() == false)
                {
                    return;
                }
                else if (tarkistaEmail() == false)
                {
                    return;
                }
                else if (tarkistaOnkoEmailOlemassa() == false) //jos sähköpostiosoite löytyi tietokannasta
                {
                    if (tbEmail.Text != rivi.Cells["email"].Value.ToString()) //sallii tehdä päivityksen, jos muita tietoja, kun email-osoitetta muutetaan
                    {
                        MessageBox.Show("Sähköpostiosoite on jo käytössä.");
                        return;
                    }
                }
                ok = true;
                if (ok == true)
                {
                    AsiakasDAO ad = new AsiakasDAO();
                    int tulos = ad.paivitaAsiakas(a, asiakas_id);
                    tyhjennaLomake();
                    btnPoista.Enabled = false;
                    btnViePaivitys.Enabled = false;
                    MessageBox.Show(tulos + " asiakas päivitetty.");

                    dgvAsiakkaat.DataSource = null;
                    asiakkaatbindingSource.DataSource = ad.haeAsiakkaat();
                    dgvAsiakkaat.DataSource = asiakkaatbindingSource;
                    asiakkaat = ad.haeAsiakkaat();
                }
            }
            else
            {
                tyhjennaLomake();
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            int rowClicked = dgvAsiakkaat.CurrentRow.Index; //rivi mitä klikattiin
            int asiakas_id = (int)dgvAsiakkaat.Rows[rowClicked].Cells[0].Value;
    
            try
            {
                DialogResult dr = MessageBox.Show("Poistetaanko asiakas tunnisteella: " + asiakas_id, "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    AsiakasDAO ad = new AsiakasDAO();
                    int tulos = ad.poistaAsiakas(asiakas_id);
                    tyhjennaLomake();
                    btnPoista.Enabled = false;
                    btnViePaivitys.Enabled = false;
                    MessageBox.Show("Poistettu " + tulos + " asiakas");

                    dgvAsiakkaat.DataSource = null;
                    asiakkaatbindingSource.DataSource = ad.haeAsiakkaat();
                    dgvAsiakkaat.DataSource = asiakkaatbindingSource;
                    asiakkaat = ad.haeAsiakkaat();
                }
                else
                    tyhjennaLomake();
            }
            catch (Exception)
            {
                MessageBox.Show("Asiakasta ei voi poistaa. Tarkista varaukset.");
            }
            
        }
        private void BtnKopioiTiedot_Click(object sender, EventArgs e)
        {
            btnPoista.Enabled = true;
            btnViePaivitys.Enabled = true;
            int clickedRow = dgvAsiakkaat.CurrentRow.Index;

            Asiakas muokattavaAsiakas = asiakkaat[clickedRow];
            cbPostinumero.Text = muokattavaAsiakas.postinro;
            tbEtunimi.Text = muokattavaAsiakas.etunimi;
            tbSukunimi.Text = muokattavaAsiakas.sukunimi;
            tbLahiosoite.Text = muokattavaAsiakas.lahiosoite;
            tbEmail.Text = muokattavaAsiakas.email;
            tbPuhelinnumero.Text = muokattavaAsiakas.puhelinnro;
        }

        private void Form_Asiakkaat_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnPoista.Enabled = false;
            btnViePaivitys.Enabled = false;
            BtnKopioiTiedot.Enabled = false;
            MySqlConnection connection = new MySqlConnection(connectionString);//yhdistää mysql servulle
            connection.Open();
            MySqlCommand postikasky = new MySqlCommand("SELECT postinro FROM posti", connection);
            AutoCompleteStringCollection kokoelma = new AutoCompleteStringCollection();

            using (MySqlDataReader reader = postikasky.ExecuteReader())
            {
                while (reader.Read())
                {
                    kokoelma.Add(reader.GetString(0));
                }

                cbPostinumero.AutoCompleteCustomSource = kokoelma;

            }
            connection.Close();
        }

        private void btnEtsi_Click(object sender, EventArgs e)
        {
            AsiakasDAO asiakasdao = new AsiakasDAO();
            asiakkaat = asiakasdao.etsiAsiakasta(tbEtsiAsiakasta.Text);    //haetaan listaan kaikki asiakkaat
            asiakkaatbindingSource.DataSource = asiakkaat;  //yhdistää listan datagridviewiin
            dgvAsiakkaat.DataSource = asiakkaatbindingSource;
        }

        private void tyhjennaLomake()
        {
            tbEmail.Clear();
            tbEtunimi.Clear();
            tbLahiosoite.Clear();
            cbPostinumero.Text = "";
            tbPuhelinnumero.Clear();
            tbSukunimi.Clear();
        }

        private void tbEtunimi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text != String.Empty)
            {
                string nimi = tb.Text;

                nimi = nimi.Substring(0, 1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower(); //Pakotetaan eka kirjain isoksi

                tb.Text = nimi;
            }
        }
        private bool tarkistaEmail()
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

        private void tbEtunimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }

        private void tbPuhelinnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)45 && e.KeyChar != (char)43)
            {
                e.Handled = true;
            }
        }
        private bool tarkistaTiedot()
        {
            if (tbEmail.Text == String.Empty || tbEtunimi.Text == String.Empty || tbSukunimi.Text == String.Empty || tbLahiosoite.Text == String.Empty || tbPuhelinnumero.Text == String.Empty || cbPostinumero.Text == String.Empty)
            {
                MessageBox.Show("Kaikki tiedot ovat pakollisia.");
                return false;
            }
            else 
                return true;
        }
    }
}
