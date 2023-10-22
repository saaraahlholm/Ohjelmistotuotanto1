using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Action;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Security.Policy;
using System.Diagnostics;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Pdfa;
using System.Globalization;

namespace Mokkiprojekti
{
    public partial class Form_Laskutus : Form
    {
        public Form_Laskutus()
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

        private void Form_Laskutus_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void tbSumma_TextChanged(object sender, EventArgs e)
        {
            if (tbSumma.Text == String.Empty)
            {
                tbSumma.Text = "0";
            }
            else if (tbALV.Text == String.Empty)
            {

                tbALV.Text = "0";
            }
            else
            {
                double sumYht = double.Parse(tbSumma.Text) * ((double.Parse(tbALV.Text) / 100) + 1);
                lblYhteensa.Text = sumYht.ToString();
            }


        }
        List<Laskutettavat> laskutettavat = new List<Laskutettavat>();
        List<JObject> haeLaskutettavat = new List<JObject>();
        List<Laskutus> haeLaskuList = new List<Laskutus>();
        BindingSource laskuBs1 = new BindingSource();
        BindingSource laskuBs2 = new BindingSource(); //Pitääkö näitä olla näin monta, kun Varaus-näkymä tulloo näkyviin kaksi kertaa dgv1 ja dgv2 


        //private void btnLataaKaikki_Click(object sender, EventArgs e)
        //{

        //    //LaskutusDAO laskuDao = new LaskutusDAO();
        //    //laskutettavat = laskuDao.hankiVarausTiedot();    //haetaan listaan kaikki näkymät
        //    //laskuBs1.DataSource = laskutettavat;            //yhdistää listan datagridview
        //    //dgvLasku1.DataSource =laskuBs1;
        //}

        private void btnHaeVaraus_Click(object sender, EventArgs e)
        {
            LaskutusDAO laskuDao = new LaskutusDAO();
            haeLaskutettavat = laskuDao.haeLaskutetut(tbHae1.Text);      //haetaan listaan kaikki varaukset
            laskuBs1.DataSource = haeLaskutettavat;                     //yhdistää listan datagridview
            dgvLasku1.DataSource = laskuBs1;

        }

        private void button1_Click(object sender, EventArgs e)
        {       //Laskuta-nappi, joka lisää tiedot laskutus kenttiin.

            //int rowClicked = dgvLasku1.CurrentRow.Index; //rivi mitä klikattiin
            //Laskutettavat editMe = laskutettavat[rowClicked];


            //lblVarausID.Text = editMe.varaus_id.ToString();
            //tbSumma.Text = editMe.kokhinta.ToString();
            //lblErapva.Text = editMe.loppupvm.AddDays(14).ToString();

            btnLuoPDF.Enabled = true;
            btnLisaaLasku.Enabled = true;

            DataGridViewRow dataGridViewRivi = dgvLasku1.CurrentRow;

            lblVarausID.Text = dataGridViewRivi.Cells["varaus_id"].Value.ToString();

            tbSumma.Text = dataGridViewRivi.Cells["Kok.hinta"].Value.ToString(); //muuta kolumnien nimeä saman nimisiksi

            string erapva = dataGridViewRivi.Cells["loppupvm"].Value.ToString();

            DateTime dateValue = DateTime.ParseExact(erapva, "d.M.yyyy H.mm.ss", CultureInfo.InvariantCulture);
            dateValue = dateValue.AddDays(14);
            lblErapva.Text = dateValue.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {   //Lataa Laskut-nappi
            LaskutusDAO laskuDao = new LaskutusDAO();
            haeLaskuList = laskuDao.hankiLaskut();    //haetaan listaan kaikki laskut
            laskuBs2.DataSource = haeLaskuList;  //yhdistää listan datagridview
            dgvLasku2.DataSource = laskuBs2;



        }

        private void btnLisaaLasku_Click(object sender, EventArgs e)
        {
            btnPoistaLasku.Enabled = true;
            // DateTime loppupvm =dgvLasku1.   //Yritystä liittää loppupäivämäärä eräpäivään???
            //DateTime epv = loppupvm.AddDays(14);
            Laskutus laskutus1 = new Laskutus
            {

                varaus_id = int.Parse(lblVarausID.Text),
                summa = double.Parse(tbSumma.Text),
                alv = double.Parse(tbALV.Text),
                erapva = DateTime.Parse(lblErapva.Text)

            };
            if (rbMaksamaton.Checked == true)
            {
                laskutus1.tila = 0;

            }
            else if (rbMaksettu.Checked == true)
            {
                laskutus1.tila = 1;
            }
            else if(rbMyohassa.Checked==true)
            {   //Tähän ominaisuus, joka saa tilan muuttumaan 2:een jos lasku on myöhässä
                laskutus1.tila = 2;

            }
            LaskutusDAO laskuDao = new LaskutusDAO();
            int tulos = laskuDao.lisaa1Lasku(laskutus1);    //haetaan listaan kaikki laskut
            //laskuBs2.DataSource = laskutettavat;            //yhdistää listan datagridview

            MessageBox.Show(tulos + " kappaletta laskuja lisättiin!");

            dgvLasku2.DataSource = null;
            laskuBs2.DataSource = laskuDao.hankiLaskut();
            dgvLasku2.DataSource = laskuBs2;
            haeLaskuList = laskuDao.hankiLaskut();


        }

        private void btnPoistaLasku_Click(object sender, EventArgs e)
        {
            //Tähän vielä ominaisuus, joka poistaa laskuja
            int rowClicked = dgvLasku2.CurrentRow.Index; //rivi mitä klikattiin
            int lasku_id = (int)dgvLasku2.Rows[rowClicked].Cells[0].Value;

            DialogResult result = MessageBox.Show("Poistetaanko lasku tunnisteella: " + lasku_id, "Vahvistus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                btnLisaaLasku.Enabled = false;
                // tarkistaSyotteet();
                LaskutusDAO laskutusDAO = new LaskutusDAO();
                int tulos = laskutusDAO.poistaLasku(lasku_id);
                MessageBox.Show("Poistettu " + tulos + " lasku!");
                tyhjennaLaskuLomake();

                dgvLasku2.DataSource = null;
                laskuBs2.DataSource = laskutusDAO.hankiLaskut();
                dgvLasku2.DataSource = laskuBs2;
                haeLaskuList = laskutusDAO.hankiLaskut(); //laskut listan päivitys
            }
            else if (result == DialogResult.No)
            {
                tyhjennaLaskuLomake();
            }

        }



        private void dgvLasku2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnLisaaLasku.Enabled = true;
            btnLuoPDF.Enabled = false;
            int rowClicked = dgvLasku2.CurrentRow.Index; //rivi mitä klikattiin
            Laskutus editMe = haeLaskuList[rowClicked];
            

            lblVarausID.Text = editMe.varaus_id.ToString();
            tbSumma.Text = editMe.summa.ToString();
            tbALV.Text = editMe.alv.ToString();
            lblErapva.Text = editMe.erapva.ToString();
            if (editMe.tila == 0)
            {
                rbMaksamaton.Checked = true;
            }
            if (editMe.tila == 1)
            {

                rbMaksettu.Checked = true;
            }
            if (DateTime.Now > DateTime.Parse(lblErapva.Text) && editMe.tila != 1)
            {

                rbMyohassa.Checked = true;
            }
        }

