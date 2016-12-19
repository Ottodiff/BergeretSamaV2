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
        private string _idRace;
        private string _races;

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

        public string raceSelect()
        {
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            string CommandText = "SELECT races FROM race WHERE idRace = '" + IdRace + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
               this.Races = ((string)sqldr["races"]);
            }

            sqlconnection.Close();

            return this.Races;
        }
    }
}
