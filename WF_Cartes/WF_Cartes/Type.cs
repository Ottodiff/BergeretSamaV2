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
        private string _idType;
        private string _types;

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

        public string typeSelect()
        {
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            string CommandText = "SELECT types FROM type WHERE idType = '" + IdType + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                this.Types = ((string)sqldr["types"]);
            }

            sqlconnection.Close();

            return this.Types;
        }
    }
}
