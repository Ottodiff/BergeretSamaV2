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
    public partial class FrmCarte : Form
    {
        FrmConnexion co = new FrmConnexion();

        Race ra = new Race();
        Classe cl = new Classe();
        Rarete rare = new Rarete();
        Type ty = new Type();
        Extension ex = new Extension();


        SQLiteConnection sqlconnection = new SQLiteConnection("Data Source= carte.db");
        string CommandText;
        SQLiteCommand cmd;
        SQLiteDataReader sqldr;

        string selectedCarte = null;
        public FrmCarte()
        {
            InitializeComponent();

            sqlconnection.Open();

            CommandText = "SELECT * FROM cartes";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                lsbCartes.Items.Add(sqldr["nom"]);
            }
            sqldr.Close();
            cmd.Dispose();
            sqlconnection.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //affiche la form a propos
            APropos aPropos = new APropos();
            aPropos.ShowDialog();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (co.EstCo == true)
            {
                co.EstCo = false;
                connexionToolStripMenuItem.Text = "Connexion";

                lblBvn.Text = "";
                btnAjouter.Visible = false;
                btnModifier.Visible = false;
                btnSupprimer.Visible = false;
            }
            else
            {
                co.ShowDialog();
                if (co.EstCo == true)
                {
                    connexionToolStripMenuItem.Text = "Deconnexion";

                    lblBvn.Text = "Bienvenue " + co.Nomutilisateur;
                    btnAjouter.Visible = true;
                    btnModifier.Visible = true;
                    btnSupprimer.Visible = true;
                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lsbCartes_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlconnection.Open();

            CommandText = "SELECT * FROM cartes WHERE nom = \"" + lsbCartes.SelectedItem  + "\"";
            cmd = new SQLiteCommand(CommandText, sqlconnection);
            sqldr = cmd.ExecuteReader();

            while (sqldr.Read())
            {
                selectedCarte = sqldr["idCarte"].ToString();
                tbxNom.Text = (string)sqldr["nom"];
                tbxCout.Text = (string)sqldr["cout"];
                tbxAttaque.Text = (string)sqldr["attaque"];
                tbxVie.Text = (string)sqldr["vie"];
                ra.IdRace = sqldr["idRace"].ToString();
                tbxDescription.Text = (string)sqldr["description"];
                tbxHistoire.Text = (string)sqldr["histoire"];
                rare.IdRarete = sqldr["idRarete"].ToString();
                ty.IdType = sqldr["idType"].ToString();
                cl.IdClasse = sqldr["idClasse"].ToString();
                ex.IdExtension = sqldr["idExtension"].ToString();
            }

            sqldr.Close();
            cmd.Dispose();
            sqlconnection.Close();

            tbxRace.Text = ra.raceSelect();
            tbxClasse.Text = cl.classeSelect();
            tbxRarete.Text = rare.rareteSelect();
            tbxType.Text = ty.typeSelect();
            tbxExtension.Text = ex.extensionSelect();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouter aj = new FrmAjouter();
            aj.ShowDialog();

            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            try
            {
                sqlconnection.Close();
                Console.WriteLine("justclose");
            }
            catch (Exception)
            {
                sqlconnection.Open();
                Console.WriteLine("done");
                sqlconnection.Close();
                throw;
            }
        }
    }
}
