using Picerija.Forme.Teme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using DB.Windows;

namespace Picerija.Forme.Radnici
{
    public partial class frmMejl : frmTema
    {
        OpenFileDialog ofd;
        String imeFajla = "";
        public frmMejl()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ofd = new OpenFileDialog();
                ofd.Filter = "Slike(.jpg,.img)|*.jpg;*.png;|Pdf fajl|*.pdf";
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    imeFajla = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            //gmail smtp: smtp.gmail.com, port: 587
            //yahoo smtp: smtp.mail.yahoo.com, port: 587
            SmtpClient klijentDetalji = new SmtpClient();
            klijentDetalji.Port = Convert.ToInt32(txtPort.Text.Trim());
            klijentDetalji.Host = txtSMTP.Text.Trim();
            klijentDetalji.EnableSsl = cbSsl.Checked;
            klijentDetalji.DeliveryMethod = SmtpDeliveryMethod.Network;
            klijentDetalji.UseDefaultCredentials = false;
            klijentDetalji.Credentials = new NetworkCredential(txtEmailPosiljaoca.Text.Trim(), txtSifra.Text.Trim());

            MailMessage mejlDetalji = new MailMessage();
            mejlDetalji.From = new MailAddress(txtEmailPosiljaoca.Text.Trim());
            mejlDetalji.To.Add(txtEmailPrimaoca.Text.Trim());

            mejlDetalji.Subject = txtNaslov.Text.Trim();
            mejlDetalji.Body = rtxtPoruka.Text.Trim();

            if(imeFajla.Length>0)
            {
                Attachment prilog = new Attachment(imeFajla);
                mejlDetalji.Attachments.Add(prilog);
            }

            klijentDetalji.Send(mejlDetalji);
            Obavjestenja.prikaziPorukuUspjesno("Poruka je uspješno poslata!");
            imeFajla = "";
        }

        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSMTP.Text = "smtp.gmail.com";
            txtPort.Text = "587";
            cbSsl.Checked = true;
        }

        private void yahooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSMTP.Text = "smtp.mail.yahoo.com";
            txtPort.Text = "587";
            cbSsl.Checked = true;
        }

        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSMTP.Text = "smtp-mail.outlook.com";
            txtPort.Text = "587";
            cbSsl.Checked = true;
        }

        private void hotmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSMTP.Text = "smtp.live.com";
            txtPort.Text = "587";
            cbSsl.Checked = true;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
