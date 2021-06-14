using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Test
    {
        public string NazivTesta { get; set; }
        public int BrojPozitivnih { get; set; }
        public int BrojNegativnih { get; set; }
        public override string ToString()
        {
            return NazivTesta;
        }
    }
}
