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
    public partial class AddMouvement : MetroFramework.Forms.MetroForm
    {
        List<string> lsError = new List<string>();

        public AddMouvement()
        {
            InitializeComponent();

            this.StyleManager = mSMAddMouvement;
            this.StyleManager.Style = (MetroFramework.MetroColorStyle)Settings.Default.Style;
        }

        // --------------------------------------------------------------------
        // Bouttons et Cliques :
        // --------------------------------------------------------------------
        private void mLinkBack_Click(object sender, EventArgs e)
        {
            Dashboard MainForm = new Dashboard();
            MainForm.Show();
            this.Close();
        }

        private void mButtonAddMouvement_Click(object sender, EventArgs e)
        {
            {
                CheckErrorNom();
                bool creditDebit = CheckCreditDebit();


                if (lsError.Count == 0)
                {
                    DaoMouvement.create(new Mouvement(mTxBMouvementLibelle.Text, creditDebit));

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
        // Fonctions de vérification des champs avant l'ajout du mouvement :
        // --------------------------------------------------------------------
        private void CheckErrorNom()
        {
            if (mTxBMouvementLibelle.Text == "")
            {
                lsError.Add("- Champ \"nom\" vide");
            }
        }

        // --------------------------------------------------------------------
        // Fonctions privé :
        // --------------------------------------------------------------------
        private bool CheckCreditDebit()
        {
            if (mRBDebit.Checked == true)
            {
                return true;
            }
            else if (mRBCredit.Checked == true)
            {
                return false;
            }
            else
            {
                lsError.Add("- Boutton \"Crédit\"  ou \"Débit\" non coché");
                return true;
            }
        }
    }
}