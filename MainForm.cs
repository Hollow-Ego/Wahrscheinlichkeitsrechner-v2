using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wahrscheinlichkeitsrechner_v2
{
    public partial class WahrscheinlichkeitsrechnerMainForm : Form
    {
        public WahrscheinlichkeitsrechnerMainForm()
        {
            InitializeComponent();
        }

        private void closeLabel_MouseClick(object sender, MouseEventArgs e)
        {
            
        }


        // enables dragging the form around
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTopControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ButtonLaengeN_Click(object sender, EventArgs e)
        {
            laengeNControl1.Visible = true;
            nVersuche1.Visible = false;
            einTreffer1.Visible = false;
            buttonLaengeN.BackColor = Color.SteelBlue;
            buttonNVersuche.BackColor = Color.SlateGray;
            button1Treffer.BackColor = Color.SlateGray;
        }

        private void ButtonNVersuche_Click(object sender, EventArgs e)
        {
            nVersuche1.Visible = true;
            laengeNControl1.Visible = false;
            einTreffer1.Visible = false;
            buttonNVersuche.BackColor = Color.SteelBlue;
            buttonLaengeN.BackColor = Color.SlateGray;
            button1Treffer.BackColor = Color.SlateGray;
        }

        private void button1Treffer_Click(object sender, EventArgs e)
        {
            einTreffer1.Visible = true;
            nVersuche1.Visible = false;
            laengeNControl1.Visible = false;
            buttonNVersuche.BackColor = Color.SlateGray;
            buttonLaengeN.BackColor = Color.SlateGray;
            button1Treffer.BackColor = Color.SteelBlue;
        }

  
        private void ButtonCloseApp_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
