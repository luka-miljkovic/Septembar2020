using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        private static Komunikacija Instance;

        public static Komunikacija GetInstance()
        {
            if (Instance == null)
                Instance = new Komunikacija();
            return Instance;
        }

        public bool PoveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 9000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal Laborant PrijaviKorisnika(Laborant korisnik)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrijaviKorisnika;
            transfer.TransferObjekat = korisnik;
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
            return (Laborant)transfer.Rezultat;
        }

        public void Kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public void Template()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);

            transfer = (TransferKlasa)formater.Deserialize(tok);
        }
    }
}
