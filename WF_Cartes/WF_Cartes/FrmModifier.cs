/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : FrmModifier.cs 
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
    public partial class FrmModifier : Form
    {
        //declaration form
        FrmCarte ca = new FrmCarte();

        //declaration base de donnees
        SQLiteConnection sqlconnection = new SQLiteConnection("Data Source=carte.db");
        string CommandText;
        SQLiteCommand cmd;
        SQLiteDataReader sqldr;

        //declaration et initialisation variable
        int id = 0;

        //Geter/Seter
        public string Nom
        {
            get { return tbxNom.Text; }
            set { tbxNom.Text = value; }
        }
        
        //constructeur
        public FrmModifier()
        {
            InitializeComponent();
        }

        /// <summary>
        /// charge toute les donnees necessaire a la creation d une carte et selectionne les information de la carte selectionne
        /// </summary>
        /// <param name="nom">nom de la carte selectionne</param>
        public void Charge(string nom)
        {
            //ouvre la connexion
            sqlconnection.Open();

            //initialisation de variable
            this.Nom = nom;

            //selectionne la race
            CommandText = "SELECT races FROM race";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            //pour chaque reponse
            while (sqldr.Read())
            {
                //ajoute la reponse dans le combobox
                cbxRace.Items.Add(sqldr["races"]);
            }

            //selectionne la rarete
            CommandText = "SELECT raretes FROM rarete";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            //pour chaque reponse
            while (sqldr.Read())
            {
                //ajoute la reponse dans le combobox
                cbxRarete.Items.Add(sqldr["raretes"]);
            }

            //selectionne le type
            CommandText = "SELECT types FROM type";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            //pour chaque reponse
            while (sqldr.Read())
            {
                //ajoute la reponse dans le combobox
                cbxType.Items.Add(sqldr["types"]);
            }

            //selectionne la classe
            CommandText = "SELECT classes FROM classe";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            //pour chaque reponse
            while (sqldr.Read())
            {
                //ajoute la reponse dans le combobox
                cbxClasse.Items.Add(sqldr["classes"]);
            }

            //selectionne l extension
            CommandText = "SELECT extensions FROM extension";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            //pour chaque reponse
            while (sqldr.Read())
            {
                //ajoute la reponse dans le combobox
                cbxExtension.Items.Add(sqldr["extensions"]);
            }

            //execute la requete
            CommandText = "SELECT * FROM cartes as ca, race as ra, classe as cla, extension as ex, rarete as rar, type as ty  WHERE ca.idRace = ra.idRace  AND ca.idClasse = cla.idClasse AND ca.idExtension = ex.idExtension AND ca.idRarete = rar.idRarete AND ca.idType = ty.idType AND nom = \"" + Nom + "\"";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            //pour chaque reponse
            while (sqldr.Read())
            {
                //attribue les valeurs selectionnees
                id = Convert.ToInt32(sqldr["idCarte"]);
                tbxNom.Text = (string)sqldr["nom"];
                nudCout.Value = Convert.ToInt32(sqldr["cout"]);
                nudAttaque.Value = Convert.ToInt32(sqldr["attaque"]);
                nudVie.Value = Convert.ToInt32(sqldr["vie"]);
                cbxRace.SelectedItem = (string)sqldr["races"];
                tbxDescription.Text = (string)sqldr["description"];
                tbxHistoire.Text = (string)sqldr["histoire"];
                cbxRarete.SelectedItem = (string)sqldr["raretes"];
                cbxType.SelectedItem = (string)sqldr["types"];
                cbxClasse.SelectedItem = (string)sqldr["classes"];
                cbxExtension.SelectedItem = (string)sqldr["extensions"];
            }

            //ferme la connexion et vide la commande
            cmd.Dispose();
            sqldr.Close();
            sqlconnection.Close();
        }

        //valider
        private void btnValider_Click(object sender, EventArgs e)
        {
            //si tout les champs ne sont pas vide
            if ((tbxNom.Text != "") && (tbxDescription.Text != "") && (tbxHistoire.Text != "") && (cbxRace.SelectedIndex != -1) && (cbxRarete.SelectedIndex != -1) && (cbxClasse.SelectedIndex != -1) && (cbxType.SelectedIndex != -1) && (cbxExtension.SelectedIndex != -1))
            {
                //ouvre la connexion
                sqlconnection.Open();

                //met tout le nom en minuscule et la premiere lettre en majuscule
                string oldstring = tbxNom.Text;
                string newstring = oldstring[0].ToString().ToUpper() + oldstring.Substring(1).ToLower();

                //execute la requete
                CommandText = "UPDATE cartes SET nom = \"" + newstring + "\", cout = " + nudCout.Value + ", attaque = " + nudAttaque.Value + ", vie = " + nudVie.Value + ", description = \"" + tbxDescription.Text + "\", histoire = \"" + tbxHistoire.Text + "\", idRace = " + (cbxRace.SelectedIndex + 1) + ", idRarete = " + (cbxRarete.SelectedIndex + 1) + ", idClasse = " + (cbxClasse.SelectedIndex + 1) + ", idType = " + (cbxType.SelectedIndex + 1) + " WHERE idCarte = " + id;
                cmd = new SQLiteCommand(CommandText, sqlconnection);
                cmd.ExecuteNonQuery();

                //ferme la connexion et vide la commande
                cmd.Dispose();
                sqlconnection.Close();

                //affiche un message de confirmation de modification
                MessageBox.Show("Carte modifié avec succès!");

                //renvoie ok
                this.DialogResult = DialogResult.OK;
                //ferme la form
                this.Close();
            }
            //si un ou plusieurs champs sont vide
            else
            {
                //message d erreur
                MessageBox.Show("Il manque des champs à remplir ou des informations complémentaire à choisir.");
            }
        }

        //annuler
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //ferme la form
            this.Close();
        }
    }
}
