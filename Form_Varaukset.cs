using Google.Protobuf.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkiprojekti
{
    public partial class Form_Varaukset : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=vn;";
        BindingSource varauksetBindingSource = new BindingSource();
        List<JObject> jvaraukset = new List<JObject>();
        List<JObject> palvelut = new List<JObject>();
        public Form_Varaukset()
        {
            InitializeComponent();
        }

        //Liikkuminen formilta toiselle
        private void etusivuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
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

        private void Form_Varaukset_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnKopioiTiedot.Enabled = false;
            btnViePaivitys.Enabled = false;
            btnPoista.Enabled = false;
            dtpSaapuminen.MinDate = DateTime.Today;
        }

        private void BtnLataaVaraukset_Click(object sender, EventArgs e)
        {
            VaraustenHallintaDAO vhd  = new VaraustenHallintaDAO();

            jvaraukset = vhd.lataaVaraukset(); //haetaan tietokannasta kaikki varaukset
            varauksetBindingSource.DataSource = jvaraukset;
            dgvVaraukset.DataSource = varauksetBindingSource; //näytetään ne datagridviewissä
        }

        private void BtnKopioiTiedot_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvVaraukset.CurrentRow;

                btnPoista.Enabled = true;
                btnViePaivitys.Enabled = true;
                lblTahanAsiakasID.Visible = true;
                lblTahanVarausID.Visible = true;
                lblTahanMokkiID.Visible = true;
                lblTahanEtunimi.Visible = true;
                lblTahanSukunimi.Visible = true;
                lblTahanEmail.Visible = true;

                lblTahanVarausID.Text = row.Cells["varaus_id"].Value.ToString(); //kopioidaan tiedot datagridviewistä klikatun solun perusteella
                lblTahanAsiakasID.Text = row.Cells["asiakas_id"].Value.ToString();
                lblTahanMokkiID.Text = row.Cells["mokki_mokki_id"].Value.ToString();
                lblTahanEtunimi.Text = row.Cells["etunimi"].Value.ToString();
                lblTahanSukunimi.Text = row.Cells["sukunimi"].Value.ToString();
                lblTahanEmail.Text = row.Cells["email"].Value.ToString();
                tbPalveluidenlkm.Text = row.Cells["lkm"].Value.ToString();

                string dateValueString = row.Cells["varattu_alkupvm"].Value.ToString(); 
                                                                                        // Muunnetaan string-muotoinen päivämäärä DateTime-muotoon
                DateTime dateValue = DateTime.ParseExact(dateValueString, "d.M.yyyy H.mm.ss", CultureInfo.InvariantCulture);

                // Asetetaan päivämäärä DateTimePickeriin
                dtpSaapuminen.Value = dateValue;

                string dateValueString2 = row.Cells["varattu_loppupvm"].Value.ToString(); 
                                                                                          // Muunnetaan string-muotoinen päivämäärä DateTime-muotoon
                DateTime dateValue2 = DateTime.ParseExact(dateValueString2, "d.M.yyyy H.mm.ss", CultureInfo.InvariantCulture);

                // Asetetaan päivämäärä DateTimePickeriin
                dtpLahto.Value = dateValue2;

                VaraustenHallintaDAO vhd = new VaraustenHallintaDAO();
                int rowClicked = dgvVaraukset.CurrentRow.Index;
                palvelut = vhd.etsiPalvelut(row.Cells["alue_id"].Value.ToString());
                cbPalvelu.DataSource = palvelut;
                cbPalvelu.ValueMember = "nimi";
                cbPalvelu.Text = row.Cells["nimi"].Value.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Tapahtui virhe.");
            }
        }

        private void btnViePaivitys_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvVaraukset.CurrentRow;
                string dateValueString = row.Cells["varattu_alkupvm"].Value.ToString();
            // Muunnetaan string-muotoinen päivämäärä DateTime-muotoo
                DateTime dateValue = DateTime.ParseExact(dateValueString, "d.M.yyyy H.mm.ss", CultureInfo.InvariantCulture);
            
            if (tarkistaVaraus() == false)
                {
                    return;
                }
                else
                {
                    if ((dateValue - DateTime.Today).Days > 2) //varausta voidaan muokata, jos siihen on enemmän, kuin 2 vrk aikaa
                    {
                        VaraustenHallintaDAO vhd = new VaraustenHallintaDAO();

                        Varaus v = new Varaus()
                        {
                            varattu_alkupvm = dtpSaapuminen.Value.Date.AddHours(0).AddMinutes(00).AddSeconds(00),
                            varattu_loppupvm = dtpLahto.Value.Date.AddHours(0).AddMinutes(00).AddSeconds(00)
                        };
                        
                        Palvelu p = new Palvelu()
                        {
                            palvelu_id = vhd.haePalvelunID(cbPalvelu.Text)
                        };
                        VarauksenPalvelut vp = new VarauksenPalvelut()
                        {
                            lkm = Convert.ToInt32(tbPalveluidenlkm.Text)
                        };

                        int rowClicked = dgvVaraukset.CurrentRow.Index; //rivi mitä klikattiin
                        int varaus_id = Convert.ToInt32(dgvVaraukset.Rows[rowClicked].Cells[0].Value);

                        if (row.Cells["palvelu_id"].Value.ToString() == null || row.Cells["palvelu_id"].Value.ToString() == "")
                        {
                            vp.varaus_id = varaus_id;
                            vp.palvelu_id = vhd.haePalvelunID(cbPalvelu.Text);
                            vhd.lisaaPalvelu(vp);
                        }

                        int tulos = vhd.paivitaVaraus(v, varaus_id, p.palvelu_id, vp.lkm);

                        
                        lblTahanAsiakasID.Visible = false;
                        lblTahanEmail.Visible = false;
                        lblTahanVarausID.Visible = false;
                        lblTahanMokkiID.Visible = false;
                        lblTahanEtunimi.Visible = false;
                        lblTahanSukunimi.Visible = false;
                        cbPalvelu.ValueMember = "";
                        MessageBox.Show("Varaus päivitetty.");

                        dgvVaraukset.DataSource = null; //päivitetään myös dgv:n tiedot
                        varauksetBindingSource.DataSource = vhd.lataaVaraukset();
                        dgvVaraukset.DataSource = varauksetBindingSource;
                    }
                    else
                    {
                        lblTahanAsiakasID.Visible = false;
                        lblTahanEmail.Visible = false;
                        lblTahanVarausID.Visible = false;
                        lblTahanMokkiID.Visible = false;
                        lblTahanEtunimi.Visible = false;
                        lblTahanSukunimi.Visible = false;
                        MessageBox.Show("Varausta ei voi enää muokata.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tapahtui virhe.");
            }
        }
           
        private void btnPoista_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvVaraukset.CurrentRow;
                string dateValueString = row.Cells["varattu_alkupvm"].Value.ToString();
                // Muunnetaan string-muotoinen päivämäärä DateTime-muotoon
                DateTime dateValue = DateTime.ParseExact(dateValueString, "d.M.yyyy H.mm.ss", CultureInfo.InvariantCulture);
                if ((dateValue - DateTime.Today).Days > 2)
                {
                    int rowClicked = dgvVaraukset.CurrentRow.Index; //rivi mitä klikattiin
                    int varaus_id = Convert.ToInt32(dgvVaraukset.Rows[rowClicked].Cells[0].Value);
                    MessageBox.Show("Poistetaan varaus tunnisteella: " + varaus_id);

                    VaraustenHallintaDAO vhd = new VaraustenHallintaDAO();
                    int tulos = vhd.poistaVaraus(varaus_id);
                    lblTahanAsiakasID.Visible = false;
                    lblTahanEmail.Visible = false;
                    lblTahanVarausID.Visible = false;
                    lblTahanMokkiID.Visible = false;
                    lblTahanEtunimi.Visible = false;
                    lblTahanSukunimi.Visible = false;
                    MessageBox.Show("Varaus poistettu");

                    dgvVaraukset.DataSource = null;
                    varauksetBindingSource.DataSource = vhd.lataaVaraukset();
                    dgvVaraukset.DataSource = varauksetBindingSource;
                    jvaraukset = vhd.lataaVaraukset();
                }
                else
                {
                    MessageBox.Show("Varausta ei voi enää poistaa.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tapahtui virhe.");
            }    
        }
        private void dgvVaraukset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnKopioiTiedot.Enabled = true;
        }

        private void btnEtsi_Click(object sender, EventArgs e)
        {
            VaraustenHallintaDAO vhd = new VaraustenHallintaDAO();
            varauksetBindingSource.DataSource = vhd.haeVarausta(tbEtsiVarausta.Text);
            dgvVaraukset.DataSource = varauksetBindingSource;
        }
        private bool tarkistaVaraus() //tarkistaa, onko ks. ajankohdalle tehty jo varaus ks. mökkiin
        {
            int mokki_id = int.Parse(lblTahanMokkiID.Text);
            DateTime varattu_alkupvm = dtpSaapuminen.Value;
            DateTime varattu_loppupvm = dtpLahto.Value;
            DataGridViewRow row = dgvVaraukset.CurrentRow;
            string dateValueString = row.Cells["varattu_alkupvm"].Value.ToString();
            // Muunnetaan string-muotoinen päivämäärä DateTime-muotoon
            string dateValueString2 = row.Cells["varattu_loppupvm"].Value.ToString();

            MySqlConnection connection = new MySqlConnection(connectionString);//yhdistää mysql servulle
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM varaus WHERE mokki_mokki_id = @mokki_mokki_id AND ((varattu_alkupvm < @varattu_loppupvm) AND (varattu_loppupvm > @varattu_alkupvm))", connection);
                command.Parameters.AddWithValue("@mokki_mokki_id", mokki_id);
                command.Parameters.AddWithValue("@varattu_alkupvm", varattu_alkupvm);
                command.Parameters.AddWithValue("@varattu_loppupvm", varattu_loppupvm);
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0 && dtpSaapuminen.Value != Convert.ToDateTime(dateValueString) && dtpLahto.Value != Convert.ToDateTime(dateValueString2))
                {
                        MessageBox.Show("Mökki varattu kyseiselle ajankohdalle.");
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
        private void dtpSaapuminen_ValueChanged(object sender, EventArgs e)
        {
            dtpLahto.MinDate = dtpSaapuminen.Value.AddDays(1);
   
        }
    }
}
