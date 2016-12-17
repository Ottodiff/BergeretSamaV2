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
        private string _idRarete;
        private string _raretes;

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

        public string rareteSelect()
        {
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            string CommandText = "SELECT raretes FROM rarete WHERE idRarete = '" + IdRarete + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                this.Raretes = ((string)sqldr["raretes"]);
            }

            return this.Raretes;
        }
    }
}
