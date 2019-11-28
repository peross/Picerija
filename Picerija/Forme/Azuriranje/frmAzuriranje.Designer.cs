namespace Picerija.Forme.Azuriranje
{
    partial class frmAzuriranje
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
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblVerzije = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Segoe Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriraj.Image = global::Picerija.Properties.Resources.Other_Update_Metro_icon;
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.Location = new System.Drawing.Point(96, 213);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(78, 33);
            this.btnAzuriraj.TabIndex = 11;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAzuriraj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(7, 95);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(24, 13);
            this.lblOpis.TabIndex = 10;
            this.lblOpis.Text = "Opis";
            // 
            // lblVerzije
            // 
            this.lblVerzije.Font = new System.Drawing.Font("Segoe Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVerzije.Location = new System.Drawing.Point(98, 20);
            this.lblVerzije.Name = "lblVerzije";
            this.lblVerzije.Size = new System.Drawing.Size(168, 54);
            this.lblVerzije.TabIndex = 9;
            this.lblVerzije.Text = "label1";
            this.lblVerzije.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox.Location = new System.Drawing.Point(7, 111);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(260, 96);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.TabStop = false;
            this.richTextBox.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Picerija.Properties.Resources.Network_Download_icon;
            this.pictureBox.Location = new System.Drawing.Point(10, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(80, 80);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // frmAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 252);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblVerzije);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.richTextBox);
            this.Name = "frmAzuriranje";
            this.Text = "Ažuriranje aplikacije";
            this.Load += new System.EventHandler(this.frmAzuriranje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblVerzije;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}