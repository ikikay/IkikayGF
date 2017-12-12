using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Using perso
using IkikayGF.Properties;  // Personnalisation des couleurs
using IkikayGF.Dao;
using IkikayGF.Classes;
using MetroFramework;

namespace IkikayGF.Forms
{
    public partial class AddCategorie : MetroFramework.Forms.MetroForm
    {
        List<string> lsError = new List<string>();

        public AddCategorie()
        {
            InitializeComponent();

            this.StyleManager = mSMAddCategorie;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;
        }

        // --------------------------------------------------------------------
        // Boutons et Cliques :
        // --------------------------------------------------------------------
        private void mLinkBack_Click(object sender, EventArgs e)
        {
            Dashboard MainForm = new Dashboard();
            MainForm.Show();
            this.Close();
        }

        private void mButtonAddCategorie_Click(object sender, EventArgs e)
        {
            {
                CheckErrorNom();


                if (lsError.Count == 0)
                {
                    DaoCategorie.create(new Categorie(mTxBCategorieLibelle.Text));

                    Dashboard MainForm = new Dashboard();
                    MainForm.Show();
                    this.Close();
                }
                else
                {
                    // TODO : Si trop d'erreurs, elles ne sont pas toutes affiché, trouver un moyen de faire un ascenseur vertical.
                    string lesErreurs = "";
                    foreach (string erreur in lsError)
                    {
                        lesErreurs += erreur + "\n";
                    }
                    MetroMessageBox.Show(this, lesErreurs, "Erreurs");
                    lsError.Clear();
                }
            }
        }

        // --------------------------------------------------------------------
        // Fonctions de vérification des champs avant l'ajout d'une catégorie :
        // --------------------------------------------------------------------
        private void CheckErrorNom()
        {
            if (mTxBCategorieLibelle.Text == "")
            {
                lsError.Add("- Champ \"nom\" vide");
            }
        }
    }
}
