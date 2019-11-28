﻿using Picerija.Forme;
using Picerija.Forme.Artikli;
using Picerija.Forme.Izvjestaji;
using Picerija.Forme.Kasa;
using Picerija.Forme.Radnici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picerija
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrijava());
        }
    }
}
