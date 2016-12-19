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
        private string _idExtension;
        private string _extensions;

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

        public string extensionSelect()
        {
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
            sqlconnection.Open();

            string CommandText = "SELECT extensions FROM extension WHERE IdExtension = '" + IdExtension + "'"; ;
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                this.Extensions = ((string)sqldr["extensions"]);
            }

            sqlconnection.Close();

            return this.Extensions;
        }
    }
}
