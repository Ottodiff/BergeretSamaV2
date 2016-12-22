/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : Rarete.cs 
* *****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WF_Cartes
{
    class Rarete
    {
        //declaration variables
        private string _idRarete;
        private string _raretes;

        //Geter/Seter
        public string IdRarete
        {
            get
            {
                return _idRarete;
            }

            set
            {
                _idRarete = value;
            }
        }

        public string Raretes
        {
            get
            {
                return _raretes;
            }

            set
            {
                _raretes = value;
            }
        }

        /// <summary>
        /// recherche dans la bd le nom de rarete en fonction de l id envoyer
        /// </summary>
        /// <returns>nom de la rarete</returns>
        public string rareteSelect()
        {
            //ouvre la connexion
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            //execute la requete
            string CommandText = "SELECT raretes FROM rarete WHERE idRarete = '" + IdRarete + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            //pour le resultat
            while (sqldr.Read())
            {
                this.Raretes = ((string)sqldr["raretes"]);
            }

            //ferme la connexion
            sqlconnection.Close();

            //retourne la variable contenant le resultat
            return this.Raretes;
        }
    }
}
