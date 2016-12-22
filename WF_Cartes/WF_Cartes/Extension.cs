/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : Extension.cs 
* *****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WF_Cartes
{
    class Extension
    {
        //declaration de variables
        private string _idExtension;
        private string _extensions;

        //Geter/Seter
        public string IdExtension
        {
            get
            {
                return _idExtension;
            }

            set
            {
                _idExtension = value;
            }
        }

        public string Extensions
        {
            get
            {
                return _extensions;
            }

            set
            {
                _extensions = value;
            }
        }

        /// <summary>
        /// recherche dans la bd le nom de extension en fonction de l id envoyer
        /// </summary>
        /// <returns>nom de l'extension</returns>
        public string extensionSelect()
        {
            //ouvre la connexion
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            //execute la requete
            string CommandText = "SELECT extensions FROM extension WHERE IdExtension = '" + IdExtension + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            //pour le resultat
            while (sqldr.Read())
            {
                //entre le resultat dans la variable
                this.Extensions = ((string)sqldr["extensions"]);
            }

            //ferme la connexion
            sqlconnection.Close();

            //retourne la variable contenant le resultat
            return this.Extensions;
        }
    }
}
