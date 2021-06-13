using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
