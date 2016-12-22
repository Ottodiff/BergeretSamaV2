using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WF_Cartes
{
    public partial class FrmModifier : Form
    {
        FrmCarte ca = new FrmCarte();

        SQLiteConnection sqlconnection = new SQLiteConnection("Data Source=carte.db");
        string CommandText;
        SQLiteCommand cmd;
        SQLiteDataReader sqldr;

        public FrmModifier()
        {
            InitializeComponent();

            Charge();
        }

        public void Charge()
        {
            sqlconnection.Open();

            //race
            CommandText = "SELECT races FROM race";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                cbxRace.Items.Add(sqldr["races"]);
            }

            //rarete
            CommandText = "SELECT raretes FROM rarete";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                cbxRarete.Items.Add(sqldr["raretes"]);
            }

            //type
            CommandText = "SELECT types FROM type";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                cbxType.Items.Add(sqldr["types"]);
            }

            //classe
            CommandText = "SELECT classes FROM classe";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                cbxClasse.Items.Add(sqldr["classes"]);
            }

            //extension
            CommandText = "SELECT extensions FROM extension";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                cbxExtension.Items.Add(sqldr["extensions"]);
            }

            cmd.Dispose();
            sqldr.Close();
            sqlconnection.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
