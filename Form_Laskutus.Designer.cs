namespace Mokkiprojekti
{
    partial class Form_Laskutus
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
            this.dgvLasku2 = new System.Windows.Forms.DataGridView();
            this.dgvLasku1 = new System.Windows.Forms.DataGridView();
            this.gbLasku = new System.Windows.Forms.GroupBox();
            this.lblErapva = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTila = new System.Windows.Forms.Label();
            this.rbMyohassa = new System.Windows.Forms.RadioButton();
            this.rbMaksettu = new System.Windows.Forms.RadioButton();
            this.rbMaksamaton = new System.Windows.Forms.RadioButton();
            this.lblVarausID = new System.Windows.Forms.Label();
            this.btnLisaaLasku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYhteensa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbALV = new System.Windows.Forms.TextBox();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.tbHae1 = new System.Windows.Forms.TextBox();
            this.btnHaeVaraus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPoistaLasku = new System.Windows.Forms.Button();
            this.btnLuoPDF = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku1)).BeginInit();
            this.gbLasku.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // dgvLasku2
            // 
            this.dgvLasku2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLasku2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLasku2.Location = new System.Drawing.Point(394, 363);
            this.dgvLasku2.Name = "dgvLasku2";
            this.dgvLasku2.RowHeadersWidth = 51;
            this.dgvLasku2.RowTemplate.Height = 29;
            this.dgvLasku2.Size = new System.Drawing.Size(906, 188);
            this.dgvLasku2.TabIndex = 8;
            this.dgvLasku2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLasku2_CellClick);
            this.dgvLasku2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLasku2_MouseDoubleClick);
            // 
            // dgvLasku1
            // 
            this.dgvLasku1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLasku1.Location = new System.Drawing.Point(394, 116);
            this.dgvLasku1.Name = "dgvLasku1";
            this.dgvLasku1.RowHeadersWidth = 51;
            this.dgvLasku1.RowTemplate.Height = 29;
            this.dgvLasku1.Size = new System.Drawing.Size(1156, 188);
            this.dgvLasku1.TabIndex = 7;
            this.dgvLasku1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLasku1_CellClick);
            // 
            // gbLasku
            // 
            this.gbLasku.Controls.Add(this.lblErapva);
            this.gbLasku.Controls.Add(this.lbl4);
            this.gbLasku.Controls.Add(this.panel1);
            this.gbLasku.Controls.Add(this.lblVarausID);
            this.gbLasku.Controls.Add(this.btnLisaaLasku);
            this.gbLasku.Controls.Add(this.label1);
            this.gbLasku.Controls.Add(this.lblYhteensa);
            this.gbLasku.Controls.Add(this.label4);
            this.gbLasku.Controls.Add(this.label3);
            this.gbLasku.Controls.Add(this.lbl2);
            this.gbLasku.Controls.Add(this.lbl1);
            this.gbLasku.Controls.Add(this.tbALV);
            this.gbLasku.Controls.Add(this.tbSumma);
            this.gbLasku.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbLasku.Location = new System.Drawing.Point(12, 132);
            this.gbLasku.Name = "gbLasku";
            this.gbLasku.Size = new System.Drawing.Size(364, 423);
            this.gbLasku.TabIndex = 9;
            this.gbLasku.TabStop = false;
            this.gbLasku.Text = "Laskun tiedot";
            // 
            // lblErapva
            // 
            this.lblErapva.AutoSize = true;
            this.lblErapva.Location = new System.Drawing.Point(124, 227);
            this.lblErapva.Name = "lblErapva";
            this.lblErapva.Size = new System.Drawing.Size(18, 20);
            this.lblErapva.TabIndex = 24;
            this.lblErapva.Text = "0";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(22, 229);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(72, 20);
            this.lbl4.TabIndex = 23;
            this.lbl4.Text = "Eräpäivä:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTila);
            this.panel1.Controls.Add(this.rbMyohassa);
            this.panel1.Controls.Add(this.rbMaksettu);
            this.panel1.Controls.Add(this.rbMaksamaton);
            this.panel1.Location = new System.Drawing.Point(103, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 120);
            this.panel1.TabIndex = 22;
            // 
            // lblTila
            // 
            this.lblTila.AutoSize = true;
            this.lblTila.Location = new System.Drawing.Point(172, 50);
            this.lblTila.Name = "lblTila";
            this.lblTila.Size = new System.Drawing.Size(0, 20);
            this.lblTila.TabIndex = 3;
            // 
            // rbMyohassa
            // 
            this.rbMyohassa.AutoSize = true;
            this.rbMyohassa.Location = new System.Drawing.Point(21, 81);
            this.rbMyohassa.Name = "rbMyohassa";
            this.rbMyohassa.Size = new System.Drawing.Size(106, 24);
            this.rbMyohassa.TabIndex = 2;
            this.rbMyohassa.TabStop = true;
            this.rbMyohassa.Text = "Erääntynyt";
            this.rbMyohassa.UseVisualStyleBackColor = true;
            // 
            // rbMaksettu
            // 
            this.rbMaksettu.AutoSize = true;
            this.rbMaksettu.Location = new System.Drawing.Point(21, 41);
            this.rbMaksettu.Name = "rbMaksettu";
            this.rbMaksettu.Size = new System.Drawing.Size(96, 24);
            this.rbMaksettu.TabIndex = 1;
            this.rbMaksettu.TabStop = true;
            this.rbMaksettu.Text = "Maksettu";
            this.rbMaksettu.UseVisualStyleBackColor = true;
            // 
            // rbMaksamaton
            // 
            this.rbMaksamaton.AutoSize = true;
            this.rbMaksamaton.Location = new System.Drawing.Point(21, 3);
            this.rbMaksamaton.Name = "rbMaksamaton";
            this.rbMaksamaton.Size = new System.Drawing.Size(112, 24);
            this.rbMaksamaton.TabIndex = 0;
            this.rbMaksamaton.TabStop = true;
            this.rbMaksamaton.Text = "Ei maksettu";
            this.rbMaksamaton.UseVisualStyleBackColor = true;
            // 
            // lblVarausID
            // 
            this.lblVarausID.AutoSize = true;
            this.lblVarausID.Location = new System.Drawing.Point(124, 43);
            this.lblVarausID.Name = "lblVarausID";
            this.lblVarausID.Size = new System.Drawing.Size(0, 20);
            this.lblVarausID.TabIndex = 21;
            // 
            // btnLisaaLasku
            // 
            this.btnLisaaLasku.Enabled = false;
            this.btnLisaaLasku.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLisaaLasku.Location = new System.Drawing.Point(102, 388);
            this.btnLisaaLasku.Name = "btnLisaaLasku";
            this.btnLisaaLasku.Size = new System.Drawing.Size(112, 29);
            this.btnLisaaLasku.TabIndex = 17;
            this.btnLisaaLasku.Text = "Lisää lasku";
            this.btnLisaaLasku.UseVisualStyleBackColor = true;
            this.btnLisaaLasku.Click += new System.EventHandler(this.btnLisaaLasku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tila:";
            // 
            // lblYhteensa
            // 
            this.lblYhteensa.AutoSize = true;
            this.lblYhteensa.Location = new System.Drawing.Point(124, 185);
            this.lblYhteensa.Name = "lblYhteensa";
            this.lblYhteensa.Size = new System.Drawing.Size(18, 20);
            this.lblYhteensa.TabIndex = 18;
            this.lblYhteensa.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Yhteensä: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "ALV/%";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(22, 91);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(66, 20);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "Summa:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(22, 43);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(84, 20);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "Varaus ID: ";
            // 
            // tbALV
            // 
            this.tbALV.Location = new System.Drawing.Point(103, 136);
            this.tbALV.Name = "tbALV";
            this.tbALV.Size = new System.Drawing.Size(145, 27);
            this.tbALV.TabIndex = 12;
            this.tbALV.Text = "24";
            this.tbALV.TextChanged += new System.EventHandler(this.tbSumma_TextChanged);
            this.tbALV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbALV_KeyPress);
            // 
            // tbSumma
            // 
            this.tbSumma.Location = new System.Drawing.Point(103, 87);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.Size = new System.Drawing.Size(145, 27);
            this.tbSumma.TabIndex = 11;
            this.tbSumma.TextChanged += new System.EventHandler(this.tbSumma_TextChanged);
            this.tbSumma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSumma_KeyPress);
            // 
            // tbHae1
            // 
            this.tbHae1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbHae1.Location = new System.Drawing.Point(512, 82);
            this.tbHae1.Name = "tbHae1";
            this.tbHae1.Size = new System.Drawing.Size(306, 27);
            this.tbHae1.TabIndex = 13;
            // 
            // btnHaeVaraus
            // 
            this.btnHaeVaraus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHaeVaraus.Location = new System.Drawing.Point(394, 82);
            this.btnHaeVaraus.Name = "btnHaeVaraus";
            this.btnHaeVaraus.Size = new System.Drawing.Size(112, 29);
            this.btnHaeVaraus.TabIndex = 14;
            this.btnHaeVaraus.Text = "Hae varaukset";
            this.btnHaeVaraus.UseVisualStyleBackColor = true;
            this.btnHaeVaraus.Click += new System.EventHandler(this.btnHaeVaraus_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(824, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Laskuta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(394, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 29);
            this.button2.TabIndex = 21;
            this.button2.Text = "Lataa laskut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPoistaLasku
            // 
            this.btnPoistaLasku.Enabled = false;
            this.btnPoistaLasku.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoistaLasku.Location = new System.Drawing.Point(966, 325);
            this.btnPoistaLasku.Name = "btnPoistaLasku";
            this.btnPoistaLasku.Size = new System.Drawing.Size(112, 29);
            this.btnPoistaLasku.TabIndex = 22;
            this.btnPoistaLasku.Text = "Poista lasku";
            this.btnPoistaLasku.UseVisualStyleBackColor = true;
            this.btnPoistaLasku.Click += new System.EventHandler(this.btnPoistaLasku_Click);
            // 
            // btnLuoPDF
            // 
            this.btnLuoPDF.Enabled = false;
            this.btnLuoPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuoPDF.Location = new System.Drawing.Point(115, 561);
            this.btnLuoPDF.Name = "btnLuoPDF";
            this.btnLuoPDF.Size = new System.Drawing.Size(112, 29);
            this.btnLuoPDF.TabIndex = 25;
            this.btnLuoPDF.Text = "Luo PDF-lasku";
            this.btnLuoPDF.UseVisualStyleBackColor = true;
            this.btnLuoPDF.Click += new System.EventHandler(this.btnLuoPDF_Click);
            // 
            // Form_Laskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 953);
            this.Controls.Add(this.btnLuoPDF);
            this.Controls.Add(this.btnPoistaLasku);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHaeVaraus);
            this.Controls.Add(this.gbLasku);
            this.Controls.Add(this.dgvLasku2);
            this.Controls.Add(this.dgvLasku1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbHae1);
            this.Name = "Form_Laskutus";
            this.Text = "Laskutus";
            this.Load += new System.EventHandler(this.Form_Laskutus_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku1)).EndInit();
            this.gbLasku.ResumeLayout(false);
            this.gbLasku.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private DataGridView dgvLasku2;
        private DataGridView dgvLasku1;
        private GroupBox gbLasku;
        private TextBox tbALV;
        private TextBox tbHae1;
        private TextBox tbSumma;
        private Label lbl1;
        private Label lblYhteensa;
        private Label label4;
        private Label label3;
        private Label lbl2;
        private Label label1;
        private Button btnHaeVaraus;
        private Button button1;
        private Button btnLisaaLasku;
        private Button button2;
        private Button btnPoistaLasku;
        private Label lblVarausID;
        private Panel panel1;
        private RadioButton rbMyohassa;
        private RadioButton rbMaksettu;
        private RadioButton rbMaksamaton;
        private Label lblTila;
        private Label lbl4;
        private Label lblErapva;
        private Button btnLuoPDF;
    }
}