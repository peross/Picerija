using DB;
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

namespace Picerija.Forme.Izvjestaji
{
    public partial class frmIzvjestaji : frmTema
    {
        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            prikaziIzvjestaj();
        }

        private void prikaziIzvjestaj()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVCH0L3;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("pregledProdajePoMjesecu", con);
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@odDatuma",SqlDbType.Date).Value = dtpOd.Value.Date;
            cmd.Parameters.Add("@doDatuma", SqlDbType.Date).Value = dtpDo.Value.Date;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvIzjvestaj.DataSource = dt;
            con.Close(); 
        }

        private void btnPrikaziPojedinca_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVCH0L3;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("pregledProdajePoRadniku", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ImeRadnika", SqlDbType.NVarChar).Value = txtImeProdavnca.Text.Trim();
            cmd.Parameters.Add("@PrezimeRadnika", SqlDbType.NVarChar).Value = txtPrezimeProdavca.Text.Trim();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvIzjvestaj.DataSource = dt;
            con.Close(); 
        }

        private void btnPrikaziPotrosnjuPoDanu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IVCH0L3;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("ukupnaPotrosnjaPoDanu", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Datum", SqlDbType.Date).Value = dtpPotrosenoPoDanu.Value.Date;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvIzjvestaj.DataSource = dt;
            con.Close(); 
        }

    }
}
