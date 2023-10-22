namespace Mokkiprojekti
{
    partial class Form_Varaukset
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
            this.btnEtsi = new System.Windows.Forms.Button();
            this.tbEtsiVarausta = new System.Windows.Forms.TextBox();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.BtnLataaVaraukset = new System.Windows.Forms.Button();
            this.BtnKopioiTiedot = new System.Windows.Forms.Button();
            this.gbVarauksenTiedot = new System.Windows.Forms.GroupBox();
            this.tbPalveluidenlkm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPalvelu = new System.Windows.Forms.Label();
            this.cbPalvelu = new System.Windows.Forms.ComboBox();
            this.lblTahanEmail = new System.Windows.Forms.Label();
            this.lblTahanSukunimi = new System.Windows.Forms.Label();
            this.lblTahanEtunimi = new System.Windows.Forms.Label();
            this.lblTahanMokkiID = new System.Windows.Forms.Label();
            this.lblTahanAsiakasID = new System.Windows.Forms.Label();
            this.lblTahanVarausID = new System.Windows.Forms.Label();
            this.dtpLahto = new System.Windows.Forms.DateTimePicker();
            this.dtpSaapuminen = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnViePaivitys = new System.Windows.Forms.Button();
            this.lblLahto = new System.Windows.Forms.Label();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSaapuminen = new System.Windows.Forms.Label();
            this.lblAsiakasID = new System.Windows.Forms.Label();
            this.lblMokkiID = new System.Windows.Forms.Label();
            this.lblVarausID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.gbVarauksenTiedot.SuspendLayout();
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
            // btnEtsi
            // 
            this.btnEtsi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEtsi.Location = new System.Drawing.Point(1268, 88);
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.Size = new System.Drawing.Size(94, 29);
            this.btnEtsi.TabIndex = 22;
            this.btnEtsi.Text = "Hae";
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // tbEtsiVarausta
            // 
            this.tbEtsiVarausta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbEtsiVarausta.Location = new System.Drawing.Point(1043, 89);
            this.tbEtsiVarausta.Name = "tbEtsiVarausta";
            this.tbEtsiVarausta.Size = new System.Drawing.Size(219, 27);
            this.tbEtsiVarausta.TabIndex = 21;
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Location = new System.Drawing.Point(630, 125);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.RowHeadersWidth = 51;
            this.dgvVaraukset.RowTemplate.Height = 29;
            this.dgvVaraukset.Size = new System.Drawing.Size(776, 379);
            this.dgvVaraukset.TabIndex = 16;
            this.dgvVaraukset.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVaraukset_CellClick);
            // 
            // BtnLataaVaraukset
            // 
            this.BtnLataaVaraukset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLataaVaraukset.Location = new System.Drawing.Point(630, 85);
            this.BtnLataaVaraukset.Name = "BtnLataaVaraukset";
            this.BtnLataaVaraukset.Size = new System.Drawing.Size(186, 34);
            this.BtnLataaVaraukset.TabIndex = 17;
            this.BtnLataaVaraukset.Text = "Lataa kaikki varaukset";
            this.BtnLataaVaraukset.UseVisualStyleBackColor = true;
            this.BtnLataaVaraukset.Click += new System.EventHandler(this.BtnLataaVaraukset_Click);
            // 
            // BtnKopioiTiedot
            // 
            this.BtnKopioiTiedot.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnKopioiTiedot.Location = new System.Drawing.Point(822, 85);
            this.BtnKopioiTiedot.Name = "BtnKopioiTiedot";
            this.BtnKopioiTiedot.Size = new System.Drawing.Size(184, 34);
            this.BtnKopioiTiedot.TabIndex = 19;
            this.BtnKopioiTiedot.Text = "Kopioi varauksen tiedot";
            this.BtnKopioiTiedot.UseVisualStyleBackColor = true;
            this.BtnKopioiTiedot.Click += new System.EventHandler(this.BtnKopioiTiedot_Click);
            // 
            // gbVarauksenTiedot
            // 
            this.gbVarauksenTiedot.Controls.Add(this.tbPalveluidenlkm);
            this.gbVarauksenTiedot.Controls.Add(this.label1);
            this.gbVarauksenTiedot.Controls.Add(this.lblPalvelu);
            this.gbVarauksenTiedot.Controls.Add(this.cbPalvelu);
            this.gbVarauksenTiedot.Controls.Add(this.lblTahanEmail);
            this.gbVarauksenTiedot.Controls.Add(this.lblTahanSukunimi);
            this.gbVarauksenTiedot.Controls.Add(this.lblTahanEtunimi);
            this.gbVarauksenTiedot.Controls.Add(this.lblTahanMokkiID);
            this.gbVarauksenTiedot.Controls.Add(this.lblTahanAsiakasID);
            this.gbVarauksenTiedot.Controls.Add(this.lblTahanVarausID);
            this.gbVarauksenTiedot.Controls.Add(this.dtpLahto);
            this.gbVarauksenTiedot.Controls.Add(this.dtpSaapuminen);
            this.gbVarauksenTiedot.Controls.Add(this.lblEmail);
            this.gbVarauksenTiedot.Controls.Add(this.lblSukunimi);
            this.gbVarauksenTiedot.Controls.Add(this.btnPoista);
            this.gbVarauksenTiedot.Controls.Add(this.btnViePaivitys);
            this.gbVarauksenTiedot.Controls.Add(this.lblLahto);
            this.gbVarauksenTiedot.Controls.Add(this.lblEtunimi);
            this.gbVarauksenTiedot.Controls.Add(this.lblSaapuminen);
            this.gbVarauksenTiedot.Controls.Add(this.lblAsiakasID);
            this.gbVarauksenTiedot.Controls.Add(this.lblMokkiID);
            this.gbVarauksenTiedot.Controls.Add(this.lblVarausID);
            this.gbVarauksenTiedot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbVarauksenTiedot.Location = new System.Drawing.Point(219, 99);
            this.gbVarauksenTiedot.Name = "gbVarauksenTiedot";
            this.gbVarauksenTiedot.Size = new System.Drawing.Size(392, 495);
            this.gbVarauksenTiedot.TabIndex = 15;
            this.gbVarauksenTiedot.TabStop = false;
            this.gbVarauksenTiedot.Text = "Varauksen tiedot";
            // 
            // tbPalveluidenlkm
            // 
            this.tbPalveluidenlkm.Location = new System.Drawing.Point(174, 274);
            this.tbPalveluidenlkm.Name = "tbPalveluidenlkm";
            this.tbPalveluidenlkm.Size = new System.Drawing.Size(186, 27);
            this.tbPalveluidenlkm.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Palveluiden lukumäärä:";
            // 
            // lblPalvelu
            // 
            this.lblPalvelu.AutoSize = true;
            this.lblPalvelu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPalvelu.Location = new System.Drawing.Point(6, 236);
            this.lblPalvelu.Name = "lblPalvelu";
            this.lblPalvelu.Size = new System.Drawing.Size(139, 20);
            this.lblPalvelu.TabIndex = 21;
            this.lblPalvelu.Text = "Varauksen palvelu:";
            // 
            // cbPalvelu
            // 
            this.cbPalvelu.FormattingEnabled = true;
            this.cbPalvelu.Location = new System.Drawing.Point(174, 230);
            this.cbPalvelu.Name = "cbPalvelu";
            this.cbPalvelu.Size = new System.Drawing.Size(186, 28);
            this.cbPalvelu.TabIndex = 20;
            // 
            // lblTahanEmail
            // 
            this.lblTahanEmail.AutoSize = true;
            this.lblTahanEmail.Location = new System.Drawing.Point(174, 389);
            this.lblTahanEmail.Name = "lblTahanEmail";
            this.lblTahanEmail.Size = new System.Drawing.Size(64, 20);
            this.lblTahanEmail.TabIndex = 19;
            this.lblTahanEmail.Text = "lblEmail";
            this.lblTahanEmail.Visible = false;
            // 
            // lblTahanSukunimi
            // 
            this.lblTahanSukunimi.AutoSize = true;
            this.lblTahanSukunimi.Location = new System.Drawing.Point(174, 353);
            this.lblTahanSukunimi.Name = "lblTahanSukunimi";
            this.lblTahanSukunimi.Size = new System.Drawing.Size(91, 20);
            this.lblTahanSukunimi.TabIndex = 18;
            this.lblTahanSukunimi.Text = "lblSukunimi";
            this.lblTahanSukunimi.Visible = false;
            // 
            // lblTahanEtunimi
            // 
            this.lblTahanEtunimi.AutoSize = true;
            this.lblTahanEtunimi.Location = new System.Drawing.Point(174, 317);
            this.lblTahanEtunimi.Name = "lblTahanEtunimi";
            this.lblTahanEtunimi.Size = new System.Drawing.Size(80, 20);
            this.lblTahanEtunimi.TabIndex = 17;
            this.lblTahanEtunimi.Text = "lblEtunimi";
            this.lblTahanEtunimi.Visible = false;
            // 
            // lblTahanMokkiID
            // 
            this.lblTahanMokkiID.AutoSize = true;
            this.lblTahanMokkiID.Location = new System.Drawing.Point(174, 194);
            this.lblTahanMokkiID.Name = "lblTahanMokkiID";
            this.lblTahanMokkiID.Size = new System.Drawing.Size(85, 20);
            this.lblTahanMokkiID.TabIndex = 16;
            this.lblTahanMokkiID.Text = "lblMokkiID";
            this.lblTahanMokkiID.Visible = false;
            // 
            // lblTahanAsiakasID
            // 
            this.lblTahanAsiakasID.AutoSize = true;
            this.lblTahanAsiakasID.Location = new System.Drawing.Point(174, 158);
            this.lblTahanAsiakasID.Name = "lblTahanAsiakasID";
            this.lblTahanAsiakasID.Size = new System.Drawing.Size(95, 20);
            this.lblTahanAsiakasID.TabIndex = 15;
            this.lblTahanAsiakasID.Text = "lblAsiakasID";
            this.lblTahanAsiakasID.Visible = false;
            // 
            // lblTahanVarausID
            // 
            this.lblTahanVarausID.AutoSize = true;
            this.lblTahanVarausID.Location = new System.Drawing.Point(174, 122);
            this.lblTahanVarausID.Name = "lblTahanVarausID";
            this.lblTahanVarausID.Size = new System.Drawing.Size(89, 20);
            this.lblTahanVarausID.TabIndex = 14;
            this.lblTahanVarausID.Text = "lblVarausID";
            this.lblTahanVarausID.Visible = false;
            // 
            // dtpLahto
            // 
            this.dtpLahto.Location = new System.Drawing.Point(136, 79);
            this.dtpLahto.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpLahto.Name = "dtpLahto";
            this.dtpLahto.Size = new System.Drawing.Size(250, 27);
            this.dtpLahto.TabIndex = 13;
            this.dtpLahto.Value = new System.DateTime(2023, 5, 2, 14, 53, 42, 0);
            // 
            // dtpSaapuminen
            // 
            this.dtpSaapuminen.Location = new System.Drawing.Point(136, 36);
            this.dtpSaapuminen.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpSaapuminen.Name = "dtpSaapuminen";
            this.dtpSaapuminen.Size = new System.Drawing.Size(250, 27);
            this.dtpSaapuminen.TabIndex = 12;
            this.dtpSaapuminen.Value = new System.DateTime(2023, 5, 2, 14, 53, 33, 0);
            this.dtpSaapuminen.ValueChanged += new System.EventHandler(this.dtpSaapuminen_ValueChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(6, 392);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(115, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Varaajan email:";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSukunimi.Location = new System.Drawing.Point(6, 353);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(141, 20);
            this.lblSukunimi.TabIndex = 10;
            this.lblSukunimi.Text = "Varaajan sukunimi:";
            // 
            // btnPoista
            // 
            this.btnPoista.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoista.Location = new System.Drawing.Point(217, 440);
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
            this.btnViePaivitys.Location = new System.Drawing.Point(70, 440);
            this.btnViePaivitys.Name = "btnViePaivitys";
            this.btnViePaivitys.Size = new System.Drawing.Size(108, 49);
            this.btnViePaivitys.TabIndex = 8;
            this.btnViePaivitys.Text = "Päivitä";
            this.btnViePaivitys.UseVisualStyleBackColor = true;
            this.btnViePaivitys.Click += new System.EventHandler(this.btnViePaivitys_Click);
            // 
            // lblLahto
            // 
            this.lblLahto.AutoSize = true;
            this.lblLahto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLahto.Location = new System.Drawing.Point(6, 80);
            this.lblLahto.Name = "lblLahto";
            this.lblLahto.Size = new System.Drawing.Size(53, 20);
            this.lblLahto.TabIndex = 2;
            this.lblLahto.Text = "Lähtö:";
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEtunimi.Location = new System.Drawing.Point(6, 314);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(131, 20);
            this.lblEtunimi.TabIndex = 3;
            this.lblEtunimi.Text = "Varaajan etunimi:";
            // 
            // lblSaapuminen
            // 
            this.lblSaapuminen.AutoSize = true;
            this.lblSaapuminen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaapuminen.Location = new System.Drawing.Point(6, 41);
            this.lblSaapuminen.Name = "lblSaapuminen";
            this.lblSaapuminen.Size = new System.Drawing.Size(99, 20);
            this.lblSaapuminen.TabIndex = 1;
            this.lblSaapuminen.Text = "Saapuminen:";
            // 
            // lblAsiakasID
            // 
            this.lblAsiakasID.AutoSize = true;
            this.lblAsiakasID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAsiakasID.Location = new System.Drawing.Point(6, 158);
            this.lblAsiakasID.Name = "lblAsiakasID";
            this.lblAsiakasID.Size = new System.Drawing.Size(86, 20);
            this.lblAsiakasID.TabIndex = 7;
            this.lblAsiakasID.Text = "Asiakas ID:";
            // 
            // lblMokkiID
            // 
            this.lblMokkiID.AutoSize = true;
            this.lblMokkiID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMokkiID.Location = new System.Drawing.Point(6, 197);
            this.lblMokkiID.Name = "lblMokkiID";
            this.lblMokkiID.Size = new System.Drawing.Size(76, 20);
            this.lblMokkiID.TabIndex = 5;
            this.lblMokkiID.Text = "Mökki ID:";
            // 
            // lblVarausID
            // 
            this.lblVarausID.AutoSize = true;
            this.lblVarausID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVarausID.Location = new System.Drawing.Point(6, 119);
            this.lblVarausID.Name = "lblVarausID";
            this.lblVarausID.Size = new System.Drawing.Size(80, 20);
            this.lblVarausID.TabIndex = 0;
            this.lblVarausID.Text = "Varaus ID:";
            // 
            // Form_Varaukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 953);
            this.Controls.Add(this.btnEtsi);
            this.Controls.Add(this.tbEtsiVarausta);
            this.Controls.Add(this.dgvVaraukset);
            this.Controls.Add(this.BtnLataaVaraukset);
            this.Controls.Add(this.BtnKopioiTiedot);
            this.Controls.Add(this.gbVarauksenTiedot);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Varaukset";
            this.Text = "Varausten hallinta";
            this.Load += new System.EventHandler(this.Form_Varaukset_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.gbVarauksenTiedot.ResumeLayout(false);
            this.gbVarauksenTiedot.PerformLayout();
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
        private Button btnEtsi;
        private TextBox tbEtsiVarausta;
        private DataGridView dgvVaraukset;
        private Button BtnLataaVaraukset;
        private Button BtnKopioiTiedot;
        private GroupBox gbVarauksenTiedot;
        private Label lblTahanEmail;
        private Label lblTahanSukunimi;
        private Label lblTahanEtunimi;
        private Label lblTahanMokkiID;
        private Label lblTahanAsiakasID;
        private Label lblTahanVarausID;
        private DateTimePicker dtpLahto;
        private DateTimePicker dtpSaapuminen;
        private Label lblEmail;
        private Label lblSukunimi;
        private Button btnPoista;
        private Button btnViePaivitys;
        private Label lblLahto;
        private Label lblEtunimi;
        private Label lblSaapuminen;
        private Label lblAsiakasID;
        private Label lblMokkiID;
        private Label lblVarausID;
        private Label lblPalvelu;
        private ComboBox cbPalvelu;
        private TextBox tbPalveluidenlkm;
        private Label label1;
    }
}