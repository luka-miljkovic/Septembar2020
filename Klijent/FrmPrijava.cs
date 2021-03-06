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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();

            
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            Komunikacija.GetInstance().PoveziSeNaServer();

            txtKorisnickoIme.Text = "ana";
            txtLozinka.Text = "ana";
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            Laborant k = new Laborant
            {
                KorisnickoIme = txtKorisnickoIme.Text,
                Lozinka = txtLozinka.Text
            };
            k = Komunikacija.GetInstance().PrijaviKorisnika(k);

            if(k != null)
            {
                this.Hide();
                new FrmKlijent(k).ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Neuspesna prijava! Probajte opet");
            }

        }
    }
}
