namespace Picerija.Forme.Izvjestaji
{
    partial class frmIzvjestaji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.btnPrikaziMjesec = new System.Windows.Forms.Button();
            this.dgvIzjvestaj = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezimeProdavca = new System.Windows.Forms.TextBox();
            this.txtImeProdavnca = new System.Windows.Forms.TextBox();
            this.btnPrikaziPojedinca = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziPotrosnjuPoDanu = new System.Windows.Forms.Button();
            this.dtpPotrosenoPoDanu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzjvestaj)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpOd
            // 
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOd.Location = new System.Drawing.Point(41, 16);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(106, 22);
            this.dtpOd.TabIndex = 1;
            // 
            // dtpDo
            // 
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDo.Location = new System.Drawing.Point(41, 47);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(106, 22);
            this.dtpDo.TabIndex = 2;
            // 
            // btnPrikaziMjesec
            // 
            this.btnPrikaziMjesec.Location = new System.Drawing.Point(153, 16);
            this.btnPrikaziMjesec.Name = "btnPrikaziMjesec";
            this.btnPrikaziMjesec.Size = new System.Drawing.Size(75, 52);
            this.btnPrikaziMjesec.TabIndex = 3;
            this.btnPrikaziMjesec.Text = "Prikaži";
            this.btnPrikaziMjesec.UseVisualStyleBackColor = true;
            this.btnPrikaziMjesec.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvIzjvestaj
            // 
            this.dgvIzjvestaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzjvestaj.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIzjvestaj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIzjvestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIzjvestaj.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIzjvestaj.EnableHeadersVisualStyles = false;
            this.dgvIzjvestaj.Location = new System.Drawing.Point(13, 98);
            this.dgvIzjvestaj.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIzjvestaj.Name = "dgvIzjvestaj";
            this.dgvIzjvestaj.ReadOnly = true;
            this.dgvIzjvestaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzjvestaj.Size = new System.Drawing.Size(790, 431);
            this.dgvIzjvestaj.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpOd);
            this.groupBox1.Controls.Add(this.dtpDo);
            this.groupBox1.Controls.Add(this.btnPrikaziMjesec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 79);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mjesečni izvještaj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Od:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPrezimeProdavca);
            this.groupBox2.Controls.Add(this.txtImeProdavnca);
            this.groupBox2.Controls.Add(this.btnPrikaziPojedinca);
            this.groupBox2.Location = new System.Drawing.Point(258, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 79);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pojedinačni izvještaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ime:";
            // 
            // txtPrezimeProdavca
            // 
            this.txtPrezimeProdavca.Location = new System.Drawing.Point(72, 49);
            this.txtPrezimeProdavca.Name = "txtPrezimeProdavca";
            this.txtPrezimeProdavca.Size = new System.Drawing.Size(126, 22);
            this.txtPrezimeProdavca.TabIndex = 47;
            // 
            // txtImeProdavnca
            // 
            this.txtImeProdavnca.Location = new System.Drawing.Point(72, 21);
            this.txtImeProdavnca.Name = "txtImeProdavnca";
            this.txtImeProdavnca.Size = new System.Drawing.Size(126, 22);
            this.txtImeProdavnca.TabIndex = 46;
            // 
            // btnPrikaziPojedinca
            // 
            this.btnPrikaziPojedinca.Location = new System.Drawing.Point(204, 20);
            this.btnPrikaziPojedinca.Name = "btnPrikaziPojedinca";
            this.btnPrikaziPojedinca.Size = new System.Drawing.Size(75, 51);
            this.btnPrikaziPojedinca.TabIndex = 3;
            this.btnPrikaziPojedinca.Text = "Prikaži";
            this.btnPrikaziPojedinca.UseVisualStyleBackColor = true;
            this.btnPrikaziPojedinca.Click += new System.EventHandler(this.btnPrikaziPojedinca_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtpPotrosenoPoDanu);
            this.groupBox3.Controls.Add(this.btnPrikaziPotrosnjuPoDanu);
            this.groupBox3.Location = new System.Drawing.Point(552, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 79);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ukupno potrošeno po danu";
            // 
            // btnPrikaziPotrosnjuPoDanu
            // 
            this.btnPrikaziPotrosnjuPoDanu.Location = new System.Drawing.Point(118, 18);
            this.btnPrikaziPotrosnjuPoDanu.Name = "btnPrikaziPotrosnjuPoDanu";
            this.btnPrikaziPotrosnjuPoDanu.Size = new System.Drawing.Size(75, 51);
            this.btnPrikaziPotrosnjuPoDanu.TabIndex = 3;
            this.btnPrikaziPotrosnjuPoDanu.Text = "Prikaži";
            this.btnPrikaziPotrosnjuPoDanu.UseVisualStyleBackColor = true;
            this.btnPrikaziPotrosnjuPoDanu.Click += new System.EventHandler(this.btnPrikaziPotrosnjuPoDanu_Click);
            // 
            // dtpPotrosenoPoDanu
            // 
            this.dtpPotrosenoPoDanu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPotrosenoPoDanu.Location = new System.Drawing.Point(6, 39);
            this.dtpPotrosenoPoDanu.Name = "dtpPotrosenoPoDanu";
            this.dtpPotrosenoPoDanu.Size = new System.Drawing.Size(106, 22);
            this.dtpPotrosenoPoDanu.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Izaberite dan:";
            // 
            // frmIzvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvIzjvestaj);
            this.Name = "frmIzvjestaji";
            this.Text = "Izvještaji";
            this.Load += new System.EventHandler(this.frmIzvjestaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzjvestaj)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnPrikaziMjesec;
        private System.Windows.Forms.DataGridView dgvIzjvestaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezimeProdavca;
        private System.Windows.Forms.TextBox txtImeProdavnca;
        private System.Windows.Forms.Button btnPrikaziPojedinca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPotrosenoPoDanu;
        private System.Windows.Forms.Button btnPrikaziPotrosnjuPoDanu;
    }
}