using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class OsiguranoLice
    {
        public int OsiguranoLiceId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string LBO { get; set; }
        public string KrvnaGrupa { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
