namespace Mokkiprojekti
{
    partial class Form_AlueetPalvelut
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
            dgvAlueet = new DataGridView();
            dgvPalvelut = new DataGridView();
            btnLataaalue = new Button();
            btnLataapalvelu = new Button();
            btnHaealue = new Button();
            btnHaepalvelu = new Button();
            tbHaealue = new TextBox();
            tbHaepalvelu = new TextBox();
            gbAlueidenhallinta = new GroupBox();
            btnPoistaalue = new Button();
            btnMuokkaaaluetta = new Button();
            btnLisaaalue = new Button();
            tbAlueennimi = new TextBox();
            label1 = new Label();
            gbPalveluidenhallinta = new GroupBox();
            btnPoistapalvelu = new Button();
            btnMuokkaapalvelua = new Button();
            cbAlueid = new ComboBox();
            btnLisaapalvelu = new Button();
            tbAlv = new TextBox();
            tbHinta = new TextBox();
            tbKuvaus = new TextBox();
            tbTyyppi = new TextBox();
            tbPalvelunnimi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnKopioipalvelu = new Button();
            btnKopioialue = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlueet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPalvelut).BeginInit();
            gbAlueidenhallinta.SuspendLayout();
            gbPalveluidenhallinta.SuspendLayout();
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
            // dgvAlueet
            // 
            dgvAlueet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlueet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlueet.Location = new Point(485, 106);
            dgvAlueet.Name = "dgvAlueet";
            dgvAlueet.RowHeadersWidth = 51;
            dgvAlueet.RowTemplate.Height = 29;
            dgvAlueet.Size = new Size(605, 227);
            dgvAlueet.TabIndex = 17;
            // 
            // dgvPalvelut
            // 
            dgvPalvelut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPalvelut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPalvelut.Location = new Point(485, 423);
            dgvPalvelut.Name = "dgvPalvelut";
            dgvPalvelut.RowHeadersWidth = 51;
            dgvPalvelut.RowTemplate.Height = 29;
            dgvPalvelut.Size = new Size(923, 399);
            dgvPalvelut.TabIndex = 21;
            // 
            // btnLataaalue
            // 
            btnLataaalue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLataaalue.Location = new Point(631, 53);
            btnLataaalue.Name = "btnLataaalue";
            btnLataaalue.Size = new Size(120, 37);
            btnLataaalue.TabIndex = 14;
            btnLataaalue.Text = "Lataa ";
            btnLataaalue.UseVisualStyleBackColor = true;
            btnLataaalue.Click += btnLataaalue_Click;
            // 
            // btnLataapalvelu
            // 
            btnLataapalvelu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLataapalvelu.Location = new Point(631, 370);
            btnLataapalvelu.Name = "btnLataapalvelu";
            btnLataapalvelu.Size = new Size(120, 37);
            btnLataapalvelu.TabIndex = 18;
            btnLataapalvelu.Text = "Lataa ";
            btnLataapalvelu.UseVisualStyleBackColor = true;
            btnLataapalvelu.Click += btnLataapalvelu_Click;
            // 
            // btnHaealue
            // 
            btnHaealue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHaealue.Location = new Point(958, 53);
            btnHaealue.Name = "btnHaealue";
            btnHaealue.Size = new Size(120, 37);
            btnHaealue.TabIndex = 16;
            btnHaealue.Text = "Hae";
            btnHaealue.UseVisualStyleBackColor = true;
            btnHaealue.Click += btnHaealue_Click;
            // 
            // btnHaepalvelu
            // 
            btnHaepalvelu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHaepalvelu.Location = new Point(958, 370);
            btnHaepalvelu.Name = "btnHaepalvelu";
            btnHaepalvelu.Size = new Size(120, 37);
            btnHaepalvelu.TabIndex = 20;
            btnHaepalvelu.Text = "Hae";
            btnHaepalvelu.UseVisualStyleBackColor = true;
            btnHaepalvelu.Click += btnHaepalvelu_Click;
            // 
            // tbHaealue
            // 
            tbHaealue.Location = new Point(768, 58);
            tbHaealue.Name = "tbHaealue";
            tbHaealue.Size = new Size(170, 27);
            tbHaealue.TabIndex = 15;
            // 
            // tbHaepalvelu
            // 
            tbHaepalvelu.Location = new Point(768, 375);
            tbHaepalvelu.Name = "tbHaepalvelu";
            tbHaepalvelu.Size = new Size(170, 27);
            tbHaepalvelu.TabIndex = 19;
            // 
            // gbAlueidenhallinta
            // 
            gbAlueidenhallinta.Controls.Add(btnPoistaalue);
            gbAlueidenhallinta.Controls.Add(btnMuokkaaaluetta);
            gbAlueidenhallinta.Controls.Add(btnLisaaalue);
            gbAlueidenhallinta.Controls.Add(tbAlueennimi);
            gbAlueidenhallinta.Controls.Add(label1);
            gbAlueidenhallinta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbAlueidenhallinta.Location = new Point(20, 59);
            gbAlueidenhallinta.Name = "gbAlueidenhallinta";
            gbAlueidenhallinta.Size = new Size(415, 245);
            gbAlueidenhallinta.TabIndex = 33;
            gbAlueidenhallinta.TabStop = false;
            gbAlueidenhallinta.Text = "Alueiden hallinta";
            // 
            // btnPoistaalue
            // 
            btnPoistaalue.Location = new Point(286, 134);
            btnPoistaalue.Name = "btnPoistaalue";
            btnPoistaalue.Size = new Size(109, 47);
            btnPoistaalue.TabIndex = 4;
            btnPoistaalue.Text = "Poista";
            btnPoistaalue.UseVisualStyleBackColor = true;
            btnPoistaalue.Click += btnPoistaalue_Click;
            // 
            // btnMuokkaaaluetta
            // 
            btnMuokkaaaluetta.Location = new Point(147, 134);
            btnMuokkaaaluetta.Name = "btnMuokkaaaluetta";
            btnMuokkaaaluetta.Size = new Size(109, 47);
            btnMuokkaaaluetta.TabIndex = 3;
            btnMuokkaaaluetta.Text = "Muokkaa";
            btnMuokkaaaluetta.UseVisualStyleBackColor = true;
            btnMuokkaaaluetta.Click += btnMuokkaaaluetta_Click;
            // 
            // btnLisaaalue
            // 
            btnLisaaalue.Location = new Point(10, 134);
            btnLisaaalue.Name = "btnLisaaalue";
            btnLisaaalue.Size = new Size(109, 47);
            btnLisaaalue.TabIndex = 2;
            btnLisaaalue.Text = "Lisää";
            btnLisaaalue.UseVisualStyleBackColor = true;
            btnLisaaalue.Click += btnLisaaalue_Click;
            // 
            // tbAlueennimi
            // 
            tbAlueennimi.Location = new Point(121, 68);
            tbAlueennimi.Name = "tbAlueennimi";
            tbAlueennimi.Size = new Size(274, 27);
            tbAlueennimi.TabIndex = 1;
            tbAlueennimi.Leave += tbAlueennimi_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 68);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Alueen nimi:";
            // 
            // gbPalveluidenhallinta
            // 
            gbPalveluidenhallinta.Controls.Add(btnPoistapalvelu);
            gbPalveluidenhallinta.Controls.Add(btnMuokkaapalvelua);
            gbPalveluidenhallinta.Controls.Add(cbAlueid);
            gbPalveluidenhallinta.Controls.Add(btnLisaapalvelu);
            gbPalveluidenhallinta.Controls.Add(tbAlv);
            gbPalveluidenhallinta.Controls.Add(tbHinta);
            gbPalveluidenhallinta.Controls.Add(tbKuvaus);
            gbPalveluidenhallinta.Controls.Add(tbTyyppi);
            gbPalveluidenhallinta.Controls.Add(tbPalvelunnimi);
            gbPalveluidenhallinta.Controls.Add(label7);
            gbPalveluidenhallinta.Controls.Add(label6);
            gbPalveluidenhallinta.Controls.Add(label5);
            gbPalveluidenhallinta.Controls.Add(label4);
            gbPalveluidenhallinta.Controls.Add(label3);
            gbPalveluidenhallinta.Controls.Add(label2);
            gbPalveluidenhallinta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbPalveluidenhallinta.Location = new Point(12, 423);
            gbPalveluidenhallinta.Name = "gbPalveluidenhallinta";
            gbPalveluidenhallinta.Size = new Size(415, 480);
            gbPalveluidenhallinta.TabIndex = 34;
            gbPalveluidenhallinta.TabStop = false;
            gbPalveluidenhallinta.Text = "Palveluiden hallinta";
            // 
            // btnPoistapalvelu
            // 
            btnPoistapalvelu.Location = new Point(294, 276);
            btnPoistapalvelu.Name = "btnPoistapalvelu";
            btnPoistapalvelu.Size = new Size(109, 47);
            btnPoistapalvelu.TabIndex = 13;
            btnPoistapalvelu.Text = "Poista";
            btnPoistapalvelu.UseVisualStyleBackColor = true;
            btnPoistapalvelu.Click += btnPoistapalvelu_Click;
            // 
            // btnMuokkaapalvelua
            // 
            btnMuokkaapalvelua.Location = new Point(155, 276);
            btnMuokkaapalvelua.Name = "btnMuokkaapalvelua";
            btnMuokkaapalvelua.Size = new Size(109, 47);
            btnMuokkaapalvelua.TabIndex = 12;
            btnMuokkaapalvelua.Text = "Muokkaa";
            btnMuokkaapalvelua.UseVisualStyleBackColor = true;
            btnMuokkaapalvelua.Click += btnMuokkaapalvelua_Click;
            // 
            // cbAlueid
            // 
            cbAlueid.FormattingEnabled = true;
            cbAlueid.Location = new Point(139, 46);
            cbAlueid.Name = "cbAlueid";
            cbAlueid.Size = new Size(243, 28);
            cbAlueid.TabIndex = 5;
            // 
            // btnLisaapalvelu
            // 
            btnLisaapalvelu.Location = new Point(18, 276);
            btnLisaapalvelu.Name = "btnLisaapalvelu";
            btnLisaapalvelu.Size = new Size(109, 47);
            btnLisaapalvelu.TabIndex = 11;
            btnLisaapalvelu.Text = "Lisää";
            btnLisaapalvelu.UseVisualStyleBackColor = true;
            btnLisaapalvelu.Click += btnLisaapalvelu_Click;
            // 
            // tbAlv
            // 
            tbAlv.Location = new Point(139, 212);
            tbAlv.Name = "tbAlv";
            tbAlv.Size = new Size(243, 27);
            tbAlv.TabIndex = 10;
            tbAlv.KeyPress += tbAlv_KeyPress;
            // 
            // tbHinta
            // 
            tbHinta.Location = new Point(139, 179);
            tbHinta.Name = "tbHinta";
            tbHinta.Size = new Size(243, 27);
            tbHinta.TabIndex = 9;
            tbHinta.KeyPress += tbHinta_KeyPress;
            // 
            // tbKuvaus
            // 
            tbKuvaus.Location = new Point(139, 146);
            tbKuvaus.Name = "tbKuvaus";
            tbKuvaus.Size = new Size(243, 27);
            tbKuvaus.TabIndex = 8;
            tbKuvaus.Leave += tbKuvaus_Leave;
            // 
            // tbTyyppi
            // 
            tbTyyppi.Location = new Point(139, 113);
            tbTyyppi.Name = "tbTyyppi";
            tbTyyppi.Size = new Size(243, 27);
            tbTyyppi.TabIndex = 7;
            tbTyyppi.KeyPress += tbTyyppi_KeyPress;
            // 
            // tbPalvelunnimi
            // 
            tbPalvelunnimi.Location = new Point(139, 80);
            tbPalvelunnimi.Name = "tbPalvelunnimi";
            tbPalvelunnimi.Size = new Size(243, 27);
            tbPalvelunnimi.TabIndex = 6;
            tbPalvelunnimi.Leave += tbPalvelunnimi_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 210);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 0;
            label7.Text = "Alv.:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 177);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 0;
            label6.Text = "Hinta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 111);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 0;
            label5.Text = "Tyyppi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 143);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 0;
            label4.Text = "Kuvaus:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 79);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Palvelun nimi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 44);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Alue_id:";
            // 
            // btnKopioipalvelu
            // 
            btnKopioipalvelu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKopioipalvelu.Location = new Point(485, 370);
            btnKopioipalvelu.Name = "btnKopioipalvelu";
            btnKopioipalvelu.Size = new Size(120, 37);
            btnKopioipalvelu.TabIndex = 35;
            btnKopioipalvelu.Text = "Kopioi";
            btnKopioipalvelu.UseVisualStyleBackColor = true;
            btnKopioipalvelu.Click += btnKopioipalvelu_Click;
            // 
            // btnKopioialue
            // 
            btnKopioialue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKopioialue.Location = new Point(485, 53);
            btnKopioialue.Name = "btnKopioialue";
            btnKopioialue.Size = new Size(120, 37);
            btnKopioialue.TabIndex = 36;
            btnKopioialue.Text = "Kopioi";
            btnKopioialue.UseVisualStyleBackColor = true;
            btnKopioialue.Click += btnKopioialue_Click;
            // 
            // Form_AlueetPalvelut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 953);
            Controls.Add(btnKopioialue);
            Controls.Add(btnKopioipalvelu);
            Controls.Add(gbPalveluidenhallinta);
            Controls.Add(gbAlueidenhallinta);
            Controls.Add(tbHaepalvelu);
            Controls.Add(tbHaealue);
            Controls.Add(btnHaepalvelu);
            Controls.Add(btnHaealue);
            Controls.Add(btnLataapalvelu);
            Controls.Add(btnLataaalue);
            Controls.Add(dgvPalvelut);
            Controls.Add(dgvAlueet);
            Controls.Add(menuStrip1);
            Name = "Form_AlueetPalvelut";
            Text = "Alueet ja palvelut - hallinnoi";
            Load += Form_AlueetPalvelut_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlueet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPalvelut).EndInit();
            gbAlueidenhallinta.ResumeLayout(false);
            gbAlueidenhallinta.PerformLayout();
            gbPalveluidenhallinta.ResumeLayout(false);
            gbPalveluidenhallinta.PerformLayout();
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
        private DataGridView dgvAlueet;
        private DataGridView dgvPalvelut;
        private Button btnLataaalue;
        private Button btnLataapalvelu;
        private Button btnHaealue;
        private Button btnHaepalvelu;
        private TextBox tbHaealue;
        private TextBox tbHaepalvelu;
        private GroupBox gbAlueidenhallinta;
        private TextBox tbAlueennimi;
        private Label label1;
        private GroupBox gbPalveluidenhallinta;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tbAlv;
        private TextBox tbHinta;
        private TextBox tbKuvaus;
        private TextBox tbTyyppi;
        private TextBox tbPalvelunnimi;
        private Button btnLisaaalue;
        private Button btnLisaapalvelu;
        private ComboBox cbAlueid;
        private Label label2;
        private Button btnPoistaalue;
        private Button btnMuokkaaaluetta;
        private Button btnPoistapalvelu;
        private Button btnMuokkaapalvelua;
        private Button btnKopioipalvelu;
        private Button btnKopioialue;
    }
}