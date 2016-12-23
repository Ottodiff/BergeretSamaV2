/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : FrmCarte.cs 
* *****************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WF_Cartes
{
    public partial class FrmCarte : Form
    {
        //initialise la form
        FrmConnexion co = new FrmConnexion();
        

        //declaration classes
        Race ra = new Race();
        Classe cl = new Classe();
        Rarete rare = new Rarete();
        Type ty = new Type();
        Extension ex = new Extension();

        //declaration bases de donnees
        SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
        string CommandText;
        SQLiteCommand cmd;
        SQLiteDataReader sqldr;

        //declaration variable
        string selectedCarte = null;

        //constructeur
        public FrmCarte()
        {
            InitializeComponent();

            //affiche les cartes dans la listbox
            refreshCarte();
        }
        
        //frm Apropos        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //affiche la form a propos
            APropos aPropos = new APropos();
            aPropos.ShowDialog();
        }

        //connexion
        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //si on est co
            if (co.EstCo == true)
            {
                //on deconnecte
                co.EstCo = false;
                //on change le text
                connexionToolStripMenuItem.Text = "Connexion";

                //on modifie en fonction l affichage des boutons et du message de bienvenue
                lblBvn.Text = "";
                btnAjouter.Visible = false;
                btnModifier.Visible = false;
                btnSupprimer.Visible = false;
                cartesToolStripMenuItem.Visible = false;
            }
            //si on est pas co
            else
            {
                //on affiche la fenetre de connexion
                co.ShowDialog();
                //si on est connecter
                if (co.EstCo == true)
                {
                    //on affiche deconnexion
                    connexionToolStripMenuItem.Text = "Deconnexion";

                    //on modifie en fonction l affichage des boutons et du message de bienvenue
                    lblBvn.Text = "Bienvenue " + co.Nomutilisateur;
                    btnAjouter.Visible = true;
                    btnModifier.Visible = true;
                    btnSupprimer.Visible = true;
                    cartesToolStripMenuItem.Visible = true;
                }
            }
        }

        //quitter
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ferme l application
            Application.Exit();
        }

        //charge les informations en fonction de la carte selectionnee
        private void lsbCartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on ouvre la connexion
            sqlconnection.Open();

            //selectionne les informations de la carte en focntion du nom selectione
            CommandText = "SELECT * FROM cartes WHERE nom = \"" + lsbCartes.SelectedItem + "\"";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            //pour le resultat charge les informations dans les element de l interface prevu a cet effet
            while (sqldr.Read())
            {
                selectedCarte = sqldr["idCarte"].ToString();
                tbxNom.Text = (string)sqldr["nom"];
                tbxCout.Text = (string)sqldr["cout"];
                tbxAttaque.Text = (string)sqldr["attaque"];
                tbxVie.Text = (string)sqldr["vie"];
                tbxDescription.Text = (string)sqldr["description"];
                tbxHistoire.Text = (string)sqldr["histoire"];
                ra.IdRace = sqldr["idRace"].ToString();
                rare.IdRarete = sqldr["idRarete"].ToString();
                ty.IdType = sqldr["idType"].ToString();
                cl.IdClasse = sqldr["idClasse"].ToString();
                ex.IdExtension = sqldr["idExtension"].ToString();
            }

            //ferme les connexion et vide les commandes
            sqldr.Close();
            cmd.Dispose();
            sqlconnection.Close();

            //affiche les resultats dans les textbox prevu a cet effet
            tbxRace.Text = ra.raceSelect();
            tbxClasse.Text = cl.classeSelect();
            tbxRarete.Text = rare.rareteSelect();
            tbxType.Text = ty.typeSelect();
            tbxExtension.Text = ex.extensionSelect();
        }

        //supprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //si une carte est selectionne
            if (lsbCartes.SelectedIndex != -1)
            {
                //ouvre la connexion
                sqlconnection.Open();

                //execute la requete
                CommandText = "DELETE FROM cartes WHERE nom =\"" + lsbCartes.SelectedItem + "\"";
                cmd = new SQLiteCommand(CommandText, sqlconnection);
                cmd.ExecuteNonQuery();

                //ferme la connxion et vide la commande
                cmd.Dispose();
                sqlconnection.Close();

                //message de confirmation de suppression
                MessageBox.Show("Carte supprimée avec succès!");

                //rafraichie les cartes dans la listbox et vide les informations dans les textbox
                refreshCarte();
                clear();
            }
            //sinon demande d en selectionner une
            else
            {
                MessageBox.Show("Veuillez sélectionner une carte pour la supprimer.");
            }
        }

        //ajouter
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //initialise la form
            FrmAjouter aj = new FrmAjouter();
            DialogResult result = aj.ShowDialog();

            //si la form retourne ok
            if (result == DialogResult.OK)
            {
                //rafraichie les carte dans la listbox
                refreshCarte();
            }
        }

        //modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            //si une carte est selectionee
            if (lsbCartes.SelectedIndex != -1)
            {
                //initialise la form
                FrmModifier mo = new FrmModifier();
                mo.Charge(tbxNom.Text);

                DialogResult result = mo.ShowDialog();

                //si la form retourne ok
                if (result == DialogResult.OK)
                {
                    //rafraichie la listbox
                    refreshCarte();
                }
                //vide les textbox
                clear();
            }
            //sinon demande d en selectionner une
            else
            {
                MessageBox.Show("Veuillez sélectionner une carte.");
            }
        }

        //ajouter
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //appelle le contenu du bouton ajouter
            btnAjouter.PerformClick();
        }

        //modifier
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //appelle le contenu du bouton modifier
            btnModifier.PerformClick();
        }

        //supprimer
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //appelle le contenu du bouton supprimer
            btnSupprimer.PerformClick();
        }

        /// <summary>
        /// rafraichie la listbox avec les cartes de la base de donnees
        /// </summary>
        public void refreshCarte()
        {
            //vide la listbox
            lsbCartes.Items.Clear();

            //ouvre la connection a la base de donnees
            sqlconnection.Open();

            //selectionne les cartes dans la base de donnees
            CommandText = "SELECT * FROM cartes";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            //tant qu il y a des cartes dans la reponse de la requete
            while (sqldr.Read())
            {
                //pour chaque carte ajouter le nom dans la listbox
                lsbCartes.Items.Add(sqldr["nom"]);
            }

            //on ferme les connections, et on vide les variables
            sqldr.Close();
            cmd.Dispose();
            sqlconnection.Close();
        }

        /// <summary>
        /// vide les textbox
        /// </summary>
        public void clear()
        {
            //remet tout les champs vide
            tbxNom.Text = "";
            tbxCout.Text = "";
            tbxAttaque.Text = "";
            tbxVie.Text = "";
            tbxRace.Text = "";
            tbxDescription.Text = "";
            tbxHistoire.Text = "";
            tbxClasse.Text = "";
            tbxRarete.Text = "";
            tbxType.Text = "";
            tbxExtension.Text = "";
        }
    }
}