        public void tyhjennaLaskuLomake()
        {
            lblVarausID.Text = "";
            tbSumma.Text = "";
            tbALV.Text = "";
            lblYhteensa.Text = "0";
            lblErapva.Text = "0";

        }
        private void OpenPdfFile(string fileName)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
                processStartInfo.FileName = fileName;
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "open";
                System.Diagnostics.Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa PDF-tiedostoa: " + ex.Message);
            }
        }

        private void btnLuoPDF_Click(object sender, EventArgs e)
        {

            string dir = @"C:\TEMP";
            // Jos kansiota ei ole, se luodaan tässä
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            DataGridViewRow dataGridViewRivi = dgvLasku1.CurrentRow;

            string etunimi = dataGridViewRivi.Cells["etunimi"].Value.ToString();
            string sukunimi = dataGridViewRivi.Cells["sukunimi"].Value.ToString();
            string moknimi = dataGridViewRivi.Cells["mokkinimi"].Value.ToString();
            string reissuYot = dataGridViewRivi.Cells["Reissuaika"].Value.ToString();
            string hintaPerYo = dataGridViewRivi.Cells["hinta/yo"].Value.ToString();
            string palvnimi = dataGridViewRivi.Cells["nimi"].Value.ToString();
            string palvhinta = dataGridViewRivi.Cells["palvhinta"].Value.ToString();
            string palvmaara = dataGridViewRivi.Cells["palvmaara"].Value.ToString();
            string kokhinta = dataGridViewRivi.Cells["Kok.Hinta"].Value.ToString();


            string email = dataGridViewRivi.Cells["email"].Value.ToString(); //muuta kolumnien nimeä saman nimisiksi


            string luku = lblVarausID.Text;
            // Luodaan PDF-tiedosto
            PdfWriter writer = new PdfWriter("C:\\TEMP\\Lasku" + luku + ".pdf");
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document document = new Document(pdfDoc);

            // Lisätään laskun tiedot PDF-dokumenttiin
            document.Add(new Paragraph("Laskun numero: " + luku));
            document.Add(new Paragraph("Maksajan nimi: " + etunimi + " " + sukunimi));
            document.Add(new Paragraph("Sähköpostiosoite: " + email));
            document.Add(new Paragraph("________________________________________________"));
            document.Add(new Paragraph("Mökki: " + moknimi));
            document.Add(new Paragraph("Hinta: " + hintaPerYo + " €/vrk, vuorokaudet: " + reissuYot));
            document.Add(new Paragraph("Palvelut: " + palvnimi + " Hinta: " + palvhinta + " Määrä: " + palvmaara));
            document.Add(new Paragraph("________________________________________________"));
            document.Add(new Paragraph("Hinta ilman alvia: " + kokhinta));
            document.Add(new Paragraph("ALV: " + tbALV.Text));
            document.Add(new Paragraph("MAKSETTAVA YHT: " + lblYhteensa.Text));
            document.Add(new Paragraph("Eräpäivä: " + lblErapva.Text));
            document.Add(new Paragraph("________________________________________________"));
            document.Add(new Paragraph("Saaja: Village Newbies"));
            document.Add(new Paragraph("Tilinumero: FI32 12345899376"));
            document.Add(new Paragraph("Viesti: Kirjoita viestikenttään oma nimesi ja laskun numero."));
            document.Add(new Paragraph("________________________________________________"));

            // Suljetaan PDF-dokumentti
            document.Close();
            OpenPdfFile("C:\\TEMP\\Lasku" + luku + ".pdf");




        }
        //Varmistusta sille ettei syötä vääränlaisia arvoja.
        private void tbSumma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void tbALV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }

        }

        private void dgvLasku1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
        }

        private void dgvLasku2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPoistaLasku.Enabled = true;
        }
    }
}
