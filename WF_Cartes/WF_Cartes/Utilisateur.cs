using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace SADOWSKI_MCDs
{
    public class Utilisateur
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

        public Utilisateur()
            : this("", "")
        {

        }

        public Utilisateur(string nom)
            : this(nom, "")
        {

        }

        public Utilisateur(string nom, string motDePasse)
        {
            Nom = nom;
            Motdepasse = motDePasse;
        }

        public bool login()
        {

            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= MCDs.db");
            sqlconnection.Open();

            string CommandText = "SELECT * FROM Utilisateurs WHERE nomUtilisateur = '" + this.Nom + "' AND mdpUtilisateur = '" + this.Motdepasse + "'";
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                if (sqldr["nomUtilisateur"].ToString() == this.Nom && sqldr["mdpUtilisateur"].ToString() == this.Motdepasse)
                {
                    return true;
                }
            }

            sqlconnection.Close();
            return false;
        }

        public void nouvelUtilisateur()
        {
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= MCDs.db");
            sqlconnection.Open();

            //INSERT INTO table VALUES ('valeur 1', 'valeur 2', ...)
            //"insert into highscores (name, score) values ('Myself', 6000)";
            string CommandText = "INSERT INTO Utilisateurs (nomUtilisateur, mdputilisateur) values ('" + this.Nom + "', '" + this.Motdepasse + "')";
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            cmd.ExecuteNonQuery();

            sqlconnection.Close();            
        }
    }
}
