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

namespace Server
{
    public partial class FrmServer : Form
    {
        Server s = new Server();
        Timer t;
        BindingList<Test> testovi;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            if (s.PokreniServer())
            {
                
            }

            txtDanOd.Text = "07.07.2021.";
            txtDanDo.Text = "03.03.2021.";

            cmbLaboratorija.DataSource = Broker.GetInstance().VratiLaboratorije();

            t = new Timer();
            t.Interval = 5000;
            t.Tick += Osvezi;
            t.Start();

            
        }

        private void Osvezi(object sender, EventArgs e)
        {
            testovi = new BindingList<Test>();

            testovi.Add(new Test { NazivTesta = "PCR" });
            testovi.Add(new Test { NazivTesta = "Seroloski" });
            testovi.Add(new Test { NazivTesta = "Antitela" });

            string uslov = "";
            /*if(cbDanOd.Checked && cbDanDo.Checked && cbLaboratorija.Checked)
            {
                try
                {
                    DateTime datumOd = Convert.ToDateTime(txtDanOd.Text);
                    DateTime datumDo = Convert.ToDateTime(txtDanDo.Text);
                    Laboratorija lab = (Laboratorija)cmbLaboratorija.SelectedItem;

                    uslov += $"and DatumVremeRezultata > {datumOd} and " +
                        $"DatumVremeRezultata < {datumDo} and " +
                        $"LaboratorijaID = {lab.LaboratorijaId}";
                }
                catch (Exception)
                {
                    MessageBox.Show("Niste uneli lepo datum");
                    uslov = "";
                }
            }

            if(cbDanOd.Checked && cbDanDo.Checked)
            {
                try
                {
                    DateTime datumOd = Convert.ToDateTime(txtDanOd.Text);
                    DateTime datumDo = Convert.ToDateTime(txtDanDo.Text);

                    uslov += $"and DatumVremeRezultata > {datumOd} and " +
                        $"DatumVremeRezultata < {datumDo}";
                        
                }
                catch (Exception)
                {
                    MessageBox.Show("Niste uneli lepo datum");
                    uslov = "";
                }
            }

            if (cbDanOd.Checked && cbLaboratorija.Checked)
            {
                try
                {
                    DateTime datumOd = Convert.ToDateTime(txtDanOd.Text);
                    Laboratorija lab = (Laboratorija)cmbLaboratorija.SelectedItem;

                    uslov += $"and DatumVremeRezultata > {datumOd} and " +
                        $"LaboratorijaID = {lab.LaboratorijaId}";
                }
                catch (Exception)
                {
                    MessageBox.Show("Niste uneli lepo datum");
                    uslov = "";
                }
            }

            if (cbDanDo.Checked && cbLaboratorija.Checked)
            {
                try
                {
                    DateTime datumDo = Convert.ToDateTime(txtDanDo.Text);
                    Laboratorija lab = (Laboratorija)cmbLaboratorija.SelectedItem;

                    uslov += $"and DatumVremeRezultata < {datumDo} and " +
                        $"LaboratorijaID = {lab.LaboratorijaId}";
                }
                catch (Exception)
                {
                    MessageBox.Show("Niste uneli lepo datum");
                    uslov = "";
                }
            }*/

            if (cbDanOd.Checked)
            {
                try
                {
                    DateTime datumOd = Convert.ToDateTime(txtDanOd.Text);
                    //MessageBox.Show(datumOd.ToString("yyyyMMdd"));

                    uslov += $" and DatumVremeRezultata > '{datumOd.ToString("yyyyMMdd")}'";
                }
                catch (Exception)
                {
                    MessageBox.Show("Niste uneli lepo datum");
                    uslov += "";
                }
            }

            if (cbDanDo.Checked)
            {
                try
                {
                    DateTime datumDo = Convert.ToDateTime(txtDanDo.Text);
                    //MessageBox.Show(datumDo.ToString("yyyyMMdd"));

                    uslov += $" and DatumVremeRezultata < '{datumDo.ToString("yyyyMMdd")}'";
                }
                catch (Exception)
                {
                    MessageBox.Show("Niste uneli lepo datum");
                    uslov += "";
                }
            }

            if (cbLaboratorija.Checked)
            {
                Laboratorija lab = (Laboratorija)cmbLaboratorija.SelectedItem;

                uslov += $" and LaboratorijaID = {lab.LaboratorijaId}";
                
            }

            foreach (Test t in testovi)
            {
                t.BrojPozitivnih = Broker.GetInstance().BrojPozitivnih(t.NazivTesta, uslov);
                t.BrojNegativnih = Broker.GetInstance().BrojNegativnih(t.NazivTesta, uslov);
            }

            dgvTestovi.DataSource = testovi;
        }
    }
}
