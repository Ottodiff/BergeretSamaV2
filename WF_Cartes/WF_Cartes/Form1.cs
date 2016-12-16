using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Cartes
{
    public partial class FrmCarte : Form
    {
        Connexion co = new Connexion();

        public FrmCarte()
        {
            InitializeComponent();
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
            }
            else
            {
                //affiche la fenetre de connexion
                co.EstCo = true;
                co.ShowDialog();
                connexionToolStripMenuItem.Text = "Deconnexion";
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
