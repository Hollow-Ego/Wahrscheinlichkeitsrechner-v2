namespace Wahrscheinlichkeitsrechner_v2
{
    partial class einTreffer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLaengeNMain = new System.Windows.Forms.Panel();
            this.warnungEinTreffer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWarnungText = new System.Windows.Forms.Label();
            this.buttonResetEinTreffer = new System.Windows.Forms.Button();
            this.buttonBerechneEinTreffer = new System.Windows.Forms.Button();
            this.großPOutputEinTreffer = new System.Windows.Forms.TextBox();
            this.kleinPInputEinTreffer = new System.Windows.Forms.TextBox();
            this.kleinNInputEinTreffer = new System.Windows.Forms.TextBox();
            this.labelGroßPEinTreffer = new System.Windows.Forms.Label();
            this.labelKleinPEinTreffer = new System.Windows.Forms.Label();
            this.labelKleinNEinTreffer = new System.Windows.Forms.Label();
            this.labelErklaerungLaengeN = new System.Windows.Forms.Label();
            this.panelLaengeNMain.SuspendLayout();
            this.warnungEinTreffer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLaengeNMain
            // 
            this.panelLaengeNMain.Controls.Add(this.warnungEinTreffer);
            this.panelLaengeNMain.Controls.Add(this.buttonResetEinTreffer);
            this.panelLaengeNMain.Controls.Add(this.buttonBerechneEinTreffer);
            this.panelLaengeNMain.Controls.Add(this.großPOutputEinTreffer);
            this.panelLaengeNMain.Controls.Add(this.kleinPInputEinTreffer);
            this.panelLaengeNMain.Controls.Add(this.kleinNInputEinTreffer);
            this.panelLaengeNMain.Controls.Add(this.labelGroßPEinTreffer);
            this.panelLaengeNMain.Controls.Add(this.labelKleinPEinTreffer);
            this.panelLaengeNMain.Controls.Add(this.labelKleinNEinTreffer);
            this.panelLaengeNMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLaengeNMain.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLaengeNMain.Location = new System.Drawing.Point(0, 157);
            this.panelLaengeNMain.Name = "panelLaengeNMain";
            this.panelLaengeNMain.Size = new System.Drawing.Size(800, 273);
            this.panelLaengeNMain.TabIndex = 3;
            // 
            // warnungEinTreffer
            // 
            this.warnungEinTreffer.Controls.Add(this.pictureBox1);
            this.warnungEinTreffer.Controls.Add(this.labelWarnungText);
            this.warnungEinTreffer.Location = new System.Drawing.Point(15, 160);
            this.warnungEinTreffer.Name = "warnungEinTreffer";
            this.warnungEinTreffer.Size = new System.Drawing.Size(322, 100);
            this.warnungEinTreffer.TabIndex = 8;
            this.warnungEinTreffer.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wahrscheinlichkeitsrechner_v2.Properties.Resources.warning_big;
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 73);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelWarnungText
            // 
            this.labelWarnungText.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelWarnungText.Location = new System.Drawing.Point(90, 0);
            this.labelWarnungText.Name = "labelWarnungText";
            this.labelWarnungText.Size = new System.Drawing.Size(232, 100);
            this.labelWarnungText.TabIndex = 0;
            this.labelWarnungText.Text = "Ein oder mehrere Werte sind ungültig!";
            this.labelWarnungText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResetEinTreffer
            // 
            this.buttonResetEinTreffer.AutoSize = true;
            this.buttonResetEinTreffer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonResetEinTreffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetEinTreffer.Location = new System.Drawing.Point(617, 200);
            this.buttonResetEinTreffer.Name = "buttonResetEinTreffer";
            this.buttonResetEinTreffer.Size = new System.Drawing.Size(156, 44);
            this.buttonResetEinTreffer.TabIndex = 7;
            this.buttonResetEinTreffer.Text = "Reset";
            this.buttonResetEinTreffer.UseVisualStyleBackColor = false;
            this.buttonResetEinTreffer.Click += new System.EventHandler(this.ButtonResetEinTreffer_Click);
            // 
            // buttonBerechneEinTreffer
            // 
            this.buttonBerechneEinTreffer.AutoSize = true;
            this.buttonBerechneEinTreffer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBerechneEinTreffer.Enabled = false;
            this.buttonBerechneEinTreffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBerechneEinTreffer.Location = new System.Drawing.Point(455, 200);
            this.buttonBerechneEinTreffer.Name = "buttonBerechneEinTreffer";
            this.buttonBerechneEinTreffer.Size = new System.Drawing.Size(158, 44);
            this.buttonBerechneEinTreffer.TabIndex = 6;
            this.buttonBerechneEinTreffer.Text = "Berechnen";
            this.buttonBerechneEinTreffer.UseVisualStyleBackColor = false;
            this.buttonBerechneEinTreffer.Click += new System.EventHandler(this.ButtonBerechneEinTreffer_Click);
            // 
            // großPOutputEinTreffer
            // 
            this.großPOutputEinTreffer.Location = new System.Drawing.Point(59, 112);
            this.großPOutputEinTreffer.Name = "großPOutputEinTreffer";
            this.großPOutputEinTreffer.ReadOnly = true;
            this.großPOutputEinTreffer.Size = new System.Drawing.Size(714, 39);
            this.großPOutputEinTreffer.TabIndex = 5;
            // 
            // kleinPInputEinTreffer
            // 
            this.kleinPInputEinTreffer.Location = new System.Drawing.Point(59, 62);
            this.kleinPInputEinTreffer.MaxLength = 17;
            this.kleinPInputEinTreffer.Name = "kleinPInputEinTreffer";
            this.kleinPInputEinTreffer.Size = new System.Drawing.Size(714, 39);
            this.kleinPInputEinTreffer.TabIndex = 4;
            this.kleinPInputEinTreffer.TextChanged += new System.EventHandler(this.IsNumberValid);
            // 
            // kleinNInputEinTreffer
            // 
            this.kleinNInputEinTreffer.Location = new System.Drawing.Point(59, 15);
            this.kleinNInputEinTreffer.MaxLength = 17;
            this.kleinNInputEinTreffer.Name = "kleinNInputEinTreffer";
            this.kleinNInputEinTreffer.Size = new System.Drawing.Size(714, 39);
            this.kleinNInputEinTreffer.TabIndex = 3;
            this.kleinNInputEinTreffer.TextChanged += new System.EventHandler(this.IsNumberValid);
            // 
            // labelGroßPEinTreffer
            // 
            this.labelGroßPEinTreffer.AutoSize = true;
            this.labelGroßPEinTreffer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroßPEinTreffer.Location = new System.Drawing.Point(9, 115);
            this.labelGroßPEinTreffer.Name = "labelGroßPEinTreffer";
            this.labelGroßPEinTreffer.Size = new System.Drawing.Size(56, 32);
            this.labelGroßPEinTreffer.TabIndex = 2;
            this.labelGroßPEinTreffer.Text = "P =";
            this.labelGroßPEinTreffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKleinPEinTreffer
            // 
            this.labelKleinPEinTreffer.AutoSize = true;
            this.labelKleinPEinTreffer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKleinPEinTreffer.Location = new System.Drawing.Point(9, 65);
            this.labelKleinPEinTreffer.Name = "labelKleinPEinTreffer";
            this.labelKleinPEinTreffer.Size = new System.Drawing.Size(54, 32);
            this.labelKleinPEinTreffer.TabIndex = 1;
            this.labelKleinPEinTreffer.Text = "p =";
            this.labelKleinPEinTreffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKleinNEinTreffer
            // 
            this.labelKleinNEinTreffer.AutoSize = true;
            this.labelKleinNEinTreffer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKleinNEinTreffer.Location = new System.Drawing.Point(9, 18);
            this.labelKleinNEinTreffer.Name = "labelKleinNEinTreffer";
            this.labelKleinNEinTreffer.Size = new System.Drawing.Size(54, 32);
            this.labelKleinNEinTreffer.TabIndex = 0;
            this.labelKleinNEinTreffer.Text = "n =";
            this.labelKleinNEinTreffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelErklaerungLaengeN
            // 
            this.labelErklaerungLaengeN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelErklaerungLaengeN.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErklaerungLaengeN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErklaerungLaengeN.Location = new System.Drawing.Point(0, 0);
            this.labelErklaerungLaengeN.Name = "labelErklaerungLaengeN";
            this.labelErklaerungLaengeN.Size = new System.Drawing.Size(800, 157);
            this.labelErklaerungLaengeN.TabIndex = 2;
            this.labelErklaerungLaengeN.Text = "\r\nBerechnet die Wahrscheinlichkeit (P) für mindestens einen Treffer bei n Zufalls" +
    "versuchen.\r\n\r\nn: Anzahl der Zufallsversuche (ganze Zahl)\r\np: Trefferwahrscheinli" +
    "chkeit bei einem Zufallsversuch (0<p<1)";
            this.labelErklaerungLaengeN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // einTreffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLaengeNMain);
            this.Controls.Add(this.labelErklaerungLaengeN);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "einTreffer";
            this.Size = new System.Drawing.Size(800, 430);
            this.panelLaengeNMain.ResumeLayout(false);
            this.panelLaengeNMain.PerformLayout();
            this.warnungEinTreffer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLaengeNMain;
        private System.Windows.Forms.Panel warnungEinTreffer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWarnungText;
        private System.Windows.Forms.Button buttonResetEinTreffer;
        private System.Windows.Forms.Button buttonBerechneEinTreffer;
        private System.Windows.Forms.TextBox großPOutputEinTreffer;
        private System.Windows.Forms.TextBox kleinPInputEinTreffer;
        private System.Windows.Forms.TextBox kleinNInputEinTreffer;
        private System.Windows.Forms.Label labelGroßPEinTreffer;
        private System.Windows.Forms.Label labelKleinPEinTreffer;
        private System.Windows.Forms.Label labelKleinNEinTreffer;
        private System.Windows.Forms.Label labelErklaerungLaengeN;
    }
}
