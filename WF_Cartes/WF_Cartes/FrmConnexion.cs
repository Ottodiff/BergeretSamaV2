/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : FrmConnexion.cs 
* *****************************************/

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
    public partial class FrmConnexion : Form
    {
        //declaration de variables
        private bool _estCo;
        private string _nomutilisateur;

        //Geter/Seter
        public bool EstCo
        {
            get { return _estCo; }
            set { _estCo = value; }
        }

        public string Nomutilisateur
        {
            get
            {
                return _nomutilisateur;
            }

            set
            {
                _nomutilisateur = value;
            }
        }

        //constructeur
        public FrmConnexion(bool estCo)
        {
            EstCo = estCo;
        }

        public FrmConnexion():this(false)
        {
            InitializeComponent();
        }

        //annuler
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        //ok
        private void btnOK_Click(object sender, EventArgs e)
        {
            //declaration classe
            Utilisateur uti = new Utilisateur();

            //initialisation variables
            uti.Nom = tbxIdentifiant.Text;
            uti.Motdepasse = tbxMdp.Text;

            //affichage
            label3.Visible = false;

            //si login a retourner vrai
            if (uti.login() == true)
            {
                //ferme la form
                Form.ActiveForm.Close();
                //affichage
                label3.Visible = false;
                //met la valeur a vrai
                EstCo = true;

                //attribution valeur
                Nomutilisateur = uti.Nom;

                //remet les valeur a vide
                tbxIdentifiant.Text="";
                tbxMdp.Text = "";
                tbxIdentifiant.Focus();
            }
            //sinon si login a retourner faux
            else 
            {
                //affichage
                label3.Visible = true;
                //remet le nom d utilisateur dans le textbox
                tbxIdentifiant.Text = uti.Nom;
                //remet le mot de passe a vide
                tbxMdp.Text = "";
                //remet le focus sur le mot de passe
                tbxMdp.Focus();
            }
        }
    }
}
