﻿using System;
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
    public partial class FrmAjouter : Form
    {

        public FrmAjouter()
        {
            InitializeComponent();

            Charge();
        }

        public void Charge()
        {
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source=carte.db");

            sqlconnection.Open();

            //race
            string CommandText = "SELECT races FROM race";
            SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);
            SQLiteDataReader sqldr = cmd.ExecuteReader();

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

            sqlconnection = null;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");

            if ((tbxNom.Text != "") && (tbxDescription.Text != "") && (tbxHistoire.Text != "") && (cbxRace.SelectedIndex != -1) && (cbxRarete.SelectedIndex != -1) && (cbxClasse.SelectedIndex != -1) && (cbxType.SelectedIndex != -1) && (cbxExtension.SelectedIndex != -1))
            {
                sqlconnection.Open();

                string CommandText = "INSERT INTO cartes VALUES(null,\"" + tbxNom.Text + "\",\"" + nudCout.Value + "\",\"" + nudAttaque.Value + "\",\"" + nudVie.Value + "\",\"" + tbxDescription.Text + "\",\"" + tbxHistoire.Text + "\"," + (cbxRace.SelectedIndex + 1) + "," + (cbxRarete.SelectedIndex + 1) + "," + (cbxClasse.SelectedIndex + 1) + "," + (cbxType.SelectedIndex + 1) + "," + (cbxExtension.SelectedIndex + 1) + ")";

                SQLiteCommand cmd = new SQLiteCommand(CommandText, sqlconnection);

                cmd.CommandTimeout = 4;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                sqlconnection.Close();
            }
            else
            {
                MessageBox.Show("Il manque des champs à remplir ou des informations complémentaire à choisir.");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAjouter_Load(object sender, EventArgs e)
        {

        }
    }
}