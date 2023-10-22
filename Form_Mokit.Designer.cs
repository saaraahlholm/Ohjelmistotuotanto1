using System.Windows.Forms;

namespace Mokkiprojekti
{
    partial class Form_Mokit
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aloitusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etusivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusivarausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallinoiVarauksiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mökkijärjestelmäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alueetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallinnoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportointiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mökitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asiakasjärjestelmäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laskutusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ohjeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMokki = new System.Windows.Forms.GroupBox();
            this.cbAlueId = new System.Windows.Forms.ComboBox();
            this.cbPostinro = new System.Windows.Forms.ComboBox();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnViePaivitys = new System.Windows.Forms.Button();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblKatuosoite = new System.Windows.Forms.Label();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.lblHinta = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.lblMokinNimi = new System.Windows.Forms.Label();
            this.tbMokinNimi2 = new System.Windows.Forms.TextBox();
            this.btnLisaaMokki = new System.Windows.Forms.Button();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.lblAlue = new System.Windows.Forms.Label();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.lblPostinro = new System.Windows.Forms.Label();
            this.lblMokinVaraukset = new System.Windows.Forms.Label();
            this.dgvMokinVaraukset = new System.Windows.Forms.DataGridView();
            this.btnKopioi = new System.Windows.Forms.Button();
            this.dgvMokki = new System.Windows.Forms.DataGridView();
            this.btnLataaKaikki = new System.Windows.Forms.Button();
            this.btnEtsi = new System.Windows.Forms.Button();
            this.tbEtsi = new System.Windows.Forms.TextBox();
            this.lblPakollinenTieto = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbMokki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokinVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aloitusToolStripMenuItem,
            this.varauksetToolStripMenuItem,
            this.mökkijärjestelmäToolStripMenuItem,
            this.asiakasjärjestelmäToolStripMenuItem,
            this.laskutusToolStripMenuItem,
            this.apuaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1625, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aloitusToolStripMenuItem
            // 
            this.aloitusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etusivuToolStripMenuItem,
            this.lopetusToolStripMenuItem});
            this.aloitusToolStripMenuItem.Name = "aloitusToolStripMenuItem";
            this.aloitusToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.aloitusToolStripMenuItem.Text = "Aloitus";
            // 
            // etusivuToolStripMenuItem
            // 
            this.etusivuToolStripMenuItem.Name = "etusivuToolStripMenuItem";
            this.etusivuToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.etusivuToolStripMenuItem.Text = "Etusivu";
            this.etusivuToolStripMenuItem.Click += new System.EventHandler(this.etusivuToolStripMenuItem_Click_1);
            // 
            // lopetusToolStripMenuItem
            // 
            this.lopetusToolStripMenuItem.Name = "lopetusToolStripMenuItem";
            this.lopetusToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.lopetusToolStripMenuItem.Text = "Lopetus";
            this.lopetusToolStripMenuItem.Click += new System.EventHandler(this.lopetusToolStripMenuItem_Click_1);
            // 
            // varauksetToolStripMenuItem
            // 
            this.varauksetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusivarausToolStripMenuItem,
            this.hallinoiVarauksiaToolStripMenuItem1});
            this.varauksetToolStripMenuItem.Name = "varauksetToolStripMenuItem";
            this.varauksetToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.varauksetToolStripMenuItem.Text = "Varausjärjestelmä";
            // 
            // uusivarausToolStripMenuItem
            // 
            this.uusivarausToolStripMenuItem.Name = "uusivarausToolStripMenuItem";
            this.uusivarausToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.uusivarausToolStripMenuItem.Text = "Uusi varaus";
            this.uusivarausToolStripMenuItem.Click += new System.EventHandler(this.uusivarausToolStripMenuItem_Click_1);
            // 
            // hallinoiVarauksiaToolStripMenuItem1
            // 
            this.hallinoiVarauksiaToolStripMenuItem1.Name = "hallinoiVarauksiaToolStripMenuItem1";
            this.hallinoiVarauksiaToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.hallinoiVarauksiaToolStripMenuItem1.Text = "Hallinnoi varauksia";
            this.hallinoiVarauksiaToolStripMenuItem1.Click += new System.EventHandler(this.hallinnoiVarauksiaToolStripMenuItem1_Click_1);
            // 
            // mökkijärjestelmäToolStripMenuItem
            // 
            this.mökkijärjestelmäToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alueetToolStripMenuItem,
            this.mökitToolStripMenuItem});
            this.mökkijärjestelmäToolStripMenuItem.Name = "mökkijärjestelmäToolStripMenuItem";
            this.mökkijärjestelmäToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.mökkijärjestelmäToolStripMenuItem.Text = "Mökkijärjestelmä";
            // 
            // alueetToolStripMenuItem
            // 
            this.alueetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallinnoiToolStripMenuItem,
            this.raportointiToolStripMenuItem});
            this.alueetToolStripMenuItem.Name = "alueetToolStripMenuItem";
            this.alueetToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.alueetToolStripMenuItem.Text = "Alueet ja palvelut";
            // 
            // hallinnoiToolStripMenuItem
            // 
            this.hallinnoiToolStripMenuItem.Name = "hallinnoiToolStripMenuItem";
            this.hallinnoiToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.hallinnoiToolStripMenuItem.Text = "Hallinnoi";
            this.hallinnoiToolStripMenuItem.Click += new System.EventHandler(this.hallinnoiToolStripMenuItem_Click_1);
            // 
            // raportointiToolStripMenuItem
            // 
            this.raportointiToolStripMenuItem.Name = "raportointiToolStripMenuItem";
            this.raportointiToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.raportointiToolStripMenuItem.Text = "Raportointi";
            this.raportointiToolStripMenuItem.Click += new System.EventHandler(this.raportointiToolStripMenuItem_Click_1);
            // 
            // mökitToolStripMenuItem
            // 
            this.mökitToolStripMenuItem.Name = "mökitToolStripMenuItem";
            this.mökitToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.mökitToolStripMenuItem.Text = "Mökit";
            this.mökitToolStripMenuItem.Click += new System.EventHandler(this.mökitToolStripMenuItem_Click_1);
            // 
            // asiakasjärjestelmäToolStripMenuItem
            // 
            this.asiakasjärjestelmäToolStripMenuItem.Name = "asiakasjärjestelmäToolStripMenuItem";
            this.asiakasjärjestelmäToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.asiakasjärjestelmäToolStripMenuItem.Text = "Asiakasjärjestelmä";
            this.asiakasjärjestelmäToolStripMenuItem.Click += new System.EventHandler(this.asiakasjärjestelmäToolStripMenuItem_Click_1);
            // 
            // laskutusToolStripMenuItem
            // 
            this.laskutusToolStripMenuItem.Name = "laskutusToolStripMenuItem";
            this.laskutusToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.laskutusToolStripMenuItem.Text = "Laskutus";
            this.laskutusToolStripMenuItem.Click += new System.EventHandler(this.laskutusToolStripMenuItem_Click_1);
            // 
            // apuaToolStripMenuItem
            // 
            this.apuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ohjeetToolStripMenuItem});
            this.apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            this.apuaToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.apuaToolStripMenuItem.Text = "Apua";
            // 
            // ohjeetToolStripMenuItem
            // 
            this.ohjeetToolStripMenuItem.Name = "ohjeetToolStripMenuItem";
            this.ohjeetToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.ohjeetToolStripMenuItem.Text = "Ohjeet";
            this.ohjeetToolStripMenuItem.Click += new System.EventHandler(this.ohjeetToolStripMenuItem_Click_1);
            // 
            // gbMokki
            // 
            this.gbMokki.Controls.Add(this.lblPakollinenTieto);
            this.gbMokki.Controls.Add(this.cbAlueId);
            this.gbMokki.Controls.Add(this.cbPostinro);
            this.gbMokki.Controls.Add(this.btnPoista);
            this.gbMokki.Controls.Add(this.btnViePaivitys);
            this.gbMokki.Controls.Add(this.lblVarustelu);
            this.gbMokki.Controls.Add(this.tbVarustelu);
            this.gbMokki.Controls.Add(this.lblKuvaus);
            this.gbMokki.Controls.Add(this.lblKatuosoite);
            this.gbMokki.Controls.Add(this.tbKuvaus);
            this.gbMokki.Controls.Add(this.tbKatuosoite);
            this.gbMokki.Controls.Add(this.lblHinta);
            this.gbMokki.Controls.Add(this.tbHinta);
            this.gbMokki.Controls.Add(this.lblMokinNimi);
            this.gbMokki.Controls.Add(this.tbMokinNimi2);
            this.gbMokki.Controls.Add(this.btnLisaaMokki);
            this.gbMokki.Controls.Add(this.tbHenkilomaara);
            this.gbMokki.Controls.Add(this.lblAlue);
            this.gbMokki.Controls.Add(this.lblHenkilomaara);
            this.gbMokki.Controls.Add(this.lblPostinro);
            this.gbMokki.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbMokki.Location = new System.Drawing.Point(23, 73);
            this.gbMokki.Name = "gbMokki";
            this.gbMokki.Size = new System.Drawing.Size(392, 569);
            this.gbMokki.TabIndex = 0;
            this.gbMokki.TabStop = false;
            this.gbMokki.Text = "Mökin tiedot";
            // 
            // cbAlueId
            // 
            this.cbAlueId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAlueId.FormattingEnabled = true;
            this.cbAlueId.Location = new System.Drawing.Point(141, 177);
            this.cbAlueId.Name = "cbAlueId";
            this.cbAlueId.Size = new System.Drawing.Size(223, 28);
            this.cbAlueId.TabIndex = 5;
            // 
            // cbPostinro
            // 
            this.cbPostinro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPostinro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPostinro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPostinro.FormattingEnabled = true;
            this.cbPostinro.Location = new System.Drawing.Point(141, 127);
            this.cbPostinro.MaxLength = 5;
            this.cbPostinro.Name = "cbPostinro";
            this.cbPostinro.Size = new System.Drawing.Size(223, 28);
            this.cbPostinro.TabIndex = 4;
            this.cbPostinro.Text = "00002";
            this.cbPostinro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPostinro_KeyPress);
            // 
            // btnPoista
            // 
            this.btnPoista.Enabled = false;
            this.btnPoista.Location = new System.Drawing.Point(268, 492);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(107, 49);
            this.btnPoista.TabIndex = 12;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnViePaivitys
            // 
            this.btnViePaivitys.Enabled = false;
            this.btnViePaivitys.Location = new System.Drawing.Point(141, 492);
            this.btnViePaivitys.Name = "btnViePaivitys";
            this.btnViePaivitys.Size = new System.Drawing.Size(107, 49);
            this.btnViePaivitys.TabIndex = 11;
            this.btnViePaivitys.Text = "Päivitä";
            this.btnViePaivitys.UseVisualStyleBackColor = true;
            this.btnViePaivitys.Click += new System.EventHandler(this.btnViePaivitys_Click);
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(25, 317);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(86, 20);
            this.lblVarustelu.TabIndex = 0;
            this.lblVarustelu.Text = "*Varustelu:";
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbVarustelu.Location = new System.Drawing.Point(139, 315);
            this.tbVarustelu.MaxLength = 500;
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(228, 27);
            this.tbVarustelu.TabIndex = 8;
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(26, 365);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(71, 20);
            this.lblKuvaus.TabIndex = 0;
            this.lblKuvaus.Text = "*Kuvaus:";
            // 
            // lblKatuosoite
            // 
            this.lblKatuosoite.AutoSize = true;
            this.lblKatuosoite.Location = new System.Drawing.Point(25, 83);
            this.lblKatuosoite.Name = "lblKatuosoite";
            this.lblKatuosoite.Size = new System.Drawing.Size(96, 20);
            this.lblKatuosoite.TabIndex = 0;
            this.lblKatuosoite.Text = "*Katuosoite:";
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKuvaus.Location = new System.Drawing.Point(141, 363);
            this.tbKuvaus.MaxLength = 500;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(228, 27);
            this.tbKuvaus.TabIndex = 9;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKatuosoite.Location = new System.Drawing.Point(139, 80);
            this.tbKatuosoite.MaxLength = 45;
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(228, 27);
            this.tbKatuosoite.TabIndex = 3;
            this.tbKatuosoite.Leave += new System.EventHandler(this.tbKatuosoite_Leave);
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(25, 271);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(82, 20);
            this.lblHinta.TabIndex = 0;
            this.lblHinta.Text = "*Hinta/yö:";
            // 
            // tbHinta
            // 
            this.tbHinta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHinta.Location = new System.Drawing.Point(141, 268);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(228, 27);
            this.tbHinta.TabIndex = 7;
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHinta_KeyPress);
            this.tbHinta.Validating += new System.ComponentModel.CancelEventHandler(this.tbHinta_Validating);
            // 
            // lblMokinNimi
            // 
            this.lblMokinNimi.AutoSize = true;
            this.lblMokinNimi.Location = new System.Drawing.Point(26, 36);
            this.lblMokinNimi.Name = "lblMokinNimi";
            this.lblMokinNimi.Size = new System.Drawing.Size(99, 20);
            this.lblMokinNimi.TabIndex = 0;
            this.lblMokinNimi.Text = "*Mökin nimi:";
            // 
            // tbMokinNimi2
            // 
            this.tbMokinNimi2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMokinNimi2.Location = new System.Drawing.Point(137, 33);
            this.tbMokinNimi2.MaxLength = 45;
            this.tbMokinNimi2.Name = "tbMokinNimi2";
            this.tbMokinNimi2.Size = new System.Drawing.Size(228, 27);
            this.tbMokinNimi2.TabIndex = 2;
            this.tbMokinNimi2.Leave += new System.EventHandler(this.tbMokinNimi_Leave);
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.Location = new System.Drawing.Point(12, 492);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(107, 49);
            this.btnLisaaMokki.TabIndex = 10;
            this.btnLisaaMokki.Text = "Lisää mökki";
            this.btnLisaaMokki.UseVisualStyleBackColor = true;
            this.btnLisaaMokki.Click += new System.EventHandler(this.btnLisaaMokki_Click);
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHenkilomaara.Location = new System.Drawing.Point(139, 221);
            this.tbHenkilomaara.MaxLength = 4;
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(228, 27);
            this.tbHenkilomaara.TabIndex = 6;
            this.tbHenkilomaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHenkilomaara_KeyPress);
            this.tbHenkilomaara.Validating += new System.ComponentModel.CancelEventHandler(this.tbHenkilomaara_Validating);
            // 
            // lblAlue
            // 
            this.lblAlue.AutoSize = true;
            this.lblAlue.Location = new System.Drawing.Point(25, 177);
            this.lblAlue.Name = "lblAlue";
            this.lblAlue.Size = new System.Drawing.Size(47, 20);
            this.lblAlue.TabIndex = 0;
            this.lblAlue.Text = "*Alue";
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(25, 224);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(117, 20);
            this.lblHenkilomaara.TabIndex = 0;
            this.lblHenkilomaara.Text = "*Henkilömäärä:";
            // 
            // lblPostinro
            // 
            this.lblPostinro.AutoSize = true;
            this.lblPostinro.Location = new System.Drawing.Point(25, 131);
            this.lblPostinro.Name = "lblPostinro";
            this.lblPostinro.Size = new System.Drawing.Size(110, 20);
            this.lblPostinro.TabIndex = 0;
            this.lblPostinro.Text = "*Postinumero:";
            // 
            // lblMokinVaraukset
            // 
            this.lblMokinVaraukset.AutoSize = true;
            this.lblMokinVaraukset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMokinVaraukset.Location = new System.Drawing.Point(446, 619);
            this.lblMokinVaraukset.Name = "lblMokinVaraukset";
            this.lblMokinVaraukset.Size = new System.Drawing.Size(143, 23);
            this.lblMokinVaraukset.TabIndex = 32;
            this.lblMokinVaraukset.Text = "Mökin varaukset";
            // 
            // dgvMokinVaraukset
            // 
            this.dgvMokinVaraukset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMokinVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokinVaraukset.Location = new System.Drawing.Point(446, 652);
            this.dgvMokinVaraukset.Name = "dgvMokinVaraukset";
            this.dgvMokinVaraukset.RowHeadersVisible = false;
            this.dgvMokinVaraukset.RowHeadersWidth = 51;
            this.dgvMokinVaraukset.RowTemplate.Height = 29;
            this.dgvMokinVaraukset.Size = new System.Drawing.Size(1119, 267);
            this.dgvMokinVaraukset.TabIndex = 0;
            // 
            // btnKopioi
            // 
            this.btnKopioi.Enabled = false;
            this.btnKopioi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKopioi.Location = new System.Drawing.Point(619, 45);
            this.btnKopioi.Name = "btnKopioi";
            this.btnKopioi.Size = new System.Drawing.Size(170, 35);
            this.btnKopioi.TabIndex = 13;
            this.btnKopioi.Text = "Kopioi mökin tiedot";
            this.btnKopioi.UseVisualStyleBackColor = true;
            this.btnKopioi.Click += new System.EventHandler(this.btnKopioi_Click);
            // 
            // dgvMokki
            // 
            this.dgvMokki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokki.Location = new System.Drawing.Point(446, 104);
            this.dgvMokki.Name = "dgvMokki";
            this.dgvMokki.RowHeadersVisible = false;
            this.dgvMokki.RowHeadersWidth = 51;
            this.dgvMokki.Size = new System.Drawing.Size(1119, 477);
            this.dgvMokki.TabIndex = 0;
            this.dgvMokki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMokki_CellClick);
            // 
            // btnLataaKaikki
            // 
            this.btnLataaKaikki.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLataaKaikki.Location = new System.Drawing.Point(446, 45);
            this.btnLataaKaikki.Name = "btnLataaKaikki";
            this.btnLataaKaikki.Size = new System.Drawing.Size(154, 35);
            this.btnLataaKaikki.TabIndex = 1;
            this.btnLataaKaikki.Text = "Lataa kaikki mökit";
            this.btnLataaKaikki.UseVisualStyleBackColor = true;
            this.btnLataaKaikki.Click += new System.EventHandler(this.btnLataaKaikki_Click);
            // 
            // btnEtsi
            // 
            this.btnEtsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEtsi.Location = new System.Drawing.Point(1247, 48);
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Size = new System.Drawing.Size(94, 29);
            this.btnEtsi.TabIndex = 15;
            this.btnEtsi.Text = "Etsi";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // tbEtsi
            // 
            this.tbEtsi.Location = new System.Drawing.Point(845, 47);
            this.tbEtsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEtsi.Name = "tbEtsi";
            this.tbEtsi.Size = new System.Drawing.Size(374, 27);
            this.tbEtsi.TabIndex = 33;
            // 
            // lblPakollinenTieto
            // 
            this.lblPakollinenTieto.AutoSize = true;
            this.lblPakollinenTieto.Location = new System.Drawing.Point(26, 430);
            this.lblPakollinenTieto.Name = "lblPakollinenTieto";
            this.lblPakollinenTieto.Size = new System.Drawing.Size(144, 20);
            this.lblPakollinenTieto.TabIndex = 13;
            this.lblPakollinenTieto.Text = "* = pakollinen tieto";
            // 
            // Form_Mokit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 953);
            this.Controls.Add(this.tbEtsi);
            this.Controls.Add(this.btnEtsi);
            this.Controls.Add(this.lblMokinVaraukset);
            this.Controls.Add(this.dgvMokinVaraukset);
            this.Controls.Add(this.btnKopioi);
            this.Controls.Add(this.dgvMokki);
            this.Controls.Add(this.btnLataaKaikki);
            this.Controls.Add(this.gbMokki);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Mokit";
            this.Text = "Mökit";
            this.Load += new System.EventHandler(this.Form_Mokit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbMokki.ResumeLayout(false);
            this.gbMokki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokinVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private GroupBox gbMokki;
        private Button btnPoista;
        private Button btnViePaivitys;
        private Label lblVarustelu;
        private TextBox tbVarustelu;
        private Label lblKuvaus;
        private Label lblKatuosoite;
        private TextBox tbKuvaus;
        private TextBox tbKatuosoite;
        private Label lblHinta;
        private TextBox tbHinta;
        private Label lblMokinNimi;
        private TextBox tbMokinNimi2;
        private Button btnLisaaMokki;


        private Label lblAlue;

        private Label lblHenkilomaara;
        private Label lblPostinro;
        private Label lblMokinVaraukset;
        private DataGridView dgvMokinVaraukset;
        private Button btnKopioi;
        private DataGridView dgvMokki;
        private Button btnLataaKaikki;
        private Button btnEtsi;
        private ComboBox cbPostinro;
        private ComboBox cbAlueId;


        private TextBox tbHenkilomaara;
        private TextBox tbEtsi;
        private Label lblPakollinenTieto;
    }
}