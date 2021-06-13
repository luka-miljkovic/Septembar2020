using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Laborant
    {
        public int LaborantId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public Laboratorija Laboratorija { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
