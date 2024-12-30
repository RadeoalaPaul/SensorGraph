using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPATemp
{
    public class ButtonHandler
    {
        public static List<Button> buttons;
        private bool NotActive = false;

        private Meniu_principal MeniuPrincipal; //INSTANTA clasa Meniu_principal
        private ButtonManager buttonManager; //INSTANTA clasa ButtonManager

        public ButtonHandler(Meniu_principal principal, params Button[] btns) //CONSTRUCTOR
        {
            MeniuPrincipal = principal;
            buttons = new List<Button>(btns);

            foreach (var button in buttons)
            {
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button ClickedButton = sender as Button;
            if (ClickedButton != null)
            {
                if (!NotActive) {
                    DisableButtons(ClickedButton);
                    buttonManager = new ButtonManager(ClickedButton, this, MeniuPrincipal); //apelam ButonManager
                    MeniuPrincipal.bAccesat = ClickedButton.Name;
                }
                else { EnableButtons(); }
            }
        }

        private void DisableButtons(Button ActiveButton) //DEZACTIVARE BUTOANE
        {
            foreach (var button in buttons)
            {
                if (button != ActiveButton)
                {
                    button.Enabled = false;
                }
            }
            NotActive = true;
        }
        public void EnableButtons() //ACTIVARE BUTOANE
        {
            foreach (var button in buttons)
            {
                button.Enabled = true;
            }
            NotActive = false;
        }
    }
}
