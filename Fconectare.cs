using System.Runtime.InteropServices;

namespace MIPATemp
{
    public partial class Fconectare : Form
    {
        //CONSOLA
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        //
        private Data Database;

        public readonly string db_file = AppDomain.CurrentDomain.BaseDirectory + "/db_info.txt"; //definire adresa fisier

        public Fconectare()
        {
            InitializeComponent();
            AllocConsole();
        }
        private void bIesireFcon_Click(object sender, EventArgs e)
        {
            Meniu_principal principal = new Meniu_principal();
            this.Close();
            principal.Show();
        }

        private void bConFcon_Click(object sender, EventArgs e)
        {
            Meniu_principal principal = new Meniu_principal();
            Database = new Data();

            if (Database.VerificaBD(t1Fcon.Text, t2Fcon.Text, t3Fcon.Text, t4Fcon.Text)) //server, user, password, database - PARAMETRII
            {
                Database.ScriereBD(t1Fcon.Text, t2Fcon.Text, t3Fcon.Text, t4Fcon.Text);
                this.Hide();
                principal.Show();
                principal.conectat = true;
            }
        }

        private void TSInfo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill in the blanks recording to descriptions in order to make a connection", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSHelp1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server -> the server to connect to (if you want to simulate on your PC type 'localhost'\nID -> the user that connects (for localhost type 'root')\nPassword -> Password of your database (by default it's null)\nName of database -> your database name (ex. 'database1')", "Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
