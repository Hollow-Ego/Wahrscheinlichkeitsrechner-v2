namespace Wahrscheinlichkeitsrechner_v2
{
    partial class LaengeNControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaengeNControl));
            this.labelErklaerungLaengeN = new System.Windows.Forms.Label();
            this.panelLaengeNMain = new System.Windows.Forms.Panel();
            this.warnungLaengeN = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWarnungText = new System.Windows.Forms.Label();
            this.buttonResetLaengeN = new System.Windows.Forms.Button();
            this.buttonBerechneLaengeN = new System.Windows.Forms.Button();
            this.kleinNOutputLaengeN = new System.Windows.Forms.TextBox();
            this.kleinPInputLaengeN = new System.Windows.Forms.TextBox();
            this.kleinAInputLaengeN = new System.Windows.Forms.TextBox();
            this.labelKleinNLaengeN = new System.Windows.Forms.Label();
            this.labelKleinPLaengeN = new System.Windows.Forms.Label();
            this.labelKleinALaengeN = new System.Windows.Forms.Label();
            this.panelLaengeNMain.SuspendLayout();
            this.warnungLaengeN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelErklaerungLaengeN
            // 
            this.labelErklaerungLaengeN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelErklaerungLaengeN.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErklaerungLaengeN.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErklaerungLaengeN.Location = new System.Drawing.Point(0, 0);
            this.labelErklaerungLaengeN.Name = "labelErklaerungLaengeN";
            this.labelErklaerungLaengeN.Size = new System.Drawing.Size(800, 157);
            this.labelErklaerungLaengeN.TabIndex = 0;
            this.labelErklaerungLaengeN.Text = resources.GetString("labelErklaerungLaengeN.Text");
            this.labelErklaerungLaengeN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelErklaerungLaengeN.Click += new System.EventHandler(this.labelErklaerungLaengeN_Click);
            // 
            // panelLaengeNMain
            // 
            this.panelLaengeNMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelLaengeNMain.Controls.Add(this.warnungLaengeN);
            this.panelLaengeNMain.Controls.Add(this.buttonResetLaengeN);
            this.panelLaengeNMain.Controls.Add(this.buttonBerechneLaengeN);
            this.panelLaengeNMain.Controls.Add(this.kleinNOutputLaengeN);
            this.panelLaengeNMain.Controls.Add(this.kleinPInputLaengeN);
            this.panelLaengeNMain.Controls.Add(this.kleinAInputLaengeN);
            this.panelLaengeNMain.Controls.Add(this.labelKleinNLaengeN);
            this.panelLaengeNMain.Controls.Add(this.labelKleinPLaengeN);
            this.panelLaengeNMain.Controls.Add(this.labelKleinALaengeN);
            this.panelLaengeNMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLaengeNMain.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLaengeNMain.Location = new System.Drawing.Point(0, 157);
            this.panelLaengeNMain.Name = "panelLaengeNMain";
            this.panelLaengeNMain.Size = new System.Drawing.Size(800, 273);
            this.panelLaengeNMain.TabIndex = 1;
            this.panelLaengeNMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLaengeNMain_Paint);
            // 
            // warnungLaengeN
            // 
            this.warnungLaengeN.Controls.Add(this.pictureBox1);
            this.warnungLaengeN.Controls.Add(this.labelWarnungText);
            this.warnungLaengeN.Location = new System.Drawing.Point(15, 160);
            this.warnungLaengeN.Name = "warnungLaengeN";
            this.warnungLaengeN.Size = new System.Drawing.Size(322, 100);
            this.warnungLaengeN.TabIndex = 8;
            this.warnungLaengeN.Visible = false;
            this.warnungLaengeN.Paint += new System.Windows.Forms.PaintEventHandler(this.warnungLaengeN_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wahrscheinlichkeitsrechner_v2.Properties.Resources.warning_big;
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 73);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.labelWarnungText.Click += new System.EventHandler(this.labelWarnungText_Click);
            // 
            // buttonResetLaengeN
            // 
            this.buttonResetLaengeN.AutoSize = true;
            this.buttonResetLaengeN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonResetLaengeN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetLaengeN.Location = new System.Drawing.Point(617, 200);
            this.buttonResetLaengeN.Name = "buttonResetLaengeN";
            this.buttonResetLaengeN.Size = new System.Drawing.Size(156, 44);
            this.buttonResetLaengeN.TabIndex = 7;
            this.buttonResetLaengeN.Text = "Reset";
            this.buttonResetLaengeN.UseVisualStyleBackColor = false;
            this.buttonResetLaengeN.Click += new System.EventHandler(this.buttonResetLaengeN_Click);
            // 
            // buttonBerechneLaengeN
            // 
            this.buttonBerechneLaengeN.AutoSize = true;
            this.buttonBerechneLaengeN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBerechneLaengeN.Enabled = false;
            this.buttonBerechneLaengeN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBerechneLaengeN.Location = new System.Drawing.Point(455, 200);
            this.buttonBerechneLaengeN.Name = "buttonBerechneLaengeN";
            this.buttonBerechneLaengeN.Size = new System.Drawing.Size(158, 44);
            this.buttonBerechneLaengeN.TabIndex = 6;
            this.buttonBerechneLaengeN.Text = "Berechnen";
            this.buttonBerechneLaengeN.UseVisualStyleBackColor = false;
            this.buttonBerechneLaengeN.Click += new System.EventHandler(this.ButtonBerechneLaengeN_Click);
            // 
            // kleinNOutputLaengeN
            // 
            this.kleinNOutputLaengeN.Location = new System.Drawing.Point(59, 112);
            this.kleinNOutputLaengeN.Name = "kleinNOutputLaengeN";
            this.kleinNOutputLaengeN.ReadOnly = true;
            this.kleinNOutputLaengeN.Size = new System.Drawing.Size(714, 39);
            this.kleinNOutputLaengeN.TabIndex = 5;
            this.kleinNOutputLaengeN.TextChanged += new System.EventHandler(this.kleinNOutputLaengeN_TextChanged);
            // 
            // kleinPInputLaengeN
            // 
            this.kleinPInputLaengeN.Location = new System.Drawing.Point(59, 62);
            this.kleinPInputLaengeN.MaxLength = 17;
            this.kleinPInputLaengeN.Name = "kleinPInputLaengeN";
            this.kleinPInputLaengeN.Size = new System.Drawing.Size(714, 39);
            this.kleinPInputLaengeN.TabIndex = 4;
            this.kleinPInputLaengeN.TextChanged += new System.EventHandler(this.IsNumberValid);
            // 
            // kleinAInputLaengeN
            // 
            this.kleinAInputLaengeN.Location = new System.Drawing.Point(59, 15);
            this.kleinAInputLaengeN.MaxLength = 17;
            this.kleinAInputLaengeN.Name = "kleinAInputLaengeN";
            this.kleinAInputLaengeN.Size = new System.Drawing.Size(714, 39);
            this.kleinAInputLaengeN.TabIndex = 3;
            this.kleinAInputLaengeN.TextChanged += new System.EventHandler(this.IsNumberValid);
            // 
            // labelKleinNLaengeN
            // 
            this.labelKleinNLaengeN.AutoSize = true;
            this.labelKleinNLaengeN.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKleinNLaengeN.Location = new System.Drawing.Point(9, 115);
            this.labelKleinNLaengeN.Name = "labelKleinNLaengeN";
            this.labelKleinNLaengeN.Size = new System.Drawing.Size(54, 32);
            this.labelKleinNLaengeN.TabIndex = 2;
            this.labelKleinNLaengeN.Text = "n =";
            this.labelKleinNLaengeN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelKleinNLaengeN.Click += new System.EventHandler(this.labelKleinNLaengeN_Click);
            // 
            // labelKleinPLaengeN
            // 
            this.labelKleinPLaengeN.AutoSize = true;
            this.labelKleinPLaengeN.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKleinPLaengeN.Location = new System.Drawing.Point(9, 65);
            this.labelKleinPLaengeN.Name = "labelKleinPLaengeN";
            this.labelKleinPLaengeN.Size = new System.Drawing.Size(54, 32);
            this.labelKleinPLaengeN.TabIndex = 1;
            this.labelKleinPLaengeN.Text = "p =";
            this.labelKleinPLaengeN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelKleinPLaengeN.Click += new System.EventHandler(this.labelKleinPLaengeN_Click);
            // 
            // labelKleinALaengeN
            // 
            this.labelKleinALaengeN.AutoSize = true;
            this.labelKleinALaengeN.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKleinALaengeN.Location = new System.Drawing.Point(9, 18);
            this.labelKleinALaengeN.Name = "labelKleinALaengeN";
            this.labelKleinALaengeN.Size = new System.Drawing.Size(54, 32);
            this.labelKleinALaengeN.TabIndex = 0;
            this.labelKleinALaengeN.Text = "a =";
            this.labelKleinALaengeN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelKleinALaengeN.Click += new System.EventHandler(this.labelKleinALaengeN_Click);
            // 
            // LaengeNControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLaengeNMain);
            this.Controls.Add(this.labelErklaerungLaengeN);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LaengeNControl";
            this.Size = new System.Drawing.Size(800, 430);
            this.panelLaengeNMain.ResumeLayout(false);
            this.panelLaengeNMain.PerformLayout();
            this.warnungLaengeN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelErklaerungLaengeN;
        private System.Windows.Forms.Panel panelLaengeNMain;
        private System.Windows.Forms.Label labelKleinPLaengeN;
        private System.Windows.Forms.Label labelKleinALaengeN;
        private System.Windows.Forms.Label labelKleinNLaengeN;
        private System.Windows.Forms.TextBox kleinNOutputLaengeN;
        private System.Windows.Forms.TextBox kleinPInputLaengeN;
        private System.Windows.Forms.TextBox kleinAInputLaengeN;
        private System.Windows.Forms.Button buttonResetLaengeN;
        private System.Windows.Forms.Button buttonBerechneLaengeN;
        private System.Windows.Forms.Panel warnungLaengeN;
        private System.Windows.Forms.Label labelWarnungText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
