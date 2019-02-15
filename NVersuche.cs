using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Wahrscheinlichkeitsrechner_v2
{
    public partial class NVersuche : UserControl
    {
        public NVersuche()
        {
            InitializeComponent();
        }

        // variablen zum Rechnen
        double n;
        double k;
        double p;

        // prüft ob die Eingabe einer Dezimalzahl entspricht und markiert ggfs. die Felder rot
        private void IsNumberValid(object sender, EventArgs e)
        {
            // prüft ob die Eingabe einer Zahl entspricht und ob die Zahl gültig ist
            // n = int; k = int; 0<p<1
            bool isIntN = double.TryParse(kleinNInputNVersuche.Text, out n);
            bool isIntK = double.TryParse(kleinKInputNVersuche.Text, out k);
            bool isDoubleP = double.TryParse(kleinPInputNVersuche.Text, out p);

            bool isValidNumberN = isIntN && kleinNInputNVersuche.Text != "" && !Regex.IsMatch(kleinNInputNVersuche.Text, @"[,.]");
            bool isValidNumberK = isIntK && kleinKInputNVersuche.Text != "" && !Regex.IsMatch(kleinKInputNVersuche.Text, @"[,.]");
            bool isValidNumberP = isDoubleP && kleinPInputNVersuche.Text != "" && 0 <= p && p <= 1;


            // wenn die Eingabe nicht gültig ist, wird das Feld rot hinterlegt
            kleinNInputNVersuche.BackColor = isValidNumberN ? Color.White : Color.LightCoral;
            kleinKInputNVersuche.BackColor = isValidNumberK ? Color.White : Color.LightCoral;
            kleinPInputNVersuche.BackColor = isValidNumberP ? Color.White : Color.LightCoral;

            // wenn die Eingabe nicht gültig ist, wird eine Warnung angezeigt
            warnungNVersuche.Visible = (isValidNumberN && isValidNumberK && isValidNumberP) ? false : true;

            // wenn die Eingabe nicht gültig ist, kann der Knopf auch nicht gedrückt werden
            buttonBerechneNVersuche.Enabled = (isValidNumberN && isValidNumberK && isValidNumberP) ? true : false;

            // Debug Zeilen
            System.Diagnostics.Debug.WriteLine(n);
            System.Diagnostics.Debug.WriteLine(k);
            System.Diagnostics.Debug.WriteLine(p);
        }

        private void ButtonBerechneNVersuche_Click(object sender, EventArgs e)
        {
            // berechne n über k
            double result=1;
            double gP;

            for (int i = 1; i <= k; i++)
            {
                result *= n - (k - i);
                result /= i;
            }
            // berechne P
            gP = result * Math.Pow(p, k) * Math.Pow(1 - p, n - k);

            großPOutputNVersuche.Text = gP<=0 ? "<0,0000000000000000000000000001" : gP.ToString();
            //großPOutputNVersuche.Text = gP.ToString();
        }

        private void ButtonResetNVersuche_Click(object sender, EventArgs e)
        {
            kleinNInputNVersuche.BackColor = Color.White;
            kleinNInputNVersuche.Text = "";
            kleinKInputNVersuche.BackColor = Color.White;
            kleinKInputNVersuche.Text = "";
            kleinPInputNVersuche.BackColor = Color.White;
            kleinPInputNVersuche.Text = "";
            großPOutputNVersuche.Text = "";
            buttonBerechneNVersuche.Enabled = false;
            warnungNVersuche.Visible = false;
        }
    }
}
