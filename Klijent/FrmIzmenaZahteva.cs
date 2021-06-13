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
    public partial class FrmIzmenaZahteva : Form
    {
        public Zahtev z;


        public FrmIzmenaZahteva(Zahtev z)
        {
            InitializeComponent();
            this.z = z;
        }

        private void FrmIzmenaZahteva_Load(object sender, EventArgs e)
        {
            

            cmbTip.Items.AddRange(new string[] { "PCR", "Seroloski", "Antitela" });
            cmbRezultat.Items.AddRange(new string[] { "Pozitivan", "Negativan" });
            cmbStatus.Items.AddRange(new string[] { "Obradjen", "Neobradjen", "Nedostaju podaci" });
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (cmbTip.SelectedItem == null ||
                cmbRezultat.SelectedItem == null ||
                cmbStatus.SelectedItem == null ||
                txtNapomena.Text == "")
            {
                MessageBox.Show("Sva polja prilikom izmene su obavezna!!!");
                return;
            }

            z.DatumVremeRezultata = DateTime.Now;
            z.Tip = (string)cmbTip.SelectedItem;
            z.Rezultat = (string)cmbRezultat.SelectedItem;
            z.Status = (string)cmbStatus.SelectedItem;
            z.Napomena = txtNapomena.Text;

            this.Close();
        }
    }
}
