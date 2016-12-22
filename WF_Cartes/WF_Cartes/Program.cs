/******************************************
* Projet : DB_Cartes
* Description : Application gérant des cartes dans une base de données SQLite
* Date : 23.09.2016
* Version : 1.0
* Auteur : SADOWSKI Christophe
* Fichier : Program.cs 
* *****************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Cartes
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCarte());
        }
    }
}
