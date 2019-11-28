using DB;
using DB.Windows;
using Picerija.Forme.Teme;
using Picerija.Modeli.Radnici;
using Picerija.Upotreba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picerija.Forme
{
    public partial class frmPrijava : frmTema
    {
        public static string postaviIme = "";
        public static string postaviSifru = "";
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            postaviIme = txtKorIme.Text;
            postaviSifru = txtSifra.Text;
            if (formaValidna())
            {
                DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
                bool detaljiPrijaveTacni = Convert.ToBoolean(db.vratiSkalarnuVrijednost("provjeraPrijave", vratiParametre()));
                if (detaljiPrijaveTacni)
                {
                    this.Hide();
                    frmKontrolnaTabla forma = new frmKontrolnaTabla();
                    forma.Show();
                }
                else
                {
                    Obavjestenja.prikaziPorukuGreska("Netačno korisničko ime ili šifra.");
                }
            }
        }


        private DbParametri[] vratiParametre()
        {
            List<DbParametri> parametri = new List<DbParametri>();

            DbParametri dbparam1 = new DbParametri();
            dbparam1.Parametar = "@KorIme";
            dbparam1.Vrijednost = txtKorIme.Text;
            parametri.Add(dbparam1);


            DbParametri dbparam2 = new DbParametri();
            dbparam2.Parametar = "@Sifra";
            dbparam2.Vrijednost = txtSifra.Text;
            parametri.Add(dbparam2);

            return parametri.ToArray();
        }

        private bool formaValidna()
        {
            if(txtKorIme.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti korisničko ime.");
                txtKorIme.Clear();
                txtKorIme.Focus();
                return false;
            }

            if (txtSifra.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti šifru.");
                txtSifra.Clear();
                txtSifra.Focus();
                return false;
            }
            return true;
        }
    }
}
