namespace WF_Cartes
{
    partial class FrmModifier
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
            this.nudVie = new System.Windows.Forms.NumericUpDown();
            this.nudAttaque = new System.Windows.Forms.NumericUpDown();
            this.nudCout = new System.Windows.Forms.NumericUpDown();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.cbxExtension = new System.Windows.Forms.ComboBox();
            this.cbxClasse = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxRarete = new System.Windows.Forms.ComboBox();
            this.cbxRace = new System.Windows.Forms.ComboBox();
            this.tbxHistoire = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCout)).BeginInit();
            this.SuspendLayout();
            // 
            // nudVie
            // 
            this.nudVie.Location = new System.Drawing.Point(104, 92);
            this.nudVie.Name = "nudVie";
            this.nudVie.Size = new System.Drawing.Size(243, 20);
            this.nudVie.TabIndex = 3;
            // 
            // nudAttaque
            // 
            this.nudAttaque.Location = new System.Drawing.Point(104, 67);
            this.nudAttaque.Name = "nudAttaque";
            this.nudAttaque.Size = new System.Drawing.Size(243, 20);
            this.nudAttaque.TabIndex = 2;
            // 
            // nudCout
            // 
            this.nudCout.Location = new System.Drawing.Point(104, 42);
            this.nudCout.Name = "nudCout";
            this.nudCout.Size = new System.Drawing.Size(243, 20);
            this.nudCout.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(104, 417);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(272, 417);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cbxExtension
            // 
            this.cbxExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExtension.FormattingEnabled = true;
            this.cbxExtension.Location = new System.Drawing.Point(104, 379);
            this.cbxExtension.Name = "cbxExtension";
            this.cbxExtension.Size = new System.Drawing.Size(243, 21);
            this.cbxExtension.TabIndex = 10;
            // 
            // cbxClasse
            // 
            this.cbxClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClasse.FormattingEnabled = true;
            this.cbxClasse.Location = new System.Drawing.Point(104, 354);
            this.cbxClasse.Name = "cbxClasse";
            this.cbxClasse.Size = new System.Drawing.Size(243, 21);
            this.cbxClasse.TabIndex = 9;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(104, 329);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(243, 21);
            this.cbxType.TabIndex = 8;
            // 
            // cbxRarete
            // 
            this.cbxRarete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRarete.FormattingEnabled = true;
            this.cbxRarete.Location = new System.Drawing.Point(104, 304);
            this.cbxRarete.Name = "cbxRarete";
            this.cbxRarete.Size = new System.Drawing.Size(243, 21);
            this.cbxRarete.TabIndex = 7;
            // 
            // cbxRace
            // 
            this.cbxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRace.FormattingEnabled = true;
            this.cbxRace.Location = new System.Drawing.Point(104, 116);
            this.cbxRace.Name = "cbxRace";
            this.cbxRace.Size = new System.Drawing.Size(243, 21);
            this.cbxRace.TabIndex = 4;
            // 
            // tbxHistoire
            // 
            this.tbxHistoire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHistoire.Location = new System.Drawing.Point(104, 227);
            this.tbxHistoire.Multiline = true;
            this.tbxHistoire.Name = "tbxHistoire";
            this.tbxHistoire.Size = new System.Drawing.Size(243, 71);
            this.tbxHistoire.TabIndex = 6;
            // 
            // tbxDescription
            // 
            this.tbxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDescription.Location = new System.Drawing.Point(104, 141);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(243, 80);
            this.tbxDescription.TabIndex = 5;
            // 
            // tbxNom
            // 
            this.tbxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNom.Location = new System.Drawing.Point(104, 15);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(243, 20);
            this.tbxNom.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Extension :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Classe :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Type :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Rareté :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Histoire :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Race :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Vie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Attaque :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Cout :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nom : ";
            // 
            // FrmModifier
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(414, 484);
            this.Controls.Add(this.nudVie);
            this.Controls.Add(this.nudAttaque);
            this.Controls.Add(this.nudCout);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cbxExtension);
            this.Controls.Add(this.cbxClasse);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.cbxRarete);
            this.Controls.Add(this.cbxRace);
            this.Controls.Add(this.tbxHistoire);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifier";
            this.Text = "FrmModifier";
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudVie;
        private System.Windows.Forms.NumericUpDown nudAttaque;
        private System.Windows.Forms.NumericUpDown nudCout;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cbxExtension;
        private System.Windows.Forms.ComboBox cbxClasse;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxRarete;
        private System.Windows.Forms.ComboBox cbxRace;
        private System.Windows.Forms.TextBox tbxHistoire;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}