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
    public partial class einTreffer : UserControl
    {
        public einTreffer()
        {
            InitializeComponent();
        }
        // variablen zum Rechnen
        double n;
        double p;

        // prüft ob die Eingabe einer Dezimalzahl entspricht und markiert ggfs. die Felder rot
        private void IsNumberValid(object sender, EventArgs e)
        {
            // prüft ob die Eingabe einer Zahl entspricht und ob die Zahl gültig ist
            // 0<a<1; 0<p<1; (a==1) != (b==1)
            bool isIntN = double.TryParse(kleinNInputEinTreffer.Text, out n);
            bool isDoubleP = double.TryParse(kleinPInputEinTreffer.Text, out p);
            bool isValidNumberN = isIntN && kleinNInputEinTreffer.Text != "" && !Regex.IsMatch(kleinNInputEinTreffer.Text, @"[,.]"); 
            bool isValidNumberP = isDoubleP && kleinPInputEinTreffer.Text != "" && 0 <= p && p <= 1;


            // wenn die Eingabe nicht gültig ist, wird das Feld rot hinterlegt
            kleinNInputEinTreffer.BackColor = isValidNumberN ? Color.White : Color.LightCoral;
            kleinPInputEinTreffer.BackColor = isValidNumberP ? Color.White : Color.LightCoral;

            // wenn die Eingabe nicht gültig ist, wird eine Warnung angezeigt
            warnungEinTreffer.Visible = (isValidNumberN && isValidNumberP) ? false : true;

            // wenn die Eingabe nicht gültig ist, kann der Knopf auch nicht gedrückt werden
            buttonBerechneEinTreffer.Enabled = (isValidNumberN && isValidNumberP) ? true : false;

            // Debug Zeilen
            System.Diagnostics.Debug.WriteLine(n);
            System.Diagnostics.Debug.WriteLine(p);
        }


        private void ButtonBerechneEinTreffer_Click(object sender, EventArgs e)
        {
            var gP = 1 - Math.Pow((1 - p), n);
            großPOutputEinTreffer.Text = gP <= 0 ? "<0,0000000000000000000000000001" : gP.ToString();
        }

        private void ButtonResetEinTreffer_Click(object sender, EventArgs e)
        {

            kleinNInputEinTreffer.Text = "";
            kleinNInputEinTreffer.BackColor = Color.White;

            kleinPInputEinTreffer.Text = "";
            kleinPInputEinTreffer.BackColor = Color.White;

            großPOutputEinTreffer.Text = "";

            buttonBerechneEinTreffer.Enabled = false;
            warnungEinTreffer.Visible = false;
        }
    }
}
