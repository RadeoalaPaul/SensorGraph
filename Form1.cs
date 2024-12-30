using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Diagnostics;
using ScottPlot;
using K4os.Compression.LZ4.Streams.Adapters;
using IronPython.Compiler.Ast;
using System.Drawing.Text;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace MIPATemp
{
    public partial class Meniu_principal : Form
    {
        //VARIABILE SI INSTANTE
        Fconectare input_db = new Fconectare();
        public bool conectat = false;
        public readonly string adresa_script = AppDomain.CurrentDomain.BaseDirectory + "/script.py"; // adresa script python
        public string adresa_conectare = "";
        public string bAccesat = "";
        private string[] db_data = { "", "", "", "" };
        private bool selectat = false;
        public bool afisat = false;
        private bool afisat_gf_existent = false;
        private bool salvat = false;
        MySqlConnection conn = new MySqlConnection();
        //

        private ButtonHandler buttonHandler;
        private Graph graph;

        //
        public Meniu_principal()
        {
            InitializeComponent();

            //NOU

            buttonHandler = new ButtonHandler(this, bNou, bGE, bSE);
            graph = new Graph();

            //////

            //HIDE
            continut_bd.Hide();
            gfTemperatura.Hide();
            gfUmiditate.Hide();
            TSSave.Visible = false;
            //////
            //DATA GRID VIEW

        }
        public void HideElements()
        {
            if (gfTemperatura.Visible || gfUmiditate.Visible)
            {
                gfTemperatura.Hide();
                gfUmiditate.Hide();
                TSSave.Visible = false;
            }
        }
        public string string_conectare(string server, string user, string password, string database) //FUNCTIE DE CREARE STRING CONECTARE
        {
            return @"host = '" + server + "'; port = '3306';" + " user = '" + user + "'; password = '" + password + "'; database = '" + database + "';";
        }
        void citire_fisierDB(string adresa_fisier) //CITIRE DATE INPUT BAZA DE DATE 
        {
            db_data = File.ReadAllLines(input_db.db_file);
        }
        void salvare_grafic() //FUNCTIE SALVARE GRAFIC
        {
            graph.Salvare(adresa_conectare);
        }
        void stergere_existent(string nume_tabel) //STERGERE TABEL CU GRAFIC EXISTENT
        {
            graph.Stergere(nume_tabel, adresa_conectare);
        }
        void afisare_existent(string nume_tabel) //AFISARE GRAFIC EXISTENT
        {
            graph.Existent(nume_tabel, adresa_conectare, gfTemperatura, gfUmiditate, continut_bd);
            afisat_gf_existent = true;
        }
        public void afisare_grafica()
        {
            graph.Afisare(adresa_conectare, gfTemperatura, gfUmiditate, TSSave);
        }
        /*public void Conexiune(string buton, string string_conectare, DataGridView D) //EXTRAGEM TABELELE DIN BAZA DE DATE
        {
            continut_bd = D;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (buton == "bGE") { afisat_gf_existent = true; }
                conn.ConnectionString = adresa_conectare;
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SHOW TABLES", conn);
                DataTable data = new DataTable();
                adapter.Fill(data);
                continut_bd.DataSource = data;
                continut_bd.Show();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }*/
        public void Conexiune(string buton) //EXTRAGEM TABELELE DIN BAZA DE DATE
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if(buton == "bGE") { afisat_gf_existent = true; }
                conn.ConnectionString = adresa_conectare;
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SHOW TABLES", conn);
                DataTable data = new DataTable();
                adapter.Fill(data);
                continut_bd.DataSource = data;
                continut_bd.Show();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void bSE_Click(object sender, EventArgs e) // BUTON STERGERE GRAFIC
        {
            if (continut_bd.Visible)
            {
                continut_bd.Hide();
            }
        }
        private void bGE_Click(object sender, EventArgs e) // BUTON GRAFIC EXISTENT
        {
            if (continut_bd.Visible)
            {
                continut_bd.Hide();
            }
            if(graph.AfisatExistent)
            {
                HideElements();
                graph.AfisatExistent = false;
            }
        }
        private void bConectare_Click(object sender, EventArgs e) //BUTON CONECTARE
        {
            this.Hide();
            input_db.Show();
        }
        private void TSInfo_Click(object sender, EventArgs e) //BUTON INFO
        {
            MessageBox.Show("Software for viewing the variation of humidity and temperature in time", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TSHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connect to a database first\n1.New Graph -> Create a new Graph to put in database\n2.Delete Existent Graph - Delete a Graph from database\n3.Existent Graph - Choose an Existent Graph from database", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void bIesire_Click(object sender, EventArgs e) //BUTON IESIRE
        {
            Application.Exit();
        }
        private void Meniu_principal_Shown(object sender, EventArgs e) //CAND ESTE AFISAT MENIUL PRINCIPAL
        {
            if (conectat)
            {
                bConectare.Hide();
                citire_fisierDB(input_db.db_file);
                adresa_conectare = string_conectare(db_data[0], db_data[1], db_data[2], db_data[3]);
            }
        }
        private void TSSave_Click(object sender, EventArgs e) //de adaugat
        {
            salvare_grafic();
        }
        private void continut_bd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bAccesat == "bGE") //cazul GRAFIC EXISTENT
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var cellValue = continut_bd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    afisare_existent(cellValue.ToString());
                }
            }
            else //cazul STERGERE EXISTENT
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var cellValue = continut_bd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    stergere_existent(cellValue.ToString());
                    Conexiune(bAccesat);
                }
            }
        }

        private void bNou_Click(object sender, EventArgs e)
        {
            if(afisat)
            {
                HideElements();
                afisat = false;
            }
        }
    }
}
