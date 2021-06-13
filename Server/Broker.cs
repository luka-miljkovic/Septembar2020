using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Broker
    {
        SqlConnection connection;
        SqlCommand command;
        SqlTransaction transaction;

        void connect()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProSoft-Septembar2020;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            command = connection.CreateCommand();
        }

        Broker()
        {
            connect();
        }

        private static Broker Instance;

        public static Broker GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Broker();
            }
            return Instance;
        }

        void Template()
        {
            try
            {
                connection.Open();
                command.CommandText = $"";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        internal object PrijaviKorisnika(Laborant korisnik)
        {
            Laborant l = new Laborant();
            try
            {
                connection.Open();
                command.CommandText = $"select * from Laborant " +
                    $"where KorisnickoIme = '{korisnik.KorisnickoIme}' " +
                    $"and Lozinka = '{korisnik.Lozinka}'";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    l.LaborantId = (int)reader[0];
                    l.Ime = (string)reader[1];
                    l.Prezime = (string)reader[2];
                    l.KorisnickoIme = korisnik.KorisnickoIme;
                    l.Lozinka = korisnik.Lozinka;
                    l.Laboratorija = new Laboratorija { LaboratorijaId = (int)reader[5] };
                }
                else
                {
                    l = null;
                }
                reader.Close();
                if(l != null && l.Laboratorija != null)
                    l.Laboratorija = VratiLaboratoriju(l.Laboratorija.LaboratorijaId);
                return l;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        internal bool SacuvajIzmene(List<Zahtev> zahtevi)
        {
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                command = new SqlCommand("", connection, transaction);
                foreach(Zahtev z in zahtevi)
                {
                    if(z.Status == "Obradjen")
                    {
                        command.CommandText = $"update Zahtev " +
                            $"set Tip = '{z.Tip}', Rezultat = '{z.Rezultat}', DatumVremeRezultata = '{z.DatumVremeRezultata.ToString("MM/dd/yyyy hh:mm tt")}', Napomena = '{z.Napomena}', Status = 'Obradjen'" +
                            $"where ZahtevID = {z.ZahtevId}";
                        command.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                transaction.Rollback();
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        //internal List<Zahtev> VratiNeobradjeneZahteve(int laboratorijaId)
        //{
        //    List<Zahtev> zahtevi = new List<Zahtev>();
        //    try
        //    {
        //        connection.Open();
        //        command.CommandText = $"select * from Zahtev z join OsiguranoLice ol " +
        //            $"on(z.OsiguranoLiceID = ol.OsiguranoLiceID) " +
        //            $"where z.LaboratorijaID = {laboratorijaId} and z.Status = 'Neobradjen'";
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            Zahtev z = new Zahtev();
        //            z.ZahtevId = (int)reader[0];
        //            z.DatumVremeTestiranja = Convert.ToDateTime(reader[1]);
        //            if (Convert.ToBoolean(reader[2]))
        //                z.Hitno = true;
        //            else
        //                z.Hitno = false;
        //            //if (reader[3] == DBNull.Value)
        //            //    z.Tip = "";
        //            //else
        //            //    z.Tip = (string)reader[3];
        //            //if (reader[4] == DBNull.Value)
        //            //    z.Rezultat = "";
        //            //else
        //            //    z.Rezultat = (string)reader[4];
        //            z.Status = "Neobradjen";
        //            z.OsiguranoLice = new OsiguranoLice { OsiguranoLiceId = (int)reader[8] };
        //            z.Laboratorija = new Laboratorija { LaboratorijaId = (int)reader[9] };

        //            zahtevi.Add(z);
        //        }
        //        reader.Close();

        //        foreach (Zahtev z in zahtevi)
        //        {
        //            z.OsiguranoLice = VratiOsiguranoLice(z.OsiguranoLice.OsiguranoLiceId);
        //            z.Laboratorija = VratiLaboratoriju(z.Laboratorija.LaboratorijaId);
        //        }

        //        return zahtevi;
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //        throw;
        //    }
        //    finally
        //    {
        //        if (connection != null)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        //pesacki nacin bez join upita
        internal List<Zahtev> VratiNeobradjeneZahteve(Laborant laborant)
        {
            List<Zahtev> zahtevi = new List<Zahtev>();
            try
            {
                connection.Open();
                command.CommandText = $"select * from Zahtev where Status = 'Neobradjen' " +
                    $"and LaboratorijaID = {laborant.Laboratorija.LaboratorijaId}";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Zahtev z = new Zahtev();
                    z.ZahtevId = (int)reader[0];
                    z.DatumVremeTestiranja = Convert.ToDateTime(reader[1]);
                    if (Convert.ToBoolean(reader[2]))
                        z.Hitno = true;
                    else
                        z.Hitno = false;
                    if (reader[3] == DBNull.Value)
                        z.Tip = "";
                    else
                        z.Tip = (string)reader[3];
                    if (reader[4] == DBNull.Value)
                        z.Rezultat = "";
                    else
                        z.Rezultat = (string)reader[4];
                    if (reader[5] != DBNull.Value)
                        z.DatumVremeRezultata = Convert.ToDateTime(reader[5]);
                    if (reader[6] == DBNull.Value)
                        z.Napomena = "";
                    else
                        z.Napomena = (string)reader[6];
                    
                    z.Status = (string)reader[7];
                    z.OsiguranoLice = new OsiguranoLice { OsiguranoLiceId = (int)reader[8] };
                    z.Laboratorija = new Laboratorija { LaboratorijaId = (int)reader[9] };
                    z.Laborant = laborant;
                    zahtevi.Add(z);
                }
                reader.Close();

                foreach (Zahtev z in zahtevi)
                {
                    z.OsiguranoLice = VratiOsiguranoLice(z.OsiguranoLice.OsiguranoLiceId);
                    z.Laboratorija = VratiLaboratoriju(z.Laboratorija.LaboratorijaId);
                }

                return zahtevi;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private OsiguranoLice VratiOsiguranoLice(int osiguranoLiceId)
        {
            OsiguranoLice ol = new OsiguranoLice();
            try
            {
                command.CommandText = $"select * from OsiguranoLice " +
                    $"where OsiguranoLiceID = {osiguranoLiceId}";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ol.OsiguranoLiceId = osiguranoLiceId;
                    ol.Ime = (string)reader[1];
                    ol.Prezime = (string)reader[2];
                    ol.LBO = (string)reader[3];
                    ol.KrvnaGrupa = (string)reader[4];
                }
                reader.Close();
                return ol;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Laboratorija VratiLaboratoriju(int id)
        {
            Laboratorija l = new Laboratorija();
            try
            {
                command.CommandText = $"select * from Laboratorija " +
                    $"where LaboratorijaID = {id}";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    l.LaboratorijaId = id;
                    l.Naziv = (string)reader[1];
                    l.DnevniKapacitetTestova = (int)reader[2];
                    l.Grad = (string)reader[3];

                    
                }
                reader.Close();
                return l;
            }
            catch (Exception)
            {

                throw;
            }
        }

        void TemplateVratiSve()
        {
            try
            {
                connection.Open();
                command.CommandText = $"";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
