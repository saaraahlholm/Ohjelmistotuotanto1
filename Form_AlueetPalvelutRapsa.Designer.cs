namespace Mokkiprojekti
{
    partial class Form_AlueetPalvelutRapsa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            aloitusToolStripMenuItem = new ToolStripMenuItem();
            etusivuToolStripMenuItem = new ToolStripMenuItem();
            lopetusToolStripMenuItem = new ToolStripMenuItem();
            varauksetToolStripMenuItem = new ToolStripMenuItem();
            uusivarausToolStripMenuItem = new ToolStripMenuItem();
            hallinoiVarauksiaToolStripMenuItem1 = new ToolStripMenuItem();
            mökkijärjestelmäToolStripMenuItem = new ToolStripMenuItem();
            alueetToolStripMenuItem = new ToolStripMenuItem();
            hallinnoiToolStripMenuItem = new ToolStripMenuItem();
            raportointiToolStripMenuItem = new ToolStripMenuItem();
            mökitToolStripMenuItem = new ToolStripMenuItem();
            asiakasjärjestelmäToolStripMenuItem = new ToolStripMenuItem();
            laskutusToolStripMenuItem = new ToolStripMenuItem();
            apuaToolStripMenuItem = new ToolStripMenuItem();
            ohjeetToolStripMenuItem = new ToolStripMenuItem();
            dgvVaratutmajoitukset = new DataGridView();
            dgvOstetutpalvelut = new DataGridView();
            groupBox1 = new GroupBox();
            btnLataakaikki = new Button();
            cbAlueetrapsa = new ComboBox();
            dtpLahtopvm = new DateTimePicker();
            dtpSaapumispvm = new DateTimePicker();
            btnHaemajoitukset = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVaratutmajoitukset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOstetutpalvelut).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aloitusToolStripMenuItem, varauksetToolStripMenuItem, mökkijärjestelmäToolStripMenuItem, asiakasjärjestelmäToolStripMenuItem, laskutusToolStripMenuItem, apuaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1625, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aloitusToolStripMenuItem
            // 
            aloitusToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { etusivuToolStripMenuItem, lopetusToolStripMenuItem });
            aloitusToolStripMenuItem.Name = "aloitusToolStripMenuItem";
            aloitusToolStripMenuItem.Size = new Size(69, 24);
            aloitusToolStripMenuItem.Text = "Aloitus";
            // 
            // etusivuToolStripMenuItem
            // 
            etusivuToolStripMenuItem.Name = "etusivuToolStripMenuItem";
            etusivuToolStripMenuItem.Size = new Size(144, 26);
            etusivuToolStripMenuItem.Text = "Etusivu";
            etusivuToolStripMenuItem.Click += etusivuToolStripMenuItem_Click_1;
            // 
            // lopetusToolStripMenuItem
            // 
            lopetusToolStripMenuItem.Name = "lopetusToolStripMenuItem";
            lopetusToolStripMenuItem.Size = new Size(144, 26);
            lopetusToolStripMenuItem.Text = "Lopetus";
            lopetusToolStripMenuItem.Click += lopetusToolStripMenuItem_Click_1;
            // 
            // varauksetToolStripMenuItem
            // 
            varauksetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uusivarausToolStripMenuItem, hallinoiVarauksiaToolStripMenuItem1 });
            varauksetToolStripMenuItem.Name = "varauksetToolStripMenuItem";
            varauksetToolStripMenuItem.Size = new Size(139, 24);
            varauksetToolStripMenuItem.Text = "Varausjärjestelmä";
            // 
            // uusivarausToolStripMenuItem
            // 
            uusivarausToolStripMenuItem.Name = "uusivarausToolStripMenuItem";
            uusivarausToolStripMenuItem.Size = new Size(217, 26);
            uusivarausToolStripMenuItem.Text = "Uusi varaus";
            uusivarausToolStripMenuItem.Click += uusivarausToolStripMenuItem_Click_1;
            // 
            // hallinoiVarauksiaToolStripMenuItem1
            // 
            hallinoiVarauksiaToolStripMenuItem1.Name = "hallinoiVarauksiaToolStripMenuItem1";
            hallinoiVarauksiaToolStripMenuItem1.Size = new Size(217, 26);
            hallinoiVarauksiaToolStripMenuItem1.Text = "Hallinnoi varauksia";
            hallinoiVarauksiaToolStripMenuItem1.Click += hallinnoiVarauksiaToolStripMenuItem1_Click_1;
            // 
            // mökkijärjestelmäToolStripMenuItem
            // 
            mökkijärjestelmäToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alueetToolStripMenuItem, mökitToolStripMenuItem });
            mökkijärjestelmäToolStripMenuItem.Name = "mökkijärjestelmäToolStripMenuItem";
            mökkijärjestelmäToolStripMenuItem.Size = new Size(136, 24);
            mökkijärjestelmäToolStripMenuItem.Text = "Mökkijärjestelmä";
            // 
            // alueetToolStripMenuItem
            // 
            alueetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hallinnoiToolStripMenuItem, raportointiToolStripMenuItem });
            alueetToolStripMenuItem.Name = "alueetToolStripMenuItem";
            alueetToolStripMenuItem.Size = new Size(208, 26);
            alueetToolStripMenuItem.Text = "Alueet ja palvelut";
            // 
            // hallinnoiToolStripMenuItem
            // 
            hallinnoiToolStripMenuItem.Name = "hallinnoiToolStripMenuItem";
            hallinnoiToolStripMenuItem.Size = new Size(167, 26);
            hallinnoiToolStripMenuItem.Text = "Hallinnoi";
            hallinnoiToolStripMenuItem.Click += hallinnoiToolStripMenuItem_Click_1;
            // 
            // raportointiToolStripMenuItem
            // 
            raportointiToolStripMenuItem.Name = "raportointiToolStripMenuItem";
            raportointiToolStripMenuItem.Size = new Size(167, 26);
            raportointiToolStripMenuItem.Text = "Raportointi";
            raportointiToolStripMenuItem.Click += raportointiToolStripMenuItem_Click_1;
            // 
            // mökitToolStripMenuItem
            // 
            mökitToolStripMenuItem.Name = "mökitToolStripMenuItem";
            mökitToolStripMenuItem.Size = new Size(208, 26);
            mökitToolStripMenuItem.Text = "Mökit";
            mökitToolStripMenuItem.Click += mökitToolStripMenuItem_Click_1;
            // 
            // asiakasjärjestelmäToolStripMenuItem
            // 
            asiakasjärjestelmäToolStripMenuItem.Name = "asiakasjärjestelmäToolStripMenuItem";
            asiakasjärjestelmäToolStripMenuItem.Size = new Size(145, 24);
            asiakasjärjestelmäToolStripMenuItem.Text = "Asiakasjärjestelmä";
            asiakasjärjestelmäToolStripMenuItem.Click += asiakasjärjestelmäToolStripMenuItem_Click_1;
            // 
            // laskutusToolStripMenuItem
            // 
            laskutusToolStripMenuItem.Name = "laskutusToolStripMenuItem";
            laskutusToolStripMenuItem.Size = new Size(78, 24);
            laskutusToolStripMenuItem.Text = "Laskutus";
            laskutusToolStripMenuItem.Click += laskutusToolStripMenuItem_Click_1;
            // 
            // apuaToolStripMenuItem
            // 
            apuaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ohjeetToolStripMenuItem });
            apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            apuaToolStripMenuItem.Size = new Size(58, 24);
            apuaToolStripMenuItem.Text = "Apua";
            // 
            // ohjeetToolStripMenuItem
            // 
            ohjeetToolStripMenuItem.Name = "ohjeetToolStripMenuItem";
            ohjeetToolStripMenuItem.Size = new Size(136, 26);
            ohjeetToolStripMenuItem.Text = "Ohjeet";
            ohjeetToolStripMenuItem.Click += ohjeetToolStripMenuItem_Click_1;
            // 
            // dgvVaratutmajoitukset
            // 
            dgvVaratutmajoitukset.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaratutmajoitukset.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaratutmajoitukset.Location = new Point(502, 108);
            dgvVaratutmajoitukset.Name = "dgvVaratutmajoitukset";
            dgvVaratutmajoitukset.RowHeadersWidth = 51;
            dgvVaratutmajoitukset.RowTemplate.Height = 29;
            dgvVaratutmajoitukset.Size = new Size(1000, 300);
            dgvVaratutmajoitukset.TabIndex = 0;
            // 
            // dgvOstetutpalvelut
            // 
            dgvOstetutpalvelut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOstetutpalvelut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOstetutpalvelut.Location = new Point(502, 461);
            dgvOstetutpalvelut.Name = "dgvOstetutpalvelut";
            dgvOstetutpalvelut.RowHeadersWidth = 51;
            dgvOstetutpalvelut.RowTemplate.Height = 29;
            dgvOstetutpalvelut.Size = new Size(1000, 300);
            dgvOstetutpalvelut.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLataakaikki);
            groupBox1.Controls.Add(cbAlueetrapsa);
            groupBox1.Controls.Add(dtpLahtopvm);
            groupBox1.Controls.Add(dtpSaapumispvm);
            groupBox1.Controls.Add(btnHaemajoitukset);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(36, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 602);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hae varatut majoitukset ja ostetut palvelut";
            // 
            // btnLataakaikki
            // 
            btnLataakaikki.Location = new Point(110, 489);
            btnLataakaikki.Name = "btnLataakaikki";
            btnLataakaikki.Size = new Size(250, 50);
            btnLataakaikki.TabIndex = 4;
            btnLataakaikki.Text = "Hae palvelut aikavälillä";
            btnLataakaikki.UseVisualStyleBackColor = true;
            btnLataakaikki.Click += btnLataakaikki_Click;
            // 
            // cbAlueetrapsa
            // 
            cbAlueetrapsa.FormattingEnabled = true;
            cbAlueetrapsa.Location = new Point(132, 77);
            cbAlueetrapsa.Name = "cbAlueetrapsa";
            cbAlueetrapsa.Size = new Size(250, 28);
            cbAlueetrapsa.TabIndex = 1;
            // 
            // dtpLahtopvm
            // 
            dtpLahtopvm.Location = new Point(132, 237);
            dtpLahtopvm.Name = "dtpLahtopvm";
            dtpLahtopvm.Size = new Size(250, 27);
            dtpLahtopvm.TabIndex = 3;
            // 
            // dtpSaapumispvm
            // 
            dtpSaapumispvm.Location = new Point(132, 153);
            dtpSaapumispvm.Name = "dtpSaapumispvm";
            dtpSaapumispvm.Size = new Size(250, 27);
            dtpSaapumispvm.TabIndex = 2;
            // 
            // btnHaemajoitukset
            // 
            btnHaemajoitukset.Location = new Point(110, 347);
            btnHaemajoitukset.Name = "btnHaemajoitukset";
            btnHaemajoitukset.Size = new Size(250, 50);
            btnHaemajoitukset.TabIndex = 5;
            btnHaemajoitukset.Text = "Hae majoitukset aikavälillä";
            btnHaemajoitukset.UseVisualStyleBackColor = true;
            btnHaemajoitukset.Click += btnHaemajoitukset_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 242);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 0;
            label5.Text = "Lähtö:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 153);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 0;
            label4.Text = "Saapuminen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 77);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Alue:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(502, 70);
            label2.Name = "label2";
            label2.Size = new Size(169, 23);
            label2.TabIndex = 0;
            label2.Text = "Varatut majoitukset";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(502, 417);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 0;
            label3.Text = "Ostetut palvelut";
            // 
            // Form_AlueetPalvelutRapsa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 953);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(dgvOstetutpalvelut);
            Controls.Add(dgvVaratutmajoitukset);
            Controls.Add(menuStrip1);
            Name = "Form_AlueetPalvelutRapsa";
            Text = "Alueet ja palvelut - raportointi";
            Load += Form_AlueetPalvelutRapsa_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVaratutmajoitukset).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOstetutpalvelut).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aloitusToolStripMenuItem;
        private ToolStripMenuItem etusivuToolStripMenuItem;
        private ToolStripMenuItem lopetusToolStripMenuItem;
        private ToolStripMenuItem varauksetToolStripMenuItem;
        private ToolStripMenuItem uusivarausToolStripMenuItem;
        private ToolStripMenuItem hallinoiVarauksiaToolStripMenuItem1;
        private ToolStripMenuItem mökkijärjestelmäToolStripMenuItem;
        private ToolStripMenuItem alueetToolStripMenuItem;
        private ToolStripMenuItem hallinnoiToolStripMenuItem;
        private ToolStripMenuItem raportointiToolStripMenuItem;
        private ToolStripMenuItem mökitToolStripMenuItem;
        private ToolStripMenuItem asiakasjärjestelmäToolStripMenuItem;
        private ToolStripMenuItem laskutusToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem;
        private ToolStripMenuItem ohjeetToolStripMenuItem;
        private DataGridView dgvVaratutmajoitukset;
        private DataGridView dgvOstetutpalvelut;
        private GroupBox groupBox1;
        private ComboBox cbAlueetrapsa;
        private DateTimePicker dtpLahtopvm;
        private DateTimePicker dtpSaapumispvm;
        private Button btnHaemajoitukset;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLataakaikki;
    }
}