namespace Wahrscheinlichkeitsrechner_v2
{
    partial class NVersuche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NVersuche));
            this.panelLaengeNMain = new System.Windows.Forms.Panel();
            this.warnungNVersuche = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWarnungText = new System.Windows.Forms.Label();
            this.buttonResetNVersuche = new System.Windows.Forms.Button();
            this.buttonBerechneNVersuche = new System.Windows.Forms.Button();
            this.großPOutputNVersuche = new System.Windows.Forms.TextBox();
            this.kleinPInputNVersuche = new System.Windows.Forms.TextBox();
            this.kleinNInputNVersuche = new System.Windows.Forms.TextBox();
            this.labelGroßPNVersuche = new System.Windows.Forms.Label();
            this.labelKleinPNVersuche = new System.Windows.Forms.Label();
            this.labelKleinNNVersuche = new System.Windows.Forms.Label();
            this.labelErklaerungLaengeN = new System.Windows.Forms.Label();
            this.kleinKInputNVersuche = new System.Windows.Forms.TextBox();
            this.labelKleinKNVersuche = new System.Windows.Forms.Label();
            this.panelLaengeNMain.SuspendLayout();
            this.warnungNVersuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLaengeNMain
            // 
            this.panelLaengeNMain.Controls.Add(this.kleinKInputNVersuche);
            this.panelLaengeNMain.Controls.Add(this.labelKleinKNVersuche);
            this.panelLaengeNMain.Controls.Add(this.warnungNVersuche);
            this.panelLaengeNMain.Controls.Add(this.buttonResetNVersuche);
            this.panelLaengeNMain.Controls.Add(this.buttonBerechneNVersuche);
            this.panelLaengeNMain.Controls.Add(this.großPOutputNVersuche);
            this.panelLaengeNMain.Controls.Add(this.kleinPInputNVersuche);
            this.panelLaengeNMain.Controls.Add(this.kleinNInputNVersuche);
            this.panelLaengeNMain.Controls.Add(this.labelGroßPNVersuche);
            this.panelLaengeNMain.Controls.Add(this.labelKleinPNVersuche);
            this.panelLaengeNMain.Controls.Add(this.labelKleinNNVersuche);
            this.panelLaengeNMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLaengeNMain.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLaengeNMain.Location = new System.Drawing.Point(0, 124);
            this.panelLaengeNMain.Name = "panelLaengeNMain";
            this.panelLaengeNMain.Size = new System.Drawing.Size(800, 306);
            this.panelLaengeNMain.TabIndex = 3;
            // 
            // warnungNVersuche
            // 
            this.warnungNVersuche.Controls.Add(this.pictureBox1);
            this.warnungNVersuche.Controls.Add(this.labelWarnungText);
            this.warnungNVersuche.Location = new System.Drawing.Point(15, 202);
            this.warnungNVersuche.Name = "warnungNVersuche";
            this.warnungNVersuche.Size = new System.Drawing.Size(322, 100);
            this.warnungNVersuche.TabIndex = 8;
            this.warnungNVersuche.Visible = false;
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
            // buttonResetNVersuche
            // 
            this.buttonResetNVersuche.AutoSize = true;
            this.buttonResetNVersuche.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonResetNVersuche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetNVersuche.Location = new System.Drawing.Point(617, 242);
            this.buttonResetNVersuche.Name = "buttonResetNVersuche";
            this.buttonResetNVersuche.Size = new System.Drawing.Size(156, 44);
            this.buttonResetNVersuche.TabIndex = 5;
            this.buttonResetNVersuche.Text = "Reset";
            this.buttonResetNVersuche.UseVisualStyleBackColor = false;
            this.buttonResetNVersuche.Click += new System.EventHandler(this.ButtonResetNVersuche_Click);
            // 
            // buttonBerechneNVersuche
            // 
            this.buttonBerechneNVersuche.AutoSize = true;
            this.buttonBerechneNVersuche.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBerechneNVersuche.Enabled = false;
            this.buttonBerechneNVersuche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBerechneNVersuche.Location = new System.Drawing.Point(455, 242);
            this.buttonBerechneNVersuche.Name = "buttonBerechneNVersuche";
            this.buttonBerechneNVersuche.Size = new System.Drawing.Size(158, 44);
            this.buttonBerechneNVersuche.TabIndex = 4;
            this.buttonBerechneNVersuche.Text = "Berechnen";
            this.buttonBerechneNVersuche.UseVisualStyleBackColor = false;
            this.buttonBerechneNVersuche.Click += new System.EventHandler(this.ButtonBerechneNVersuche_Click);
            // 
            // großPOutputNVersuche
            // 
            this.großPOutputNVersuche.Location = new System.Drawing.Point(59, 155);
            this.großPOutputNVersuche.Name = "großPOutputNVersuche";
            this.großPOutputNVersuche.ReadOnly = true;
            this.großPOutputNVersuche.Size = new System.Drawing.Size(714, 39);
            this.großPOutputNVersuche.TabIndex = 6;
            // 
            // kleinPInputNVersuche
            // 
            this.kleinPInputNVersuche.Location = new System.Drawing.Point(59, 105);
            this.kleinPInputNVersuche.MaxLength = 17;
            this.kleinPInputNVersuche.Name = "kleinPInputNVersuche";
            this.kleinPInputNVersuche.Size = new System.Drawing.Size(714, 39);
            this.kleinPInputNVersuche.TabIndex = 3;
            this.kleinPInputNVersuche.TextChanged += new System.EventHandler(this.IsNumberValid);
            // 
            // kleinNInputNVersuche
            // 
            this.kleinNInputNVersuche.Location = new System.Drawing.Point(59, 15);
            this.kleinNInputNVersuche.MaxLength = 17;
            this.kleinNInputNVersuche.Name = "kleinNInputNVersuche";
            this.kleinNInputNVersuche.Size = new System.Drawing.Size(714, 39);
            this.kleinNInputNVersuche.TabIndex = 1;
            this.kleinNInputNVersuche.TextChanged += new System.EventHandler(this.IsNumberValid);
            // 
            // labelGroßPNVersuche
            // 
            this.labelGroßPNVersuche.AutoSize = true;
            this.labelGroßPNVersuche.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroßPNVersuche.Location = new System.Drawing.Point(9, 158);
            this.labelGroßPNVersuche.Name = "labelGroßPNVersuche";
            this.labelGroßPNVersuche.Size = new System.Drawing.Size(56, 32);
            this.labelGroßPNVersuche.TabIndex = 2;
            this.labelGroßPNVersuche.Text = "P =";
            this.labelGroßPNVersuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKleinPNVersuche
            // 
            this.labelKleinPNVersuche.AutoSize = true;
            this.labelKleinPNVersuche.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKleinPNVersuche.Location = new System.Drawing.Point(9, 108);
            this.labelKleinPNVersuche.Name = "labelKleinPNVersuche";
            this.labelKleinPNVersuche.Size = new System.Drawing.Size(54, 32);
            this.labelKleinPNVersuche.TabIndex = 1;
            this.labelKleinPNVersuche.Text = "p =";
            this.labelKleinPNVersuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKleinNNVersuche
            // 
            this.labelKleinNNVersuche.AutoSize = true;
            this.labelKleinNNVersuche.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKleinNNVersuche.Location = new System.Drawing.Point(9, 18);
            this.labelKleinNNVersuche.Name = "labelKleinNNVersuche";
            this.labelKleinNNVersuche.Size = new System.Drawing.Size(54, 32);
            this.labelKleinNNVersuche.TabIndex = 0;
            this.labelKleinNNVersuche.Text = "n =";
            this.labelKleinNNVersuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelErklaerungLaengeN
            // 
            this.labelErklaerungLaengeN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelErklaerungLaengeN.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErklaerungLaengeN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErklaerungLaengeN.Location = new System.Drawing.Point(0, 0);
            this.labelErklaerungLaengeN.Name = "labelErklaerungLaengeN";
            this.labelErklaerungLaengeN.Size = new System.Drawing.Size(800, 124);
            this.labelErklaerungLaengeN.TabIndex = 7;
            this.labelErklaerungLaengeN.Text = resources.GetString("labelErklaerungLaengeN.Text");
            this.labelErklaerungLaengeN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kleinKInputNVersuche
            // 
            this.kleinKInputNVersuche.Location = new System.Drawing.Point(59, 60);
            this.kleinKInputNVersuche.MaxLength = 17;
            this.kleinKInputNVersuche.Name = "kleinKInputNVersuche";
            this.kleinKInputNVersuche.Size = new System.Drawing.Size(714, 39);
            this.kleinKInputNVersuche.TabIndex = 2;
            this.kleinKInputNVersuche.TextChanged += new System.EventHandler(this.IsNumberValid);
            // 
            // labelKleinKNVersuche
            // 
            this.labelKleinKNVersuche.AutoSize = true;
            this.labelKleinKNVersuche.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKleinKNVersuche.Location = new System.Drawing.Point(9, 63);
            this.labelKleinKNVersuche.Name = "labelKleinKNVersuche";
            this.labelKleinKNVersuche.Size = new System.Drawing.Size(53, 32);
            this.labelKleinKNVersuche.TabIndex = 9;
            this.labelKleinKNVersuche.Text = "k =";
            this.labelKleinKNVersuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NVersuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLaengeNMain);
            this.Controls.Add(this.labelErklaerungLaengeN);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "NVersuche";
            this.Size = new System.Drawing.Size(800, 430);
            this.panelLaengeNMain.ResumeLayout(false);
            this.panelLaengeNMain.PerformLayout();
            this.warnungNVersuche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLaengeNMain;
        private System.Windows.Forms.TextBox kleinKInputNVersuche;
        private System.Windows.Forms.Label labelKleinKNVersuche;
        private System.Windows.Forms.Panel warnungNVersuche;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWarnungText;
        private System.Windows.Forms.Button buttonResetNVersuche;
        private System.Windows.Forms.Button buttonBerechneNVersuche;
        private System.Windows.Forms.TextBox großPOutputNVersuche;
        private System.Windows.Forms.TextBox kleinPInputNVersuche;
        private System.Windows.Forms.TextBox kleinNInputNVersuche;
        private System.Windows.Forms.Label labelGroßPNVersuche;
        private System.Windows.Forms.Label labelKleinPNVersuche;
        private System.Windows.Forms.Label labelKleinNNVersuche;
        private System.Windows.Forms.Label labelErklaerungLaengeN;
    }
}
