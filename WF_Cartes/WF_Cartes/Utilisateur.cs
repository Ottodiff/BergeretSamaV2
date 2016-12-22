/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : Utilisateur.cs 
* *****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WF_Cartes
{
    class Utilisateur
    {
        //declaration variables
        private string _nom;
        private string _motDePasse;

        //Geter/Seter
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Motdepasse
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }

        //constructeur
        public Utilisateur():this("", "")
        {

        }

        public Utilisateur(string nom):this(nom, "")
        {

        }

        public Utilisateur(string nom, string motDePasse)
        {
            Nom = nom;
            Motdepasse = motDePasse;
        }

        /// <summary>
        /// verifie l utilisateur et retourne connecter ou non
        /// </summary>
        /// <returns>vrai -> connecter, faux -> pas connecter</returns>
        public bool login()
        {
            //ouvre la connexion
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source = carte.db");
            sqlconnection.Open();

            //execute la requete
            string CommandText = "SELECT * FROM utilisateur WHERE nom = '" + this.Nom + "' AND motDePasse = '" + this.Motdepasse + "'";
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            //pour le resultat
            while (sqldr.Read())
            {
                //verifie si le nom et le mot de passe corresponde
                if (sqldr["nom"].ToString() == this.Nom && sqldr["motDePasse"].ToString() == this.Motdepasse)
                {
                    //ferme la connexion et vide la commande
                    cmd.Dispose();
                    sqldr.Close();
                    sqlconnection.Close();
                    //retourne vrai, donc connecte
                    return true;
                }
            }

            //ferme la connexion et vide la commande
            cmd.Dispose();
            sqldr.Close();
            sqlconnection.Close();
            //retourne faut, donc pas connecte
            return false;
        }
    }
}