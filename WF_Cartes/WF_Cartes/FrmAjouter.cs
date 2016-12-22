/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : FrmAjouter.cs 
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
    public partial class FrmAjouter : Form
    {
        //declaration variables
        SQLiteConnection sqlconnection = new SQLiteConnection("Data Source=carte.db");
        string CommandText;
        SQLiteCommand cmd;
        SQLiteDataReader sqldr;

        //constructeur
        public FrmAjouter()
        {
            InitializeComponent();

            //affiche toute les informations necessaire pour creer une carte
            Charge();
        }
        
        //affiche toute les informations necessaire pour creer une carte
        public void Charge()
        {
            //ouvre la connexion
            sqlconnection.Open();

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

            //ferme la connexion et vide la commande
            cmd.Dispose();
            sqldr.Close();
            sqlconnection.Close();
        }

        //valider
        private void btnValider_Click(object sender, EventArgs e)
        {
            //declaration variable
            string nom = "";

            //si tout les champs ne sont pas vide
            if ((tbxNom.Text != "") && (tbxDescription.Text != "") && (tbxHistoire.Text != "") && (cbxRace.SelectedIndex != -1) && (cbxRarete.SelectedIndex != -1) && (cbxClasse.SelectedIndex != -1) && (cbxType.SelectedIndex != -1) && (cbxExtension.SelectedIndex != -1))
            {
                //ouvre la connexion
                sqlconnection.Open();

                //permet de mettre le nom en minuscule avec la premiere lettre en majuscule
                string oldstring = tbxNom.Text;
                string newstring = oldstring[0].ToString().ToUpper() + oldstring.Substring(1).ToLower();

                //execute la requete
                CommandText = "SELECT nom FROM cartes WHERE nom = \"" + newstring + "\"";
                cmd = new SQLiteCommand(CommandText, sqlconnection);
                sqldr = cmd.ExecuteReader();

                //pour chaque reponse
                while (sqldr.Read())
                {
                    //entre le resultat dans la variable
                    nom = (string)sqldr["nom"];
                }

                //si le nom est vide
                if(nom == "")
                {
                    //execute la requete
                    CommandText = "INSERT INTO cartes VALUES(null,\"" + newstring + "\",\"" + nudCout.Value + "\",\"" + nudAttaque.Value + "\",\"" + nudVie.Value + "\",\"" + tbxDescription.Text + "\",\"" + tbxHistoire.Text + "\"," + (cbxRace.SelectedIndex + 1) + "," + (cbxRarete.SelectedIndex + 1) + "," + (cbxClasse.SelectedIndex + 1) + "," + (cbxType.SelectedIndex + 1) + "," + (cbxExtension.SelectedIndex + 1) + ")";
                    cmd = new SQLiteCommand(CommandText, sqlconnection);
                    cmd.ExecuteNonQuery();

                    //ferme la connexion et vide la commande
                    cmd.Dispose();
                    sqlconnection.Close();

                    //message de confirmation d ajout
                    MessageBox.Show("Carte ajoutée avec succès!");

                    //retourne ok
                    this.DialogResult = DialogResult.OK;
                    //ferme la form
                    this.Close();
                }
                //sinon demande de nommer la carte differement
                else
                {
                    //ferme la connexion
                    sqlconnection.Close();

                    //message d erreur
                    MessageBox.Show("Veuillez nommer votre carte différemment");

                }
            }
            //si un champ ou plusieur sont vide
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
