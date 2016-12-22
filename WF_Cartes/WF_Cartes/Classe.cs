/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : Classe.cs 
* *****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WF_Cartes
{
    class Classe
    {
        //declaration variables
        private string _idClasse;
        private string _classes;

        //Geter/Seter
        public string IdClasse
        {
            get
            {
                return _idClasse;
            }

            set
            {
                _idClasse = value;
            }
        }

        public string Classes
        {
            get
            {
                return _classes;
            }

            set
            {
                _classes = value;
            }
        }

        /// <summary>
        /// recherche dans la bd le nom de classe en fonction de l id envoyer
        /// </summary>
        /// <returns>nom de la classe</returns>
        public string classeSelect()
        {
            //ouvre la connexion
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            //execute la requete
            string CommandText = "SELECT classes FROM classe WHERE idClasse = '" + IdClasse + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            //pour le resultat
            while (sqldr.Read())
            {
                //entre le resultat dans la variable
                this.Classes = ((string)sqldr["classes"]);
            }

            //ferme la connexion
            sqlconnection.Close();

            //retourne la variable contenant le resultat
            return this.Classes;
        }
    }
}
