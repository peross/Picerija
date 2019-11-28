using DB;
using Picerija.Forme.Artikli;
using Picerija.Forme.Kasa;
using Picerija.Forme.Radnici;
using Picerija.Forme.Teme;
using Picerija.Upotreba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Picerija.Modeli.Radnici;
using Picerija.Forme.Izvjestaji;
using DB.Windows;

namespace Picerija.Forme
{
    public partial class frmKontrolnaTabla : frmTema
    {
        public static string imeRadnika = "";
        public static string prezimeRadnika = "";
        public frmKontrolnaTabla()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ArtikliToolStripButton_Click(object sender, EventArgs e)
        {
            frmUpravljajArtiklima forma = new frmUpravljajArtiklima();
            forma.ShowDialog();
        }

        private void KasaToolStripButton_Click(object sender, EventArgs e)
        {
            frmKasa forma = new frmKasa();
            forma.ShowDialog();
        }

        private void UpravljajKorisinicimaToolStripButton_Click(object sender, EventArgs e)
        {
            frmUpravljajRadnicima forma = new frmUpravljajRadnicima();
            forma.ShowDialog();
        }

        private void frmKontrolnaTabla_Load(object sender, EventArgs e)
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());

            DataTable dtArikli = db.vratiPodatkeLista("infoKorisnik", new DbParametri
            {
                Parametar = "@KorIme",
                Vrijednost = frmPrijava.postaviIme
            });
            DataRow red = dtArikli.Rows[0];

            lblIme.Text = red["Ime"].ToString() + " " + red["Prezime"].ToString();
            pcbKorisnik.Image = (red["Slika"] is DBNull) ? null : SlikaUpravljanje.staviSliku((byte[])red["Slika"]);
            pcbKorisnik.BackgroundImage = null;
            pcbKorisnik.BackColor = Color.Transparent;
            
            if (pcbKorisnik.Image == null)
                pcbKorisnik.BackgroundImage = Picerija.Properties.Resources.no_photo;

            snimiZapis("detaljiPrijavljivanja"); //ubacivanje korisnika nakon prijave u tabelu prijava

            imeRadnika = red["Ime"].ToString();
            prezimeRadnika = red["Prezime"].ToString();
        }

        private void snimiZapis(string storedProceIme)
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            db.snimiIliAzurirajZapis(storedProceIme, vratiObjekt());
        }

        private PrijaveRadnika vratiObjekt()
        {
            PrijaveRadnika radnik = new PrijaveRadnika();
            radnik.KorIme = frmPrijava.postaviIme;
            radnik.Sifra = frmPrijava.postaviSifru;
            radnik.DatumPrijave = dtpPrijava.Value.Date;
            return radnik;
        }

        private void OdjavaToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrijava forma = new frmPrijava();
            forma.Show();
        }

        private void lblIme_MouseEnter(object sender, EventArgs e)
        {
            pcbKorisnik.Visible = true;
        }

        private void lblIme_MouseLeave(object sender, EventArgs e)
        {
            pcbKorisnik.Visible = false;
        }

        private void IzvjestajiToolStripButton_Click(object sender, EventArgs e)
        {
            frmIzvjestaji forma = new frmIzvjestaji();
            forma.ShowDialog();
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOaplikaciji forma = new frmOaplikaciji();
            forma.ShowDialog();
        }

        private void PomocPodrskaToolStripButton_Click(object sender, EventArgs e)
        {
            Obavjestenja.prikaziPorukuUspjesno("Ukoliko imate nekih pitanja možete me kontaktirati putem mejla.\npero.soldat@gmail.com");
        }
    }
}
