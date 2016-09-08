namespace B2D1_Week1_2_Notebook
{
    partial class Form1
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
            this.bSchrijf = new System.Windows.Forms.Button();
            this.bLees = new System.Windows.Forms.Button();
            this.tbNotitie = new System.Windows.Forms.TextBox();
            this.lNotitie = new System.Windows.Forms.Label();
            this.bAantal = new System.Windows.Forms.Button();
            this.lAantal = new System.Windows.Forms.Label();
            this.lNummer = new System.Windows.Forms.Label();
            this.tbNoteNummer = new System.Windows.Forms.TextBox();
            this.lNoteNummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSchrijf
            // 
            this.bSchrijf.Location = new System.Drawing.Point(12, 226);
            this.bSchrijf.Name = "bSchrijf";
            this.bSchrijf.Size = new System.Drawing.Size(75, 23);
            this.bSchrijf.TabIndex = 0;
            this.bSchrijf.Text = "Schrijf";
            this.bSchrijf.UseVisualStyleBackColor = true;
            this.bSchrijf.Click += new System.EventHandler(this.button1_Click);
            // 
            // bLees
            // 
            this.bLees.Location = new System.Drawing.Point(109, 226);
            this.bLees.Name = "bLees";
            this.bLees.Size = new System.Drawing.Size(75, 23);
            this.bLees.TabIndex = 1;
            this.bLees.Text = "Lees";
            this.bLees.UseVisualStyleBackColor = true;
            this.bLees.Click += new System.EventHandler(this.bLees_Click);
            // 
            // tbNotitie
            // 
            this.tbNotitie.Location = new System.Drawing.Point(12, 29);
            this.tbNotitie.Name = "tbNotitie";
            this.tbNotitie.Size = new System.Drawing.Size(252, 20);
            this.tbNotitie.TabIndex = 2;
            // 
            // lNotitie
            // 
            this.lNotitie.AutoSize = true;
            this.lNotitie.Location = new System.Drawing.Point(12, 10);
            this.lNotitie.Name = "lNotitie";
            this.lNotitie.Size = new System.Drawing.Size(37, 13);
            this.lNotitie.TabIndex = 3;
            this.lNotitie.Text = "Notitie";
            // 
            // bAantal
            // 
            this.bAantal.Location = new System.Drawing.Point(197, 226);
            this.bAantal.Name = "bAantal";
            this.bAantal.Size = new System.Drawing.Size(75, 23);
            this.bAantal.TabIndex = 4;
            this.bAantal.Text = "Aantal";
            this.bAantal.UseVisualStyleBackColor = true;
            this.bAantal.Click += new System.EventHandler(this.bAantal_Click);
            // 
            // lAantal
            // 
            this.lAantal.AutoSize = true;
            this.lAantal.Location = new System.Drawing.Point(197, 207);
            this.lAantal.Name = "lAantal";
            this.lAantal.Size = new System.Drawing.Size(46, 13);
            this.lAantal.TabIndex = 5;
            this.lAantal.Text = "Aantal : ";
            // 
            // lNummer
            // 
            this.lNummer.AutoSize = true;
            this.lNummer.Location = new System.Drawing.Point(237, 206);
            this.lNummer.Name = "lNummer";
            this.lNummer.Size = new System.Drawing.Size(0, 13);
            this.lNummer.TabIndex = 6;
            // 
            // tbNoteNummer
            // 
            this.tbNoteNummer.Location = new System.Drawing.Point(12, 92);
            this.tbNoteNummer.Name = "tbNoteNummer";
            this.tbNoteNummer.Size = new System.Drawing.Size(72, 20);
            this.tbNoteNummer.TabIndex = 7;
            // 
            // lNoteNummer
            // 
            this.lNoteNummer.AutoSize = true;
            this.lNoteNummer.Location = new System.Drawing.Point(12, 73);
            this.lNoteNummer.Name = "lNoteNummer";
            this.lNoteNummer.Size = new System.Drawing.Size(108, 13);
            this.lNoteNummer.TabIndex = 8;
            this.lNoteNummer.Text = "Zoek Notitie nummer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lNoteNummer);
            this.Controls.Add(this.tbNoteNummer);
            this.Controls.Add(this.lNummer);
            this.Controls.Add(this.lAantal);
            this.Controls.Add(this.bAantal);
            this.Controls.Add(this.lNotitie);
            this.Controls.Add(this.tbNotitie);
            this.Controls.Add(this.bLees);
            this.Controls.Add(this.bSchrijf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSchrijf;
        private System.Windows.Forms.Button bLees;
        private System.Windows.Forms.TextBox tbNotitie;
        private System.Windows.Forms.Label lNotitie;
        private System.Windows.Forms.Button bAantal;
        private System.Windows.Forms.Label lAantal;
        private System.Windows.Forms.Label lNummer;
        private System.Windows.Forms.TextBox tbNoteNummer;
        private System.Windows.Forms.Label lNoteNummer;
    }
}

