using DB;
using DB.Windows;
using Picerija.Forme.Teme;
using Picerija.Modeli.Artikli;
using Picerija.Modeli.Kasa;
using Picerija.Modeli.Radnici;
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

namespace Picerija.Forme.Kasa
{
    public partial class frmKasa : frmTema
    {
        public int radnikId { get; set; }

        int panel;
        public frmKasa()
        {
            InitializeComponent();
            autopopunjavanje();
            panel = 30;
        }
        private void autopopunjavanje()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-IVCH0L3;Initial Catalog=Prodaja;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Artikli WHERE Naziv LIKE @ime", con);
            cmd.Parameters.Add(new SqlParameter("@ime", "%" + txtNazivArtikla.Text + "%"));
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            AutoCompleteStringCollection kolekcija = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                kolekcija.Add(dr.GetString(1));
            }
            txtNazivArtikla.AutoCompleteCustomSource = kolekcija;
            con.Close();
        }
        private List<ArtikliKorpa> sopingKorpa = new List<ArtikliKorpa>();
        private int brStaviPoStrani = 0;
        private int brStavkiZaStampanje = 0;
        private int novaSirinaPanela()
        {
            return this.Width / 2 - panel;
        }

        private void frmKasa_Resize(object sender, EventArgs e)
        {
            panel1.Width = novaSirinaPanela();
            panel2.Width = novaSirinaPanela();
            panel2.Location = new Point(this.Width / 2, panel2.Location.Y);
        }

        private void frmKasa_Load(object sender, EventArgs e)
        {
            generisiNoviId();

            lblImeProdavca.Text = frmKontrolnaTabla.imeRadnika;
            lblPrezimeProdavca.Text = frmKontrolnaTabla.prezimeRadnika;
            popuniCmb();
            vratiIdRadnika();
            
        }

        private void generisiNoviId()
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            txtIdNarudzbe.Text = db.vratiSkalarnuVrijednost("korpaGenerisiNoviId").ToString();
        }

        private void vratiIdRadnika()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVCH0L3;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT IdRadnika FROM Radnici WHERE Ime='" + lblImeProdavca.Text + "' AND Prezime='" + lblPrezimeProdavca.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblIdRadnika.Text = dr["IdRadnika"].ToString();
            }
            con.Close();
            
        }

        private void popuniCmb()
        {
            cmbArtikli.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVCH0L3;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Naziv, Cijena FROM Artikli";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbArtikli.Items.Add(dr["Naziv"].ToString());
            }
            con.Close();
        }

        private void btnDodajUkorpu_Click(object sender, EventArgs e)
        {
            if (formaValidna())
            {
                ArtikliKorpa stavke = new ArtikliKorpa()
                {
                    IdArtikla = Convert.ToInt32(txtBarkod.Text.Trim()),
                    Artikli = txtNazivArtikla.Text,
                    Kolicina = Convert.ToDecimal(txtKolicina.Text.Trim()),
                    CijenaPoJedinici = Convert.ToDecimal(txtCijenaPoJedinici.Text.Trim()),
                    UkupanIznos = Convert.ToDecimal(txtKolicina.Text.Trim()) * Convert.ToDecimal(txtCijenaPoJedinici.Text.Trim())
                };
                txtSifraArtikla.Text = txtBarkod.Text;
                txtKolicinaStavke.Text = txtKolicina.Text;

                sopingKorpa.Add(stavke);
                dgvPorudzba.DataSource = null;
                dgvPorudzba.DataSource = sopingKorpa;
                

                txtNazivArtikla.Clear();
                txtKolicina.Text = "1";
                txtCijenaPoJedinici.Clear();

                decimal ukupanIznos = sopingKorpa.Sum(x => x.UkupanIznos);
                decimal pdv = (17 * ukupanIznos) / 100;
                decimal iznosBezPDV = ukupanIznos - pdv;

                txtUkupanIznos.Text = iznosBezPDV.ToString();
                txtPDV.Text = pdv.ToString();
                txtUkZaPlatiti.Text = ukupanIznos.ToString(".00");

                txtBarkod.Text = "";
            }
        }

        private bool formaValidna()
        {
            int tempBarkod;
            bool jeBroj = int.TryParse(txtBarkod.Text, out tempBarkod);

            if (txtBarkod.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti šifru artikla.");
                return false;
            }
            if (txtNazivArtikla.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti naziv artikla.");
                return false;
            }
                
            if (txtKolicina.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti količinu.");
                return false;
            }
            if (txtCijenaPoJedinici.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti cijenu.");
                return false;
            }
            return true; 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Restoran 100+", new Font("Fake Receipt", 30, FontStyle.Regular),
                Brushes.Black, new Point(235, 20));
            //e.Graphics.DrawString("----------------------------------------------------------------------", new Font("Fake Receipt", 12, FontStyle.Regular),
            //    Brushes.Black, new Point(20, 80));
            e.Graphics.DrawString("Datum: " +DateTime.Now, new Font("Fake Receipt", 12, FontStyle.Regular),
                Brushes.Black, new Point(20, 170));
            e.Graphics.DrawString("Račun izdao: " + lblImeProdavca.Text.Trim() + " " + lblPrezimeProdavca.Text.Trim(), new Font("Fake Receipt", 12, FontStyle.Regular),
                Brushes.Black, new Point(20, 200));
            e.Graphics.DrawString("----------------------------------------------------------------------",
                new Font("Fake Receipt", 12, FontStyle.Regular),
                Brushes.Black, new Point(20, 220));
            e.Graphics.DrawString("Maloprodajni fiskalni račun", new Font("Fake Receipt", 12, FontStyle.Regular),
                Brushes.Black, new Point(230, 240));
            e.Graphics.DrawString("----------------------------------------------------------------------",
                new Font("Fake Receipt", 12, FontStyle.Regular),
                Brushes.Black, new Point(20, 260));
            e.Graphics.DrawString("Naziv artikla", new Font("Fake Receipt", 12, FontStyle.Regular),
                Brushes.Black, new Point(20, 280));
            e.Graphics.DrawString("Kol.", new Font("Fake Receipt", 12, FontStyle.Regular),
                Brushes.Black, new Point(380, 280));
            e.Graphics.DrawString("Cijena po kom.", new Font("Fake Receipt", 12, FontStyle.Regular),
              Brushes.Black, new Point(510, 280));
            e.Graphics.DrawString("Uk. iznos", new Font("Fake Receipt", 12, FontStyle.Regular),
              Brushes.Black, new Point(710, 280));
            e.Graphics.DrawString("----------------------------------------------------------------------",
                new Font("Fake Receipt", 12, FontStyle.Regular),
                Brushes.Black, new Point(20, 300));

            int yPozicija = 320;
            for (int i = brStavkiZaStampanje; i < sopingKorpa.Count; i++)
            {
                brStaviPoStrani++;
                if (brStaviPoStrani <= 25)
                {
                    brStavkiZaStampanje++;
                    if (brStavkiZaStampanje <= sopingKorpa.Count)
                    {
                        e.Graphics.DrawString(sopingKorpa[i].Artikli, new Font("Fake Receipt", 12, FontStyle.Regular),
            Brushes.Black, new Point(20, yPozicija));
                        e.Graphics.DrawString(sopingKorpa[i].Kolicina.ToString(), new Font("Fake Receipt", 12, FontStyle.Regular),
                      Brushes.Black, new Point(390, yPozicija));
                        e.Graphics.DrawString(sopingKorpa[i].CijenaPoJedinici.ToString(), new Font("Fake Receipt", 12, FontStyle.Regular),
                      Brushes.Black, new Point(580, yPozicija));
                        e.Graphics.DrawString(sopingKorpa[i].UkupanIznos.ToString(), new Font("Fake Receipt", 12, FontStyle.Regular),
                      Brushes.Black, new Point(750, yPozicija));
                        yPozicija += 25;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    brStaviPoStrani = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
            e.Graphics.DrawString("----------------------------------------------------------------------",
                new Font("Fake Receipt", 12, FontStyle.Regular),
                Brushes.Black, new Point(20, yPozicija));
            e.Graphics.DrawString("Ukupan iznos bez PDV-a: " + txtUkupanIznos.Text.Trim() + " KM", new Font("Fake Receipt", 12, FontStyle.Regular),
              Brushes.Black, new Point(440, yPozicija + 25));
            e.Graphics.DrawString("PDV (17%): " + txtPDV.Text.Trim() + " KM", new Font("Fake Receipt", 12, FontStyle.Regular),
              Brushes.Black, new Point(440, yPozicija + 50));
            e.Graphics.DrawString("Za uplatu: " + txtUkZaPlatiti.Text.Trim() + " KM", new Font("Fake Receipt", 12, FontStyle.Regular),
              Brushes.Black, new Point(440, yPozicija + 75));

            //restartovanje varijabli
            brStaviPoStrani = 0;
            brStavkiZaStampanje = 0;
        }

        private void btnPregledRacuna_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            snimiIliAzurirajZapis("korpaDodavanje");
            snimiIliAzurirajZapis("stavkeKorpeDodavanje");
        }

        private Korpa snimiIliAzurirajZapis(string storedProceIme)
        {
            Korpa korpa = new Korpa();
            return korpa;
        }

        private void txtNazivArtikla_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVCH0L3;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT IdProizvoda,Cijena FROM Artikli WHERE Naziv='" + txtNazivArtikla.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtBarkod.Text = dr["IdProizvoda"].ToString();
                txtCijenaPoJedinici.Text = dr["Cijena"].ToString();
            }
            con.Close();  
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            decimal tempBarkod;
            bool jeBroj = decimal.TryParse(txtBarkod.Text.Trim(), out tempBarkod);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVCH0L3;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Naziv FROM Artikli WHERE IdProizvoda='" + txtBarkod.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                txtNazivArtikla.Text = dr["Naziv"].ToString();
            }
            con.Close(); 
        }

        private void btnStampajRacun_Click(object sender, EventArgs e)
        {
            dodavanjeUkorpu("dodavanjeKorpa");
            dodavanjeStavkeKorpe();
            generisiNoviId();
            printDocument1.Print();
        }

        private void dodavanjeStavkeKorpe()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVCH0L3;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();

            for (int i = 0; i < dgvPorudzba.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StavkeKorpe(IdProizvoda, IdKorpe, Kolicina) VALUES(@idProizvoda, @idKorpe, @kolicina)", con);
                cmd.Parameters.AddWithValue("@idProizvoda", dgvPorudzba.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@idKorpe", Convert.ToInt32(txtIdNarudzbe.Text.Trim()));
                cmd.Parameters.AddWithValue("@kolicina", dgvPorudzba.Rows[i].Cells[2].Value);
                cmd.ExecuteNonQuery();
            }
        }


        private void dodavanjeUkorpu(string storedProceIme)
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            db.snimiIliAzurirajZapis(storedProceIme, vratiObjekt());
        }

        private Korpa vratiObjekt()
        {
            Korpa korpa = new Korpa();
            korpa.IdKorpe = Convert.ToInt32(txtIdNarudzbe.Text.Trim());
            korpa.IdRadnika = Convert.ToInt32(lblIdRadnika.Text.Trim());
            korpa.Datum = dtpDatum.Value.Date;
            return korpa;
        }

        private void btnPonistiNarudzbu_Click(object sender, EventArgs e)
        {
            txtSifraArtikla.Clear();
            txtKolicina.Text = "1";
            txtNazivArtikla.Clear();
            txtCijenaPoJedinici.Clear();

            dgvPorudzba.DataSource = null;
            txtUkupanIznos.Text = "0";
            txtPDV.Text = "0";
            txtUkZaPlatiti.Text = "0.00";
            sopingKorpa.Clear();
        }

        private void dgvPorudzba_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hit = dgvPorudzba.HitTest(e.X, e.Y);
                dgvPorudzba.Rows[hit.RowIndex].Selected = true;
                contextMenuStrip1.Show(dgvPorudzba, e.X, e.Y);
            }
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgvPorudzba.CurrentCell.RowIndex;
            sopingKorpa.RemoveAt(index);
            dgvPorudzba.DataSource = null;
            dgvPorudzba.DataSource = sopingKorpa;

            decimal ukupanIznos = sopingKorpa.Sum(x => x.UkupanIznos);
            decimal pdv = (17 * ukupanIznos) / 100;
            decimal iznosBezPDV = ukupanIznos - pdv;

            txtUkupanIznos.Text = iznosBezPDV.ToString();
            txtPDV.Text = pdv.ToString();
            txtUkZaPlatiti.Text = ukupanIznos.ToString("0.00");
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            int index = dgvPorudzba.CurrentCell.RowIndex;
            sopingKorpa.RemoveAt(index);
            dgvPorudzba.DataSource = null;
            dgvPorudzba.DataSource = sopingKorpa;

            decimal ukupanIznos = sopingKorpa.Sum(x => x.UkupanIznos);
            decimal pdv = (17 * ukupanIznos) / 100;
            decimal iznosBezPDV = ukupanIznos - pdv;

            txtUkupanIznos.Text = iznosBezPDV.ToString();
            txtPDV.Text = pdv.ToString();
            txtUkZaPlatiti.Text = ukupanIznos.ToString("0.00");
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            dtpDatum.Value = dtpDatum.Value.Date;
        }

        private void frmKasa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                btnPregledRacuna.PerformClick();
            if (e.KeyCode == Keys.F10)
                btnPonistiNarudzbu.PerformClick();
            if (e.KeyCode == Keys.F12)
                btnStampajRacun.PerformClick();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDodajUkorpu.PerformClick();
        }

        private void dgvPorudzba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btnObrisiStavku.PerformClick();
        }

    }
}
