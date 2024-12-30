using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPATemp
{
    public class Graph
    {
        public bool AfisatExistent = false;
        public bool steregere = false;

        public void Afisare(string string_conectare, FormsPlot T, FormsPlot U, ToolStripMenuItem Save) //AFISARE GRAFICE SI SCRIERE IN FISIERE
        {
            FormsPlot gfTemperatura = T;
            FormsPlot gfUmiditate = U;
            ToolStripMenuItem TSSave = Save;
            string adresa_conectare = string_conectare;

                gfTemperatura.Show();
                gfUmiditate.Show();

                gfTemperatura.Plot.Clear();
                gfUmiditate.Plot.Clear();

                List<float> temperatura = new List<float>();
                List<float> umiditate = new List<float>();
                List<float> timp = new List<float>();

                foreach (var line in File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "/temperatura.in")) //SCRIERE FISIER
                {
                    if (float.TryParse(line, out float val))
                    {
                        temperatura.Add(val);
                    }
                }
                foreach (var line in File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "/umiditate.in")) //SCRIERE FISIER
                {
                    if (float.TryParse(line, out float val))
                    {
                        umiditate.Add(val);
                    }
                }
                Console.Clear();
                Console.WriteLine("Timp");
                for (int i = 0; i < temperatura.Count; i++)
                {
                    timp.Add(2 * i);
                    Console.WriteLine(2 * i);
                }
                Console.WriteLine("Temperatura");
                for (int i = 0; i < temperatura.Count; i++)
                {
                    Console.WriteLine(temperatura[i]);
                }
                Console.WriteLine("Umiditate");
                for (int i = 0; i < temperatura.Count; i++)
                {
                    Console.WriteLine(umiditate[i]);
                }

                gfTemperatura.Plot.Add.Scatter(timp, temperatura);
                gfUmiditate.Plot.Add.Scatter(timp, umiditate);

                if (adresa_conectare != "")
                {
                    TSSave.Visible = true;
                }
        }
        public void Salvare(string string_conectare) //FUNCTIE SALVARE GRAFIC
        {
            MySqlConnection conn = new MySqlConnection(string_conectare);
            //citire fisiere
            float result;
            int c = 0;
            List<float> temperaturi = new List<float>();
            List<float> umiditati = new List<float>();
            List<int> timp = new List<int>();
            foreach (string line in File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "/temperatura.in"))
            {
                result = float.Parse(line);
                temperaturi.Add(result);
                timp.Add(c * 2);
                c++;
            }
            foreach (string line in File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "/umiditate.in"))
            {
                result = float.Parse(line);
                umiditati.Add(result);
            }
            //creare tabel
            //denumire
            DateTime time = DateTime.Now;
            string time_string = time.ToString("ddMMHHmmss"); //grafic + time_string
            Console.WriteLine(time_string);
            //////////
            
            conn.Open();

            MySqlCommand comanda_creare = new MySqlCommand("CREATE TABLE grafic" + time_string + " (X FLOAT, Yt FLOAT, Yu FLOAT);", conn);
            comanda_creare.ExecuteNonQuery();
            Console.Clear();
            Console.WriteLine("Salvat!");
            //scriere tabel
            for (int i = 0; i < timp.Count; i++)
            {
                using (MySqlCommand comanda_scriere = new MySqlCommand("INSERT INTO grafic" + time_string + " (X,Yt,Yu) VALUES (@X,@Yt,@Yu);", conn))
                {
                    comanda_scriere.Parameters.AddWithValue("@X", timp[i]);
                    comanda_scriere.Parameters.AddWithValue("@Yt", temperaturi[i]);
                    comanda_scriere.Parameters.AddWithValue("@Yu", umiditati[i]);

                    comanda_scriere.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
        public void Stergere(string nume_tabel, string string_conectare) //STERGERE TABEL CU GRAFIC EXISTENT
        {
            MySqlConnection conn = new MySqlConnection(string_conectare);
            try
            {
                MySqlCommand delete = new MySqlCommand("DROP TABLE " + nume_tabel, conn);
                conn.Open();
                delete.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void Existent(string nume_tabel, string string_conectare, FormsPlot T, FormsPlot U, DataGridView D) //AFISARE GRAFIC EXISTENT
        {
            if (!AfisatExistent)
            {
                AfisatExistent = true;
                FormsPlot gfTemperatura = T;
                FormsPlot gfUmiditate = U;
                DataGridView continut_bd = D;

                MySqlConnection conn = new MySqlConnection(string_conectare);
                List<float> X = new List<float>();
                List<float> Yt = new List<float>();
                List<float> Yu = new List<float>();
                MySqlCommand read = new MySqlCommand("SELECT X, Yt, Yu FROM " + nume_tabel, conn);

                conn.Open();
                try
                {
                    using (MySqlDataReader reader = read.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            X.Add(float.Parse(reader["X"].ToString()));
                            Yt.Add(float.Parse(reader["Yt"].ToString()));
                            Yu.Add(float.Parse(reader["Yu"].ToString()));
                        }
                    }
                }
                catch
                {
                    conn.Close();
                }
                conn.Close();
                //AFISARE
                continut_bd.Hide();
                gfTemperatura.Plot.Clear();
                gfUmiditate.Plot.Clear();
                gfTemperatura.Show();
                gfUmiditate.Show();
                gfTemperatura.Plot.Add.Scatter(X, Yt); //timp-temperatura
                gfUmiditate.Plot.Add.Scatter(X, Yu); //timp-umiditate
            }
        }
    }
}
