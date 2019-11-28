using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picerija.Modeli.Radnici
{
    public class zaposleniRadnici
    {
        public int IdRadnika { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public string Telefon { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int IdUloge { get; set; }
        public string KorIme { get; set; }
        public string Sifra { get; set; }
        public DateTime KreiranDana { get; set; }
        public byte[] Slika { get; set; }
        public string AdresaStanovanja { get; set; }
        public decimal TrenutnaPlata { get; set; }
        public decimal PocetnaPlata { get; set; }
        public string Komentar { get; set; }
    }
}
