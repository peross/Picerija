namespace Picerija.Forme.Artikli
{
    partial class frmArtikliInfo
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
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.snimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelGornjiPanel = new System.Windows.Forms.Panel();
            this.GornjiPanelLabel = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.gornjiPanel = new System.Windows.Forms.Panel();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProizvoda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJedMjere = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnObrisiSliku = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.labelGornjiPanel.SuspendLayout();
            this.gornjiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem,
            this.toolStripMenuItem1,
            this.snimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.izlazToolStripMenuItem.Text = "&Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // snimiToolStripMenuItem
            // 
            this.snimiToolStripMenuItem.Name = "snimiToolStripMenuItem";
            this.snimiToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.snimiToolStripMenuItem.Text = "Snimi";
            this.snimiToolStripMenuItem.Click += new System.EventHandler(this.snimiToolStripMenuItem_Click);
            // 
            // labelGornjiPanel
            // 
            this.labelGornjiPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelGornjiPanel.Controls.Add(this.GornjiPanelLabel);
            this.labelGornjiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGornjiPanel.Location = new System.Drawing.Point(0, 0);
            this.labelGornjiPanel.Name = "labelGornjiPanel";
            this.labelGornjiPanel.Size = new System.Drawing.Size(600, 53);
            this.labelGornjiPanel.TabIndex = 0;
            // 
            // GornjiPanelLabel
            // 
            this.GornjiPanelLabel.AutoSize = true;
            this.GornjiPanelLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GornjiPanelLabel.ForeColor = System.Drawing.Color.White;
            this.GornjiPanelLabel.Location = new System.Drawing.Point(229, 14);
            this.GornjiPanelLabel.Name = "GornjiPanelLabel";
            this.GornjiPanelLabel.Size = new System.Drawing.Size(129, 29);
            this.GornjiPanelLabel.TabIndex = 0;
            this.GornjiPanelLabel.Text = "Novi artikl";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(318, 200);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 22);
            this.txtCijena.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cijena (KM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Jed. mjere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Naziv artikla";
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Location = new System.Drawing.Point(318, 90);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(266, 22);
            this.txtNazivArtikla.TabIndex = 0;
            this.txtNazivArtikla.TextChanged += new System.EventHandler(this.txtNazivArtikla_TextChanged);
            // 
            // gornjiPanel
            // 
            this.gornjiPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gornjiPanel.Controls.Add(this.cmbKategorije);
            this.gornjiPanel.Controls.Add(this.label6);
            this.gornjiPanel.Controls.Add(this.txtIdProizvoda);
            this.gornjiPanel.Controls.Add(this.label4);
            this.gornjiPanel.Controls.Add(this.cmbJedMjere);
            this.gornjiPanel.Controls.Add(this.label1);
            this.gornjiPanel.Controls.Add(this.txtOpis);
            this.gornjiPanel.Controls.Add(this.btnObrisiSliku);
            this.gornjiPanel.Controls.Add(this.btnDodajSliku);
            this.gornjiPanel.Controls.Add(this.txtNazivArtikla);
            this.gornjiPanel.Controls.Add(this.label2);
            this.gornjiPanel.Controls.Add(this.label3);
            this.gornjiPanel.Controls.Add(this.label5);
            this.gornjiPanel.Controls.Add(this.txtCijena);
            this.gornjiPanel.Controls.Add(this.pcbLogo);
            this.gornjiPanel.Controls.Add(this.labelGornjiPanel);
            this.gornjiPanel.Location = new System.Drawing.Point(5, 29);
            this.gornjiPanel.Name = "gornjiPanel";
            this.gornjiPanel.Size = new System.Drawing.Size(602, 351);
            this.gornjiPanel.TabIndex = 2;
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(318, 121);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(266, 24);
            this.cmbKategorije.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Kategorija";
            // 
            // txtIdProizvoda
            // 
            this.txtIdProizvoda.Enabled = false;
            this.txtIdProizvoda.Location = new System.Drawing.Point(318, 60);
            this.txtIdProizvoda.Name = "txtIdProizvoda";
            this.txtIdProizvoda.Size = new System.Drawing.Size(100, 22);
            this.txtIdProizvoda.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Id";
            // 
            // cmbJedMjere
            // 
            this.cmbJedMjere.FormattingEnabled = true;
            this.cmbJedMjere.Location = new System.Drawing.Point(318, 159);
            this.cmbJedMjere.Name = "cmbJedMjere";
            this.cmbJedMjere.Size = new System.Drawing.Size(100, 24);
            this.cmbJedMjere.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(318, 242);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(266, 91);
            this.txtOpis.TabIndex = 39;
            // 
            // btnObrisiSliku
            // 
            this.btnObrisiSliku.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisiSliku.BackgroundImage = global::Picerija.Properties.Resources.Remove_Image_48px;
            this.btnObrisiSliku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnObrisiSliku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiSliku.FlatAppearance.BorderSize = 0;
            this.btnObrisiSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiSliku.Location = new System.Drawing.Point(114, 191);
            this.btnObrisiSliku.Name = "btnObrisiSliku";
            this.btnObrisiSliku.Size = new System.Drawing.Size(28, 28);
            this.btnObrisiSliku.TabIndex = 38;
            this.btnObrisiSliku.UseVisualStyleBackColor = false;
            this.btnObrisiSliku.Click += new System.EventHandler(this.btnObrisiSliku_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.BackColor = System.Drawing.Color.Transparent;
            this.btnDodajSliku.BackgroundImage = global::Picerija.Properties.Resources.Add_Image_48px_1;
            this.btnDodajSliku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDodajSliku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajSliku.FlatAppearance.BorderSize = 0;
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSliku.Location = new System.Drawing.Point(84, 191);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(28, 28);
            this.btnDodajSliku.TabIndex = 37;
            this.btnDodajSliku.UseVisualStyleBackColor = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.White;
            this.pcbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbLogo.Image = global::Picerija.Properties.Resources.no_photo;
            this.pcbLogo.Location = new System.Drawing.Point(19, 14);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(204, 171);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // frmArtikliInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 389);
            this.Controls.Add(this.gornjiPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmArtikliInfo";
            this.Text = "Dodavanje novog artikla";
            this.Load += new System.EventHandler(this.frmArtikliInfo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.labelGornjiPanel.ResumeLayout(false);
            this.labelGornjiPanel.PerformLayout();
            this.gornjiPanel.ResumeLayout(false);
            this.gornjiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem snimiToolStripMenuItem;
        private System.Windows.Forms.Panel labelGornjiPanel;
        private System.Windows.Forms.Label GornjiPanelLabel;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.Panel gornjiPanel;
        private System.Windows.Forms.Button btnObrisiSliku;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cmbJedMjere;
        private System.Windows.Forms.TextBox txtIdProizvoda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.Label label6;
    }
}