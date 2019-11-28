using Picerija.Forme.Azuriranje;
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

namespace Picerija.Forme
{
    public partial class frmOaplikaciji : frmTema
    {
        public frmOaplikaciji()
        {
            InitializeComponent();
        }

        private void frmOaplikaciji_Load(object sender, EventArgs e)
        {
            lblVerzija.Text = Application.ProductVersion;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
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
                if (MessageBox.Show("Verzija " + novaVerzija.Major + "." + novaVerzija.Minor + "." + novaVerzija.Build + " aplikacije je sada dostupna.\nDa li želite da skinete novu verziju?", "Obavještenje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    frmAzuriranje forma = new frmAzuriranje();
                    forma.ShowDialog();
                }
            }
            else
                MessageBox.Show("Najnovija verzija aplikacije je već instalirana.", "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
