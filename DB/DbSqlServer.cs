using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DbSqlServer
    {
        //Reader, Scalar i NoQuery
        //***** PRIJAVA KORISNIKA *****
        private string _konstring;
        
        public DbSqlServer(string konstring)
        {
            _konstring = konstring;
        }

        //procedura
        public object vratiSkalarnuVrijednost(string storedProceIme)
        {
            object vrijednost = null;

            using (SqlConnection kon = new SqlConnection(_konstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = System.Data.CommandType.StoredProcedure;
                    kon.Open();

                    vrijednost = kom.ExecuteScalar();
                }
            }
            return vrijednost;
        }
        //jedan parametar
        public object vratiSkalarnuVrijednost(string storedProceIme, DbParametri parametar)
        {
            object vrijednost = null;

            using (SqlConnection kon = new SqlConnection(_konstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = System.Data.CommandType.StoredProcedure;
                    kon.Open();

                    kom.Parameters.AddWithValue(parametar.Parametar, parametar.Vrijednost);

                    vrijednost = kom.ExecuteScalar();
                }
            }
            return vrijednost;
        }
        //vise parametara
        public object vratiSkalarnuVrijednost(string storedProceIme, DbParametri[] parametri)
        {
            object vrijednost = null;

            using (SqlConnection kon = new SqlConnection(_konstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = System.Data.CommandType.StoredProcedure;
                    kon.Open();

                    foreach(var para in parametri)
                    {
                        kom.Parameters.AddWithValue(para.Parametar, para.Vrijednost);
                    }

                    vrijednost = kom.ExecuteScalar();
                }
            }
            return vrijednost;
        }

        // ***** KRAJ PRIJAVA KORISNIKA *****

        // ***** UCITAVANJE PODATAKA ZA ARTIKLE U DATAGRIDVIEW *****

        //procedura
        public DataTable vratiPodatkeLista(string storedProceIme)
        {
            DataTable dtPodaci = new DataTable();

            using (SqlConnection kon = new SqlConnection(_konstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = CommandType.StoredProcedure;
                    kon.Open();
                    SqlDataReader citac = kom.ExecuteReader();

                    dtPodaci.Load(citac);
                }
            }
            return dtPodaci;
        }

        //jedan parametar
        public DataTable vratiPodatkeLista(string storedProceIme, DbParametri parametar)
        {
            DataTable dtPodaci = new DataTable();

            using (SqlConnection kon = new SqlConnection(_konstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = CommandType.StoredProcedure;
                    kon.Open();

                    kom.Parameters.AddWithValue(parametar.Parametar, parametar.Vrijednost);

                    SqlDataReader citac = kom.ExecuteReader();

                    dtPodaci.Load(citac);
                }
            }
            return dtPodaci;
        }

        //vise parametara
        public DataTable vratiPodatkeLista(string storedProceIme, DbParametri[] parametri)
        {
            DataTable dtPodaci = new DataTable();

            using (SqlConnection kon = new SqlConnection(_konstring))
            {
                using (SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = CommandType.StoredProcedure;
                    kon.Open();

                    foreach(var para in parametri)
                    kom.Parameters.AddWithValue(para.Parametar, para.Vrijednost);

                    SqlDataReader citac = kom.ExecuteReader();

                    dtPodaci.Load(citac);
                }
            }
            return dtPodaci;
        }

        // ***** KRAJ UCITAVANJA PODATAKA ZA ARTIKLE *****

        // ***** DODAVANJE/AZURIRANJE PODATAKA ***** 
        public void snimiIliAzurirajZapis(string storedProceIme, object obj)
        {
            using(SqlConnection kon = new SqlConnection(_konstring))
            {
                using(SqlCommand kom = new SqlCommand(storedProceIme, kon))
                {
                    kom.CommandType = CommandType.StoredProcedure;
                    kon.Open();

                    //parametri
                    Type tip = obj.GetType();
                    BindingFlags zastavica = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] svojsta = tip.GetProperties(zastavica);

                    foreach(var svojstvo in svojsta)
                    {
                        kom.Parameters.AddWithValue("@" + svojstvo.Name, svojstvo.GetValue(obj, null)); //dodavanje na osnovu parametara iz procedure u sql-u
                    }

                    kom.ExecuteNonQuery();
                }
            }
        }
    }
}
