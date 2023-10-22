namespace Mokkiprojekti
{
    partial class Form_Asiakkaat
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
            this.gbAsiakas = new System.Windows.Forms.GroupBox();
            this.lblPakollinenTieto = new System.Windows.Forms.Label();
            this.cbPostinumero = new System.Windows.Forms.ComboBox();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnViePaivitys = new System.Windows.Forms.Button();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.lblPuhelinnumero = new System.Windows.Forms.Label();
            this.tbPuhelinnumero = new System.Windows.Forms.TextBox();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.btnLisaaAsiakas = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLahiosoite = new System.Windows.Forms.Label();
            this.BtnKopioiTiedot = new System.Windows.Forms.Button();
            this.BtnLataaAsiakkaat = new System.Windows.Forms.Button();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.dgvAsiakkaanVaraukset = new System.Windows.Forms.DataGridView();
            this.lblAsiakkaanVaraukset = new System.Windows.Forms.Label();
            this.tbEtsiAsiakasta = new System.Windows.Forms.TextBox();
            this.btnEtsi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbAsiakas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaanVaraukset)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1625, 28);
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
            // gbAsiakas
            // 
            this.gbAsiakas.Controls.Add(this.lblPakollinenTieto);
            this.gbAsiakas.Controls.Add(this.cbPostinumero);
            this.gbAsiakas.Controls.Add(this.btnPoista);
            this.gbAsiakas.Controls.Add(this.btnViePaivitys);
            this.gbAsiakas.Controls.Add(this.lblSukunimi);
            this.gbAsiakas.Controls.Add(this.tbSukunimi);
            this.gbAsiakas.Controls.Add(this.lblPuhelinnumero);
            this.gbAsiakas.Controls.Add(this.tbPuhelinnumero);
            this.gbAsiakas.Controls.Add(this.lblEtunimi);
            this.gbAsiakas.Controls.Add(this.tbEtunimi);
            this.gbAsiakas.Controls.Add(this.btnLisaaAsiakas);
            this.gbAsiakas.Controls.Add(this.tbEmail);
            this.gbAsiakas.Controls.Add(this.tbLahiosoite);
            this.gbAsiakas.Controls.Add(this.lblPostinumero);
            this.gbAsiakas.Controls.Add(this.lblEmail);
            this.gbAsiakas.Controls.Add(this.lblLahiosoite);
            this.gbAsiakas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbAsiakas.Location = new System.Drawing.Point(12, 87);
            this.gbAsiakas.Name = "gbAsiakas";
            this.gbAsiakas.Size = new System.Drawing.Size(392, 495);
            this.gbAsiakas.TabIndex = 7;
            this.gbAsiakas.TabStop = false;
            this.gbAsiakas.Text = "Asiakkaan tiedot";
            // 
            // lblPakollinenTieto
            // 
            this.lblPakollinenTieto.AutoSize = true;
            this.lblPakollinenTieto.Location = new System.Drawing.Point(6, 321);
            this.lblPakollinenTieto.Name = "lblPakollinenTieto";
            this.lblPakollinenTieto.Size = new System.Drawing.Size(144, 20);
            this.lblPakollinenTieto.TabIndex = 10;
            this.lblPakollinenTieto.Text = "* = pakollinen tieto";
            // 
            // cbPostinumero
            // 
            this.cbPostinumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPostinumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPostinumero.FormattingEnabled = true;
            this.cbPostinumero.Location = new System.Drawing.Point(150, 174);
            this.cbPostinumero.MaxLength = 5;
            this.cbPostinumero.Name = "cbPostinumero";
            this.cbPostinumero.Size = new System.Drawing.Size(228, 28);
            this.cbPostinumero.TabIndex = 4;
            // 
            // btnPoista
            // 
            this.btnPoista.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoista.Location = new System.Drawing.Point(278, 366);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(108, 49);
            this.btnPoista.TabIndex = 9;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnViePaivitys
            // 
            this.btnViePaivitys.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViePaivitys.Location = new System.Drawing.Point(150, 366);
            this.btnViePaivitys.Name = "btnViePaivitys";
            this.btnViePaivitys.Size = new System.Drawing.Size(108, 49);
            this.btnViePaivitys.TabIndex = 8;
            this.btnViePaivitys.Text = "Päivitä";
            this.btnViePaivitys.UseVisualStyleBackColor = true;
            this.btnViePaivitys.Click += new System.EventHandler(this.btnViePaivitys_Click);
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(6, 83);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(85, 20);
            this.lblSukunimi.TabIndex = 2;
            this.lblSukunimi.Text = "*Sukunimi:";
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(150, 80);
            this.tbSukunimi.MaxLength = 40;
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(228, 27);
            this.tbSukunimi.TabIndex = 2;
            this.tbSukunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimi_KeyPress);
            this.tbSukunimi.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // lblPuhelinnumero
            // 
            this.lblPuhelinnumero.AutoSize = true;
            this.lblPuhelinnumero.Location = new System.Drawing.Point(6, 271);
            this.lblPuhelinnumero.Name = "lblPuhelinnumero";
            this.lblPuhelinnumero.Size = new System.Drawing.Size(127, 20);
            this.lblPuhelinnumero.TabIndex = 3;
            this.lblPuhelinnumero.Text = "*Puhelinnumero:";
            // 
            // tbPuhelinnumero
            // 
            this.tbPuhelinnumero.Location = new System.Drawing.Point(151, 268);
            this.tbPuhelinnumero.MaxLength = 15;
            this.tbPuhelinnumero.Name = "tbPuhelinnumero";
            this.tbPuhelinnumero.Size = new System.Drawing.Size(228, 27);
            this.tbPuhelinnumero.TabIndex = 6;
            this.tbPuhelinnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuhelinnumero_KeyPress);
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(6, 40);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(74, 20);
            this.lblEtunimi.TabIndex = 1;
            this.lblEtunimi.Text = "*Etunimi:";
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(150, 33);
            this.tbEtunimi.MaxLength = 20;
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(225, 27);
            this.tbEtunimi.TabIndex = 1;
            this.tbEtunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimi_KeyPress);
            this.tbEtunimi.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // btnLisaaAsiakas
            // 
            this.btnLisaaAsiakas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLisaaAsiakas.Location = new System.Drawing.Point(22, 366);
            this.btnLisaaAsiakas.Name = "btnLisaaAsiakas";
            this.btnLisaaAsiakas.Size = new System.Drawing.Size(108, 49);
            this.btnLisaaAsiakas.TabIndex = 7;
            this.btnLisaaAsiakas.Text = "Lisää asiakas";
            this.btnLisaaAsiakas.UseVisualStyleBackColor = true;
            this.btnLisaaAsiakas.Click += new System.EventHandler(this.btnLisaaAsiakas_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(150, 221);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(228, 27);
            this.tbEmail.TabIndex = 5;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(150, 127);
            this.tbLahiosoite.MaxLength = 40;
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(228, 27);
            this.tbLahiosoite.TabIndex = 3;
            this.tbLahiosoite.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Location = new System.Drawing.Point(6, 177);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(110, 20);
            this.lblPostinumero.TabIndex = 7;
            this.lblPostinumero.Text = "*Postinumero:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "*Email:";
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.AutoSize = true;
            this.lblLahiosoite.Location = new System.Drawing.Point(6, 130);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(92, 20);
            this.lblLahiosoite.TabIndex = 0;
            this.lblLahiosoite.Text = "*Lähiosoite:";
            // 
            // BtnKopioiTiedot
            // 
            this.BtnKopioiTiedot.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnKopioiTiedot.Location = new System.Drawing.Point(615, 83);
            this.BtnKopioiTiedot.Name = "BtnKopioiTiedot";
            this.BtnKopioiTiedot.Size = new System.Drawing.Size(184, 34);
            this.BtnKopioiTiedot.TabIndex = 11;
            this.BtnKopioiTiedot.Text = "Kopioi asiakkaan tiedot";
            this.BtnKopioiTiedot.UseVisualStyleBackColor = true;
            this.BtnKopioiTiedot.Click += new System.EventHandler(this.BtnKopioiTiedot_Click);
            // 
            // BtnLataaAsiakkaat
            // 
            this.BtnLataaAsiakkaat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLataaAsiakkaat.Location = new System.Drawing.Point(423, 83);
            this.BtnLataaAsiakkaat.Name = "BtnLataaAsiakkaat";
            this.BtnLataaAsiakkaat.Size = new System.Drawing.Size(186, 34);
            this.BtnLataaAsiakkaat.TabIndex = 10;
            this.BtnLataaAsiakkaat.Text = "Lataa kaikki asiakkaat";
            this.BtnLataaAsiakkaat.UseVisualStyleBackColor = true;
            this.BtnLataaAsiakkaat.Click += new System.EventHandler(this.BtnLataaAsiakkaat_Click);
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(423, 123);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.RowHeadersWidth = 51;
            this.dgvAsiakkaat.RowTemplate.Height = 29;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(776, 379);
            this.dgvAsiakkaat.TabIndex = 10;
            this.dgvAsiakkaat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsiakkaat_CellClick);
            // 
            // dgvAsiakkaanVaraukset
            // 
            this.dgvAsiakkaanVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaanVaraukset.Location = new System.Drawing.Point(423, 599);
            this.dgvAsiakkaanVaraukset.Name = "dgvAsiakkaanVaraukset";
            this.dgvAsiakkaanVaraukset.RowHeadersWidth = 51;
            this.dgvAsiakkaanVaraukset.RowTemplate.Height = 29;
            this.dgvAsiakkaanVaraukset.Size = new System.Drawing.Size(624, 266);
            this.dgvAsiakkaanVaraukset.TabIndex = 11;
            // 
            // lblAsiakkaanVaraukset
            // 
            this.lblAsiakkaanVaraukset.AutoSize = true;
            this.lblAsiakkaanVaraukset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAsiakkaanVaraukset.Location = new System.Drawing.Point(423, 562);
            this.lblAsiakkaanVaraukset.Name = "lblAsiakkaanVaraukset";
            this.lblAsiakkaanVaraukset.Size = new System.Drawing.Size(152, 20);
            this.lblAsiakkaanVaraukset.TabIndex = 12;
            this.lblAsiakkaanVaraukset.Text = "Asiakkaan varaukset";
            // 
            // tbEtsiAsiakasta
            // 
            this.tbEtsiAsiakasta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbEtsiAsiakasta.Location = new System.Drawing.Point(836, 87);
            this.tbEtsiAsiakasta.Name = "tbEtsiAsiakasta";
            this.tbEtsiAsiakasta.Size = new System.Drawing.Size(219, 27);
            this.tbEtsiAsiakasta.TabIndex = 13;
            // 
            // btnEtsi
            // 
            this.btnEtsi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEtsi.Location = new System.Drawing.Point(1061, 86);
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Size = new System.Drawing.Size(94, 29);
            this.btnEtsi.TabIndex = 14;
            this.btnEtsi.Text = "Hae";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // Form_Asiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 953);
            this.Controls.Add(this.btnEtsi);
            this.Controls.Add(this.tbEtsiAsiakasta);
            this.Controls.Add(this.lblAsiakkaanVaraukset);
            this.Controls.Add(this.dgvAsiakkaanVaraukset);
            this.Controls.Add(this.dgvAsiakkaat);
            this.Controls.Add(this.BtnLataaAsiakkaat);
            this.Controls.Add(this.BtnKopioiTiedot);
            this.Controls.Add(this.gbAsiakas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Asiakkaat";
            this.Text = "Asiakasjärjestelmä";
            this.Load += new System.EventHandler(this.Form_Asiakkaat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAsiakas.ResumeLayout(false);
            this.gbAsiakas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaanVaraukset)).EndInit();
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
        private GroupBox gbAsiakas;
        private Button btnPoista;
        private Button btnViePaivitys;
        private Label lblSukunimi;
        private TextBox tbSukunimi;
        private Label lblPuhelinnumero;
        private TextBox tbPuhelinnumero;
        private Label lblEtunimi;
        private TextBox tbEtunimi;
        private Button btnLisaaAsiakas;
        private TextBox tbEmail;
        private TextBox tbLahiosoite;
        private Label lblPostinumero;
        private Label lblEmail;
        private Label lblLahiosoite;
        private Button BtnKopioiTiedot;
        private Button BtnLataaAsiakkaat;
        private DataGridView dgvAsiakkaat;
        private DataGridView dgvAsiakkaanVaraukset;
        private Label lblAsiakkaanVaraukset;
        private TextBox tbEtsiAsiakasta;
        private Button btnEtsi;
        private ComboBox cbPostinumero;
        private Label lblPakollinenTieto;
    }
}