namespace WF_Cartes
{
    partial class FrmCarte
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbCartes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxCout = new System.Windows.Forms.TextBox();
            this.tbxAttaque = new System.Windows.Forms.TextBox();
            this.tbxVie = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxHistoire = new System.Windows.Forms.TextBox();
            this.tbxRace = new System.Windows.Forms.TextBox();
            this.tbxRarete = new System.Windows.Forms.TextBox();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxClasse = new System.Windows.Forms.TextBox();
            this.tbxExtension = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblBvn = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.connexionToolStripMenuItem.Text = "Connexion";
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // lsbCartes
            // 
            this.lsbCartes.FormattingEnabled = true;
            this.lsbCartes.Location = new System.Drawing.Point(68, 54);
            this.lsbCartes.Name = "lsbCartes";
            this.lsbCartes.Size = new System.Drawing.Size(249, 381);
            this.lsbCartes.TabIndex = 1;
            this.lsbCartes.SelectedIndexChanged += new System.EventHandler(this.lsbCartes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cout :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Attaque :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vie :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Race :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Description :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Histoire :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rareté :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Type :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Classe :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(351, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Extension :";
            // 
            // tbxNom
            // 
            this.tbxNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNom.Enabled = false;
            this.tbxNom.Location = new System.Drawing.Point(416, 54);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(243, 20);
            this.tbxNom.TabIndex = 16;
            // 
            // tbxCout
            // 
            this.tbxCout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCout.Enabled = false;
            this.tbxCout.Location = new System.Drawing.Point(416, 80);
            this.tbxCout.Name = "tbxCout";
            this.tbxCout.Size = new System.Drawing.Size(243, 20);
            this.tbxCout.TabIndex = 18;
            // 
            // tbxAttaque
            // 
            this.tbxAttaque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAttaque.Enabled = false;
            this.tbxAttaque.Location = new System.Drawing.Point(416, 105);
            this.tbxAttaque.Name = "tbxAttaque";
            this.tbxAttaque.Size = new System.Drawing.Size(243, 20);
            this.tbxAttaque.TabIndex = 19;
            // 
            // tbxVie
            // 
            this.tbxVie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxVie.Enabled = false;
            this.tbxVie.Location = new System.Drawing.Point(416, 130);
            this.tbxVie.Name = "tbxVie";
            this.tbxVie.Size = new System.Drawing.Size(243, 20);
            this.tbxVie.TabIndex = 20;
            // 
            // tbxDescription
            // 
            this.tbxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDescription.Enabled = false;
            this.tbxDescription.Location = new System.Drawing.Point(416, 180);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(243, 80);
            this.tbxDescription.TabIndex = 22;
            // 
            // tbxHistoire
            // 
            this.tbxHistoire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHistoire.Enabled = false;
            this.tbxHistoire.Location = new System.Drawing.Point(416, 266);
            this.tbxHistoire.Multiline = true;
            this.tbxHistoire.Name = "tbxHistoire";
            this.tbxHistoire.Size = new System.Drawing.Size(243, 71);
            this.tbxHistoire.TabIndex = 23;
            // 
            // tbxRace
            // 
            this.tbxRace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRace.Enabled = false;
            this.tbxRace.Location = new System.Drawing.Point(416, 156);
            this.tbxRace.Name = "tbxRace";
            this.tbxRace.Size = new System.Drawing.Size(243, 20);
            this.tbxRace.TabIndex = 24;
            // 
            // tbxRarete
            // 
            this.tbxRarete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRarete.Enabled = false;
            this.tbxRarete.Location = new System.Drawing.Point(416, 344);
            this.tbxRarete.Name = "tbxRarete";
            this.tbxRarete.Size = new System.Drawing.Size(243, 20);
            this.tbxRarete.TabIndex = 25;
            // 
            // tbxType
            // 
            this.tbxType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxType.Enabled = false;
            this.tbxType.Location = new System.Drawing.Point(416, 369);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(243, 20);
            this.tbxType.TabIndex = 26;
            // 
            // tbxClasse
            // 
            this.tbxClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxClasse.Enabled = false;
            this.tbxClasse.Location = new System.Drawing.Point(416, 394);
            this.tbxClasse.Name = "tbxClasse";
            this.tbxClasse.Size = new System.Drawing.Size(243, 20);
            this.tbxClasse.TabIndex = 27;
            // 
            // tbxExtension
            // 
            this.tbxExtension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExtension.Enabled = false;
            this.tbxExtension.Location = new System.Drawing.Point(416, 419);
            this.tbxExtension.Name = "tbxExtension";
            this.tbxExtension.Size = new System.Drawing.Size(243, 20);
            this.tbxExtension.TabIndex = 28;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(68, 441);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(72, 23);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblBvn
            // 
            this.lblBvn.AutoSize = true;
            this.lblBvn.Location = new System.Drawing.Point(11, 32);
            this.lblBvn.Name = "lblBvn";
            this.lblBvn.Size = new System.Drawing.Size(0, 13);
            this.lblBvn.TabIndex = 30;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(245, 441);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(72, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(157, 441);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(72, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FrmCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 489);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblBvn);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.tbxExtension);
            this.Controls.Add(this.tbxClasse);
            this.Controls.Add(this.tbxType);
            this.Controls.Add(this.tbxRarete);
            this.Controls.Add(this.tbxRace);
            this.Controls.Add(this.tbxHistoire);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxVie);
            this.Controls.Add(this.tbxAttaque);
            this.Controls.Add(this.tbxCout);
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
            this.Controls.Add(this.lsbCartes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCarte";
            this.Text = "Cartes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox lsbCartes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxCout;
        private System.Windows.Forms.TextBox tbxAttaque;
        private System.Windows.Forms.TextBox tbxVie;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxHistoire;
        private System.Windows.Forms.TextBox tbxRace;
        private System.Windows.Forms.TextBox tbxRarete;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.TextBox tbxClasse;
        private System.Windows.Forms.TextBox tbxExtension;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblBvn;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
    }
}

