namespace Wahrscheinlichkeitsrechner_v2
{
    partial class WahrscheinlichkeitsrechnerMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WahrscheinlichkeitsrechnerMainForm));
            this.panelTopControl = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.labelTitel = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.button1Treffer = new System.Windows.Forms.Button();
            this.buttonNVersuche = new System.Windows.Forms.Button();
            this.buttonLaengeN = new System.Windows.Forms.Button();
            this.einTreffer1 = new Wahrscheinlichkeitsrechner_v2.einTreffer();
            this.nVersuche1 = new Wahrscheinlichkeitsrechner_v2.NVersuche();
            this.laengeNControl1 = new Wahrscheinlichkeitsrechner_v2.LaengeNControl();
            this.panelTopControl.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopControl
            // 
            this.panelTopControl.BackColor = System.Drawing.Color.SlateGray;
            this.panelTopControl.Controls.Add(this.buttonMinimize);
            this.panelTopControl.Controls.Add(this.buttonCloseApp);
            this.panelTopControl.Controls.Add(this.labelTitel);
            this.panelTopControl.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopControl.Location = new System.Drawing.Point(0, 0);
            this.panelTopControl.Name = "panelTopControl";
            this.panelTopControl.Size = new System.Drawing.Size(800, 24);
            this.panelTopControl.TabIndex = 0;
            this.panelTopControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopControl_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(758, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(21, 24);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseApp.FlatAppearance.BorderSize = 0;
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseApp.ForeColor = System.Drawing.Color.White;
            this.buttonCloseApp.Location = new System.Drawing.Point(779, 0);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(21, 24);
            this.buttonCloseApp.TabIndex = 3;
            this.buttonCloseApp.Text = "X";
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.ButtonCloseApp_Click_1);
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitel.Location = new System.Drawing.Point(0, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(255, 22);
            this.labelTitel.TabIndex = 2;
            this.labelTitel.Text = "Wahrscheinlichkeitrechner v2";
            this.labelTitel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopControl_MouseDown);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.SystemColors.Control;
            this.panelNavigation.Controls.Add(this.button1Treffer);
            this.panelNavigation.Controls.Add(this.buttonNVersuche);
            this.panelNavigation.Controls.Add(this.buttonLaengeN);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(0, 24);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(800, 40);
            this.panelNavigation.TabIndex = 1;
            // 
            // button1Treffer
            // 
            this.button1Treffer.AutoSize = true;
            this.button1Treffer.BackColor = System.Drawing.Color.SlateGray;
            this.button1Treffer.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1Treffer.FlatAppearance.BorderSize = 0;
            this.button1Treffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Treffer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Treffer.ForeColor = System.Drawing.Color.White;
            this.button1Treffer.Location = new System.Drawing.Point(203, 0);
            this.button1Treffer.Name = "button1Treffer";
            this.button1Treffer.Size = new System.Drawing.Size(144, 40);
            this.button1Treffer.TabIndex = 2;
            this.button1Treffer.Text = "mind. 1 Treffer";
            this.button1Treffer.UseVisualStyleBackColor = false;
            this.button1Treffer.Click += new System.EventHandler(this.button1Treffer_Click);
            // 
            // buttonNVersuche
            // 
            this.buttonNVersuche.AutoSize = true;
            this.buttonNVersuche.BackColor = System.Drawing.Color.SlateGray;
            this.buttonNVersuche.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonNVersuche.FlatAppearance.BorderSize = 0;
            this.buttonNVersuche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNVersuche.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNVersuche.ForeColor = System.Drawing.Color.White;
            this.buttonNVersuche.Location = new System.Drawing.Point(88, 0);
            this.buttonNVersuche.Name = "buttonNVersuche";
            this.buttonNVersuche.Size = new System.Drawing.Size(115, 40);
            this.buttonNVersuche.TabIndex = 1;
            this.buttonNVersuche.Text = "n Versuche";
            this.buttonNVersuche.UseVisualStyleBackColor = false;
            this.buttonNVersuche.Click += new System.EventHandler(this.ButtonNVersuche_Click);
            // 
            // buttonLaengeN
            // 
            this.buttonLaengeN.AutoSize = true;
            this.buttonLaengeN.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLaengeN.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLaengeN.FlatAppearance.BorderSize = 0;
            this.buttonLaengeN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaengeN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaengeN.ForeColor = System.Drawing.Color.White;
            this.buttonLaengeN.Location = new System.Drawing.Point(0, 0);
            this.buttonLaengeN.Name = "buttonLaengeN";
            this.buttonLaengeN.Size = new System.Drawing.Size(88, 40);
            this.buttonLaengeN.TabIndex = 0;
            this.buttonLaengeN.Text = "Länge n";
            this.buttonLaengeN.UseVisualStyleBackColor = false;
            this.buttonLaengeN.Click += new System.EventHandler(this.ButtonLaengeN_Click);
            // 
            // einTreffer1
            // 
            this.einTreffer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.einTreffer1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.einTreffer1.Location = new System.Drawing.Point(0, 64);
            this.einTreffer1.Margin = new System.Windows.Forms.Padding(4);
            this.einTreffer1.Name = "einTreffer1";
            this.einTreffer1.Size = new System.Drawing.Size(800, 436);
            this.einTreffer1.TabIndex = 4;
            this.einTreffer1.Visible = false;
            // 
            // nVersuche1
            // 
            this.nVersuche1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nVersuche1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVersuche1.Location = new System.Drawing.Point(0, 64);
            this.nVersuche1.Margin = new System.Windows.Forms.Padding(4);
            this.nVersuche1.Name = "nVersuche1";
            this.nVersuche1.Size = new System.Drawing.Size(800, 436);
            this.nVersuche1.TabIndex = 3;
            this.nVersuche1.Visible = false;
            // 
            // laengeNControl1
            // 
            this.laengeNControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laengeNControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laengeNControl1.Location = new System.Drawing.Point(0, 64);
            this.laengeNControl1.Margin = new System.Windows.Forms.Padding(4);
            this.laengeNControl1.Name = "laengeNControl1";
            this.laengeNControl1.Size = new System.Drawing.Size(800, 436);
            this.laengeNControl1.TabIndex = 2;
            // 
            // WahrscheinlichkeitsrechnerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.einTreffer1);
            this.Controls.Add(this.nVersuche1);
            this.Controls.Add(this.laengeNControl1);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelTopControl);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WahrscheinlichkeitsrechnerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wahrscheinlickeitsrechner v2";
            this.panelTopControl.ResumeLayout(false);
            this.panelTopControl.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopControl;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button button1Treffer;
        private System.Windows.Forms.Button buttonNVersuche;
        private System.Windows.Forms.Button buttonLaengeN;
        private LaengeNControl laengeNControl1;
        private NVersuche nVersuche1;
        private System.Windows.Forms.Label labelTitel;
        private einTreffer einTreffer1;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Button buttonMinimize;
    }
}

