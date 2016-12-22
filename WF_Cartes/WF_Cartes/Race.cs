/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : Race.cs 
* *****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WF_Cartes
{
    class Race
    {
        //declaration variables
        private string _idRace;
        private string _races;

        //Geter/Seter
        public string IdRace
        {
            get
            {
                return _idRace;
            }

            set
            {
                _idRace = value;
            }
        }

        public string Races
        {
            get
            {
                return _races;
            }

            set
            {
                _races = value;
            }
        }

        /// <summary>
        /// recherche dans la bd le nom de race en fonction de l id envoyer
        /// </summary>
        /// <returns>nom de la race</returns>
        public string raceSelect()
        {
            //ouvre la connexion
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            //execute la requete
            string CommandText = "SELECT races FROM race WHERE idRace = '" + IdRace + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            //pour le resultat
            while (sqldr.Read())
            {
                //entre le resultat dans la variable
                this.Races = ((string)sqldr["races"]);
            }

            //ferme la connexion
            sqlconnection.Close();

            //retourne la variable contenant le resultat
            return this.Races;
        }
    }
}
