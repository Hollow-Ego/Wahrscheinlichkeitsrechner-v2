using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Wahrscheinlichkeitsrechner_v2
{
    public partial class LaengeNControl : UserControl
    {
        public LaengeNControl()
        {
            InitializeComponent();
        }

        // variablen zum Rechnen
        double a;
        double p;

        // prüft ob die Eingabe einer Dezimalzahl entspricht und markiert ggfs. die Felder rot
        private void IsNumberValid(object sender, EventArgs e)
        {
            // prüft ob die Eingabe einer Zahl entspricht und ob die Zahl gültig ist
            // 0<a<1; 0<p<1; (a==1) != (b==1)
            bool isDoubleA = double.TryParse(kleinAInputLaengeN.Text, out a);
            bool isDoubleP = double.TryParse(kleinPInputLaengeN.Text, out p);
            bool isValidNumberA = isDoubleA && kleinAInputLaengeN.Text != "" && 0 <= a && a <= 1 ;
            bool isValidNumberP = isDoubleP && kleinPInputLaengeN.Text != "" && 0 <= p && p <= 1 ;

            if (a==1 && p == 1)
            {
                isValidNumberA = false;
                isValidNumberP = false;
            }

            // wenn die Eingabe nicht gültig ist, wird das Feld rot hinterlegt
            kleinAInputLaengeN.BackColor = isValidNumberA ? Color.White : Color.LightCoral;
            kleinPInputLaengeN.BackColor = isValidNumberP ? Color.White : Color.LightCoral;

            // wenn die Eingabe nicht gültig ist, wird eine Warnung angezeigt
            warnungLaengeN.Visible = (isValidNumberA && isValidNumberP) ? false : true;

            // wenn die Eingabe nicht gültig ist, kann der Knopf auch nicht gedrückt werden
            buttonBerechneLaengeN.Enabled = (isValidNumberA && isValidNumberP) ? true : false;

            // Debug Zeilen
            System.Diagnostics.Debug.WriteLine(a);
            System.Diagnostics.Debug.WriteLine(p);
        }


        // berechnet n
        private void ButtonBerechneLaengeN_Click(object sender, EventArgs e)
        {
            var ergebnis = Math.Log(1-a) / Math.Log(1 - p);
            kleinNOutputLaengeN.Text = ergebnis.ToString();


        }

        private void buttonResetLaengeN_Click(object sender, EventArgs e)
        {
            kleinAInputLaengeN.Text = "";
            kleinAInputLaengeN.BackColor = Color.White;

            kleinPInputLaengeN.Text = "";
            kleinPInputLaengeN.BackColor = Color.White;

            kleinNOutputLaengeN.Text = "";
            warnungLaengeN.Visible = false;

        }

        private void panelLaengeNMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void warnungLaengeN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelWarnungText_Click(object sender, EventArgs e)
        {

        }

        private void labelErklaerungLaengeN_Click(object sender, EventArgs e)
        {

        }

        private void kleinNOutputLaengeN_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelKleinNLaengeN_Click(object sender, EventArgs e)
        {

        }

        private void labelKleinPLaengeN_Click(object sender, EventArgs e)
        {

        }

        private void labelKleinALaengeN_Click(object sender, EventArgs e)
        {

        }
    }
}
