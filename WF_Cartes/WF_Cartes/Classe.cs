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
        private string _idClasse;
        private string _classes;

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

        public string classeSelect()
        {
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            string CommandText = "SELECT classes FROM classe WHERE idClasse = '" + IdClasse + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                this.Classes = ((string)sqldr["classes"]);
            }

            return this.Classes;
        }
    }
}
