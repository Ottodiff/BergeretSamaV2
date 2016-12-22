/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : Type.cs 
* *****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WF_Cartes
{
    class Type
    {
        //declaration variables
        private string _idType;
        private string _types;

        //Geter/Seter
        public string IdType
        {
            get
            {
                return _idType;
            }

            set
            {
                _idType = value;
            }
        }

        public string Types
        {
            get
            {
                return _types;
            }

            set
            {
                _types = value;
            }
        }

        /// <summary>
        /// recherche dans la bd le nom de type en fonction de l id envoyer
        /// </summary>
        /// <returns>nom du type</returns>
        public string typeSelect()
        {
            //ouvre la connexion
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            //execute la requete
            string CommandText = "SELECT types FROM type WHERE idType = '" + IdType + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            //pour le resultat
            while (sqldr.Read())
            {
                //entre le resultat dans la variable
                this.Types = ((string)sqldr["types"]);
            }

            //ferme la connexion
            sqlconnection.Close();

            //retourne la variable contenant le resultat
            return this.Types;
        }
    }
}
