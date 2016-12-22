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
        private bool _estCo;
        private string _nomutilisateur;

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

        public FrmConnexion(bool estCo)
        {
            EstCo = estCo;
        }

        public FrmConnexion():this(false)
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Utilisateur uti = new Utilisateur();

            uti.Nom = tbxIdentifiant.Text;
            uti.Motdepasse = tbxMdp.Text;

            label3.Visible = false;

            if (uti.login() == true)
            {
                Form.ActiveForm.Close();
                label3.Visible = false;
                EstCo = true;

                Nomutilisateur = uti.Nom;

                tbxIdentifiant.Text="";
                tbxMdp.Text = "";
            }
            else 
            {
                label3.Visible = true;
                tbxIdentifiant.Text = uti.Nom;
                tbxMdp.Text = "";
                tbxMdp.Focus();
            }
        }
    }
}
