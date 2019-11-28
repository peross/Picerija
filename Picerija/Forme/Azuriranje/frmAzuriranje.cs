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
using System.Xml;

namespace Picerija.Forme.Azuriranje
{
    public partial class frmAzuriranje : frmTema
    {
        public frmAzuriranje()
        {
            InitializeComponent();
        }

        private void frmAzuriranje_Load(object sender, EventArgs e)
        {
            string opis = "";
            Version novaVerzija = null;
            string xmlUrl = "http://diplomskirad-001-site1.htempurl.com/azuriranje.xml";

            XmlTextReader citac = null;
            try
            {
                citac = new XmlTextReader(xmlUrl);
                citac.MoveToContent();
                string element = "";
                if ((citac.NodeType == XmlNodeType.Element) && citac.Name == "aplikacija")
                {
                    while (citac.Read())
                    {
                        if (citac.NodeType == XmlNodeType.Element)
                        {
                            element = citac.Name;
                        }
                        else
                        {
                            if ((citac.NodeType == XmlNodeType.Text) && (citac.HasValue))
                            {
                                switch (element)
                                {
                                    case "opis":
                                        opis = citac.Value.ToString();
                                        break;
                                    case "verzija":
                                        novaVerzija = new Version(citac.Value);
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (citac != null)
                    citac.Close();
            }
            Version aplikacija = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            richTextBox.Text = opis;
            this.lblVerzije.Text = String.Format("Trenutna verzija: {0}\nNova verzija: {1}", aplikacija.ToString(),
                novaVerzija.ToString());
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string downloadUrl = "";
            string opis = "";
            Version novaVerzija = null;
            string xmlUrl = "http://diplomskirad-001-site1.htempurl.com/azuriranje.xml";

            XmlTextReader citac = null;
            try
            {
                citac = new XmlTextReader(xmlUrl);
                citac.MoveToContent();
                string element = "";
                if ((citac.NodeType == XmlNodeType.Element) && citac.Name == "aplikacija")
                {
                    while (citac.Read())
                    {
                        if (citac.NodeType == XmlNodeType.Element)
                        {
                            element = citac.Name;
                        }
                        else
                        {
                            if ((citac.NodeType == XmlNodeType.Text) && (citac.HasValue))
                            {
                                switch (element)
                                {
                                    case "verzija":
                                        novaVerzija = new Version(citac.Value);
                                        break;
                                    case "url":
                                        downloadUrl = citac.Value;
                                        break;
                                    case "opis":
                                        opis = citac.Value.ToString();
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (citac != null)
                    citac.Close();
            }
            Version aplikacija = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (aplikacija.CompareTo(novaVerzija) < 0)
            {
                System.Diagnostics.Process.Start(downloadUrl);
            }
        }
    }
}
