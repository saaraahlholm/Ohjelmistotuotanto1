namespace Mokkiprojekti
{
    partial class Form_Uusivaraus
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
            this.gbEtsiMokki = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpLahto = new System.Windows.Forms.DateTimePicker();
            this.dtpSaapuminen = new System.Windows.Forms.DateTimePicker();
            this.dupHenkilomaara = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHinta = new System.Windows.Forms.ComboBox();
            this.lblHinta = new System.Windows.Forms.Label();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.lblLahto = new System.Windows.Forms.Label();
            this.lblSaapuminen = new System.Windows.Forms.Label();
            this.lblAlue = new System.Windows.Forms.Label();
            this.btnEtsi = new System.Windows.Forms.Button();
            this.btnTeeVaraus = new System.Windows.Forms.Button();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.gbVaraajantiedot = new System.Windows.Forms.GroupBox();
            this.cbPostinro = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPuhelinnumero = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPuhelinnumero = new System.Windows.Forms.Label();
            this.lblPostinro = new System.Windows.Forms.Label();
            this.lblLahiosoite = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.gbMokkiJaPalvelut = new System.Windows.Forms.GroupBox();
            this.cbEiPalveluita = new System.Windows.Forms.CheckBox();
            this.tbPalvelunLkm = new System.Windows.Forms.TextBox();
            this.lblLukumaara = new System.Windows.Forms.Label();
            this.cbLisapalvelu = new System.Windows.Forms.ComboBox();
            this.lblLisapalvelu = new System.Windows.Forms.Label();
            this.lblValittumokki = new System.Windows.Forms.Label();
            this.lblValittuOtsikko = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbEtsiMokki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            this.gbVaraajantiedot.SuspendLayout();
            this.gbMokkiJaPalvelut.SuspendLayout();
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
            // gbEtsiMokki
            // 
            this.gbEtsiMokki.Controls.Add(this.label2);
            this.gbEtsiMokki.Controls.Add(this.dtpLahto);
            this.gbEtsiMokki.Controls.Add(this.dtpSaapuminen);
            this.gbEtsiMokki.Controls.Add(this.dupHenkilomaara);
            this.gbEtsiMokki.Controls.Add(this.label1);
            this.gbEtsiMokki.Controls.Add(this.cbHinta);
            this.gbEtsiMokki.Controls.Add(this.lblHinta);
            this.gbEtsiMokki.Controls.Add(this.cbAlue);
            this.gbEtsiMokki.Controls.Add(this.lblHenkilomaara);
            this.gbEtsiMokki.Controls.Add(this.lblLahto);
            this.gbEtsiMokki.Controls.Add(this.lblSaapuminen);
            this.gbEtsiMokki.Controls.Add(this.lblAlue);
            this.gbEtsiMokki.Controls.Add(this.btnEtsi);
            this.gbEtsiMokki.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbEtsiMokki.Location = new System.Drawing.Point(29, 53);
            this.gbEtsiMokki.Name = "gbEtsiMokki";
            this.gbEtsiMokki.Size = new System.Drawing.Size(374, 638);
            this.gbEtsiMokki.TabIndex = 0;
            this.gbEtsiMokki.TabStop = false;
            this.gbEtsiMokki.Text = "Etsi mökki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "* pakollinen tieto";
            // 
            // dtpLahto
            // 
            this.dtpLahto.Location = new System.Drawing.Point(109, 250);
            this.dtpLahto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpLahto.Name = "dtpLahto";
            this.dtpLahto.Size = new System.Drawing.Size(239, 30);
            this.dtpLahto.TabIndex = 3;
            // 
            // dtpSaapuminen
            // 
            this.dtpSaapuminen.Location = new System.Drawing.Point(109, 146);
            this.dtpSaapuminen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpSaapuminen.Name = "dtpSaapuminen";
            this.dtpSaapuminen.Size = new System.Drawing.Size(239, 30);
            this.dtpSaapuminen.TabIndex = 2;
            this.dtpSaapuminen.ValueChanged += new System.EventHandler(this.dtpSaapuminen_ValueChanged);
            // 
            // dupHenkilomaara
            // 
            this.dupHenkilomaara.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dupHenkilomaara.Items.Add("1");
            this.dupHenkilomaara.Items.Add("2");
            this.dupHenkilomaara.Items.Add("3");
            this.dupHenkilomaara.Items.Add("4");
            this.dupHenkilomaara.Items.Add("5");
            this.dupHenkilomaara.Items.Add("6");
            this.dupHenkilomaara.Items.Add("7");
            this.dupHenkilomaara.Items.Add("8");
            this.dupHenkilomaara.Items.Add("9");
            this.dupHenkilomaara.Items.Add("10");
            this.dupHenkilomaara.Items.Add("11");
            this.dupHenkilomaara.Items.Add("12");
            this.dupHenkilomaara.Items.Add("13");
            this.dupHenkilomaara.Items.Add("14");
            this.dupHenkilomaara.Items.Add("15");
            this.dupHenkilomaara.Items.Add("16");
            this.dupHenkilomaara.Items.Add("17");
            this.dupHenkilomaara.Items.Add("18");
            this.dupHenkilomaara.Items.Add("19");
            this.dupHenkilomaara.Items.Add("20");
            this.dupHenkilomaara.Location = new System.Drawing.Point(204, 348);
            this.dupHenkilomaara.Name = "dupHenkilomaara";
            this.dupHenkilomaara.Size = new System.Drawing.Size(154, 27);
            this.dupHenkilomaara.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "* pakollinen tieto";
            // 
            // cbHinta
            // 
            this.cbHinta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHinta.FormattingEnabled = true;
            this.cbHinta.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600"});
            this.cbHinta.Location = new System.Drawing.Point(204, 416);
            this.cbHinta.Name = "cbHinta";
            this.cbHinta.Size = new System.Drawing.Size(154, 28);
            this.cbHinta.TabIndex = 5;
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHinta.Location = new System.Drawing.Point(15, 420);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(116, 18);
            this.lblHinta.TabIndex = 0;
            this.lblHinta.Text = "Hinta/yö max.:";
            // 
            // cbAlue
            // 
            this.cbAlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(152, 54);
            this.cbAlue.MaxDropDownItems = 40;
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(196, 28);
            this.cbAlue.TabIndex = 1;
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHenkilomaara.Location = new System.Drawing.Point(15, 351);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(154, 18);
            this.lblHenkilomaara.TabIndex = 0;
            this.lblHenkilomaara.Text = "Henkilömäärä min.:";
            // 
            // lblLahto
            // 
            this.lblLahto.AutoSize = true;
            this.lblLahto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLahto.Location = new System.Drawing.Point(15, 217);
            this.lblLahto.Name = "lblLahto";
            this.lblLahto.Size = new System.Drawing.Size(67, 18);
            this.lblLahto.TabIndex = 0;
            this.lblLahto.Text = "Lähtö *:";
            // 
            // lblSaapuminen
            // 
            this.lblSaapuminen.AutoSize = true;
            this.lblSaapuminen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaapuminen.Location = new System.Drawing.Point(15, 112);
            this.lblSaapuminen.Name = "lblSaapuminen";
            this.lblSaapuminen.Size = new System.Drawing.Size(117, 18);
            this.lblSaapuminen.TabIndex = 0;
            this.lblSaapuminen.Text = "Saapuminen *:";
            // 
            // lblAlue
            // 
            this.lblAlue.AutoSize = true;
            this.lblAlue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlue.Location = new System.Drawing.Point(15, 57);
            this.lblAlue.Name = "lblAlue";
            this.lblAlue.Size = new System.Drawing.Size(45, 20);
            this.lblAlue.TabIndex = 0;
            this.lblAlue.Text = "Alue:";
            // 
            // btnEtsi
            // 
            this.btnEtsi.Location = new System.Drawing.Point(246, 514);
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Size = new System.Drawing.Size(112, 51);
            this.btnEtsi.TabIndex = 6;
            this.btnEtsi.Text = "Etsi mökki";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // btnTeeVaraus
            // 
            this.btnTeeVaraus.Location = new System.Drawing.Point(756, 293);
            this.btnTeeVaraus.Name = "btnTeeVaraus";
            this.btnTeeVaraus.Size = new System.Drawing.Size(145, 93);
            this.btnTeeVaraus.TabIndex = 17;
            this.btnTeeVaraus.Text = "Tee varaus";
            this.btnTeeVaraus.UseVisualStyleBackColor = true;
            this.btnTeeVaraus.Click += new System.EventHandler(this.btnTeeVaraus_Click);
            // 
            // dgvMokit
            // 
            this.dgvMokit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Location = new System.Drawing.Point(423, 67);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.RowHeadersVisible = false;
            this.dgvMokit.RowHeadersWidth = 51;
            this.dgvMokit.RowTemplate.Height = 29;
            this.dgvMokit.Size = new System.Drawing.Size(955, 217);
            this.dgvMokit.TabIndex = 7;
            this.dgvMokit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMokit_CellClick);
            // 
            // gbVaraajantiedot
            // 
            this.gbVaraajantiedot.Controls.Add(this.cbPostinro);
            this.gbVaraajantiedot.Controls.Add(this.tbEmail);
            this.gbVaraajantiedot.Controls.Add(this.tbPuhelinnumero);
            this.gbVaraajantiedot.Controls.Add(this.btnTeeVaraus);
            this.gbVaraajantiedot.Controls.Add(this.tbLahiosoite);
            this.gbVaraajantiedot.Controls.Add(this.tbSukunimi);
            this.gbVaraajantiedot.Controls.Add(this.tbEtunimi);
            this.gbVaraajantiedot.Controls.Add(this.lblEmail);
            this.gbVaraajantiedot.Controls.Add(this.lblPuhelinnumero);
            this.gbVaraajantiedot.Controls.Add(this.lblPostinro);
            this.gbVaraajantiedot.Controls.Add(this.lblLahiosoite);
            this.gbVaraajantiedot.Controls.Add(this.lblSukunimi);
            this.gbVaraajantiedot.Controls.Add(this.lblEtunimi);
            this.gbVaraajantiedot.Enabled = false;
            this.gbVaraajantiedot.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbVaraajantiedot.Location = new System.Drawing.Point(423, 515);
            this.gbVaraajantiedot.Name = "gbVaraajantiedot";
            this.gbVaraajantiedot.Size = new System.Drawing.Size(955, 419);
            this.gbVaraajantiedot.TabIndex = 0;
            this.gbVaraajantiedot.TabStop = false;
            this.gbVaraajantiedot.Text = "Lisää vaaraajan tiedot";
            // 
            // cbPostinro
            // 
            this.cbPostinro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPostinro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPostinro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPostinro.FormattingEnabled = true;
            this.cbPostinro.Location = new System.Drawing.Point(187, 208);
            this.cbPostinro.MaxLength = 5;
            this.cbPostinro.Name = "cbPostinro";
            this.cbPostinro.Size = new System.Drawing.Size(229, 28);
            this.cbPostinro.TabIndex = 14;
            this.cbPostinro.Text = "00002";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(187, 308);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(229, 27);
            this.tbEmail.TabIndex = 16;
            // 
            // tbPuhelinnumero
            // 
            this.tbPuhelinnumero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPuhelinnumero.Location = new System.Drawing.Point(187, 258);
            this.tbPuhelinnumero.MaxLength = 15;
            this.tbPuhelinnumero.Name = "tbPuhelinnumero";
            this.tbPuhelinnumero.Size = new System.Drawing.Size(229, 27);
            this.tbPuhelinnumero.TabIndex = 15;
            this.tbPuhelinnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuhelinnumero_KeyPress);
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLahiosoite.Location = new System.Drawing.Point(187, 158);
            this.tbLahiosoite.MaxLength = 40;
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(229, 27);
            this.tbLahiosoite.TabIndex = 13;
            this.tbLahiosoite.Leave += new System.EventHandler(this.tbLahiosoite_Leave);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSukunimi.Location = new System.Drawing.Point(187, 108);
            this.tbSukunimi.MaxLength = 40;
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(229, 27);
            this.tbSukunimi.TabIndex = 12;
            this.tbSukunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSukunimi_KeyPress);
            this.tbSukunimi.Leave += new System.EventHandler(this.tbSukunimi_Leave);
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEtunimi.Location = new System.Drawing.Point(187, 58);
            this.tbEtunimi.MaxLength = 20;
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(229, 27);
            this.tbEtunimi.TabIndex = 11;
            this.tbEtunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimi_KeyPress);
            this.tbEtunimi.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(48, 311);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblPuhelinnumero
            // 
            this.lblPuhelinnumero.AutoSize = true;
            this.lblPuhelinnumero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuhelinnumero.Location = new System.Drawing.Point(48, 261);
            this.lblPuhelinnumero.Name = "lblPuhelinnumero";
            this.lblPuhelinnumero.Size = new System.Drawing.Size(120, 20);
            this.lblPuhelinnumero.TabIndex = 0;
            this.lblPuhelinnumero.Text = "Puhelinnumero:";
            // 
            // lblPostinro
            // 
            this.lblPostinro.AutoSize = true;
            this.lblPostinro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPostinro.Location = new System.Drawing.Point(48, 211);
            this.lblPostinro.Name = "lblPostinro";
            this.lblPostinro.Size = new System.Drawing.Size(103, 20);
            this.lblPostinro.TabIndex = 0;
            this.lblPostinro.Text = "Postinumero:";
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.AutoSize = true;
            this.lblLahiosoite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLahiosoite.Location = new System.Drawing.Point(48, 161);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(85, 20);
            this.lblLahiosoite.TabIndex = 0;
            this.lblLahiosoite.Text = "Lähiosoite:";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSukunimi.Location = new System.Drawing.Point(48, 111);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(78, 20);
            this.lblSukunimi.TabIndex = 0;
            this.lblSukunimi.Text = "Sukunimi:";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEtunimi.Location = new System.Drawing.Point(48, 61);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(67, 20);
            this.lblEtunimi.TabIndex = 0;
            this.lblEtunimi.Text = "Etunimi:";
            // 
            // gbMokkiJaPalvelut
            // 
            this.gbMokkiJaPalvelut.Controls.Add(this.cbEiPalveluita);
            this.gbMokkiJaPalvelut.Controls.Add(this.tbPalvelunLkm);
            this.gbMokkiJaPalvelut.Controls.Add(this.lblLukumaara);
            this.gbMokkiJaPalvelut.Controls.Add(this.cbLisapalvelu);
            this.gbMokkiJaPalvelut.Controls.Add(this.lblLisapalvelu);
            this.gbMokkiJaPalvelut.Controls.Add(this.lblValittumokki);
            this.gbMokkiJaPalvelut.Controls.Add(this.lblValittuOtsikko);
            this.gbMokkiJaPalvelut.Enabled = false;
            this.gbMokkiJaPalvelut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbMokkiJaPalvelut.Location = new System.Drawing.Point(423, 315);
            this.gbMokkiJaPalvelut.Name = "gbMokkiJaPalvelut";
            this.gbMokkiJaPalvelut.Size = new System.Drawing.Size(955, 176);
            this.gbMokkiJaPalvelut.TabIndex = 0;
            this.gbMokkiJaPalvelut.TabStop = false;
            this.gbMokkiJaPalvelut.Text = "Varauksen mökki ja palvelut";
            // 
            // cbEiPalveluita
            // 
            this.cbEiPalveluita.AutoSize = true;
            this.cbEiPalveluita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEiPalveluita.Location = new System.Drawing.Point(299, 137);
            this.cbEiPalveluita.Name = "cbEiPalveluita";
            this.cbEiPalveluita.Size = new System.Drawing.Size(112, 24);
            this.cbEiPalveluita.TabIndex = 10;
            this.cbEiPalveluita.Text = "Ei palveluita";
            this.cbEiPalveluita.UseVisualStyleBackColor = true;
            this.cbEiPalveluita.CheckedChanged += new System.EventHandler(this.cbEiPalveluita_CheckedChanged);
            // 
            // tbPalvelunLkm
            // 
            this.tbPalvelunLkm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPalvelunLkm.Location = new System.Drawing.Point(632, 98);
            this.tbPalvelunLkm.MaxLength = 100;
            this.tbPalvelunLkm.Name = "tbPalvelunLkm";
            this.tbPalvelunLkm.Size = new System.Drawing.Size(111, 27);
            this.tbPalvelunLkm.TabIndex = 9;
            this.tbPalvelunLkm.Leave += new System.EventHandler(this.tbPalvelunLkm_Leave);
            // 
            // lblLukumaara
            // 
            this.lblLukumaara.AutoSize = true;
            this.lblLukumaara.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLukumaara.Location = new System.Drawing.Point(542, 101);
            this.lblLukumaara.Name = "lblLukumaara";
            this.lblLukumaara.Size = new System.Drawing.Size(57, 20);
            this.lblLukumaara.TabIndex = 0;
            this.lblLukumaara.Text = "Määrä:";
            // 
            // cbLisapalvelu
            // 
            this.cbLisapalvelu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLisapalvelu.FormattingEnabled = true;
            this.cbLisapalvelu.Location = new System.Drawing.Point(299, 98);
            this.cbLisapalvelu.Name = "cbLisapalvelu";
            this.cbLisapalvelu.Size = new System.Drawing.Size(203, 28);
            this.cbLisapalvelu.TabIndex = 8;
            // 
            // lblLisapalvelu
            // 
            this.lblLisapalvelu.AutoSize = true;
            this.lblLisapalvelu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLisapalvelu.Location = new System.Drawing.Point(71, 101);
            this.lblLisapalvelu.Name = "lblLisapalvelu";
            this.lblLisapalvelu.Size = new System.Drawing.Size(73, 20);
            this.lblLisapalvelu.TabIndex = 0;
            this.lblLisapalvelu.Text = "Palvelut: ";
            // 
            // lblValittumokki
            // 
            this.lblValittumokki.AutoSize = true;
            this.lblValittumokki.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValittumokki.Location = new System.Drawing.Point(299, 44);
            this.lblValittumokki.Name = "lblValittumokki";
            this.lblValittumokki.Size = new System.Drawing.Size(83, 20);
            this.lblValittumokki.TabIndex = 18;
            this.lblValittumokki.Text = "mökin nimi";
            this.lblValittumokki.Visible = false;
            // 
            // lblValittuOtsikko
            // 
            this.lblValittuOtsikko.AutoSize = true;
            this.lblValittuOtsikko.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValittuOtsikko.Location = new System.Drawing.Point(71, 44);
            this.lblValittuOtsikko.Name = "lblValittuOtsikko";
            this.lblValittuOtsikko.Size = new System.Drawing.Size(60, 20);
            this.lblValittuOtsikko.TabIndex = 0;
            this.lblValittuOtsikko.Text = "Mökki: ";
            // 
            // Form_Uusivaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 953);
            this.Controls.Add(this.gbMokkiJaPalvelut);
            this.Controls.Add(this.gbVaraajantiedot);
            this.Controls.Add(this.dgvMokit);
            this.Controls.Add(this.gbEtsiMokki);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Uusivaraus";
            this.Text = "Uusi varaus";
            this.Load += new System.EventHandler(this.Form_Uusivaraus_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbEtsiMokki.ResumeLayout(false);
            this.gbEtsiMokki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            this.gbVaraajantiedot.ResumeLayout(false);
            this.gbVaraajantiedot.PerformLayout();
            this.gbMokkiJaPalvelut.ResumeLayout(false);
            this.gbMokkiJaPalvelut.PerformLayout();
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
        private GroupBox gbEtsiMokki;
        private Label lblHinta;
        private Button btnEtsi;
        private ComboBox cbAlue;
        private Label lblHenkilomaara;
        private Label lblLahto;
        private Label lblSaapuminen;
        private Label lblAlue;
        private Button btnTeeVaraus;
        private ComboBox cbHinta;
        private DataGridView dgvMokit;
        private GroupBox gbVaraajantiedot;
        private TextBox tbEmail;
        private TextBox tbPuhelinnumero;
        private TextBox tbLahiosoite;
        private TextBox tbSukunimi;
        private TextBox tbEtunimi;
        private Label lblEmail;
        private Label lblPuhelinnumero;
        private Label lblPostinro;
        private Label lblLahiosoite;
        private Label lblSukunimi;
        private Label lblEtunimi;
        private GroupBox gbMokkiJaPalvelut;
        private Label lblLukumaara;
        private ComboBox cbLisapalvelu;
        private Label lblLisapalvelu;
        private Label lblValittumokki;
        private Label lblValittuOtsikko;
        private DomainUpDown dupHenkilomaara;
        private DateTimePicker dtpLahto;
        private DateTimePicker dtpSaapuminen;
        private Label label2;
        private Label label1;
        private TextBox tbPalvelunLkm;
        private CheckBox cbEiPalveluita;
        private ComboBox cbPostinro;
    }
}