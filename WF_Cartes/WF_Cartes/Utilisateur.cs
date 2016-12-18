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
        private string _nom;
        private string _motDePasse;

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

        public bool login()
        {

            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source = carte.db");
            sqlconnection.Open();

            string CommandText = "SELECT * FROM utilisateur WHERE nom = '" + this.Nom + "' AND motDePasse = '" + this.Motdepasse + "'";
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                if (sqldr["nom"].ToString() == this.Nom && sqldr["motDePasse"].ToString() == this.Motdepasse)
                {
                    return true;
                }
            }

            sqlconnection.Close();
            cmd.Dispose();
            sqldr.Close();
            return false;
        }
    }
}