using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmKlijent : Form
    {
        private Laborant korisnik;

        public FrmKlijent(Laborant korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void FrmKlijent_Load(object sender, EventArgs e)
        {
            
        }
    }
}
