using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MIPATemp
{
    public class Data
    {
        public readonly string db_file = AppDomain.CurrentDomain.BaseDirectory + "/db_info.txt"; //definire adresa fisier
        private static string[] db_data = { "", "", "", "" };
        public string string_conectare(string server, string user, string password, string database) //FUNCTIE DE CREARE STRING CONECTARE
        {
            return @"host = '" + server + "'; port = '3306';" + " user = '" + user + "'; password = '" + password + "'; database = '" + database + "';";
        }

        public bool VerificaBD(string server, string user, string password, string database) //VERIFICARE CONEXIUNE PENTRU PRIMA CONECTARE
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = string_conectare(server, user, password, database);
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured (check connection and values)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void ScriereBD(string server, string user, string password, string database) { //MANIPULAREA FISIERULUI CU DATE
            try
            {
                if (!File.Exists(db_file)) //CREARE FISIER
                {
                    File.AppendAllLines(db_file, [server, user, password, database]);
                }
                else //MODIFICARE EXISTENT
                {
                    File.WriteAllLines(db_file, [server, user, password, database]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
