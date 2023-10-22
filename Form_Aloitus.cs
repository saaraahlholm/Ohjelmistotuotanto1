namespace Mokkiprojekti
{
    public partial class Form_Aloitus : Form
    {

        public Form_Aloitus()
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

        private void Form_Aloitus_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}