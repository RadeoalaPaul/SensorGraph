using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPATemp
{
    public class ButtonManager
    {
        private ButtonHandler Handler; //INSTATA clasa ButtonHandler
        private Meniu_principal MeniuPrincipal; //INSTANTA clasa Meniu_principal
        private FormsPlot gfTemperatura;
        private FormsPlot gfUmiditate;
        //INSTANTA clasa Graph
        public ButtonManager(Button buton, ButtonHandler buttonHandler, Meniu_principal principal) { //CONSTRUCTOR
            Handler = buttonHandler;
            MeniuPrincipal = principal;
           
            switch(buton.Name)
            {
                case "bNou":
                    if (!MeniuPrincipal.afisat)
                    {
                        MeniuPrincipal.afisat = true;
                        PrelucrarePython();
                    }
                    break;
                default:
                    if (MeniuPrincipal.adresa_conectare != "")
                    {
                        MeniuPrincipal.Conexiune(buton.Name);
                    }
                    else {
                        Handler.EnableButtons();
                        MessageBox.Show("Connect to a database first!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                    }
                    break;
            }
        }
        void PrelucrarePython() //PENTRU bNou
        {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Users\Mucea\AppData\Local\Programs\Python\Python313\python.exe", //adresa executabil interpreter
                    Arguments = @"C:\Users\Mucea\AppData\Local\Programs\Python\Python313\script\script.py", //adresa script
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(error))
                    {
                        Handler.EnableButtons();
                        DialogResult result = MessageBox.Show("Connect the arduino to your PC!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(error);
                    }
                    else
                    {
                        MeniuPrincipal.afisare_grafica();
                    }
                }
        }
    }
}
