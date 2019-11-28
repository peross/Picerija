namespace Picerija.Forme.Kasa
{
    partial class frmKasa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrezimeProdavca = new System.Windows.Forms.Label();
            this.lblIdRadnika = new System.Windows.Forms.Label();
            this.lblImeProdavca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImeRadnika = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPonistiNarudzbu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtKolicinaStavke = new System.Windows.Forms.TextBox();
            this.txtSifraArtikla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdNarudzbe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCijenaPoJedinici = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDodajUkorpu = new System.Windows.Forms.Button();
            this.cmbArtikli = new System.Windows.Forms.ComboBox();
            this.txtUkupanIznos = new System.Windows.Forms.TextBox();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.btnStampajRacun = new System.Windows.Forms.Button();
            this.btnPregledRacuna = new System.Windows.Forms.Button();
            this.txtUkZaPlatiti = new System.Windows.Forms.TextBox();
            this.dgvPorudzba = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrišiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.obrišiToolStripMenuItem.Text = "&Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiStavku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(174)))), ((int)(((byte)(22)))));
            this.btnObrisiStavku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiStavku.FlatAppearance.BorderSize = 0;
            this.btnObrisiStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiStavku.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisiStavku.Image")));
            this.btnObrisiStavku.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnObrisiStavku.Location = new System.Drawing.Point(628, 280);
            this.btnObrisiStavku.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(216, 68);
            this.btnObrisiStavku.TabIndex = 37;
            this.btnObrisiStavku.Text = "\r\nObriši stavku\r\nDel";
            this.btnObrisiStavku.UseVisualStyleBackColor = false;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPrezimeProdavca);
            this.panel1.Controls.Add(this.lblIdRadnika);
            this.panel1.Controls.Add(this.lblImeProdavca);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblImeRadnika);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 141);
            this.panel1.TabIndex = 41;
            // 
            // lblPrezimeProdavca
            // 
            this.lblPrezimeProdavca.AutoSize = true;
            this.lblPrezimeProdavca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezimeProdavca.Location = new System.Drawing.Point(280, 114);
            this.lblPrezimeProdavca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezimeProdavca.Name = "lblPrezimeProdavca";
            this.lblPrezimeProdavca.Size = new System.Drawing.Size(45, 17);
            this.lblPrezimeProdavca.TabIndex = 11;
            this.lblPrezimeProdavca.Text = "label4";
            // 
            // lblIdRadnika
            // 
            this.lblIdRadnika.AutoSize = true;
            this.lblIdRadnika.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdRadnika.Location = new System.Drawing.Point(359, 114);
            this.lblIdRadnika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdRadnika.Name = "lblIdRadnika";
            this.lblIdRadnika.Size = new System.Drawing.Size(45, 17);
            this.lblIdRadnika.TabIndex = 10;
            this.lblIdRadnika.Text = "label4";
            this.lblIdRadnika.Visible = false;
            // 
            // lblImeProdavca
            // 
            this.lblImeProdavca.AutoSize = true;
            this.lblImeProdavca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeProdavca.Location = new System.Drawing.Point(237, 114);
            this.lblImeProdavca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImeProdavca.Name = "lblImeProdavca";
            this.lblImeProdavca.Size = new System.Drawing.Size(45, 17);
            this.lblImeProdavca.TabIndex = 5;
            this.lblImeProdavca.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Picerija.Properties.Resources.kuvar;
            this.pictureBox1.Location = new System.Drawing.Point(4, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(145, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prodajno mjesto \r\nPetra Kočića bb, Mrkonjić Grad\r\n050/212-808     065/077-415";
            // 
            // lblImeRadnika
            // 
            this.lblImeRadnika.AutoSize = true;
            this.lblImeRadnika.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeRadnika.Location = new System.Drawing.Point(145, 114);
            this.lblImeRadnika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImeRadnika.Name = "lblImeRadnika";
            this.lblImeRadnika.Size = new System.Drawing.Size(82, 16);
            this.lblImeRadnika.TabIndex = 9;
            this.lblImeRadnika.Text = "Ime radnika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(145, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Restoran 100+";
            // 
            // btnPonistiNarudzbu
            // 
            this.btnPonistiNarudzbu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPonistiNarudzbu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(41)))));
            this.btnPonistiNarudzbu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPonistiNarudzbu.FlatAppearance.BorderSize = 0;
            this.btnPonistiNarudzbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonistiNarudzbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPonistiNarudzbu.Image = ((System.Drawing.Image)(resources.GetObject("btnPonistiNarudzbu.Image")));
            this.btnPonistiNarudzbu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPonistiNarudzbu.Location = new System.Drawing.Point(628, 356);
            this.btnPonistiNarudzbu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPonistiNarudzbu.Name = "btnPonistiNarudzbu";
            this.btnPonistiNarudzbu.Size = new System.Drawing.Size(216, 68);
            this.btnPonistiNarudzbu.TabIndex = 38;
            this.btnPonistiNarudzbu.Text = "\r\nPoništi narudžbu\r\nF10";
            this.btnPonistiNarudzbu.UseVisualStyleBackColor = false;
            this.btnPonistiNarudzbu.Click += new System.EventHandler(this.btnPonistiNarudzbu_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtKolicinaStavke);
            this.panel2.Controls.Add(this.txtSifraArtikla);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIdNarudzbe);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtKolicina);
            this.panel2.Controls.Add(this.txtCijenaPoJedinici);
            this.panel2.Controls.Add(this.txtBarkod);
            this.panel2.Controls.Add(this.dtpDatum);
            this.panel2.Controls.Add(this.txtNazivArtikla);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(434, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 141);
            this.panel2.TabIndex = 36;
            // 
            // txtKolicinaStavke
            // 
            this.txtKolicinaStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKolicinaStavke.Location = new System.Drawing.Point(320, 20);
            this.txtKolicinaStavke.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicinaStavke.Name = "txtKolicinaStavke";
            this.txtKolicinaStavke.Size = new System.Drawing.Size(23, 22);
            this.txtKolicinaStavke.TabIndex = 37;
            this.txtKolicinaStavke.Text = "1";
            this.txtKolicinaStavke.Visible = false;
            // 
            // txtSifraArtikla
            // 
            this.txtSifraArtikla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifraArtikla.Location = new System.Drawing.Point(232, 20);
            this.txtSifraArtikla.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifraArtikla.Name = "txtSifraArtikla";
            this.txtSifraArtikla.Size = new System.Drawing.Size(80, 22);
            this.txtSifraArtikla.TabIndex = 36;
            this.txtSifraArtikla.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(372, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "KM";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Faktura # :";
            // 
            // txtIdNarudzbe
            // 
            this.txtIdNarudzbe.Location = new System.Drawing.Point(117, 4);
            this.txtIdNarudzbe.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdNarudzbe.Name = "txtIdNarudzbe";
            this.txtIdNarudzbe.ReadOnly = true;
            this.txtIdNarudzbe.Size = new System.Drawing.Size(163, 22);
            this.txtIdNarudzbe.TabIndex = 33;
            this.txtIdNarudzbe.Text = "1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(211, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cijena :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(30, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Kolicina :";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(117, 100);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(86, 22);
            this.txtKolicina.TabIndex = 2;
            this.txtKolicina.Text = "1";
            // 
            // txtCijenaPoJedinici
            // 
            this.txtCijenaPoJedinici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCijenaPoJedinici.Location = new System.Drawing.Point(271, 101);
            this.txtCijenaPoJedinici.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijenaPoJedinici.Name = "txtCijenaPoJedinici";
            this.txtCijenaPoJedinici.ReadOnly = true;
            this.txtCijenaPoJedinici.Size = new System.Drawing.Size(93, 22);
            this.txtCijenaPoJedinici.TabIndex = 31;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarkod.Location = new System.Drawing.Point(117, 43);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(281, 22);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatum.CustomFormat = "dd.MM.yyyy";
            this.dtpDatum.Enabled = false;
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(286, 4);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(112, 22);
            this.dtpDatum.TabIndex = 7;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNazivArtikla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNazivArtikla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNazivArtikla.Location = new System.Drawing.Point(117, 71);
            this.txtNazivArtikla.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(281, 22);
            this.txtNazivArtikla.TabIndex = 1;
            this.txtNazivArtikla.TextChanged += new System.EventHandler(this.txtNazivArtikla_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(229, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Datum :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(4, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Naziv artikla :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(48, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Šifra : ";
            // 
            // btnDodajUkorpu
            // 
            this.btnDodajUkorpu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajUkorpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.btnDodajUkorpu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajUkorpu.FlatAppearance.BorderSize = 0;
            this.btnDodajUkorpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajUkorpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajUkorpu.Image = global::Picerija.Properties.Resources.Buying_24px;
            this.btnDodajUkorpu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodajUkorpu.Location = new System.Drawing.Point(628, 204);
            this.btnDodajUkorpu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajUkorpu.Name = "btnDodajUkorpu";
            this.btnDodajUkorpu.Size = new System.Drawing.Size(216, 68);
            this.btnDodajUkorpu.TabIndex = 48;
            this.btnDodajUkorpu.Text = "\r\nDodaj u korpu\r\nEnter";
            this.btnDodajUkorpu.UseVisualStyleBackColor = false;
            this.btnDodajUkorpu.Click += new System.EventHandler(this.btnDodajUkorpu_Click);
            // 
            // cmbArtikli
            // 
            this.cmbArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbArtikli.FormattingEnabled = true;
            this.cmbArtikli.Location = new System.Drawing.Point(645, 164);
            this.cmbArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArtikli.Name = "cmbArtikli";
            this.cmbArtikli.Size = new System.Drawing.Size(199, 24);
            this.cmbArtikli.TabIndex = 47;
            this.cmbArtikli.Visible = false;
            // 
            // txtUkupanIznos
            // 
            this.txtUkupanIznos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUkupanIznos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUkupanIznos.Location = new System.Drawing.Point(636, 508);
            this.txtUkupanIznos.Margin = new System.Windows.Forms.Padding(4);
            this.txtUkupanIznos.Multiline = true;
            this.txtUkupanIznos.Name = "txtUkupanIznos";
            this.txtUkupanIznos.Size = new System.Drawing.Size(62, 43);
            this.txtUkupanIznos.TabIndex = 46;
            this.txtUkupanIznos.Text = "0.00";
            this.txtUkupanIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUkupanIznos.Visible = false;
            // 
            // txtPDV
            // 
            this.txtPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPDV.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPDV.Location = new System.Drawing.Point(702, 508);
            this.txtPDV.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDV.Multiline = true;
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.Size = new System.Drawing.Size(60, 43);
            this.txtPDV.TabIndex = 45;
            this.txtPDV.Text = "0.00";
            this.txtPDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPDV.Visible = false;
            // 
            // btnStampajRacun
            // 
            this.btnStampajRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStampajRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(178)))), ((int)(((byte)(5)))));
            this.btnStampajRacun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStampajRacun.FlatAppearance.BorderSize = 0;
            this.btnStampajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStampajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStampajRacun.Image = ((System.Drawing.Image)(resources.GetObject("btnStampajRacun.Image")));
            this.btnStampajRacun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStampajRacun.Location = new System.Drawing.Point(739, 432);
            this.btnStampajRacun.Margin = new System.Windows.Forms.Padding(4);
            this.btnStampajRacun.Name = "btnStampajRacun";
            this.btnStampajRacun.Size = new System.Drawing.Size(105, 68);
            this.btnStampajRacun.TabIndex = 40;
            this.btnStampajRacun.Text = "\r\nŠtampaj račun\r\nF12";
            this.btnStampajRacun.UseVisualStyleBackColor = false;
            this.btnStampajRacun.Click += new System.EventHandler(this.btnStampajRacun_Click);
            // 
            // btnPregledRacuna
            // 
            this.btnPregledRacuna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPregledRacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btnPregledRacuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPregledRacuna.FlatAppearance.BorderSize = 0;
            this.btnPregledRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregledRacuna.Image = ((System.Drawing.Image)(resources.GetObject("btnPregledRacuna.Image")));
            this.btnPregledRacuna.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPregledRacuna.Location = new System.Drawing.Point(628, 432);
            this.btnPregledRacuna.Margin = new System.Windows.Forms.Padding(4);
            this.btnPregledRacuna.Name = "btnPregledRacuna";
            this.btnPregledRacuna.Size = new System.Drawing.Size(105, 68);
            this.btnPregledRacuna.TabIndex = 39;
            this.btnPregledRacuna.Text = "\r\nPregled računa\r\nF11";
            this.btnPregledRacuna.UseVisualStyleBackColor = false;
            this.btnPregledRacuna.Click += new System.EventHandler(this.btnPregledRacuna_Click);
            // 
            // txtUkZaPlatiti
            // 
            this.txtUkZaPlatiti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUkZaPlatiti.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtUkZaPlatiti.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUkZaPlatiti.Location = new System.Drawing.Point(695, 552);
            this.txtUkZaPlatiti.Margin = new System.Windows.Forms.Padding(4);
            this.txtUkZaPlatiti.Multiline = true;
            this.txtUkZaPlatiti.Name = "txtUkZaPlatiti";
            this.txtUkZaPlatiti.ReadOnly = true;
            this.txtUkZaPlatiti.Size = new System.Drawing.Size(149, 69);
            this.txtUkZaPlatiti.TabIndex = 44;
            this.txtUkZaPlatiti.Text = "0.00";
            this.txtUkZaPlatiti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvPorudzba
            // 
            this.dgvPorudzba.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPorudzba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPorudzba.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPorudzba.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPorudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPorudzba.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPorudzba.EnableHeadersVisualStyles = false;
            this.dgvPorudzba.Location = new System.Drawing.Point(16, 204);
            this.dgvPorudzba.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPorudzba.Name = "dgvPorudzba";
            this.dgvPorudzba.ReadOnly = true;
            this.dgvPorudzba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPorudzba.Size = new System.Drawing.Size(604, 417);
            this.dgvPorudzba.TabIndex = 42;
            this.dgvPorudzba.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPorudzba_KeyDown);
            this.dgvPorudzba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPorudzba_MouseDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(628, 605);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ukupno : ";
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 634);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPonistiNarudzbu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDodajUkorpu);
            this.Controls.Add(this.cmbArtikli);
            this.Controls.Add(this.txtUkupanIznos);
            this.Controls.Add(this.txtPDV);
            this.Controls.Add(this.btnStampajRacun);
            this.Controls.Add(this.btnPregledRacuna);
            this.Controls.Add(this.txtUkZaPlatiti);
            this.Controls.Add(this.dgvPorudzba);
            this.Controls.Add(this.label5);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmKasa";
            this.Text = "Kasa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKasa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKasa_KeyDown);
            this.Resize += new System.EventHandler(this.frmKasa_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorudzba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Label lblImeProdavca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImeRadnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPonistiNarudzbu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdNarudzbe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtCijenaPoJedinici;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDodajUkorpu;
        private System.Windows.Forms.ComboBox cmbArtikli;
        private System.Windows.Forms.TextBox txtUkupanIznos;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Button btnStampajRacun;
        private System.Windows.Forms.Button btnPregledRacuna;
        private System.Windows.Forms.TextBox txtUkZaPlatiti;
        private System.Windows.Forms.DataGridView dgvPorudzba;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIdRadnika;
        private System.Windows.Forms.Label lblPrezimeProdavca;
        private System.Windows.Forms.TextBox txtSifraArtikla;
        private System.Windows.Forms.TextBox txtKolicinaStavke;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
    }
}