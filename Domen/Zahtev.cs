using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Zahtev
    {
        public int ZahtevId { get; set; }
        public DateTime DatumVremeTestiranja { get; set; }
        public bool Hitno { get; set; }
        public string Tip { get; set; }
        public string Rezultat { get; set; }
        public DateTime DatumVremeRezultata { get; set; }
        public string Napomena { get; set; }
        public string Status { get; set; }
        public OsiguranoLice OsiguranoLice { get; set; }
        public Laboratorija Laboratorija { get; set; }
        public Laborant Laborant { get; set; }
    }
}
