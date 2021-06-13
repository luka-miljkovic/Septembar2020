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
        BindingList<Zahtev> neobradjeniZahtevi;
        public FrmKlijent(Laborant korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void FrmKlijent_Load(object sender, EventArgs e)
        {
            neobradjeniZahtevi = new BindingList<Zahtev>(Komunikacija.GetInstance().VratiNeobradjeneZahteve(korisnik));

            dgvTestiranje.DataSource = neobradjeniZahtevi;
        }

        public void PopuniGrid()
        {
            DataGridViewComboBoxColumn tip = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn rezultat = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn status = new DataGridViewComboBoxColumn();
            List<string> tipovi = new List<string>();
            tipovi.Add("PCR");
            tipovi.Add("Seroloski");
            tipovi.Add("Antitela");
            tip.DataSource = tipovi;

            List<string> rezultati = new List<string>();
            rezultati.Add("Pozitivan");
            rezultati.Add("Negativan");
            rezultat.DataSource = rezultati;

            List<string> statusi = new List<string>();
            statusi.Add("Neobradjen");
            statusi.Add("Obradjen");
            statusi.Add("Nedostaju podaci");
            status.DataSource = statusi;

            tip.HeaderText = "Tip";
            tip.Name = "tip";
            tip.DataPropertyName = "Tip";
            //tip.DisplayMember = "Tip";

            rezultat.HeaderText = "Rezultat";
            tip.Name = "rezultat";
            tip.DataPropertyName = "Rezultat";

            status.HeaderText = "Status";
            status.Name = "status";
            status.DataPropertyName = "Status";

            dgvTestiranje.Columns.Add(tip);
            dgvTestiranje.Columns.Add(rezultat);
            dgvTestiranje.Columns.Add(status);
            //dgvTestiranje.Columns.Insert(3, rezultat);
            //dgvTestiranje.Columns.Insert(4, status);

            //dgvTestiranje.AutoGenerateColumns = false;

            neobradjeniZahtevi = new BindingList<Zahtev>(Komunikacija.GetInstance().VratiNeobradjeneZahteve(korisnik));

            dgvTestiranje.DataSource = neobradjeniZahtevi;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Zahtev z = (Zahtev)dgvTestiranje.CurrentRow.DataBoundItem;

            FrmIzmenaZahteva iz = new FrmIzmenaZahteva(z);
            iz.ShowDialog();

            int index = 0;
            foreach(Zahtev zahtev in neobradjeniZahtevi)
            {
                if (zahtev.ZahtevId == z.ZahtevId)
                    break;
                index++;
            }
            neobradjeniZahtevi.Remove(z);
            neobradjeniZahtevi.Insert(index, iz.z);
        }

        private void btnSacuvajIzabraneZahteve_Click(object sender, EventArgs e)
        {
            if (Komunikacija.GetInstance().SacuvajIzmene(new List<Zahtev>(neobradjeniZahtevi)))
            {
                MessageBox.Show("Izmene su uspesno sacuvane");
            }
            else
            {
                MessageBox.Show("Greska prilikom cuvanja. Izmene nisu sacuvane!");
            }
        }
    }
}
